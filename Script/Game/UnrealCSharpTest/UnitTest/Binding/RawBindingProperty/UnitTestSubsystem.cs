using Script.Common;
using Script.Engine;
using Script.Library;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestRawBindingProperty()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(Unreal.GWorld, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            var Property = new FTestBindingProperty();

            // Bool
            TestCoreSubsystem.TestEqual("RawBindingGetBoolProperty", Property.BoolValue, true);

            Property.BoolValue = false;

            TestCoreSubsystem.TestEqual("RawBindingSetBoolProperty", Property.BoolValue, false);

            // Int8
            TestCoreSubsystem.TestEqual("RawBindingGetInt8Property", Property.Int8Value, (sbyte)12);

            Property.Int8Value = 21;

            TestCoreSubsystem.TestEqual("RawBindingSetInt8Property", Property.Int8Value, (sbyte)21);

            // Int16
            TestCoreSubsystem.TestEqual("RawBindingGetInt16Property", Property.Int16Value, (short)12);

            Property.Int16Value = 21;

            TestCoreSubsystem.TestEqual("RawBindingSetInt16Property", Property.Int16Value, (short)21);

            // Int32
            TestCoreSubsystem.TestEqual("RawBindingGetInt32Property", Property.Int32Value, (int)12);

            Property.Int32Value = 21;

            TestCoreSubsystem.TestEqual("RawBindingSetInt32Property", Property.Int32Value, (int)21);

            // Int64
            TestCoreSubsystem.TestEqual("RawBindingGetInt64Property", Property.Int64Value, (long)12);

            Property.Int64Value = 21;

            TestCoreSubsystem.TestEqual("RawBindingSetInt64Property", Property.Int64Value, (long)21);

            // UInt8
            TestCoreSubsystem.TestEqual("RawBindingGetUInt8Property", Property.UInt8Value, (byte)12);

            Property.UInt8Value = 21;

            TestCoreSubsystem.TestEqual("RawBindingSetUInt8Property", Property.UInt8Value, (byte)21);

            // UInt16
            TestCoreSubsystem.TestEqual("RawBindingGetUInt16Property", Property.UInt16Value, (ushort)12);

            Property.UInt16Value = 21;

            TestCoreSubsystem.TestEqual("RawBindingSetUInt16Property", Property.UInt16Value, (ushort)21);

            // UInt32
            TestCoreSubsystem.TestEqual("RawBindingGetUInt32Property", Property.UInt32Value, (uint)12);

            Property.UInt32Value = 21;

            TestCoreSubsystem.TestEqual("RawBindingSetUInt32Property", Property.UInt32Value, (uint)21);

            // UInt64
            TestCoreSubsystem.TestEqual("RawBindingGetUInt64Property", Property.UInt64Value, (ulong)12);

            Property.UInt64Value = 21;

            TestCoreSubsystem.TestEqual("RawBindingSetUInt64Property", Property.UInt64Value, (ulong)21);

            // Float
            TestCoreSubsystem.TestEqual("RawBindingGetFloatProperty", Property.FloatValue, 12.3f);

            Property.FloatValue = 3.21f;

            TestCoreSubsystem.TestEqual("RawBindingSetFloatProperty", Property.FloatValue, 3.21f);

            // Double
            TestCoreSubsystem.TestEqual("RawBindingGetDoubleProperty", Property.DoubleValue, 12.3);

            Property.DoubleValue = 3.21;

            TestCoreSubsystem.TestEqual("RawBindingSetDoubleProperty", Property.DoubleValue, 3.21);

            // FName
            TestCoreSubsystem.TestEqual("RawBindingGetNameProperty", Property.NameValue, "Name12");

            Property.NameValue = "21emaN";

            TestCoreSubsystem.TestEqual("RawBindingSetNameProperty", Property.NameValue, "21emaN");

            // FText
            TestCoreSubsystem.TestEqual("RawBindingGetTextProperty", Property.TextValue, "Text12");

            Property.TextValue = "21txeT";

            TestCoreSubsystem.TestEqual("RawBindingSetTextProperty", Property.TextValue, "21txeT");

            // FString
            TestCoreSubsystem.TestEqual("RawBindingGetStringProperty", Property.StringValue, "String12");

            Property.StringValue = "21gnirtS";

            TestCoreSubsystem.TestEqual("RawBindingSetStringProperty", Property.StringValue, "21gnirtS");

            // Enum
            TestCoreSubsystem.TestEqual("RawBindingGetEnumProperty", Property.EnumValue, ETestEnum.TestEnumOne);

            Property.EnumValue = ETestEnum.TestEnumTwo;

            TestCoreSubsystem.TestEqual("RawBindingSetEnumProperty", Property.EnumValue, ETestEnum.TestEnumTwo);

            // EnumAsByteValue
            TestCoreSubsystem.TestEqual("RawBindingGetEnumAsByteValueProperty", Property.EnumAsByteValue,
                ETestEnum.TestEnumOne);

            Property.EnumAsByteValue = ETestEnum.TestEnumTwo;

            TestCoreSubsystem.TestEqual("RawBindingSetEnumAsByteValueProperty", Property.EnumAsByteValue,
                ETestEnum.TestEnumTwo);

            // EnumClass
            TestCoreSubsystem.TestEqual("RawBindingGetEnumClassProperty", Property.EnumClassValue,
                ETestEnumClass.TestEnumClassOne);

            Property.EnumClassValue = ETestEnumClass.TestEnumClassTwo;

            TestCoreSubsystem.TestEqual("RawBindingSetEnumClassProperty", Property.EnumClassValue,
                ETestEnumClass.TestEnumClassTwo);

            // RawEnum
            TestCoreSubsystem.TestEqual("RawBindingGetRawEnumProperty", Property.RawEnumValue,
                ERawTestEnum.RawTestEnumOne);

            Property.RawEnumValue = ERawTestEnum.RawTestEnumTwo;

            TestCoreSubsystem.TestEqual("RawBindingSetRawEnumProperty", Property.RawEnumValue,
                ERawTestEnum.RawTestEnumTwo);

            // RawEnumClass
            TestCoreSubsystem.TestEqual("RawBindingGetRawEnumClassProperty", Property.RawEnumClassValue,
                ERawTestEnumClass.RawTestEnumClassOne);

            Property.RawEnumClassValue = ERawTestEnumClass.RawTestEnumClassTwo;

            TestCoreSubsystem.TestEqual("RawBindingRawSetEnumClassProperty", Property.RawEnumClassValue,
                ERawTestEnumClass.RawTestEnumClassTwo);

            // UStruct
            TestCoreSubsystem.TestEqual("RawBindingGetStructProperty", Property.StructValue,
                new FTestStruct { Value = 1 });

            Property.StructValue = new FTestStruct { Value = 2 };

            TestCoreSubsystem.TestEqual("RawBindingSetStructProperty", Property.StructValue,
                new FTestStruct { Value = 2 });

            // RawStruct
            TestCoreSubsystem.TestEqual("RawBindingGetRawStructProperty", Property.RawStructValue,
                new FRawTestStruct { Value = 1 });

            Property.RawStructValue = new FRawTestStruct { Value = 2 };

            TestCoreSubsystem.TestEqual("RawBindingSetRawStructProperty", Property.RawStructValue,
                new FRawTestStruct { Value = 2 });

            // UObject
            TestCoreSubsystem.TestEqual("RawBindingGetObjectProperty", Property.ObjectValue, Unreal.GWorld);

            Property.ObjectValue = this;

            TestCoreSubsystem.TestEqual("RawBindingSetObjectProperty", Property.ObjectValue, this);

            // UClass
            TestCoreSubsystem.TestEqual("RawBindingGetClassProperty", Property.ClassValue,
                Unreal.GWorld.GetClass());

            Property.ClassValue = GetClass();

            TestCoreSubsystem.TestEqual("RawBindingSetClassProperty", Property.ClassValue, GetClass());

            // TSubclassOf
            TestCoreSubsystem.TestEqual("RawBindingGetSubclassOfProperty", Property.SubclassOfValue,
                Unreal.GWorld.GetClass());

            Property.SubclassOfValue = GetClass();

            TestCoreSubsystem.TestEqual("RawBindingSetSubclassOfProperty", Property.SubclassOfValue,
                GetClass());

            // TWeakObjectPtr
            TestCoreSubsystem.TestEqual("RawBindingGetWeakObjectPtrProperty", Property.WeakObjectPtrValue,
                Unreal.GWorld);

            Property.WeakObjectPtrValue = this;

            TestCoreSubsystem.TestEqual("RawBindingSetWeakObjectPtrProperty", Property.WeakObjectPtrValue, this);

            // TLazyObjectPtr
            TestCoreSubsystem.TestEqual("RawBindingGetLazyObjectPtrProperty", Property.LazyObjectPtrValue,
                Unreal.GWorld);

            Property.LazyObjectPtrValue = this;

            TestCoreSubsystem.TestEqual("RawBindingSetLazyObjectPtrProperty", Property.LazyObjectPtrValue, this);

            // TSoftObjectPtr
            TestCoreSubsystem.TestEqual("RawBindingGetSoftObjectPtrProperty", Property.SoftObjectPtrValue,
                Unreal.GWorld);

            Property.SoftObjectPtrValue = this;

            TestCoreSubsystem.TestEqual("RawBindingSetSoftObjectPtrProperty", Property.SoftObjectPtrValue, this);

            // TSoftClassPtr
            TestCoreSubsystem.TestEqual("RawBindingGetSoftClassPtrProperty", Property.SoftClassPtrValue,
                Unreal.GWorld.GetClass());

            Property.SoftClassPtrValue = GetClass();

            TestCoreSubsystem.TestEqual("RawBindingSetSoftClassPtrProperty", Property.SoftClassPtrValue,
                GetClass());

            // TArray
            TestCoreSubsystem.TestEqual("RawBindingGetArrayProperty", Property.ArrayValue,
                new TArray<int> { 1, 2 });

            Property.ArrayValue = new TArray<int> { 3, 4 };

            TestCoreSubsystem.TestEqual("RawBindingSetArrayProperty", Property.ArrayValue,
                new TArray<int> { 3, 4 });

            // TSet
            TestCoreSubsystem.TestEqual("RawBindingGetSetProperty", Property.SetValue,
                new TSet<int> { 1, 2 });

            Property.SetValue = new TSet<int> { 3, 4 };

            TestCoreSubsystem.TestEqual("RawBindingSetSetProperty", Property.SetValue,
                new TSet<int> { 3, 4 });

            // TMap
            TestCoreSubsystem.TestEqual("RawBindingGetMapProperty", Property.MapValue,
                new TMap<int, int> { { 1, 1 }, { 2, 2 } });

            Property.MapValue = new TMap<int, int> { { 3, 3 }, { 4, 4 } };

            TestCoreSubsystem.TestEqual("RawBindingSetMapProperty", Property.MapValue,
                new TMap<int, int> { { 3, 3 }, { 4, 4 } });
        }
    }
}