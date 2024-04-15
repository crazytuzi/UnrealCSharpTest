using Script.Dynamic;

namespace Script.CoreUObject
{
    [UInterface, MinimalAPI, Blueprintable, BlueprintType, IsBlueprintBase("true")]
    public partial class UTestDynamicInterface : UInterface
    {
    }

    public interface ITestDynamicInterface : IInterface
    {
    }
}