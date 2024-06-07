using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestArray()
        {
            TestArrayEqualTo();

            TestArrayNotEqualTo();

            TestArrayEqual();

            TestArrayGetEnumerator();

            TestArrayGetTypeSize();

            TestArrayGetSlack();

            TestArrayIsValidIndex();

            TestArrayNum();

            TestArrayIsEmpty();

            TestArrayMax();

            TestArraySubscript();

            TestArrayFind();

            TestArrayFindLast();

            TestArrayContains();

            TestArrayAddUninitialized();

            TestArrayInsertZeroed();

            TestArrayInsertDefaulted();

            TestArrayRemoveAt();

            TestArrayReset();

            TestArrayEmpty();

            TestArraySetNum();

            TestArrayAdd();

            TestArrayAddZeroed();

            TestArrayAddUnique();

            TestArrayRemoveSingle();

            TestArrayRemove();

            TestArraySwapMemory();

            TestArraySwap();
        }

        private void TestArrayEqualTo()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array1 = new TArray<int>
                {
                    12
                };

                var Array2 = new TArray<int>
                {
                    12
                };

                TestCoreSubsystem.TestEqual("ArrayPrimitiveEqualToTrue", Array1 == Array2, true);
            }

            {
                var Array1 = new TArray<int>
                {
                    12
                };

                var Array2 = new TArray<int>
                {
                    34
                };

                TestCoreSubsystem.TestEqual("ArrayPrimitiveEqualToFalse", Array1 == Array2, false);
            }

            {
                var Array1 = new TArray<UObject>
                {
                    this
                };

                var Array2 = new TArray<UObject>
                {
                    this
                };

                TestCoreSubsystem.TestEqual("ArrayCompoundEqualToTrue", Array1 == Array2, true);
            }

            {
                var Array1 = new TArray<UObject>
                {
                    this
                };

                var Array2 = new TArray<UObject>
                {
                    TestCoreSubsystem
                };

                TestCoreSubsystem.TestEqual("ArrayCompoundEqualToFalse", Array1 == Array2, false);
            }
        }

        private void TestArrayNotEqualTo()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array1 = new TArray<int>
                {
                    12
                };

                var Array2 = new TArray<int>
                {
                    34
                };

                TestCoreSubsystem.TestEqual("ArrayPrimitiveNotEqualToTrue", Array1 != Array2, true);
            }

            {
                var Array1 = new TArray<int>
                {
                    12
                };

                var Array2 = new TArray<int>
                {
                    12
                };

                TestCoreSubsystem.TestEqual("ArrayPrimitiveNotEqualToFalse", Array1 != Array2, false);
            }

            {
                var Array1 = new TArray<UObject>
                {
                    this
                };

                var Array2 = new TArray<UObject>
                {
                    TestCoreSubsystem
                };

                TestCoreSubsystem.TestEqual("ArrayCompoundNotEqualToTrue", Array1 != Array2, true);
            }

            {
                var Array1 = new TArray<UObject>
                {
                    this
                };

                var Array2 = new TArray<UObject>
                {
                    this
                };

                TestCoreSubsystem.TestEqual("ArrayCompoundNotEqualToFalse", Array1 != Array2, false);
            }
        }

        private void TestArrayEqual()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array1 = new TArray<int>
                {
                    12
                };

                var Array2 = new TArray<int>
                {
                    12
                };

                TestCoreSubsystem.TestEqual("ArrayPrimitiveEqualTrue", Array1.Equals(Array2), true);
            }

            {
                var Array1 = new TArray<int>
                {
                    12
                };

                var Array2 = new TArray<int>
                {
                    34
                };

                TestCoreSubsystem.TestEqual("ArrayPrimitiveEqualFalse", Array1.Equals(Array2), false);
            }

            {
                var Array1 = new TArray<UObject>
                {
                    this
                };

                var Array2 = new TArray<UObject>
                {
                    this
                };

                TestCoreSubsystem.TestEqual("ArrayCompoundEqualTrue", Array1.Equals(Array2), true);
            }

            {
                var Array1 = new TArray<UObject>
                {
                    this
                };

                var Array2 = new TArray<UObject>
                {
                    TestCoreSubsystem
                };

                TestCoreSubsystem.TestEqual("ArrayCompoundEqualFalse", Array1.Equals(Array2), false);
            }
        }

        private void TestArrayGetEnumerator()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12,
                    34,
                    56
                };

                var Sum = 0;

                foreach (var Value in Array)
                {
                    Sum += Value;
                }

                TestCoreSubsystem.TestEqual("ArrayGetEnumerator", Sum, 12 + 34 + 56);
            }
        }

        private void TestArrayGetTypeSize()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12
                };

                TestCoreSubsystem.TestEqual("ArrayGetTypeSize", Array.GetTypeSize(), sizeof(int));
            }
        }

        private void TestArrayGetSlack()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12,
                    34
                };

                TestCoreSubsystem.TestEqual("ArrayGetSlack", Array.GetSlack(), 2);
            }
        }

        private void TestArrayIsValidIndex()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12
                };

                TestCoreSubsystem.TestEqual("ArrayIsValidIndexTrue", Array.IsValidIndex(0), true);
            }

            {
                var Array = new TArray<int>
                {
                    12
                };

                TestCoreSubsystem.TestEqual("ArrayIsValidIndexFalse", Array.IsValidIndex(1), false);
            }
        }

        private void TestArrayNum()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12,
                    34,
                    56
                };

                TestCoreSubsystem.TestEqual("ArrayNum", Array.Num(), 3);
            }
        }

        private void TestArrayIsEmpty()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                };

                TestCoreSubsystem.TestEqual("ArrayIsEmptyTrue", Array.IsEmpty(), true);
            }

            {
                var Array = new TArray<int>
                {
                    12,
                    34,
                    56
                };

                TestCoreSubsystem.TestEqual("ArrayIsEmptyFalse", Array.IsEmpty(), false);
            }
        }

        private void TestArrayMax()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12,
                    34
                };

                TestCoreSubsystem.TestEqual("ArrayMax", Array.Max(), 4);
            }
        }

        private void TestArraySubscript()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12
                };

                TestCoreSubsystem.TestEqual("ArrayPrimitiveSubscriptGet", Array[0], 12);
            }

            {
                var Array = new TArray<int>
                {
                    12
                };

                Array[0] = 34;

                TestCoreSubsystem.TestEqual("ArrayPrimitiveSubscriptSet", Array[0], 34);
            }

            {
                var Array = new TArray<UObject>
                {
                    this
                };

                TestCoreSubsystem.TestEqual("ArrayCompoundSubscriptGet", Array[0], this);
            }

            {
                var Array = new TArray<UObject>
                {
                    this
                };

                Array[0] = TestCoreSubsystem;

                TestCoreSubsystem.TestEqual("ArrayCompoundSubscriptSet", Array[0], TestCoreSubsystem);
            }
        }

        private void TestArrayFind()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12,
                    34,
                    12,
                    34
                };

                TestCoreSubsystem.TestEqual("ArrayPrimitiveFindTrue", Array.Find(34), 1);
            }

            {
                var Array = new TArray<int>
                {
                    12,
                    34,
                    12,
                    34
                };

                TestCoreSubsystem.TestEqual("ArrayPrimitiveFindFalse", Array.Find(56), TArray.INDEX_NONE);
            }

            {
                var Array = new TArray<UObject>
                {
                    this,
                    TestCoreSubsystem,
                    this,
                    TestCoreSubsystem
                };

                TestCoreSubsystem.TestEqual("ArrayCompoundFindTrue", Array.Find(TestCoreSubsystem), 1);
            }

            {
                var Array = new TArray<UObject>
                {
                    this,
                    TestCoreSubsystem,
                    this,
                    TestCoreSubsystem
                };

                TestCoreSubsystem.TestEqual("ArrayCompoundFindFalse", Array.Find(GetWorld()), TArray.INDEX_NONE);
            }
        }

        private void TestArrayFindLast()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12,
                    34,
                    12,
                    34
                };

                TestCoreSubsystem.TestEqual("ArrayPrimitiveFindLastTrue", Array.FindLast(34), 3);
            }

            {
                var Array = new TArray<int>
                {
                    12,
                    34,
                    12,
                    34
                };

                TestCoreSubsystem.TestEqual("ArrayPrimitiveFindLastFalse", Array.FindLast(56), TArray.INDEX_NONE);
            }

            {
                var Array = new TArray<UObject>
                {
                    this,
                    TestCoreSubsystem,
                    this,
                    TestCoreSubsystem
                };

                TestCoreSubsystem.TestEqual("ArrayCompoundFindLastTrue", Array.FindLast(TestCoreSubsystem), 3);
            }

            {
                var Array = new TArray<UObject>
                {
                    this,
                    TestCoreSubsystem,
                    this,
                    TestCoreSubsystem
                };

                TestCoreSubsystem.TestEqual("ArrayCompoundFindLastFalse", Array.FindLast(GetWorld()),
                    TArray.INDEX_NONE);
            }
        }

        private void TestArrayContains()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12,
                    34
                };

                TestCoreSubsystem.TestEqual("ArrayPrimitiveContainsTrue", Array.Contains(34), true);
            }

            {
                var Array = new TArray<int>
                {
                    12,
                    34
                };

                TestCoreSubsystem.TestEqual("ArrayPrimitiveContainsFalse", Array.Contains(56), false);
            }

            {
                var Array = new TArray<UObject>
                {
                    this,
                    TestCoreSubsystem
                };

                TestCoreSubsystem.TestEqual("ArrayCompoundContainsTrue", Array.Contains(this), true);
            }

            {
                var Array = new TArray<UObject>
                {
                    this,
                    TestCoreSubsystem
                };

                TestCoreSubsystem.TestEqual("ArrayCompoundContainsFalse", Array.Contains(GetWorld()), false);
            }
        }

        private void TestArrayAddUninitialized()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12,
                    34
                };

                TestCoreSubsystem.TestEqual("ArrayAddUninitialized", Array.AddUninitialized(2), 2);
            }
        }

        private void TestArrayInsertZeroed()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12,
                    34
                };

                Array.InsertZeroed(2, 2);

                TestCoreSubsystem.TestEqual("ArrayInsertZeroed", Array.Num(), 4);
            }
        }

        private void TestArrayInsertDefaulted()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12,
                    34
                };

                Array.InsertDefaulted(2, 2);

                TestCoreSubsystem.TestEqual("ArrayInsertDefaulted", Array.Num(), 4);
            }
        }

        private void TestArrayRemoveAt()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12,
                    34,
                    56,
                    78
                };

                Array.RemoveAt(1, 2);

                TestCoreSubsystem.TestEqual("ArrayRemoveAt", Array.Num(), 2);
            }
        }

        private void TestArrayReset()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12,
                    34
                };

                Array.Reset(4);

                TestCoreSubsystem.TestEqual("ArrayReset", Array.Num(), 0);
            }
        }

        private void TestArrayEmpty()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12,
                    34
                };

                Array.Empty(4);

                TestCoreSubsystem.TestEqual("ArrayEmpty", Array.Num(), 0);
            }
        }

        private void TestArraySetNum()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12,
                    34
                };

                Array.SetNum(4);

                TestCoreSubsystem.TestEqual("ArraySetNum", Array.Num(), 4);
            }
        }

        private void TestArrayAdd()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12,
                    34
                };

                TestCoreSubsystem.TestEqual("ArrayAdd", Array.Add(56), 2);
            }
        }

        private void TestArrayAddZeroed()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12,
                    34
                };

                TestCoreSubsystem.TestEqual("ArrayAddZeroed", Array.AddZeroed(2), 2);
            }
        }

        private void TestArrayAddUnique()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12,
                    34
                };

                TestCoreSubsystem.TestEqual("ArrayPrimitiveAddUniqueTrue", Array.AddUnique(56), 2);
            }

            {
                var Array = new TArray<int>
                {
                    12,
                    34
                };

                TestCoreSubsystem.TestEqual("ArrayPrimitiveAddUniqueFalse", Array.AddUnique(34), 1);
            }

            {
                var Array = new TArray<UObject>
                {
                    this,
                    TestCoreSubsystem
                };

                TestCoreSubsystem.TestEqual("ArrayCompoundAddUniqueTrue", Array.AddUnique(GetWorld()), 2);
            }

            {
                var Array = new TArray<UObject>
                {
                    this,
                    TestCoreSubsystem
                };

                TestCoreSubsystem.TestEqual("ArrayCompoundAddUniqueFalse", Array.AddUnique(this), 0);
            }
        }

        private void TestArrayRemoveSingle()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12,
                    34
                };

                TestCoreSubsystem.TestEqual("ArrayPrimitiveRemoveSingleTrue", Array.RemoveSingle(12), 1);
            }

            {
                var Array = new TArray<int>
                {
                    12,
                    34
                };

                TestCoreSubsystem.TestEqual("ArrayPrimitiveRemoveSingleFalse", Array.RemoveSingle(56), 0);
            }

            {
                var Array = new TArray<UObject>
                {
                    this,
                    TestCoreSubsystem
                };

                TestCoreSubsystem.TestEqual("ArrayCompoundRemoveSingleTrue", Array.RemoveSingle(this), 1);
            }

            {
                var Array = new TArray<UObject>
                {
                    this,
                    TestCoreSubsystem
                };

                TestCoreSubsystem.TestEqual("ArrayCompoundRemoveSingleFalse", Array.RemoveSingle(GetWorld()), 0);
            }
        }

        private void TestArrayRemove()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12,
                    34,
                    12,
                    34
                };

                TestCoreSubsystem.TestEqual("ArrayPrimitiveRemoveTrue", Array.Remove(12), 2);
            }

            {
                var Array = new TArray<int>
                {
                    12,
                    34,
                    12,
                    34
                };

                TestCoreSubsystem.TestEqual("ArrayPrimitiveRemoveFalse", Array.Remove(56), 0);
            }

            {
                var Array = new TArray<UObject>
                {
                    this,
                    TestCoreSubsystem,
                    this,
                    TestCoreSubsystem
                };

                TestCoreSubsystem.TestEqual("ArrayCompoundRemoveTrue", Array.Remove(this), 2);
            }

            {
                var Array = new TArray<UObject>
                {
                    this,
                    TestCoreSubsystem,
                    this,
                    TestCoreSubsystem
                };

                TestCoreSubsystem.TestEqual("ArrayCompoundRemoveFalse", Array.Remove(GetWorld()), 0);
            }
        }

        private void TestArraySwapMemory()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12,
                    34
                };

                Array.SwapMemory(0, 1);

                TestCoreSubsystem.TestEqual("ArrayPrimitiveSwapMemory", Array[0] == 34 && Array[1] == 12, true);
            }

            {
                var Array = new TArray<UObject>
                {
                    this,
                    TestCoreSubsystem
                };

                Array.SwapMemory(0, 1);

                TestCoreSubsystem.TestEqual("ArrayCompoundSwapMemory",
                    Array[0] == TestCoreSubsystem && Array[1] == this, true);
            }
        }

        private void TestArraySwap()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Array = new TArray<int>
                {
                    12,
                    34
                };

                Array.Swap(0, 1);

                TestCoreSubsystem.TestEqual("ArrayPrimitiveSwap", Array[0] == 34 && Array[1] == 12, true);
            }

            {
                var Array = new TArray<UObject>
                {
                    this,
                    TestCoreSubsystem
                };

                Array.Swap(0, 1);

                TestCoreSubsystem.TestEqual("ArrayCompoundSwap", Array[0] == TestCoreSubsystem && Array[1] == this,
                    true);
            }
        }
    }
}