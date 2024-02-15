using Script.Common;

namespace Script.UnrealCSharpTest
{
    [Override]
    public partial class UUnitTestSubsystem
    {
        [Override]
        public override void Test()
        {
            TestReflectionProperty();

            TestReflectionFunction();

            TestBindingProperty();

            TestBindingFunction();

            TestRawBindingProperty();

            TestRawBindingFunction();

            TestBlueprintReflectionProperty();

            TestBlueprintReflectionFunction();

            TestCSharpFunction();

            TestBlueprintCSharpFunction();

            TestRawDynamicProperty();

            TestRawDynamicFunction();

            TestBlueprintRawDynamicProperty();

            TestBlueprintRawDynamicFunction();

            TestBlueprintDynamicProperty();

            TestBlueprintDynamicFunction();

            TestBlueprintBlueprintDynamicProperty();

            TestBlueprintBlueprintDynamicFunction();
        }
    }
}