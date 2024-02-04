using Script.Common;
using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestDynamicProperty()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            var PropertyActor = GetWorld().SpawnActor<ATestDynamicPropertyActor>(new FTransform());

            // Bool
            TestCoreSubsystem.TestEqual("DynamicGetBoolProperty", PropertyActor.BoolValue, true);

            PropertyActor.BoolValue = false;

            TestCoreSubsystem.TestEqual("DynamicSetBoolProperty", PropertyActor.BoolValue, false);

            // Int8
            TestCoreSubsystem.TestEqual("DynamicGetInt8Property", PropertyActor.Int8Value, (sbyte)12);

            PropertyActor.Int8Value = 21;

            TestCoreSubsystem.TestEqual("DynamicSetInt8Property", PropertyActor.Int8Value, (sbyte)21);

            // Int16
            TestCoreSubsystem.TestEqual("DynamicGetInt16Property", PropertyActor.Int16Value, (short)12);

            PropertyActor.Int16Value = 21;

            TestCoreSubsystem.TestEqual("DynamicSetInt16Property", PropertyActor.Int16Value, (short)21);

            // Int32
            TestCoreSubsystem.TestEqual("DynamicGetInt32Property", PropertyActor.Int32Value, (int)12);

            PropertyActor.Int32Value = 21;

            TestCoreSubsystem.TestEqual("DynamicSetInt32Property", PropertyActor.Int32Value, (int)21);

            // Int64
            TestCoreSubsystem.TestEqual("DynamicGetInt64Property", PropertyActor.Int64Value, (long)12);

            PropertyActor.Int64Value = 21;

            TestCoreSubsystem.TestEqual("DynamicSetInt64Property", PropertyActor.Int64Value, (long)21);

            // UInt8
            TestCoreSubsystem.TestEqual("DynamicGetUInt8Property", PropertyActor.UInt8Value, (byte)12);

            PropertyActor.UInt8Value = 21;

            TestCoreSubsystem.TestEqual("DynamicSetUInt8Property", PropertyActor.UInt8Value, (byte)21);

            // UInt16
            TestCoreSubsystem.TestEqual("DynamicGetUInt16Property", PropertyActor.UInt16Value, (ushort)12);

            PropertyActor.UInt16Value = 21;

            TestCoreSubsystem.TestEqual("DynamicSetUInt16Property", PropertyActor.UInt16Value, (ushort)21);

            // UInt32
            TestCoreSubsystem.TestEqual("DynamicGetUInt32Property", PropertyActor.UInt32Value, (uint)12);

            PropertyActor.UInt32Value = 21;

            TestCoreSubsystem.TestEqual("DynamicSetUInt32Property", PropertyActor.UInt32Value, (uint)21);

            // UInt64
            TestCoreSubsystem.TestEqual("DynamicGetUInt64Property", PropertyActor.UInt64Value, (ulong)12);

            PropertyActor.UInt64Value = 21;

            TestCoreSubsystem.TestEqual("DynamicSetUInt64Property", PropertyActor.UInt64Value, (ulong)21);

            // Float
            TestCoreSubsystem.TestEqual("DynamicGetFloatProperty", PropertyActor.FloatValue, 12.3f);

            PropertyActor.FloatValue = 3.21f;

            TestCoreSubsystem.TestEqual("DynamicSetFloatProperty", PropertyActor.FloatValue, 3.21f);

            // Double
            TestCoreSubsystem.TestEqual("DynamicGetDoubleProperty", PropertyActor.DoubleValue, 12.3);

            PropertyActor.DoubleValue = 3.21;

            TestCoreSubsystem.TestEqual("DynamicSetDoubleProperty", PropertyActor.DoubleValue, 3.21);

            // FName
            TestCoreSubsystem.TestEqual("DynamicGetNameProperty", PropertyActor.NameValue, "Name12");

            PropertyActor.NameValue = "21emaN";

            TestCoreSubsystem.TestEqual("DynamicSetNameProperty", PropertyActor.NameValue, "21emaN");

            // FText
            TestCoreSubsystem.TestEqual("DynamicGetTextProperty", PropertyActor.TextValue, "Text12");

            PropertyActor.TextValue = "21txeT";

            TestCoreSubsystem.TestEqual("DynamicSetTextProperty", PropertyActor.TextValue, "21txeT");

            // FString
            TestCoreSubsystem.TestEqual("DynamicGetStringProperty", PropertyActor.StringValue, "String12");

            PropertyActor.StringValue = "21gnirtS";

            TestCoreSubsystem.TestEqual("DynamicSetStringProperty", PropertyActor.StringValue, "21gnirtS");

            // Enum
            TestCoreSubsystem.TestEqual("DynamicGetEnumProperty", PropertyActor.EnumValue,
                ETestDynamicEnum.TestDynamicOne);

            PropertyActor.EnumValue = ETestDynamicEnum.TestDynamicTwo;

            TestCoreSubsystem.TestEqual("DynamicSetEnumProperty", PropertyActor.EnumValue,
                ETestDynamicEnum.TestDynamicTwo);

            // UStruct
            TestCoreSubsystem.TestEqual("DynamicGetStructProperty", PropertyActor.StructValue,
                new FTestDynamicStruct { Value = 1 });

            PropertyActor.StructValue = new FTestDynamicStruct { Value = 2 };

            TestCoreSubsystem.TestEqual("DynamicSetStructProperty", PropertyActor.StructValue,
                new FTestDynamicStruct { Value = 2 });

            // UObject
            TestCoreSubsystem.TestEqual("DynamicGetObjectProperty", PropertyActor.ObjectValue,
                PropertyActor);

            PropertyActor.ObjectValue = this;

            TestCoreSubsystem.TestEqual("DynamicSetObjectProperty", PropertyActor.ObjectValue, this);

            // TSubclassOf
            TestCoreSubsystem.TestEqual("DynamicGetSubclassOfProperty", PropertyActor.SubclassOfValue,
                PropertyActor.GetClass());

            PropertyActor.SubclassOfValue = GetClass();

            TestCoreSubsystem.TestEqual("DynamicSetSubclassOfProperty", PropertyActor.SubclassOfValue,
                GetClass());

            // TWeakObjectPtr
            TestCoreSubsystem.TestEqual("DynamicGetWeakObjectPtrProperty", PropertyActor.WeakObjectPtrValue,
                PropertyActor);

            PropertyActor.WeakObjectPtrValue = this;

            TestCoreSubsystem.TestEqual("DynamicSetWeakObjectPtrProperty", PropertyActor.WeakObjectPtrValue, this);

            // TLazyObjectPtr
            TestCoreSubsystem.TestEqual("DynamicGetLazyObjectPtrProperty", PropertyActor.LazyObjectPtrValue,
                PropertyActor);

            PropertyActor.LazyObjectPtrValue = this;

            TestCoreSubsystem.TestEqual("DynamicSetLazyObjectPtrProperty", PropertyActor.LazyObjectPtrValue, this);

            // TSoftObjectPtr
            TestCoreSubsystem.TestEqual("DynamicGetSoftObjectPtrProperty", PropertyActor.SoftObjectPtrValue,
                PropertyActor);

            PropertyActor.SoftObjectPtrValue = this;

            TestCoreSubsystem.TestEqual("DynamicSetSoftObjectPtrProperty", PropertyActor.SoftObjectPtrValue,
                this);

            // TSoftClassPtrValue
            TestCoreSubsystem.TestEqual("DynamicGetSoftClassPtrProperty", PropertyActor.SoftClassPtrValue,
                PropertyActor.GetClass());

            PropertyActor.SoftClassPtrValue = GetClass();

            TestCoreSubsystem.TestEqual("DynamicSetSoftClassPtrProperty", PropertyActor.SoftClassPtrValue,
                GetClass());

            // TArray
            TestCoreSubsystem.TestEqual("DynamicGetArrayProperty", PropertyActor.ArrayValue,
                new TArray<int> { 1, 2 });

            PropertyActor.ArrayValue = new TArray<int> { 3, 4 };

            TestCoreSubsystem.TestEqual("DynamicSetArrayProperty", PropertyActor.ArrayValue,
                new TArray<int> { 3, 4 });

            // TSet
            TestCoreSubsystem.TestEqual("DynamicGetSetProperty", PropertyActor.SetValue,
                new TSet<int> { 1, 2 });

            PropertyActor.SetValue = new TSet<int> { 3, 4 };

            TestCoreSubsystem.TestEqual("DynamicSetSetProperty", PropertyActor.SetValue,
                new TSet<int> { 3, 4 });

            // TMap
            TestCoreSubsystem.TestEqual("DynamicGetMapProperty", PropertyActor.MapValue,
                new TMap<int, int> { { 1, 1 }, { 2, 2 } });

            PropertyActor.MapValue = new TMap<int, int> { { 3, 3 }, { 4, 4 } };

            TestCoreSubsystem.TestEqual("DynamicSetMapProperty", PropertyActor.MapValue,
                new TMap<int, int> { { 3, 3 }, { 4, 4 } });
        }
    }
}