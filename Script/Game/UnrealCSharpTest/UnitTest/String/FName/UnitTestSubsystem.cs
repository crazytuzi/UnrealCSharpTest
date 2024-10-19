using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestName()
        {
            TestNameEqualTo();

            TestNameNotEqualTo();

            TestNameEqualTo();

            TestNameToString();
        }

        private void TestNameEqualTo()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Name1 = new FName("12");

                var Name2 = new FName("12");

                TestCoreSubsystem.TestEqual("NameEqualToTrue", Name1 == Name2, true);
            }

            {
                var Name1 = new FName("12");

                var Name2 = new FName("34");

                TestCoreSubsystem.TestEqual("NameEqualToFalse", Name1 == Name2, false);
            }
        }

        private void TestNameNotEqualTo()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Name1 = new FName("12");

                var Name2 = new FName("34");

                TestCoreSubsystem.TestEqual("NameNotEqualToTrue", Name1 != Name2, true);
            }

            {
                var Name1 = new FName("12");

                var Name2 = new FName("12");

                TestCoreSubsystem.TestEqual("NameNotEqualToFalse", Name1 != Name2, false);
            }
        }

        private void TestNameEqual()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Name1 = new FName("12");

                var Name2 = new FName("12");

                TestCoreSubsystem.TestEqual("NameEqualTrue", Name1.Equals(Name2), true);
            }

            {
                var Name1 = new FName("12");

                var Name2 = new FName("34");

                TestCoreSubsystem.TestEqual("NameEqualFalse", Name1.Equals(Name2), false);
            }
        }

        private void TestNameToString()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Name = new FName("12");

                TestCoreSubsystem.TestEqual("NameToString", Name.ToString(), "12");
            }
        }
    }
}