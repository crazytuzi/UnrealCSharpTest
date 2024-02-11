using Script.CoreUObject;
using Script.Game.UnitTest.Dynamic;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestBlueprintRawDynamicFunction()
        {
            GetWorld().SpawnActor<BP_TestBlueprintRawDynamicFunctionActor_C>(new FTransform());
        }
    }
}