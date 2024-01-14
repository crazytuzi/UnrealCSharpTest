using System;
using Script.Common;
using Script.CoreUObject;
using Script.Game.UnitTest.Core;

namespace Script.UnrealCSharpTest
{
    [Override]
    public partial class UTestCoreSubsystem
    {
        private void TestEqual(string InWhat, bool bIsPassed)
        {
            TestResults.Add(new FTestResult
            {
                What = InWhat,
                bIsPassed = bIsPassed
            });

            if (bIsPassed)
            {
                PassedIndex.Add(TestResults.Num() - 1);
            }
            else
            {
                NotPassedIndex.Add(TestResults.Num() - 1);
            }
        }

        public void TestEqual(string InWhat, bool InActual, bool InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, sbyte InActual, sbyte InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, short InActual, short InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, int InActual, int InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, long InActual, long InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, byte InActual, byte InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, ushort InActual, ushort InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, uint InActual, uint InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, ulong InActual, ulong InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, float InActual, float InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, double InActual, double InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, FName InActual, FName InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, FText InActual, FText InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, FString InActual, FString InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, ETestEnum InActual, ETestEnum InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, ETestEnumClass InActual, ETestEnumClass InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, FTestStruct InActual, FTestStruct InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, UObject InActual, UObject InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, TSubclassOf<UObject> InActual, TSubclassOf<UObject> InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, TScriptInterface<ITestInterface> InActual,
            TScriptInterface<ITestInterface> InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, TWeakObjectPtr<UObject> InActual, TWeakObjectPtr<UObject> InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, TLazyObjectPtr<UObject> InActual, TLazyObjectPtr<UObject> InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, TSoftObjectPtr<UObject> InActual, TSoftObjectPtr<UObject> InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, TSoftClassPtr<UObject> InActual, TSoftClassPtr<UObject> InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, TArray<int> InActual, TArray<int> InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, TSet<int> InActual, TSet<int> InExpected)
        {
            var bIsPassed = true;

            if (InActual.Num() == InExpected.Num())
            {
                foreach (var Elem in InActual)
                {
                    if (!InExpected.Contains(Elem))
                    {
                        bIsPassed = false;

                        break;
                    }
                }
            }
            else
            {
                bIsPassed = false;
            }

            TestEqual(InWhat, bIsPassed);
        }

        public void TestEqual(string InWhat, TMap<int, int> InActual, TMap<int, int> InExpected)
        {
            var bIsPassed = true;

            if (InActual.Num() == InExpected.Num())
            {
                foreach (var Elem in InActual)
                {
                    if (!InExpected.Contains(Elem.Key))
                    {
                        bIsPassed = false;

                        break;
                    }
                    else
                    {
                        if (InExpected[Elem.Key] != Elem.Value)
                        {
                            bIsPassed = false;

                            break;
                        }
                    }
                }
            }
            else
            {
                bIsPassed = false;
            }

            TestEqual(InWhat, bIsPassed);
        }

        public void TestEqual(string InWhat, ERawTestEnum InActual, ERawTestEnum InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, ERawTestEnumClass InActual, ERawTestEnumClass InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, FRawTestStruct InActual, FRawTestStruct InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, BP_TestEnum InActual, BP_TestEnum InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, BP_TestStruct InActual, BP_TestStruct InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, TScriptInterface<IBP_TestInterface_C> InActual,
            TScriptInterface<IBP_TestInterface_C> InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }
    }
}