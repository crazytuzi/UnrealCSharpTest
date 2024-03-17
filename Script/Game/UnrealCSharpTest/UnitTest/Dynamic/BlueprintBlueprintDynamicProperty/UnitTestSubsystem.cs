using Script.CoreUObject;
using Script.Game.UnitTest.Dynamic;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestBlueprintBlueprintDynamicProperty()
        {
            GetWorld().SpawnActor<BP_TestBlueprintBlueprintDynamicPropertyActor_C>(new FTransform());
        }
    }
}