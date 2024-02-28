using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestRawDynamicProperty()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            var PropertyActor = GetWorld().SpawnActor<ATestRawDynamicPropertyActor>(new FTransform());

            // Bool
            TestCoreSubsystem.TestEqual("RawDynamicGetBoolProperty", PropertyActor.BoolValue, true);

            PropertyActor.BoolValue = false;

            TestCoreSubsystem.TestEqual("RawDynamicSetBoolProperty", PropertyActor.BoolValue, false);

            // Int8
            TestCoreSubsystem.TestEqual("RawDynamicGetInt8Property", PropertyActor.Int8Value, (sbyte)12);

            PropertyActor.Int8Value = 21;

            TestCoreSubsystem.TestEqual("RawDynamicSetInt8Property", PropertyActor.Int8Value, (sbyte)21);

            // Int16
            TestCoreSubsystem.TestEqual("RawDynamicGetInt16Property", PropertyActor.Int16Value, (short)12);

            PropertyActor.Int16Value = 21;

            TestCoreSubsystem.TestEqual("RawDynamicSetInt16Property", PropertyActor.Int16Value, (short)21);

            // Int32
            TestCoreSubsystem.TestEqual("RawDynamicGetInt32Property", PropertyActor.Int32Value, (int)12);

            PropertyActor.Int32Value = 21;

            TestCoreSubsystem.TestEqual("RawDynamicSetInt32Property", PropertyActor.Int32Value, (int)21);

            // Int64
            TestCoreSubsystem.TestEqual("RawDynamicGetInt64Property", PropertyActor.Int64Value, (long)12);

            PropertyActor.Int64Value = 21;

            TestCoreSubsystem.TestEqual("RawDynamicSetInt64Property", PropertyActor.Int64Value, (long)21);

            // UInt8
            TestCoreSubsystem.TestEqual("RawDynamicGetUInt8Property", PropertyActor.UInt8Value, (byte)12);

            PropertyActor.UInt8Value = 21;

            TestCoreSubsystem.TestEqual("RawDynamicSetUInt8Property", PropertyActor.UInt8Value, (byte)21);

            // UInt16
            TestCoreSubsystem.TestEqual("RawDynamicGetUInt16Property", PropertyActor.UInt16Value, (ushort)12);

            PropertyActor.UInt16Value = 21;

            TestCoreSubsystem.TestEqual("RawDynamicSetUInt16Property", PropertyActor.UInt16Value, (ushort)21);

            // UInt32
            TestCoreSubsystem.TestEqual("RawDynamicGetUInt32Property", PropertyActor.UInt32Value, (uint)12);

            PropertyActor.UInt32Value = 21;

            TestCoreSubsystem.TestEqual("RawDynamicSetUInt32Property", PropertyActor.UInt32Value, (uint)21);

            // UInt64
            TestCoreSubsystem.TestEqual("RawDynamicGetUInt64Property", PropertyActor.UInt64Value, (ulong)12);

            PropertyActor.UInt64Value = 21;

            TestCoreSubsystem.TestEqual("RawDynamicSetUInt64Property", PropertyActor.UInt64Value, (ulong)21);

            // Float
            TestCoreSubsystem.TestEqual("RawDynamicGetFloatProperty", PropertyActor.FloatValue, 12.3f);

            PropertyActor.FloatValue = 3.21f;

            TestCoreSubsystem.TestEqual("RawDynamicSetFloatProperty", PropertyActor.FloatValue, 3.21f);

            // Double
            TestCoreSubsystem.TestEqual("RawDynamicGetDoubleProperty", PropertyActor.DoubleValue, 12.3);

            PropertyActor.DoubleValue = 3.21;

            TestCoreSubsystem.TestEqual("RawDynamicSetDoubleProperty", PropertyActor.DoubleValue, 3.21);

            // FName
            TestCoreSubsystem.TestEqual("RawDynamicGetNameProperty", PropertyActor.NameValue, "Name12");

            PropertyActor.NameValue = "21emaN";

            TestCoreSubsystem.TestEqual("RawDynamicSetNameProperty", PropertyActor.NameValue, "21emaN");

            // FText
            TestCoreSubsystem.TestEqual("RawDynamicGetTextProperty", PropertyActor.TextValue, "Text12");

            PropertyActor.TextValue = "21txeT";

            TestCoreSubsystem.TestEqual("RawDynamicSetTextProperty", PropertyActor.TextValue, "21txeT");

            // FString
            TestCoreSubsystem.TestEqual("RawDynamicGetStringProperty", PropertyActor.StringValue, "String12");

            PropertyActor.StringValue = "21gnirtS";

            TestCoreSubsystem.TestEqual("RawDynamicSetStringProperty", PropertyActor.StringValue, "21gnirtS");

            // Enum
            TestCoreSubsystem.TestEqual("RawDynamicGetEnumProperty", PropertyActor.EnumValue,
                ETestDynamicEnum.TestDynamicOne);

            PropertyActor.EnumValue = ETestDynamicEnum.TestDynamicTwo;

            TestCoreSubsystem.TestEqual("RawDynamicSetEnumProperty", PropertyActor.EnumValue,
                ETestDynamicEnum.TestDynamicTwo);

            // UStruct
            TestCoreSubsystem.TestEqual("RawDynamicGetStructProperty", PropertyActor.StructValue,
                new FTestDynamicStruct { Value = 1 });

            PropertyActor.StructValue = new FTestDynamicStruct { Value = 2 };

            TestCoreSubsystem.TestEqual("RawDynamicSetStructProperty", PropertyActor.StructValue,
                new FTestDynamicStruct { Value = 2 });

            // UObject
            TestCoreSubsystem.TestEqual("RawDynamicGetObjectProperty", PropertyActor.ObjectValue,
                PropertyActor);

            PropertyActor.ObjectValue = this;

            TestCoreSubsystem.TestEqual("RawDynamicSetObjectProperty", PropertyActor.ObjectValue, this);

            // TSubclassOf
            TestCoreSubsystem.TestEqual("RawDynamicGetSubclassOfProperty", PropertyActor.SubclassOfValue,
                PropertyActor.GetClass());

            PropertyActor.SubclassOfValue = GetClass();

            TestCoreSubsystem.TestEqual("RawDynamicSetSubclassOfProperty", PropertyActor.SubclassOfValue,
                GetClass());

            // TWeakObjectPtr
            TestCoreSubsystem.TestEqual("RawDynamicGetWeakObjectPtrProperty", PropertyActor.WeakObjectPtrValue,
                PropertyActor);

            PropertyActor.WeakObjectPtrValue = this;

            TestCoreSubsystem.TestEqual("RawDynamicSetWeakObjectPtrProperty", PropertyActor.WeakObjectPtrValue, this);

            // TLazyObjectPtr
            TestCoreSubsystem.TestEqual("RawDynamicGetLazyObjectPtrProperty", PropertyActor.LazyObjectPtrValue,
                PropertyActor);

            PropertyActor.LazyObjectPtrValue = this;

            TestCoreSubsystem.TestEqual("RawDynamicSetLazyObjectPtrProperty", PropertyActor.LazyObjectPtrValue, this);

            // TSoftObjectPtr
            TestCoreSubsystem.TestEqual("RawDynamicGetSoftObjectPtrProperty", PropertyActor.SoftObjectPtrValue,
                PropertyActor);

            PropertyActor.SoftObjectPtrValue = this;

            TestCoreSubsystem.TestEqual("RawDynamicSetSoftObjectPtrProperty", PropertyActor.SoftObjectPtrValue,
                this);

            // TSoftClassPtrValue
            TestCoreSubsystem.TestEqual("RawDynamicGetSoftClassPtrProperty", PropertyActor.SoftClassPtrValue,
                PropertyActor.GetClass());

            PropertyActor.SoftClassPtrValue = GetClass();

            TestCoreSubsystem.TestEqual("RawDynamicSetSoftClassPtrProperty", PropertyActor.SoftClassPtrValue,
                GetClass());

            // TArray
            TestCoreSubsystem.TestEqual("RawDynamicGetArrayProperty", PropertyActor.ArrayValue,
                new TArray<int> { 1, 2 });

            PropertyActor.ArrayValue = new TArray<int> { 3, 4 };

            TestCoreSubsystem.TestEqual("RawDynamicSetArrayProperty", PropertyActor.ArrayValue,
                new TArray<int> { 3, 4 });

            // TSet
            TestCoreSubsystem.TestEqual("RawDynamicGetSetProperty", PropertyActor.SetValue,
                new TSet<int> { 1, 2 });

            PropertyActor.SetValue = new TSet<int> { 3, 4 };

            TestCoreSubsystem.TestEqual("RawDynamicSetSetProperty", PropertyActor.SetValue,
                new TSet<int> { 3, 4 });

            // TMap
            TestCoreSubsystem.TestEqual("RawDynamicGetMapProperty", PropertyActor.MapValue,
                new TMap<int, int> { { 1, 1 }, { 2, 2 } });

            PropertyActor.MapValue = new TMap<int, int> { { 3, 3 }, { 4, 4 } };

            TestCoreSubsystem.TestEqual("RawDynamicSetMapProperty", PropertyActor.MapValue,
                new TMap<int, int> { { 3, 3 }, { 4, 4 } });
        }
    }
}