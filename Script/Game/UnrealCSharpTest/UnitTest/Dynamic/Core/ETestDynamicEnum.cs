using Script.Dynamic;

namespace Script.CoreUObject
{
    [UEnum, BlueprintType]
    [PathName("/Script/CoreUObject.ETestDynamicEnum")]
    public enum ETestDynamicEnum : byte
    {
        TestDynamicZero = 0,
        TestDynamicOne = 1,
        TestDynamicTwo = 2
    }
}