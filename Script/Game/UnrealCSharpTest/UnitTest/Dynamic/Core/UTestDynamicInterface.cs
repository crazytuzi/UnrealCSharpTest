using Script.Library;
using Script.Dynamic;

namespace Script.CoreUObject
{
    [UInterface, MinimalAPI, Blueprintable, BlueprintType, IsBlueprintBase("true")]
    [PathName("/Script/CoreUObject.TestDynamicInterface")]
    public partial class UTestDynamicInterface : UInterface, IStaticClass
    {
        public new static UClass StaticClass()
        {
            return UObjectImplementation.UObject_StaticClassImplementation("/Script/CoreUObject.TestDynamicInterface");
        }
    }

    [PathName("/Script/CoreUObject.TestDynamicInterface")]
    public interface ITestDynamicInterface : IInterface
    {
    }
}