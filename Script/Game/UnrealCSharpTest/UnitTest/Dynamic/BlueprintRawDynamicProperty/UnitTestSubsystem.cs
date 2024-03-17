using Script.CoreUObject;
using Script.Game.UnitTest.Dynamic;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestBlueprintRawDynamicProperty()
        {
            GetWorld().SpawnActor<BP_TestBlueprintRawDynamicPropertyActor_C>(new FTransform());
        }
    }
}