using System;
using Script.Common;
using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestBindingProperty()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            var PropertyActor = GetWorld().SpawnActor<ATestBindingPropertyActor>(new FTransform());

            // Bool
            TestCoreSubsystem.TestEqual("BindingGetBoolProperty", PropertyActor.BoolValue, true);

            PropertyActor.BoolValue = false;

            TestCoreSubsystem.TestEqual("BindingSetBoolProperty", PropertyActor.BoolValue, false);

            // Int8
            TestCoreSubsystem.TestEqual("BindingGetInt8Property", PropertyActor.Int8Value, (SByte)12);

            PropertyActor.Int8Value = 21;

            TestCoreSubsystem.TestEqual("BindingSetInt8Property", PropertyActor.Int8Value, (SByte)21);

            // Int16
            TestCoreSubsystem.TestEqual("BindingGetInt16Property", PropertyActor.Int16Value, (Int16)12);

            PropertyActor.Int16Value = 21;

            TestCoreSubsystem.TestEqual("BindingSetInt16Property", PropertyActor.Int16Value, (Int16)21);

            // Int32
            TestCoreSubsystem.TestEqual("BindingGetInt32Property", PropertyActor.Int32Value, (Int32)12);

            PropertyActor.Int32Value = 21;

            TestCoreSubsystem.TestEqual("BindingSetInt32Property", PropertyActor.Int32Value, (Int32)21);

            // Int64
            TestCoreSubsystem.TestEqual("BindingGetInt64Property", PropertyActor.Int64Value, (Int64)12);

            PropertyActor.Int64Value = 21;

            TestCoreSubsystem.TestEqual("BindingSetInt64Property", PropertyActor.Int64Value, (Int64)21);

            // UInt8
            TestCoreSubsystem.TestEqual("BindingGetUInt8Property", PropertyActor.UInt8Value, (Byte)12);

            PropertyActor.UInt8Value = 21;

            TestCoreSubsystem.TestEqual("BindingSetUInt8Property", PropertyActor.UInt8Value, (Byte)21);

            // UInt16
            TestCoreSubsystem.TestEqual("BindingGetUInt16Property", PropertyActor.UInt16Value, (UInt16)12);

            PropertyActor.UInt16Value = 21;

            TestCoreSubsystem.TestEqual("BindingSetUInt16Property", PropertyActor.UInt16Value, (UInt16)21);

            // UInt32
            TestCoreSubsystem.TestEqual("BindingGetUInt32Property", PropertyActor.UInt32Value, (UInt32)12);

            PropertyActor.UInt32Value = 21;

            TestCoreSubsystem.TestEqual("BindingSetUInt32Property", PropertyActor.UInt32Value, (UInt32)21);

            // UInt64
            TestCoreSubsystem.TestEqual("BindingGetUInt64Property", PropertyActor.UInt64Value, (UInt64)12);

            PropertyActor.UInt64Value = 21;

            TestCoreSubsystem.TestEqual("BindingSetUInt64Property", PropertyActor.UInt64Value, (UInt64)21);

            // Float
            TestCoreSubsystem.TestEqual("BindingGetFloatProperty", PropertyActor.FloatValue, 12.3f);

            PropertyActor.FloatValue = 3.21f;

            TestCoreSubsystem.TestEqual("BindingSetFloatProperty", PropertyActor.FloatValue, 3.21f);

            // Double
            TestCoreSubsystem.TestEqual("BindingGetDoubleProperty", PropertyActor.DoubleValue, 12.3);

            PropertyActor.DoubleValue = 3.21;

            TestCoreSubsystem.TestEqual("BindingSetDoubleProperty", PropertyActor.DoubleValue, 3.21);

            // FName
            TestCoreSubsystem.TestEqual("BindingGetNameProperty", PropertyActor.NameValue, "Name12");

            PropertyActor.NameValue = "21emaN";

            TestCoreSubsystem.TestEqual("BindingSetNameProperty", PropertyActor.NameValue, "21emaN");

            // FText
            TestCoreSubsystem.TestEqual("BindingGetTextProperty", PropertyActor.TextValue, "Text12");

            PropertyActor.TextValue = "21txeT";

            TestCoreSubsystem.TestEqual("BindingSetTextProperty", PropertyActor.TextValue, "21txeT");

            // FString
            TestCoreSubsystem.TestEqual("BindingGetStringProperty", PropertyActor.StringValue, "String12");

            PropertyActor.StringValue = "21gnirtS";

            TestCoreSubsystem.TestEqual("BindingSetStringProperty", PropertyActor.StringValue, "21gnirtS");

            // Enum
            TestCoreSubsystem.TestEqual("BindingGetEnumProperty", PropertyActor.EnumValue, ETestEnum.TestEnumOne);

            PropertyActor.EnumValue = ETestEnum.TestEnumTwo;

            TestCoreSubsystem.TestEqual("BindingSetEnumProperty", PropertyActor.EnumValue, ETestEnum.TestEnumTwo);

            // EnumAsByteValue
            TestCoreSubsystem.TestEqual("BindingGetEnumAsByteValueProperty", PropertyActor.EnumAsByteValue,
                ETestEnum.TestEnumOne);

            PropertyActor.EnumAsByteValue = ETestEnum.TestEnumTwo;

            TestCoreSubsystem.TestEqual("BindingSetEnumAsByteValueProperty", PropertyActor.EnumAsByteValue,
                ETestEnum.TestEnumTwo);

            // EnumClass
            TestCoreSubsystem.TestEqual("BindingGetEnumClassProperty", PropertyActor.EnumClassValue,
                ETestEnumClass.TestEnumClassOne);

            PropertyActor.EnumClassValue = ETestEnumClass.TestEnumClassTwo;

            TestCoreSubsystem.TestEqual("BindingSetEnumClassProperty", PropertyActor.EnumClassValue,
                ETestEnumClass.TestEnumClassTwo);

            // RawEnum
            TestCoreSubsystem.TestEqual("BindingGetRawEnumProperty", PropertyActor.RawEnumValue,
                ERawTestEnum.RawTestEnumOne);

            PropertyActor.RawEnumValue = ERawTestEnum.RawTestEnumTwo;

            TestCoreSubsystem.TestEqual("BindingSetRawEnumProperty", PropertyActor.RawEnumValue,
                ERawTestEnum.RawTestEnumTwo);

            // RawEnumClass
            TestCoreSubsystem.TestEqual("BindingGetRawEnumClassProperty", PropertyActor.RawEnumClassValue,
                ERawTestEnumClass.RawTestEnumClassOne);

            PropertyActor.RawEnumClassValue = ERawTestEnumClass.RawTestEnumClassTwo;

            TestCoreSubsystem.TestEqual("BindingRawSetEnumClassProperty", PropertyActor.RawEnumClassValue,
                ERawTestEnumClass.RawTestEnumClassTwo);

            // UStruct
            TestCoreSubsystem.TestEqual("BindingGetStructProperty", PropertyActor.StructValue,
                new FTestStruct { Value = 1 });

            PropertyActor.StructValue = new FTestStruct { Value = 2 };

            TestCoreSubsystem.TestEqual("BindingSetStructProperty", PropertyActor.StructValue,
                new FTestStruct { Value = 2 });

            // RawStruct
            TestCoreSubsystem.TestEqual("BindingGetRawStructProperty", PropertyActor.RawStructValue,
                new FRawTestStruct { Value = 1 });

            PropertyActor.RawStructValue = new FRawTestStruct { Value = 2 };

            TestCoreSubsystem.TestEqual("BindingSetRawStructProperty", PropertyActor.RawStructValue,
                new FRawTestStruct { Value = 2 });

            // UObject
            TestCoreSubsystem.TestEqual("BindingGetObjectProperty", PropertyActor.ObjectValue, PropertyActor);

            PropertyActor.ObjectValue = this;

            TestCoreSubsystem.TestEqual("BindingSetObjectProperty", PropertyActor.ObjectValue, this);

            // UClass
            TestCoreSubsystem.TestEqual("BindingGetClassProperty", PropertyActor.ClassValue, PropertyActor.GetClass());

            PropertyActor.ClassValue = GetClass();

            TestCoreSubsystem.TestEqual("BindingSetClassProperty", PropertyActor.ClassValue, GetClass());

            // UInterface
            TestCoreSubsystem.TestEqual("BindingGetInterfaceProperty", PropertyActor.InterfaceValue,
                PropertyActor.InterfaceValue);

            PropertyActor.InterfaceValue = PropertyActor.InterfaceValue;

            TestCoreSubsystem.TestEqual("BindingSetInterfaceProperty", PropertyActor.InterfaceValue,
                PropertyActor.InterfaceValue);

            // TSubclassOf
            TestCoreSubsystem.TestEqual("BindingGetSubclassOfProperty", PropertyActor.SubclassOfValue,
                PropertyActor.GetClass());

            PropertyActor.SubclassOfValue = GetClass();

            TestCoreSubsystem.TestEqual("BindingSetSubclassOfProperty", PropertyActor.SubclassOfValue,
                GetClass());

            // TWeakObjectPtr
            TestCoreSubsystem.TestEqual("BindingGetWeakObjectPtrProperty", PropertyActor.WeakObjectPtrValue,
                PropertyActor);

            PropertyActor.WeakObjectPtrValue = this;

            TestCoreSubsystem.TestEqual("BindingSetWeakObjectPtrProperty", PropertyActor.WeakObjectPtrValue, this);

            // TLazyObjectPtr
            TestCoreSubsystem.TestEqual("BindingGetLazyObjectPtrProperty", PropertyActor.LazyObjectPtrValue,
                PropertyActor);

            PropertyActor.LazyObjectPtrValue = this;

            TestCoreSubsystem.TestEqual("BindingSetLazyObjectPtrProperty", PropertyActor.LazyObjectPtrValue, this);

            // TSoftObjectPtr
            TestCoreSubsystem.TestEqual("BindingGetSoftObjectPtrProperty", PropertyActor.SoftObjectPtrValue,
                PropertyActor);

            PropertyActor.SoftObjectPtrValue = this;

            TestCoreSubsystem.TestEqual("BindingSetSoftObjectPtrProperty", PropertyActor.SoftObjectPtrValue, this);

            // TSoftClassPtr
            TestCoreSubsystem.TestEqual("BindingGetSoftClassPtrProperty", PropertyActor.SoftClassPtrValue,
                PropertyActor.GetClass());

            PropertyActor.SoftClassPtrValue = GetClass();

            TestCoreSubsystem.TestEqual("BindingSetSoftClassPtrProperty", PropertyActor.SoftClassPtrValue,
                GetClass());

            // TArray
            TestCoreSubsystem.TestEqual("BindingGetArrayProperty", PropertyActor.ArrayValue,
                new TArray<Int32> { 1, 2 });

            PropertyActor.ArrayValue = new TArray<Int32> { 3, 4 };

            TestCoreSubsystem.TestEqual("BindingSetArrayProperty", PropertyActor.ArrayValue,
                new TArray<Int32> { 3, 4 });

            // TSet
            TestCoreSubsystem.TestEqual("BindingGetSetProperty", PropertyActor.SetValue,
                new TSet<Int32> { 1, 2 });

            PropertyActor.SetValue = new TSet<Int32> { 3, 4 };

            TestCoreSubsystem.TestEqual("BindingSetSetProperty", PropertyActor.SetValue,
                new TSet<Int32> { 3, 4 });

            // TMap
            TestCoreSubsystem.TestEqual("BindingGetMapProperty", PropertyActor.MapValue,
                new TMap<Int32, Int32> { { 1, 1 }, { 2, 2 } });

            PropertyActor.MapValue = new TMap<Int32, Int32> { { 3, 3 }, { 4, 4 } };

            TestCoreSubsystem.TestEqual("BindingSetMapProperty", PropertyActor.MapValue,
                new TMap<Int32, Int32> { { 3, 3 }, { 4, 4 } });
        }
    }
}