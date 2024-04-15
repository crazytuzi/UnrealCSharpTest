using Script.Dynamic;

namespace Script.CoreUObject
{
    [UStruct, BlueprintType]
    public partial class FTestDynamicStruct
    {
        [UProperty, BlueprintReadWrite]
        public int Value { get; set; }
    }
}