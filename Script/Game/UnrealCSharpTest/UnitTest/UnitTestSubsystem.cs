using System;
using Script.Common;
using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    [IsOverride]
    public partial class UUnitTestSubsystem
    {
        [IsOverride]
        public override void Test()
        {
            TestProperty();

            TestFunction();
        }

        private void TestProperty()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            var PropertyActor = GetWorld().SpawnActor<ATestReflectionPropertyActor>(new FTransform());

            // Bool
            TestCoreSubsystem.TestEqual("ReflectionGetBoolProperty", PropertyActor.BoolValue, true);

            PropertyActor.BoolValue = false;

            TestCoreSubsystem.TestEqual("ReflectionSetBoolProperty", PropertyActor.BoolValue, false);

            // Int8
            TestCoreSubsystem.TestEqual("ReflectionGetInt8Property", PropertyActor.Int8Value, (SByte)12);

            PropertyActor.Int8Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetInt8Property", PropertyActor.Int8Value, (SByte)21);

            // Int16
            TestCoreSubsystem.TestEqual("ReflectionGetInt16Property", PropertyActor.Int16Value, (Int16)12);

            PropertyActor.Int16Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetInt16Property", PropertyActor.Int16Value, (Int16)21);

            // Int32
            TestCoreSubsystem.TestEqual("ReflectionGetInt32Property", PropertyActor.Int32Value, (Int32)12);

            PropertyActor.Int32Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetInt32Property", PropertyActor.Int32Value, (Int32)21);

            // Int64
            TestCoreSubsystem.TestEqual("ReflectionGetInt64Property", PropertyActor.Int64Value, (Int64)12);

            PropertyActor.Int64Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetInt64Property", PropertyActor.Int64Value, (Int64)21);

            // UInt8
            TestCoreSubsystem.TestEqual("ReflectionGetUInt8Property", PropertyActor.UInt8Value, (Byte)12);

            PropertyActor.UInt8Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetUInt8Property", PropertyActor.UInt8Value, (Byte)21);

            // UInt16
            TestCoreSubsystem.TestEqual("ReflectionGetUInt16Property", PropertyActor.UInt16Value, (UInt16)12);

            PropertyActor.UInt16Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetUInt16Property", PropertyActor.UInt16Value, (UInt16)21);

            // UInt32
            TestCoreSubsystem.TestEqual("ReflectionGetUInt32Property", PropertyActor.UInt32Value, (UInt32)12);

            PropertyActor.UInt32Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetUInt32Property", PropertyActor.UInt32Value, (UInt32)21);

            // UInt64
            TestCoreSubsystem.TestEqual("ReflectionGetUInt64Property", PropertyActor.UInt64Value, (UInt64)12);

            PropertyActor.UInt64Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetUInt64Property", PropertyActor.UInt64Value, (UInt64)21);

            // Float
            TestCoreSubsystem.TestEqual("ReflectionGetFloatProperty", PropertyActor.FloatValue, 12.3f);

            PropertyActor.FloatValue = 3.21f;

            TestCoreSubsystem.TestEqual("ReflectionSetFloatProperty", PropertyActor.FloatValue, 3.21f);

            // Double
            TestCoreSubsystem.TestEqual("ReflectionGetDoubleProperty", PropertyActor.DoubleValue, 12.3);

            PropertyActor.DoubleValue = 3.21;

            TestCoreSubsystem.TestEqual("ReflectionSetDoubleProperty", PropertyActor.DoubleValue, 3.21);

            // FName
            TestCoreSubsystem.TestEqual("ReflectionGetTextProperty", PropertyActor.NameValue, "Name12");

            PropertyActor.NameValue = "21emaN";

            TestCoreSubsystem.TestEqual("ReflectionSetNameProperty", PropertyActor.NameValue, "21emaN");

            // FText
            TestCoreSubsystem.TestEqual("ReflectionGetTextProperty", PropertyActor.TextValue, "Text12");

            PropertyActor.TextValue = "21txeT";

            TestCoreSubsystem.TestEqual("ReflectionSetTextProperty", PropertyActor.TextValue, "21txeT");

            // FString
            TestCoreSubsystem.TestEqual("ReflectionGetStringProperty", PropertyActor.StringValue, "String12");

            PropertyActor.StringValue = "21gnirtS";

            TestCoreSubsystem.TestEqual("ReflectionSetStringProperty", PropertyActor.StringValue, "21gnirtS");

            // Enum
            TestCoreSubsystem.TestEqual("ReflectionGetEnumProperty", PropertyActor.EnumValue, ETestEnum.TestEnumOne);

            PropertyActor.EnumValue = ETestEnum.TestEnumTwo;

            TestCoreSubsystem.TestEqual("ReflectionSetEnumProperty", PropertyActor.EnumValue, ETestEnum.TestEnumTwo);

            // EnumClass
            TestCoreSubsystem.TestEqual("ReflectionGetEnumClassProperty", PropertyActor.EnumClassValue,
                ETestEnumClass.TestEnumClassOne);

            PropertyActor.EnumClassValue = ETestEnumClass.TestEnumClassTwo;

            TestCoreSubsystem.TestEqual("ReflectionSetEnumClassProperty", PropertyActor.EnumClassValue,
                ETestEnumClass.TestEnumClassTwo);

            // UStruct
            TestCoreSubsystem.TestEqual("ReflectionGetStructProperty", PropertyActor.StructValue,
                new FTestStruct { Value = 1 });

            PropertyActor.StructValue = new FTestStruct { Value = 2 };

            TestCoreSubsystem.TestEqual("ReflectionSetStructProperty", PropertyActor.StructValue,
                new FTestStruct { Value = 2 });

            // UObject
            TestCoreSubsystem.TestEqual("ReflectionGetObjectProperty", PropertyActor.ObjectValue, PropertyActor);

            PropertyActor.ObjectValue = this;

            TestCoreSubsystem.TestEqual("ReflectionSetObjectProperty", PropertyActor.ObjectValue, this);

            // UClass
            TestCoreSubsystem.TestEqual("ReflectionGetClassProperty", PropertyActor.ClassValue,
                PropertyActor.GetClass());

            PropertyActor.ClassValue = GetClass();

            TestCoreSubsystem.TestEqual("ReflectionSetClassProperty", PropertyActor.ClassValue, GetClass());

            // UInterface
            TestCoreSubsystem.TestEqual("ReflectionGetInterfaceProperty", PropertyActor.InterfaceValue,
                PropertyActor.InterfaceValue);

            PropertyActor.InterfaceValue = PropertyActor.InterfaceValue;

            TestCoreSubsystem.TestEqual("ReflectionSetInterfaceProperty", PropertyActor.InterfaceValue,
                PropertyActor.InterfaceValue);

            // TArray
            TestCoreSubsystem.TestEqual("ReflectionGetArrayProperty", PropertyActor.ArrayValue,
                new TArray<Int32> { 1, 2 });

            PropertyActor.ArrayValue = new TArray<Int32> { 3, 4 };

            TestCoreSubsystem.TestEqual("ReflectionSetArrayProperty", PropertyActor.ArrayValue,
                new TArray<Int32> { 3, 4 });

            // TSet
            TestCoreSubsystem.TestEqual("ReflectionGetSetProperty", PropertyActor.SetValue,
                new TSet<Int32> { 1, 2 });

            PropertyActor.SetValue = new TSet<Int32> { 3, 4 };

            TestCoreSubsystem.TestEqual("ReflectionSetSetProperty", PropertyActor.SetValue,
                new TSet<Int32> { 3, 4 });

            // TMap
            TestCoreSubsystem.TestEqual("ReflectionGetMapProperty", PropertyActor.MapValue,
                new TMap<Int32, Int32> { { 1, 1 }, { 2, 2 } });

            PropertyActor.MapValue = new TMap<Int32, Int32> { { 3, 3 }, { 4, 4 } };

            TestCoreSubsystem.TestEqual("ReflectionSetMapProperty", PropertyActor.MapValue,
                new TMap<Int32, Int32> { { 3, 3 }, { 4, 4 } });
        }

        private void TestFunction()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            var FunctionActor = GetWorld().SpawnActor<ATestReflectionFunctionActor>(new FTransform());

            // Static
            TestCoreSubsystem.TestEqual("ReflectionStaticFunction", ATestReflectionFunctionActor.StaticFunction(),
                true);

            // Bool
            TestCoreSubsystem.TestEqual("ReflectionGetBoolFunction", FunctionActor.GetBoolValueFunction(), true);

            FunctionActor.SetBoolValueFunction(false);

            TestCoreSubsystem.TestEqual("ReflectionSetBoolFunction", FunctionActor.GetBoolValueFunction(), false);

            FunctionActor.OutBoolValueFunction(out var OutBoolValue);

            TestCoreSubsystem.TestEqual("ReflectionOutBoolFunction", OutBoolValue, false);

            // Int8
            TestCoreSubsystem.TestEqual("ReflectionGetInt8Function", FunctionActor.GetInt8ValueFunction(), (SByte)12);

            FunctionActor.SetInt8ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetInt8Function", FunctionActor.GetInt8ValueFunction(), (SByte)21);

            FunctionActor.OutInt8ValueFunction(out var OutInt8Value);

            TestCoreSubsystem.TestEqual("ReflectionOutInt8Function", OutInt8Value, (SByte)21);

            // Int16
            TestCoreSubsystem.TestEqual("ReflectionGetInt16Function", FunctionActor.GetInt16ValueFunction(), (Int16)12);

            FunctionActor.SetInt16ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetInt16Function", FunctionActor.GetInt16ValueFunction(), (Int16)21);

            FunctionActor.OutInt16ValueFunction(out var OutInt16Value);

            TestCoreSubsystem.TestEqual("ReflectionOutInt16Function", OutInt16Value, (Int16)21);

            // Int32
            TestCoreSubsystem.TestEqual("ReflectionGetInt32Function", FunctionActor.GetInt32ValueFunction(), (Int32)12);

            FunctionActor.SetInt32ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetInt32Function", FunctionActor.GetInt32ValueFunction(), (Int32)21);

            FunctionActor.OutInt32ValueFunction(out var OutInt32Value);

            TestCoreSubsystem.TestEqual("ReflectionOutInt32Function", OutInt32Value, (Int32)21);

            // Int64
            TestCoreSubsystem.TestEqual("ReflectionGetInt64Function", FunctionActor.GetInt64ValueFunction(), (Int64)12);

            FunctionActor.SetInt64ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetInt64Function", FunctionActor.GetInt64ValueFunction(), (Int64)21);

            FunctionActor.OutInt64ValueFunction(out var OutInt64Value);

            TestCoreSubsystem.TestEqual("ReflectionOutInt64Function", OutInt64Value, (Int64)21);

            // UInt8
            TestCoreSubsystem.TestEqual("ReflectionGetUInt8Function", FunctionActor.GetUInt8ValueFunction(), (Byte)12);

            FunctionActor.SetUInt8ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetUInt8Function", FunctionActor.GetUInt8ValueFunction(), (Byte)21);

            FunctionActor.OutUInt8ValueFunction(out var OutUInt8Value);

            TestCoreSubsystem.TestEqual("ReflectionOutUInt8Function", OutUInt8Value, (Byte)21);

            // UInt16
            TestCoreSubsystem.TestEqual("ReflectionGetUInt16Function", FunctionActor.GetUInt16ValueFunction(),
                (UInt16)12);

            FunctionActor.SetUInt16ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetUInt16Function", FunctionActor.GetUInt16ValueFunction(),
                (UInt16)21);

            FunctionActor.OutUInt16ValueFunction(out var OutUInt16Value);

            TestCoreSubsystem.TestEqual("ReflectionOutUInt16Function", OutUInt16Value, (UInt16)21);

            // UInt32
            TestCoreSubsystem.TestEqual("ReflectionGetUInt32Function", FunctionActor.GetUInt32ValueFunction(),
                (UInt32)12);

            FunctionActor.SetUInt32ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetUInt32Function", FunctionActor.GetUInt32ValueFunction(),
                (UInt32)21);

            FunctionActor.OutUInt32ValueFunction(out var OutUInt32Value);

            TestCoreSubsystem.TestEqual("ReflectionOutUInt32Function", OutUInt32Value, (UInt32)21);

            // UInt64
            TestCoreSubsystem.TestEqual("ReflectionGetUInt64Function", FunctionActor.GetUInt64ValueFunction(),
                (UInt64)12);

            FunctionActor.SetUInt64ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetUInt64Function", FunctionActor.GetUInt64ValueFunction(),
                (UInt64)21);

            FunctionActor.OutUInt64ValueFunction(out var OutUInt64Value);

            TestCoreSubsystem.TestEqual("ReflectionOutUInt64Function", OutUInt64Value, (UInt64)21);
        }
    }
}