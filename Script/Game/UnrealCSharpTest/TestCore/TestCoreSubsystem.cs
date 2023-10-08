using System;
using Script.Common;

namespace Script.UnrealCSharpTest
{
    [IsOverride]
    public partial class UTestCoreSubsystem
    {
        private void Test(string InWhat, Boolean bIsPassed)
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
            Test(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, SByte InActual, SByte InExpected)
        {
            Test(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, Int16 InActual, Int16 InExpected)
        {
            Test(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, Int32 InActual, Int32 InExpected)
        {
            Test(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, Int64 InActual, Int64 InExpected)
        {
            Test(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, Byte InActual, Byte InExpected)
        {
            Test(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, UInt16 InActual, UInt16 InExpected)
        {
            Test(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, UInt32 InActual, UInt32 InExpected)
        {
            Test(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, UInt64 InActual, UInt64 InExpected)
        {
            Test(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, Single InActual, Single InExpected)
        {
            Test(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, Double InActual, Double InExpected)
        {
            Test(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, FName InActual, FName InExpected)
        {
            Test(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, FText InActual, FText InExpected)
        {
            Test(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, FString InActual, FString InExpected)
        {
            Test(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, ETestEnum InActual, ETestEnum InExpected)
        {
            Test(InWhat, InActual == InExpected);
        }

        public void TestEqual(string InWhat, ETestEnumClass InActual, ETestEnumClass InExpected)
        {
            Test(InWhat, InActual == InExpected);
        }
    }
}