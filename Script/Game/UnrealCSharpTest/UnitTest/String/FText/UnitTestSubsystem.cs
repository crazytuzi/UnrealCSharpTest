using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestText()
        {
            TestTextEqualTo();

            TestTextNotEqualTo();

            TestTextEqualTo();

            TestTextToString();
        }

        private void TestTextEqualTo()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Text1 = new FText("12");

                var Text2 = new FText("12");

                TestCoreSubsystem.TestEqual("TextEqualToTrue", Text1 == Text2, true);
            }

            {
                var Text1 = new FText("12");

                var Text2 = new FText("34");

                TestCoreSubsystem.TestEqual("TextEqualToFalse", Text1 == Text2, false);
            }
        }

        private void TestTextNotEqualTo()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Text1 = new FText("12");

                var Text2 = new FText("34");

                TestCoreSubsystem.TestEqual("TextNotEqualToTrue", Text1 != Text2, true);
            }

            {
                var Text1 = new FText("12");

                var Text2 = new FText("12");

                TestCoreSubsystem.TestEqual("TextNotEqualToFalse", Text1 != Text2, false);
            }
        }

        private void TestTextEqual()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Text1 = new FText("12");

                var Text2 = new FText("12");

                TestCoreSubsystem.TestEqual("TextEqualTrue", Text1.Equals(Text2), true);
            }

            {
                var Text1 = new FText("12");

                var Text2 = new FText("34");

                TestCoreSubsystem.TestEqual("TextEqualFalse", Text1.Equals(Text2), false);
            }
        }

        private void TestTextToString()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            {
                var Text = new FText("12");

                TestCoreSubsystem.TestEqual("TextToString", Text.ToString(), "12");
            }
        }
    }
}