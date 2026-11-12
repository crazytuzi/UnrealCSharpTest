using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestRawMethodHelper()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(Unreal.GWorld, (TSubclassOf<UGameInstanceSubsystem>)UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            var Function = new FTestMethodHelper
            {
                TestCoreSubsystem = TestCoreSubsystem
            };

            Function.Test();
        }
    }
}