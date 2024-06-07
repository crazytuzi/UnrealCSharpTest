using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestSet()
        {
            TestSetGetEnumerator();

            TestSetEmpty();

            TestSetNum();

            TestSetIsEmpty();

            TestSetGetMaxIndex();

            TestSetAdd();

            TestSetRemove();

            TestSetContains();
        }

        private void TestSetGetEnumerator()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Set = new TSet<int>
                {
                    12,
                    34,
                    56
                };

                var Sum = 0;

                foreach (var Value in Set)
                {
                    Sum += Value;
                }

                TestCoreSubsystem.TestEqual("SetGetEnumerator", Sum, 12 + 34 + 56);
            }
        }

        private void TestSetEmpty()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Set = new TSet<int>
                {
                    12,
                    34
                };

                Set.Empty(4);

                TestCoreSubsystem.TestEqual("SetEmpty", Set.Num(), 0);
            }
        }

        private void TestSetNum()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Set = new TSet<int>
                {
                    12,
                    34,
                    56
                };

                TestCoreSubsystem.TestEqual("SetNum", Set.Num(), 3);
            }
        }

        private void TestSetIsEmpty()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Set = new TSet<int>
                {
                };

                TestCoreSubsystem.TestEqual("SetIsEmptyTrue", Set.IsEmpty(), true);
            }

            {
                var Set = new TSet<int>
                {
                    12,
                    34,
                    56
                };

                TestCoreSubsystem.TestEqual("SetIsEmptyFalse", Set.IsEmpty(), false);
            }
        }

        private void TestSetGetMaxIndex()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Set = new TSet<int>
                {
                    12,
                    34
                };

                TestCoreSubsystem.TestEqual("SetGetMaxIndex", Set.GetMaxIndex(), 2);
            }
        }

        private void TestSetAdd()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Set = new TSet<int>
                {
                    12,
                    34
                };

                Set.Add(56);

                TestCoreSubsystem.TestEqual("SetPrimitiveAddTrue", Set.Num(), 3);
            }

            {
                var Set = new TSet<int>
                {
                    12,
                    34
                };

                Set.Add(12);

                TestCoreSubsystem.TestEqual("SetPrimitiveAddFalse", Set.Num(), 2);
            }

            {
                var Set = new TSet<UObject>
                {
                    this,
                    TestCoreSubsystem
                };

                Set.Add(GetWorld());

                TestCoreSubsystem.TestEqual("SetCompoundAddTrue", Set.Num(), 3);
            }

            {
                var Set = new TSet<UObject>
                {
                    this,
                    TestCoreSubsystem
                };

                Set.Add(this);

                TestCoreSubsystem.TestEqual("SetCompoundAddFalse", Set.Num(), 2);
            }
        }

        private void TestSetRemove()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Set = new TSet<int>
                {
                    12,
                    34
                };

                TestCoreSubsystem.TestEqual("SetPrimitiveRemoveTrue", Set.Remove(12), 1);
            }

            {
                var Set = new TSet<int>
                {
                    12,
                    34
                };

                TestCoreSubsystem.TestEqual("SetPrimitiveRemoveFalse", Set.Remove(56), 0);
            }

            {
                var Set = new TSet<UObject>
                {
                    this,
                    TestCoreSubsystem
                };

                TestCoreSubsystem.TestEqual("SetCompoundRemoveTrue", Set.Remove(this), 1);
            }

            {
                var Set = new TSet<UObject>
                {
                    this,
                    TestCoreSubsystem
                };

                TestCoreSubsystem.TestEqual("SetCompoundRemoveFalse", Set.Remove(GetWorld()), 0);
            }
        }

        private void TestSetContains()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Set = new TSet<int>
                {
                    12,
                    34
                };

                TestCoreSubsystem.TestEqual("SetPrimitiveContainsTrue", Set.Contains(34), true);
            }

            {
                var Set = new TSet<int>
                {
                    12,
                    34
                };

                TestCoreSubsystem.TestEqual("SetPrimitiveContainsFalse", Set.Contains(56), false);
            }

            {
                var Set = new TSet<UObject>
                {
                    this,
                    TestCoreSubsystem
                };

                TestCoreSubsystem.TestEqual("SetCompoundContainsTrue", Set.Contains(this), true);
            }

            {
                var Set = new TSet<UObject>
                {
                    this,
                    TestCoreSubsystem
                };

                TestCoreSubsystem.TestEqual("SetCompoundContainsFalse", Set.Contains(GetWorld()), false);
            }
        }
    }
}