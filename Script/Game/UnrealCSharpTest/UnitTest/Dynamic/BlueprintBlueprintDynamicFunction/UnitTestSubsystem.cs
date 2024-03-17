using Script.CoreUObject;
using Script.Game.UnitTest.Dynamic;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestBlueprintBlueprintDynamicFunction()
        {
            GetWorld().SpawnActor<BP_TestBlueprintBlueprintDynamicFunctionActor_C>(new FTransform());
        }
    }
}