using System;
using Script.Common;
using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestBindingFunction()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            var FunctionActor = GetWorld().SpawnActor<ATestBindingFunctionActor>(new FTransform());

            // Static
            TestCoreSubsystem.TestEqual("BindingStaticFunction", ATestBindingFunctionActor.StaticFunction(),
                true);

            // Bool
            TestCoreSubsystem.TestEqual("BindingGetBoolFunction", FunctionActor.GetBoolValueFunction(), true);

            FunctionActor.SetBoolValueFunction(false);

            TestCoreSubsystem.TestEqual("BindingSetBoolFunction", FunctionActor.GetBoolValueFunction(), false);

            Boolean OutBoolValue = false;

            FunctionActor.OutBoolValueFunction(ref OutBoolValue);

            TestCoreSubsystem.TestEqual("BindingOutBoolFunction", OutBoolValue, false);

            // Int8
            TestCoreSubsystem.TestEqual("BindingGetInt8Function", FunctionActor.GetInt8ValueFunction(), (SByte)12);

            FunctionActor.SetInt8ValueFunction(21);

            TestCoreSubsystem.TestEqual("BindingSetInt8Function", FunctionActor.GetInt8ValueFunction(), (SByte)21);

            SByte OutInt8Value = 0;

            FunctionActor.OutInt8ValueFunction(ref OutInt8Value);

            TestCoreSubsystem.TestEqual("BindingOutInt8Function", OutInt8Value, (SByte)21);

            // Int16
            TestCoreSubsystem.TestEqual("BindingGetInt16Function", FunctionActor.GetInt16ValueFunction(), (Int16)12);

            FunctionActor.SetInt16ValueFunction(21);

            TestCoreSubsystem.TestEqual("BindingSetInt16Function", FunctionActor.GetInt16ValueFunction(), (Int16)21);

            Int16 OutInt16Value = 0;

            FunctionActor.OutInt16ValueFunction(ref OutInt16Value);

            TestCoreSubsystem.TestEqual("BindingOutInt16Function", OutInt16Value, (Int16)21);

            // Int32
            TestCoreSubsystem.TestEqual("BindingGetInt32Function", FunctionActor.GetInt32ValueFunction(), (Int32)12);

            FunctionActor.SetInt32ValueFunction(21);

            TestCoreSubsystem.TestEqual("BindingSetInt32Function", FunctionActor.GetInt32ValueFunction(), (Int32)21);

            Int32 OutInt32Value = 0;

            FunctionActor.OutInt32ValueFunction(ref OutInt32Value);

            TestCoreSubsystem.TestEqual("BindingOutInt32Function", OutInt32Value, (Int32)21);

            // Int64
            TestCoreSubsystem.TestEqual("BindingGetInt64Function", FunctionActor.GetInt64ValueFunction(), (Int64)12);

            FunctionActor.SetInt64ValueFunction(21);

            TestCoreSubsystem.TestEqual("BindingSetInt64Function", FunctionActor.GetInt64ValueFunction(), (Int64)21);

            Int64 OutInt64Value = 0;

            FunctionActor.OutInt64ValueFunction(ref OutInt64Value);

            TestCoreSubsystem.TestEqual("BindingOutInt64Function", OutInt64Value, (Int64)21);

            // UInt8
            TestCoreSubsystem.TestEqual("BindingGetUInt8Function", FunctionActor.GetUInt8ValueFunction(), (Byte)12);

            FunctionActor.SetUInt8ValueFunction(21);

            TestCoreSubsystem.TestEqual("BindingSetUInt8Function", FunctionActor.GetUInt8ValueFunction(), (Byte)21);

            Byte OutUInt8Value = 0;

            FunctionActor.OutUInt8ValueFunction(ref OutUInt8Value);

            TestCoreSubsystem.TestEqual("BindingOutUInt8Function", OutUInt8Value, (Byte)21);

            // UInt16
            TestCoreSubsystem.TestEqual("BindingGetUInt16Function", FunctionActor.GetUInt16ValueFunction(),
                (UInt16)12);

            FunctionActor.SetUInt16ValueFunction(21);

            TestCoreSubsystem.TestEqual("BindingSetUInt16Function", FunctionActor.GetUInt16ValueFunction(),
                (UInt16)21);

            UInt16 OutUInt16Value = 0;

            FunctionActor.OutUInt16ValueFunction(ref OutUInt16Value);

            TestCoreSubsystem.TestEqual("BindingOutUInt16Function", OutUInt16Value, (UInt16)21);

            // UInt32
            TestCoreSubsystem.TestEqual("BindingGetUInt32Function", FunctionActor.GetUInt32ValueFunction(),
                (UInt32)12);

            FunctionActor.SetUInt32ValueFunction(21);

            TestCoreSubsystem.TestEqual("BindingSetUInt32Function", FunctionActor.GetUInt32ValueFunction(),
                (UInt32)21);

            UInt32 OutUInt32Value = 0;

            FunctionActor.OutUInt32ValueFunction(ref OutUInt32Value);

            TestCoreSubsystem.TestEqual("BindingOutUInt32Function", OutUInt32Value, (UInt32)21);

            // UInt64
            TestCoreSubsystem.TestEqual("BindingGetUInt64Function", FunctionActor.GetUInt64ValueFunction(),
                (UInt64)12);

            FunctionActor.SetUInt64ValueFunction(21);

            TestCoreSubsystem.TestEqual("BindingSetUInt64Function", FunctionActor.GetUInt64ValueFunction(),
                (UInt64)21);

            UInt64 OutUInt64Value = 0;

            FunctionActor.OutUInt64ValueFunction(ref OutUInt64Value);

            TestCoreSubsystem.TestEqual("BindingOutUInt64Function", OutUInt64Value, (UInt64)21);

            // FName
            TestCoreSubsystem.TestEqual("BindingGetNameFunction", FunctionActor.GetNameValueFunction(), "Name12");

            FunctionActor.SetNameValueFunction("21emaN");

            TestCoreSubsystem.TestEqual("BindingSetNameFunction", FunctionActor.GetNameValueFunction(), "21emaN");

            var OutNameValue = new FName("");

            FunctionActor.OutNameValueFunction(ref OutNameValue);

            TestCoreSubsystem.TestEqual("BindingOutNameFunction", OutNameValue, "21emaN");

            // FText
            TestCoreSubsystem.TestEqual("BindingGetTextFunction", FunctionActor.GetTextValueFunction(), "Text12");

            FunctionActor.SetTextValueFunction("21txeT");

            TestCoreSubsystem.TestEqual("BindingSetTextFunction", FunctionActor.GetTextValueFunction(), "21txeT");

            var OutTextValue = new FText("");

            FunctionActor.OutTextValueFunction(ref OutTextValue);

            TestCoreSubsystem.TestEqual("BindingOutTextFunction", OutTextValue, "21txeT");

            // FString
            TestCoreSubsystem.TestEqual("BindingGetStringFunction", FunctionActor.GetStringValueFunction(),
                "String12");

            FunctionActor.SetStringValueFunction("21gnirtS");

            TestCoreSubsystem.TestEqual("BindingSetStringFunction", FunctionActor.GetStringValueFunction(),
                "21gnirtS");

            var OutStringValue = new FString("");

            FunctionActor.OutStringValueFunction(ref OutStringValue);

            TestCoreSubsystem.TestEqual("BindingOutStringFunction", OutStringValue, "21gnirtS");

            // Enum
            TestCoreSubsystem.TestEqual("BindingGetEnumFunction", FunctionActor.GetEnumValueFunction(),
                ETestEnum.TestEnumOne);

            FunctionActor.SetEnumValueFunction(ETestEnum.TestEnumTwo);

            TestCoreSubsystem.TestEqual("BindingSetEnumFunction", FunctionActor.GetEnumValueFunction(),
                ETestEnum.TestEnumTwo);

            var OutEnumValue = ETestEnum.TestEnumZero;

            FunctionActor.OutEnumValueFunction(ref OutEnumValue);

            TestCoreSubsystem.TestEqual("BindingOutEnumFunction", OutEnumValue, ETestEnum.TestEnumTwo);

            // TEnumAsByte
            TestCoreSubsystem.TestEqual("BindingGetEnumAsByteFunction", FunctionActor.GetEnumAsByteValueFunction(),
                ETestEnum.TestEnumOne);

            FunctionActor.SetEnumAsByteValueFunction(ETestEnum.TestEnumTwo);

            TestCoreSubsystem.TestEqual("BindingSetEnumAsByteFunction", FunctionActor.GetEnumAsByteValueFunction(),
                ETestEnum.TestEnumTwo);

            var OutEnumAsByteValue = ETestEnum.TestEnumZero;

            FunctionActor.OutEnumAsByteValueFunction(ref OutEnumAsByteValue);

            TestCoreSubsystem.TestEqual("BindingOutEnumAsByteFunction", OutEnumAsByteValue, ETestEnum.TestEnumTwo);

            // EnumClass
            TestCoreSubsystem.TestEqual("BindingGetEnumClassFunction", FunctionActor.GetEnumClassValueFunction(),
                ETestEnumClass.TestEnumClassOne);

            FunctionActor.SetEnumClassValueFunction(ETestEnumClass.TestEnumClassTwo);

            TestCoreSubsystem.TestEqual("BindingSetEnumClassFunction", FunctionActor.GetEnumClassValueFunction(),
                ETestEnumClass.TestEnumClassTwo);

            var OutEnumClassValue = ETestEnumClass.TestEnumClassZero;

            FunctionActor.OutEnumClassValueFunction(ref OutEnumClassValue);

            TestCoreSubsystem.TestEqual("BindingOutEnumClassFunction", OutEnumClassValue,
                ETestEnumClass.TestEnumClassTwo);

            // RawEnum
            TestCoreSubsystem.TestEqual("BindingGetRawEnumFunction", FunctionActor.GetRawEnumValueFunction(),
                ERawTestEnum.RawTestEnumOne);

            FunctionActor.SetRawEnumValueFunction(ERawTestEnum.RawTestEnumTwo);

            TestCoreSubsystem.TestEqual("BindingSetRawEnumFunction", FunctionActor.GetRawEnumValueFunction(),
                ERawTestEnum.RawTestEnumTwo);

            var OutRawEnumValue = ERawTestEnum.RawTestEnumZero;

            FunctionActor.OutRawEnumValueFunction(ref OutRawEnumValue);

            TestCoreSubsystem.TestEqual("BindingOutRawEnumFunction", OutRawEnumValue, ERawTestEnum.RawTestEnumTwo);

            // RawEnumClass
            TestCoreSubsystem.TestEqual("BindingGetRawEnumClassFunction", FunctionActor.GetRawEnumClassValueFunction(),
                ERawTestEnumClass.RawTestEnumClassOne);

            FunctionActor.SetRawEnumClassValueFunction(ERawTestEnumClass.RawTestEnumClassTwo);

            TestCoreSubsystem.TestEqual("BindingSetRawEnumClassFunction", FunctionActor.GetRawEnumClassValueFunction(),
                ERawTestEnumClass.RawTestEnumClassTwo);

            var OutRawEnumClassValue = ERawTestEnumClass.RawTestEnumClassZero;

            FunctionActor.OutRawEnumClassValueFunction(ref OutRawEnumClassValue);

            TestCoreSubsystem.TestEqual("BindingOutRawEnumClassFunction", OutRawEnumClassValue,
                ERawTestEnumClass.RawTestEnumClassTwo);

            // UStruct
            TestCoreSubsystem.TestEqual("BindingGetStructFunction", FunctionActor.GetStructValueFunction(),
                new FTestStruct { Value = 1 });

            FunctionActor.SetStructValueFunction(new FTestStruct { Value = 2 });

            TestCoreSubsystem.TestEqual("BindingSetStructFunction", FunctionActor.GetStructValueFunction(),
                new FTestStruct { Value = 2 });

            var OutStructValue = new FTestStruct();

            FunctionActor.OutStructValueFunction(ref OutStructValue);

            TestCoreSubsystem.TestEqual("BindingOutStructFunction", OutStructValue, new FTestStruct { Value = 2 });

            // RawStruct
            TestCoreSubsystem.TestEqual("BindingGetRawStructFunction", FunctionActor.GetRawStructValueFunction(),
                new FRawTestStruct { Value = 1 });

            FunctionActor.SetRawStructValueFunction(new FRawTestStruct { Value = 2 });

            TestCoreSubsystem.TestEqual("BindingSetRawStructFunction", FunctionActor.GetRawStructValueFunction(),
                new FRawTestStruct { Value = 2 });

            var OutRawStructValue = new FRawTestStruct();

            FunctionActor.OutRawStructValueFunction(ref OutRawStructValue);

            TestCoreSubsystem.TestEqual("BindingOutRawStructFunction", OutRawStructValue,
                new FRawTestStruct { Value = 2 });

            // UObject
            TestCoreSubsystem.TestEqual("BindingGetObjectFunction", FunctionActor.GetObjectValueFunction(),
                FunctionActor);

            FunctionActor.SetObjectValueFunction(this);

            TestCoreSubsystem.TestEqual("BindingSetObjectFunction", FunctionActor.GetObjectValueFunction(), this);

            var OutObjectValue = (UObject)FunctionActor;

            FunctionActor.OutObjectValueFunction(ref OutObjectValue);

            TestCoreSubsystem.TestEqual("BindingOutObjectFunction", OutObjectValue, this);

            // UClass
            TestCoreSubsystem.TestEqual("BindingGetClassFunction", FunctionActor.GetClassValueFunction(),
                FunctionActor.GetClass());

            FunctionActor.SetClassValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("BindingSetClassFunction", FunctionActor.GetClassValueFunction(),
                GetClass());

            var OutClassValue = new TSubclassOf<UObject>(FunctionActor.GetClass());

            FunctionActor.OutClassValueFunction(ref OutClassValue);

            TestCoreSubsystem.TestEqual("BindingOutClassFunction", OutClassValue, GetClass());

            // UInterface
            TestCoreSubsystem.TestEqual("BindingGetInterfaceFunction", FunctionActor.GetInterfaceValueFunction(),
                FunctionActor.InterfaceValue);

            FunctionActor.SetInterfaceValueFunction(FunctionActor.InterfaceValue);

            TestCoreSubsystem.TestEqual("BindingSetInterfaceFunction", FunctionActor.GetInterfaceValueFunction(),
                FunctionActor.InterfaceValue);

            var OutInterfaceValue = FunctionActor.InterfaceValue;

            FunctionActor.OutInterfaceValueFunction(ref OutInterfaceValue);

            TestCoreSubsystem.TestEqual("BindingOutInterfaceFunction", OutInterfaceValue,
                FunctionActor.InterfaceValue);
        }
    }
}