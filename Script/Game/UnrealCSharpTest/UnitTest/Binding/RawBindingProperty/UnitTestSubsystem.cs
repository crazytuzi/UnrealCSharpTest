using System;
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

            var PropertyActor = new FTestBindingProperty();

            // Bool
            TestCoreSubsystem.TestEqual("RawBindingGetBoolProperty", PropertyActor.BoolValue, true);

            PropertyActor.BoolValue = false;

            TestCoreSubsystem.TestEqual("RawBindingSetBoolProperty", PropertyActor.BoolValue, false);

            // Int8
            TestCoreSubsystem.TestEqual("RawBindingGetInt8Property", PropertyActor.Int8Value, (SByte)12);

            PropertyActor.Int8Value = 21;

            TestCoreSubsystem.TestEqual("RawBindingSetInt8Property", PropertyActor.Int8Value, (SByte)21);

            // Int16
            TestCoreSubsystem.TestEqual("RawBindingGetInt16Property", PropertyActor.Int16Value, (Int16)12);

            PropertyActor.Int16Value = 21;

            TestCoreSubsystem.TestEqual("RawBindingSetInt16Property", PropertyActor.Int16Value, (Int16)21);

            // Int32
            TestCoreSubsystem.TestEqual("RawBindingGetInt32Property", PropertyActor.Int32Value, (Int32)12);

            PropertyActor.Int32Value = 21;

            TestCoreSubsystem.TestEqual("RawBindingSetInt32Property", PropertyActor.Int32Value, (Int32)21);

            // Int64
            TestCoreSubsystem.TestEqual("RawBindingGetInt64Property", PropertyActor.Int64Value, (Int64)12);

            PropertyActor.Int64Value = 21;

            TestCoreSubsystem.TestEqual("RawBindingSetInt64Property", PropertyActor.Int64Value, (Int64)21);

            // UInt8
            TestCoreSubsystem.TestEqual("RawBindingGetUInt8Property", PropertyActor.UInt8Value, (Byte)12);

            PropertyActor.UInt8Value = 21;

            TestCoreSubsystem.TestEqual("RawBindingSetUInt8Property", PropertyActor.UInt8Value, (Byte)21);

            // UInt16
            TestCoreSubsystem.TestEqual("RawBindingGetUInt16Property", PropertyActor.UInt16Value, (UInt16)12);

            PropertyActor.UInt16Value = 21;

            TestCoreSubsystem.TestEqual("RawBindingSetUInt16Property", PropertyActor.UInt16Value, (UInt16)21);

            // UInt32
            TestCoreSubsystem.TestEqual("RawBindingGetUInt32Property", PropertyActor.UInt32Value, (UInt32)12);

            PropertyActor.UInt32Value = 21;

            TestCoreSubsystem.TestEqual("RawBindingSetUInt32Property", PropertyActor.UInt32Value, (UInt32)21);

            // UInt64
            TestCoreSubsystem.TestEqual("RawBindingGetUInt64Property", PropertyActor.UInt64Value, (UInt64)12);

            PropertyActor.UInt64Value = 21;

            TestCoreSubsystem.TestEqual("RawBindingSetUInt64Property", PropertyActor.UInt64Value, (UInt64)21);

            // Float
            TestCoreSubsystem.TestEqual("RawBindingGetFloatProperty", PropertyActor.FloatValue, 12.3f);

            PropertyActor.FloatValue = 3.21f;

            TestCoreSubsystem.TestEqual("RawBindingSetFloatProperty", PropertyActor.FloatValue, 3.21f);

            // Double
            TestCoreSubsystem.TestEqual("RawBindingGetDoubleProperty", PropertyActor.DoubleValue, 12.3);

            PropertyActor.DoubleValue = 3.21;

            TestCoreSubsystem.TestEqual("RawBindingSetDoubleProperty", PropertyActor.DoubleValue, 3.21);

            // FName
            TestCoreSubsystem.TestEqual("RawBindingGetNameProperty", PropertyActor.NameValue, "Name12");

            PropertyActor.NameValue = "21emaN";

            TestCoreSubsystem.TestEqual("RawBindingSetNameProperty", PropertyActor.NameValue, "21emaN");

            // FText
            TestCoreSubsystem.TestEqual("RawBindingGetTextProperty", PropertyActor.TextValue, "Text12");

            PropertyActor.TextValue = "21txeT";

            TestCoreSubsystem.TestEqual("RawBindingSetTextProperty", PropertyActor.TextValue, "21txeT");

            // FString
            TestCoreSubsystem.TestEqual("RawBindingGetStringProperty", PropertyActor.StringValue, "String12");

            PropertyActor.StringValue = "21gnirtS";

            TestCoreSubsystem.TestEqual("RawBindingSetStringProperty", PropertyActor.StringValue, "21gnirtS");

            // Enum
            TestCoreSubsystem.TestEqual("RawBindingGetEnumProperty", PropertyActor.EnumValue, ETestEnum.TestEnumOne);

            PropertyActor.EnumValue = ETestEnum.TestEnumTwo;

            TestCoreSubsystem.TestEqual("RawBindingSetEnumProperty", PropertyActor.EnumValue, ETestEnum.TestEnumTwo);

            // EnumAsByteValue
            TestCoreSubsystem.TestEqual("RawBindingGetEnumAsByteValueProperty", PropertyActor.EnumAsByteValue,
                ETestEnum.TestEnumOne);

            PropertyActor.EnumAsByteValue = ETestEnum.TestEnumTwo;

            TestCoreSubsystem.TestEqual("RawBindingSetEnumAsByteValueProperty", PropertyActor.EnumAsByteValue,
                ETestEnum.TestEnumTwo);

            // EnumClass
            TestCoreSubsystem.TestEqual("RawBindingGetEnumClassProperty", PropertyActor.EnumClassValue,
                ETestEnumClass.TestEnumClassOne);

            PropertyActor.EnumClassValue = ETestEnumClass.TestEnumClassTwo;

            TestCoreSubsystem.TestEqual("RawBindingSetEnumClassProperty", PropertyActor.EnumClassValue,
                ETestEnumClass.TestEnumClassTwo);

            // RawEnum
            TestCoreSubsystem.TestEqual("RawBindingGetRawEnumProperty", PropertyActor.RawEnumValue,
                ERawTestEnum.RawTestEnumOne);

            PropertyActor.RawEnumValue = ERawTestEnum.RawTestEnumTwo;

            TestCoreSubsystem.TestEqual("RawBindingSetRawEnumProperty", PropertyActor.RawEnumValue,
                ERawTestEnum.RawTestEnumTwo);

            // RawEnumClass
            TestCoreSubsystem.TestEqual("RawBindingGetRawEnumClassProperty", PropertyActor.RawEnumClassValue,
                ERawTestEnumClass.RawTestEnumClassOne);

            PropertyActor.RawEnumClassValue = ERawTestEnumClass.RawTestEnumClassTwo;

            TestCoreSubsystem.TestEqual("RawBindingRawSetEnumClassProperty", PropertyActor.RawEnumClassValue,
                ERawTestEnumClass.RawTestEnumClassTwo);

            // UStruct
            TestCoreSubsystem.TestEqual("RawBindingGetStructProperty", PropertyActor.StructValue,
                new FTestStruct { Value = 1 });

            PropertyActor.StructValue = new FTestStruct { Value = 2 };

            TestCoreSubsystem.TestEqual("RawBindingSetStructProperty", PropertyActor.StructValue,
                new FTestStruct { Value = 2 });

            // RawStruct
            TestCoreSubsystem.TestEqual("RawBindingGetRawStructProperty", PropertyActor.RawStructValue,
                new FRawTestStruct { Value = 1 });

            PropertyActor.RawStructValue = new FRawTestStruct { Value = 2 };

            TestCoreSubsystem.TestEqual("RawBindingSetRawStructProperty", PropertyActor.RawStructValue,
                new FRawTestStruct { Value = 2 });

            // UObject
            TestCoreSubsystem.TestEqual("RawBindingGetObjectProperty", PropertyActor.ObjectValue, Unreal.GWorld);

            PropertyActor.ObjectValue = this;

            TestCoreSubsystem.TestEqual("RawBindingSetObjectProperty", PropertyActor.ObjectValue, this);

            // UClass
            TestCoreSubsystem.TestEqual("RawBindingGetClassProperty", PropertyActor.ClassValue,
                Unreal.GWorld.GetClass());

            PropertyActor.ClassValue = GetClass();

            TestCoreSubsystem.TestEqual("RawBindingSetClassProperty", PropertyActor.ClassValue, GetClass());

            // TSubclassOf
            TestCoreSubsystem.TestEqual("RawBindingGetSubclassOfProperty", PropertyActor.SubclassOfValue,
                Unreal.GWorld.GetClass());

            PropertyActor.SubclassOfValue = GetClass();

            TestCoreSubsystem.TestEqual("RawBindingSetSubclassOfProperty", PropertyActor.SubclassOfValue,
                GetClass());

            // TWeakObjectPtr
            TestCoreSubsystem.TestEqual("RawBindingGetWeakObjectPtrProperty", PropertyActor.WeakObjectPtrValue,
                Unreal.GWorld);

            PropertyActor.WeakObjectPtrValue = this;

            TestCoreSubsystem.TestEqual("RawBindingSetWeakObjectPtrProperty", PropertyActor.WeakObjectPtrValue, this);

            // TLazyObjectPtr
            TestCoreSubsystem.TestEqual("RawBindingGetLazyObjectPtrProperty", PropertyActor.LazyObjectPtrValue,
                Unreal.GWorld);

            PropertyActor.LazyObjectPtrValue = this;

            TestCoreSubsystem.TestEqual("RawBindingSetLazyObjectPtrProperty", PropertyActor.LazyObjectPtrValue, this);

            // TSoftObjectPtr
            TestCoreSubsystem.TestEqual("RawBindingGetSoftObjectPtrProperty", PropertyActor.SoftObjectPtrValue,
                Unreal.GWorld);

            PropertyActor.SoftObjectPtrValue = this;

            TestCoreSubsystem.TestEqual("RawBindingSetSoftObjectPtrProperty", PropertyActor.SoftObjectPtrValue, this);

            // TSoftClassPtr
            TestCoreSubsystem.TestEqual("RawBindingGetSoftClassPtrProperty", PropertyActor.SoftClassPtrValue,
                Unreal.GWorld.GetClass());

            PropertyActor.SoftClassPtrValue = GetClass();

            TestCoreSubsystem.TestEqual("RawBindingSetSoftClassPtrProperty", PropertyActor.SoftClassPtrValue,
                GetClass());

            // TArray
            TestCoreSubsystem.TestEqual("RawBindingGetArrayProperty", PropertyActor.ArrayValue,
                new TArray<Int32> { 1, 2 });

            PropertyActor.ArrayValue = new TArray<Int32> { 3, 4 };

            TestCoreSubsystem.TestEqual("RawBindingSetArrayProperty", PropertyActor.ArrayValue,
                new TArray<Int32> { 3, 4 });

            // TSet
            TestCoreSubsystem.TestEqual("RawBindingGetSetProperty", PropertyActor.SetValue,
                new TSet<Int32> { 1, 2 });

            PropertyActor.SetValue = new TSet<Int32> { 3, 4 };

            TestCoreSubsystem.TestEqual("RawBindingSetSetProperty", PropertyActor.SetValue,
                new TSet<Int32> { 3, 4 });

            // TMap
            TestCoreSubsystem.TestEqual("RawBindingGetMapProperty", PropertyActor.MapValue,
                new TMap<Int32, Int32> { { 1, 1 }, { 2, 2 } });

            PropertyActor.MapValue = new TMap<Int32, Int32> { { 3, 3 }, { 4, 4 } };

            TestCoreSubsystem.TestEqual("RawBindingSetMapProperty", PropertyActor.MapValue,
                new TMap<Int32, Int32> { { 3, 3 }, { 4, 4 } });
        }
    }
}