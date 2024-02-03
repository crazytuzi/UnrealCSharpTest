using Script.Common;
using Script.Dynamic;

namespace Script.CoreUObject
{
    [UEnum]
    [PathName("/Script/CoreUObject.TestDynamicEnum")]
    public enum ETestDynamicEnum
    {
        TestDynamicZero = 0,
        TestDynamicOne = 1,
        TestDynamicTwo = 2
    }
}