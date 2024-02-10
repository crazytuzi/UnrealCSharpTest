using Script.Common;
using Script.Dynamic;

namespace Script.CoreUObject
{
    [UEnum]
    [PathName("/Script/CoreUObject.ETestDynamicEnum")]
    public enum ETestDynamicEnum : byte
    {
        TestDynamicZero = 0,
        TestDynamicOne = 1,
        TestDynamicTwo = 2
    }
}