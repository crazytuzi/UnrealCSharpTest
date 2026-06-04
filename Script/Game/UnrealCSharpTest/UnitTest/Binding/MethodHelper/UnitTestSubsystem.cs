using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestMethodHelper()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            var FunctionActor = GetWorld().SpawnActor<ATestMethodHelperActor>(new FTransform());

            FunctionActor.TestCoreSubsystem = TestCoreSubsystem;

            FunctionActor.Test();
        }
    }
}