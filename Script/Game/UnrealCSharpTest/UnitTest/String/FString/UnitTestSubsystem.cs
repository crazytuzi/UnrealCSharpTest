using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestString()
        {
            TestStringEqualTo();

            TestStringNotEqualTo();

            TestStringEqualTo();

            TestStringToString();
        }

        private void TestStringEqualTo()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var String1 = new FString("12");

                var String2 = new FString("12");

                TestCoreSubsystem.TestEqual("StringEqualToTrue", String1 == String2, true);
            }

            {
                var String1 = new FString("12");

                var String2 = new FString("34");

                TestCoreSubsystem.TestEqual("StringEqualToFalse", String1 == String2, false);
            }
        }

        private void TestStringNotEqualTo()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var String1 = new FString("12");

                var String2 = new FString("34");

                TestCoreSubsystem.TestEqual("StringNotEqualToTrue", String1 != String2, true);
            }

            {
                var String1 = new FString("12");

                var String2 = new FString("12");

                TestCoreSubsystem.TestEqual("StringNotEqualToFalse", String1 != String2, false);
            }
        }

        private void TestStringEqual()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var String1 = new FString("12");

                var String2 = new FString("12");

                TestCoreSubsystem.TestEqual("StringEqualTrue", String1.Equals(String2), true);
            }

            {
                var String1 = new FString("12");

                var String2 = new FString("34");

                TestCoreSubsystem.TestEqual("StringEqualFalse", String1.Equals(String2), false);
            }
        }

        private void TestStringToString()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var String = new FString("12");

                TestCoreSubsystem.TestEqual("StringToString", String.ToString(), "12");
            }
        }
    }
}