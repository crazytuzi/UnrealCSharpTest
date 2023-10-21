using System;
using Script.Common;
using Script.CoreUObject;
using Script.Game.UnitTest.Core;

namespace Script.UnrealCSharpTest
{
    [IsOverride]
    public partial class UTestCoreSubsystem
    {
        private void TestEqual(string InWhat, Boolean bIsPassed)
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

        public void TestEqual(string InWhat, Boolean InActual, Boolean InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, SByte InActual, SByte InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, Int16 InActual, Int16 InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, Int32 InActual, Int32 InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, Int64 InActual, Int64 InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, Byte InActual, Byte InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, UInt16 InActual, UInt16 InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, UInt32 InActual, UInt32 InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, UInt64 InActual, UInt64 InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, Single InActual, Single InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, Double InActual, Double InExpected)
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

        public void TestEqual(string InWhat, TArray<Int32> InActual, TArray<Int32> InExpected)
        {
            TestEqual(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, TSet<Int32> InActual, TSet<Int32> InExpected)
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

        public void TestEqual(string InWhat, TMap<Int32, Int32> InActual, TMap<Int32, Int32> InExpected)
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