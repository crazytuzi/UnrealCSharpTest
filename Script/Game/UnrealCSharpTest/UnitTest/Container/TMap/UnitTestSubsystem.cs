using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestMap()
        {
            TestMapGetEnumerator();

            TestMapEmpty();

            TestMapNum();

            TestMapIsEmpty();

            TestMapAdd();

            TestMapRemove();

            TestMapFindKey();

            TestMapFind();

            TestMapContains();

            TestMapSubscript();
        }

        private void TestMapGetEnumerator()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Map = new TMap<int, int>
                {
                    { 12, 12 },
                    { 34, 34 },
                    { 56, 56 },
                };

                var Sum = 0;

                foreach (var Value in Map)
                {
                    Sum += Value.Key + Value.Value;
                }

                TestCoreSubsystem.TestEqual("MapGetEnumerator", Sum, 12 + 12 + 34 + 34 + 56 + 56);
            }
        }

        private void TestMapEmpty()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Map = new TMap<int, int>
                {
                    { 12, 12 },
                    { 34, 34 }
                };

                Map.Empty(4);

                TestCoreSubsystem.TestEqual("MapEmpty", Map.Num(), 0);
            }
        }

        private void TestMapNum()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Map = new TMap<int, int>
                {
                    { 12, 12 },
                    { 34, 34 },
                    { 56, 56 },
                };

                TestCoreSubsystem.TestEqual("MapNum", Map.Num(), 3);
            }
        }

        private void TestMapIsEmpty()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Map = new TMap<int, int>
                {
                };

                TestCoreSubsystem.TestEqual("MapIsEmptyTrue", Map.IsEmpty(), true);
            }

            {
                var Map = new TMap<int, int>
                {
                    { 12, 12 },
                    { 34, 34 },
                    { 56, 56 },
                };

                TestCoreSubsystem.TestEqual("MapIsEmptyFalse", Map.IsEmpty(), false);
            }
        }

        private void TestMapAdd()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Map = new TMap<int, int>
                {
                    { 12, 12 },
                    { 34, 34 }
                };

                Map.Add(56, 56);

                TestCoreSubsystem.TestEqual("MapPrimitiveAddTrue", Map[56] == 56, true);
            }

            {
                var Map = new TMap<int, int>
                {
                    { 12, 12 },
                    { 34, 34 }
                };

                Map.Add(12, 56);

                TestCoreSubsystem.TestEqual("MapPrimitiveAddFalse", Map[12] == 56, true);
            }

            {
                var Map = new TMap<UObject, UObject>
                {
                    { this, this },
                    { TestCoreSubsystem, TestCoreSubsystem }
                };

                Map.Add(GetWorld(), GetWorld());

                TestCoreSubsystem.TestEqual("MapCompoundAddTrue", Map[GetWorld()] == GetWorld(), true);
            }

            {
                var Map = new TMap<UObject, UObject>
                {
                    { this, this },
                    { TestCoreSubsystem, TestCoreSubsystem }
                };

                Map.Add(this, GetWorld());

                TestCoreSubsystem.TestEqual("MapCompoundAddFalse", Map[this] == GetWorld(), true);
            }
        }

        private void TestMapRemove()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Map = new TMap<int, int>
                {
                    { 12, 12 },
                    { 34, 34 }
                };

                TestCoreSubsystem.TestEqual("MapPrimitiveRemoveTrue", Map.Remove(12), 1);
            }

            {
                var Map = new TMap<int, int>
                {
                    { 12, 12 },
                    { 34, 34 }
                };

                TestCoreSubsystem.TestEqual("MapPrimitiveRemoveFalse", Map.Remove(56), 0);
            }

            {
                var Map = new TMap<UObject, UObject>
                {
                    { this, this },
                    { TestCoreSubsystem, TestCoreSubsystem }
                };

                TestCoreSubsystem.TestEqual("MapCompoundRemoveTrue", Map.Remove(this), 1);
            }

            {
                var Map = new TMap<UObject, UObject>
                {
                    { this, this },
                    { TestCoreSubsystem, TestCoreSubsystem }
                };

                TestCoreSubsystem.TestEqual("MapCompoundRemoveFalse", Map.Remove(GetWorld()), 0);
            }
        }

        private void TestMapFindKey()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Map = new TMap<int, int>
                {
                    { 12, 12 },
                    { 34, 34 },
                    { 12, 12 },
                    { 34, 34 }
                };

                TestCoreSubsystem.TestEqual("MapPrimitiveFindKey", Map.FindKey(12), 12);
            }

            {
                var Map = new TMap<UObject, UObject>
                {
                    { this, this },
                    { TestCoreSubsystem, TestCoreSubsystem },
                    { this, this },
                    { TestCoreSubsystem, TestCoreSubsystem }
                };

                TestCoreSubsystem.TestEqual("MapCompoundFindKey", Map.FindKey(this), this);
            }
        }

        private void TestMapFind()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Map = new TMap<int, int>
                {
                    { 12, 12 },
                    { 34, 34 },
                    { 12, 12 },
                    { 34, 34 }
                };

                TestCoreSubsystem.TestEqual("MapPrimitiveFind", Map.Find(12), 12);
            }

            {
                var Map = new TMap<UObject, UObject>
                {
                    { this, this },
                    { TestCoreSubsystem, TestCoreSubsystem },
                    { this, this },
                    { TestCoreSubsystem, TestCoreSubsystem }
                };

                TestCoreSubsystem.TestEqual("MapCompoundFind", Map.Find(this), this);
            }
        }

        private void TestMapContains()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Map = new TMap<int, int>
                {
                    { 12, 12 },
                    { 34, 34 }
                };

                TestCoreSubsystem.TestEqual("MapPrimitiveContainsTrue", Map.Contains(12), true);
            }

            {
                var Map = new TMap<int, int>
                {
                    { 12, 12 },
                    { 34, 34 }
                };

                TestCoreSubsystem.TestEqual("MapPrimitiveContainsFalse", Map.Contains(56), false);
            }

            {
                var Map = new TMap<UObject, UObject>
                {
                    { this, this },
                    { TestCoreSubsystem, TestCoreSubsystem }
                };

                TestCoreSubsystem.TestEqual("MapCompoundContainsTrue", Map.Contains(this), true);
            }

            {
                var Map = new TMap<UObject, UObject>
                {
                    { this, this },
                    { TestCoreSubsystem, TestCoreSubsystem }
                };

                TestCoreSubsystem.TestEqual("MapCompoundContainsFalse", Map.Contains(GetWorld()), false);
            }
        }

        private void TestMapSubscript()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Map = new TMap<int, int>
                {
                    { 12, 12 }
                };

                TestCoreSubsystem.TestEqual("MapPrimitiveSubscriptGet", Map[12], 12);
            }

            {
                var Map = new TMap<int, int>
                {
                    { 12, 12 }
                };

                Map[12] = 34;

                TestCoreSubsystem.TestEqual("MapPrimitiveSubscriptSet", Map[12], 34);
            }

            {
                var Map = new TMap<UObject, UObject>
                {
                    { this, this }
                };

                TestCoreSubsystem.TestEqual("MapCompoundSubscriptGet", Map[this], this);
            }

            {
                var Map = new TMap<UObject, UObject>
                {
                    { this, this }
                };

                Map[this] = TestCoreSubsystem;

                TestCoreSubsystem.TestEqual("MapCompoundSubscriptSet", Map[this], TestCoreSubsystem);
            }
        }
    }
}