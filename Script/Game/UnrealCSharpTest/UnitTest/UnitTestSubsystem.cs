using Script.Common;

namespace Script.UnrealCSharpTest
{
    [IsOverride]
    public partial class UUnitTestSubsystem
    {
        [IsOverride]
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
        }
    }
}