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

            FunctionActor.TestCoreSubsystem = TestCoreSubsystem;

            // Static
            TestCoreSubsystem.TestEqual("BindingStaticFunction", ATestBindingFunctionActor.StaticFunction(),
                true);

            // Bool
            TestCoreSubsystem.TestEqual("BindingGetBoolFunction", FunctionActor.GetBoolValueFunction(), true);

            FunctionActor.SetBoolValueFunction(false);

            TestCoreSubsystem.TestEqual("BindingSetBoolFunction", FunctionActor.GetBoolValueFunction(), false);

            Boolean OutBoolValue = true;

            FunctionActor.OutBoolValueFunction(ref OutBoolValue);

            TestCoreSubsystem.TestEqual("BindingOutSetBoolFunction", OutBoolValue, false);

            // Int8
            TestCoreSubsystem.TestEqual("BindingGetInt8Function", FunctionActor.GetInt8ValueFunction(), (SByte)12);

            FunctionActor.SetInt8ValueFunction(21);

            TestCoreSubsystem.TestEqual("BindingSetInt8Function", FunctionActor.GetInt8ValueFunction(), (SByte)21);

            SByte OutInt8Value = 12;

            FunctionActor.OutInt8ValueFunction(ref OutInt8Value);

            TestCoreSubsystem.TestEqual("BindingOutSetInt8Function", OutInt8Value, (SByte)21);

            // Int16
            TestCoreSubsystem.TestEqual("BindingGetInt16Function", FunctionActor.GetInt16ValueFunction(), (Int16)12);

            FunctionActor.SetInt16ValueFunction(21);

            TestCoreSubsystem.TestEqual("BindingSetInt16Function", FunctionActor.GetInt16ValueFunction(), (Int16)21);

            Int16 OutInt16Value = 12;

            FunctionActor.OutInt16ValueFunction(ref OutInt16Value);

            TestCoreSubsystem.TestEqual("BindingOutSetInt16Function", OutInt16Value, (Int16)21);

            // Int32
            TestCoreSubsystem.TestEqual("BindingGetInt32Function", FunctionActor.GetInt32ValueFunction(), (Int32)12);

            FunctionActor.SetInt32ValueFunction(21);

            TestCoreSubsystem.TestEqual("BindingSetInt32Function", FunctionActor.GetInt32ValueFunction(), (Int32)21);

            Int32 OutInt32Value = 12;

            FunctionActor.OutInt32ValueFunction(ref OutInt32Value);

            TestCoreSubsystem.TestEqual("BindingOutSetInt32Function", OutInt32Value, (Int32)21);

            // Int64
            TestCoreSubsystem.TestEqual("BindingGetInt64Function", FunctionActor.GetInt64ValueFunction(), (Int64)12);

            FunctionActor.SetInt64ValueFunction(21);

            TestCoreSubsystem.TestEqual("BindingSetInt64Function", FunctionActor.GetInt64ValueFunction(), (Int64)21);

            Int64 OutInt64Value = 12;

            FunctionActor.OutInt64ValueFunction(ref OutInt64Value);

            TestCoreSubsystem.TestEqual("BindingOutSetInt64Function", OutInt64Value, (Int64)21);

            // UInt8
            TestCoreSubsystem.TestEqual("BindingGetUInt8Function", FunctionActor.GetUInt8ValueFunction(), (Byte)12);

            FunctionActor.SetUInt8ValueFunction(21);

            TestCoreSubsystem.TestEqual("BindingSetUInt8Function", FunctionActor.GetUInt8ValueFunction(), (Byte)21);

            Byte OutUInt8Value = 12;

            FunctionActor.OutUInt8ValueFunction(ref OutUInt8Value);

            TestCoreSubsystem.TestEqual("BindingOutSetUInt8Function", OutUInt8Value, (Byte)21);

            // UInt16
            TestCoreSubsystem.TestEqual("BindingGetUInt16Function", FunctionActor.GetUInt16ValueFunction(),
                (UInt16)12);

            FunctionActor.SetUInt16ValueFunction(21);

            TestCoreSubsystem.TestEqual("BindingSetUInt16Function", FunctionActor.GetUInt16ValueFunction(),
                (UInt16)21);

            UInt16 OutUInt16Value = 12;

            FunctionActor.OutUInt16ValueFunction(ref OutUInt16Value);

            TestCoreSubsystem.TestEqual("BindingOutSetUInt16Function", OutUInt16Value, (UInt16)21);

            // UInt32
            TestCoreSubsystem.TestEqual("BindingGetUInt32Function", FunctionActor.GetUInt32ValueFunction(),
                (UInt32)12);

            FunctionActor.SetUInt32ValueFunction(21);

            TestCoreSubsystem.TestEqual("BindingSetUInt32Function", FunctionActor.GetUInt32ValueFunction(),
                (UInt32)21);

            UInt32 OutUInt32Value = 12;

            FunctionActor.OutUInt32ValueFunction(ref OutUInt32Value);

            TestCoreSubsystem.TestEqual("BindingOutSetUInt32Function", OutUInt32Value, (UInt32)21);

            // UInt64
            TestCoreSubsystem.TestEqual("BindingGetUInt64Function", FunctionActor.GetUInt64ValueFunction(),
                (UInt64)12);

            FunctionActor.SetUInt64ValueFunction(21);

            TestCoreSubsystem.TestEqual("BindingSetUInt64Function", FunctionActor.GetUInt64ValueFunction(),
                (UInt64)21);

            UInt64 OutUInt64Value = 12;

            FunctionActor.OutUInt64ValueFunction(ref OutUInt64Value);

            TestCoreSubsystem.TestEqual("BindingOutSetUInt64Function", OutUInt64Value, (UInt64)21);

            // Float
            TestCoreSubsystem.TestEqual("BindingGetFloatFunction", FunctionActor.GetFloatValueFunction(), 12.3f);

            FunctionActor.SetFloatValueFunction(3.21f);

            TestCoreSubsystem.TestEqual("BindingSetFloatFunction", FunctionActor.GetFloatValueFunction(), 3.21f);

            Single OutFloatValue = 12.3f;

            FunctionActor.OutFloatValueFunction(ref OutFloatValue);

            TestCoreSubsystem.TestEqual("BindingOutFloatFunction", OutFloatValue, 3.21f);

            // Double
            TestCoreSubsystem.TestEqual("BindingGetDoubleFunction", FunctionActor.GetDoubleValueFunction(), 12.3);

            FunctionActor.SetDoubleValueFunction(3.21);

            TestCoreSubsystem.TestEqual("BindingSetDoubleFunction", FunctionActor.GetDoubleValueFunction(), 3.21);

            Double OutDoubleValue = 12.3;

            FunctionActor.OutDoubleValueFunction(ref OutDoubleValue);

            TestCoreSubsystem.TestEqual("BindingOutDoubleFunction", OutDoubleValue, 3.21);

            // FName
            TestCoreSubsystem.TestEqual("BindingGetNameFunction", FunctionActor.GetNameValueFunction(), "Name12");

            FunctionActor.SetNameValueFunction("21emaN");

            TestCoreSubsystem.TestEqual("BindingSetNameFunction", FunctionActor.GetNameValueFunction(), "21emaN");

            var OutNameValue = new FName("Name12");

            FunctionActor.OutNameValueFunction(ref OutNameValue);

            TestCoreSubsystem.TestEqual("BindingOutSetNameFunction", OutNameValue, "21emaN");

            // FText
            TestCoreSubsystem.TestEqual("BindingGetTextFunction", FunctionActor.GetTextValueFunction(), "Text12");

            FunctionActor.SetTextValueFunction("21txeT");

            TestCoreSubsystem.TestEqual("BindingSetTextFunction", FunctionActor.GetTextValueFunction(), "21txeT");

            var OutTextValue = new FText("Text12");

            FunctionActor.OutTextValueFunction(ref OutTextValue);

            TestCoreSubsystem.TestEqual("BindingOutSetTextFunction", OutTextValue, "21txeT");

            // FString
            TestCoreSubsystem.TestEqual("BindingGetStringFunction", FunctionActor.GetStringValueFunction(),
                "String12");

            FunctionActor.SetStringValueFunction("21gnirtS");

            TestCoreSubsystem.TestEqual("BindingSetStringFunction", FunctionActor.GetStringValueFunction(),
                "21gnirtS");

            var OutStringValue = new FString("String12");

            FunctionActor.OutStringValueFunction(ref OutStringValue);

            TestCoreSubsystem.TestEqual("BindingOutSetStringFunction", OutStringValue, "21gnirtS");

            // Enum
            TestCoreSubsystem.TestEqual("BindingGetEnumFunction", FunctionActor.GetEnumValueFunction(),
                ETestEnum.TestEnumOne);

            FunctionActor.SetEnumValueFunction(ETestEnum.TestEnumTwo);

            TestCoreSubsystem.TestEqual("BindingSetEnumFunction", FunctionActor.GetEnumValueFunction(),
                ETestEnum.TestEnumTwo);

            var OutEnumValue = ETestEnum.TestEnumOne;

            FunctionActor.OutEnumValueFunction(ref OutEnumValue);

            TestCoreSubsystem.TestEqual("BindingOutSetEnumFunction", OutEnumValue, ETestEnum.TestEnumTwo);

            // TEnumAsByte
            TestCoreSubsystem.TestEqual("BindingGetEnumAsByteFunction", FunctionActor.GetEnumAsByteValueFunction(),
                ETestEnum.TestEnumOne);

            FunctionActor.SetEnumAsByteValueFunction(ETestEnum.TestEnumTwo);

            TestCoreSubsystem.TestEqual("BindingSetEnumAsByteFunction", FunctionActor.GetEnumAsByteValueFunction(),
                ETestEnum.TestEnumTwo);

            var OutEnumAsByteValue = ETestEnum.TestEnumOne;

            FunctionActor.OutEnumAsByteValueFunction(ref OutEnumAsByteValue);

            TestCoreSubsystem.TestEqual("BindingOutSetEnumAsByteFunction", OutEnumAsByteValue, ETestEnum.TestEnumTwo);

            // EnumClass
            TestCoreSubsystem.TestEqual("BindingGetEnumClassFunction", FunctionActor.GetEnumClassValueFunction(),
                ETestEnumClass.TestEnumClassOne);

            FunctionActor.SetEnumClassValueFunction(ETestEnumClass.TestEnumClassTwo);

            TestCoreSubsystem.TestEqual("BindingSetEnumClassFunction", FunctionActor.GetEnumClassValueFunction(),
                ETestEnumClass.TestEnumClassTwo);

            var OutEnumClassValue = ETestEnumClass.TestEnumClassOne;

            FunctionActor.OutEnumClassValueFunction(ref OutEnumClassValue);

            TestCoreSubsystem.TestEqual("BindingOutSetEnumClassFunction", OutEnumClassValue,
                ETestEnumClass.TestEnumClassTwo);

            // RawEnum
            TestCoreSubsystem.TestEqual("BindingGetRawEnumFunction", FunctionActor.GetRawEnumValueFunction(),
                ERawTestEnum.RawTestEnumOne);

            FunctionActor.SetRawEnumValueFunction(ERawTestEnum.RawTestEnumTwo);

            TestCoreSubsystem.TestEqual("BindingSetRawEnumFunction", FunctionActor.GetRawEnumValueFunction(),
                ERawTestEnum.RawTestEnumTwo);

            var OutRawEnumValue = ERawTestEnum.RawTestEnumOne;

            FunctionActor.OutRawEnumValueFunction(ref OutRawEnumValue);

            TestCoreSubsystem.TestEqual("BindingOutSetRawEnumFunction", OutRawEnumValue, ERawTestEnum.RawTestEnumTwo);

            // RawEnumClass
            TestCoreSubsystem.TestEqual("BindingGetRawEnumClassFunction", FunctionActor.GetRawEnumClassValueFunction(),
                ERawTestEnumClass.RawTestEnumClassOne);

            FunctionActor.SetRawEnumClassValueFunction(ERawTestEnumClass.RawTestEnumClassTwo);

            TestCoreSubsystem.TestEqual("BindingSetRawEnumClassFunction", FunctionActor.GetRawEnumClassValueFunction(),
                ERawTestEnumClass.RawTestEnumClassTwo);

            var OutRawEnumClassValue = ERawTestEnumClass.RawTestEnumClassOne;

            FunctionActor.OutRawEnumClassValueFunction(ref OutRawEnumClassValue);

            TestCoreSubsystem.TestEqual("BindingOutSetRawEnumClassFunction", OutRawEnumClassValue,
                ERawTestEnumClass.RawTestEnumClassTwo);

            // UStruct
            TestCoreSubsystem.TestEqual("BindingGetStructFunction", FunctionActor.GetStructValueFunction(),
                new FTestStruct { Value = 1 });

            FunctionActor.SetStructValueFunction(new FTestStruct { Value = 2 });

            TestCoreSubsystem.TestEqual("BindingSetStructFunction", FunctionActor.GetStructValueFunction(),
                new FTestStruct { Value = 2 });

            var OutStructValue = new FTestStruct { Value = 1 };

            FunctionActor.OutStructValueFunction(ref OutStructValue);

            TestCoreSubsystem.TestEqual("BindingOutSetStructFunction", OutStructValue, new FTestStruct { Value = 2 });

            // RawStruct
            TestCoreSubsystem.TestEqual("BindingGetRawStructFunction", FunctionActor.GetRawStructValueFunction(),
                new FRawTestStruct { Value = 1 });

            FunctionActor.SetRawStructValueFunction(new FRawTestStruct { Value = 2 });

            TestCoreSubsystem.TestEqual("BindingSetRawStructFunction", FunctionActor.GetRawStructValueFunction(),
                new FRawTestStruct { Value = 2 });

            var OutRawStructValue = new FRawTestStruct { Value = 1 };

            FunctionActor.OutRawStructValueFunction(ref OutRawStructValue);

            TestCoreSubsystem.TestEqual("BindingOutSetRawStructFunction", OutRawStructValue,
                new FRawTestStruct { Value = 2 });

            // UObject
            TestCoreSubsystem.TestEqual("BindingGetObjectFunction", FunctionActor.GetObjectValueFunction(),
                FunctionActor);

            FunctionActor.SetObjectValueFunction(this);

            TestCoreSubsystem.TestEqual("BindingSetObjectFunction", FunctionActor.GetObjectValueFunction(), this);

            UObject OutObjectValue = FunctionActor;

            FunctionActor.OutObjectValueFunction(ref OutObjectValue);

            TestCoreSubsystem.TestEqual("BindingOutSetObjectFunction", OutObjectValue, this);

            // UClass
            TestCoreSubsystem.TestEqual("BindingGetClassFunction", FunctionActor.GetClassValueFunction(),
                FunctionActor.GetClass());

            FunctionActor.SetClassValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("BindingSetClassFunction", FunctionActor.GetClassValueFunction(),
                GetClass());

            var OutClassValue = new TSubclassOf<UObject>(FunctionActor.GetClass());

            FunctionActor.OutClassValueFunction(ref OutClassValue);

            TestCoreSubsystem.TestEqual("BindingOutSetClassFunction", OutClassValue, GetClass());

            // UInterface
            TestCoreSubsystem.TestEqual("BindingGetInterfaceFunction", FunctionActor.GetInterfaceValueFunction(),
                FunctionActor.InterfaceValue);

            FunctionActor.SetInterfaceValueFunction(FunctionActor.InterfaceValue);

            TestCoreSubsystem.TestEqual("BindingSetInterfaceFunction", FunctionActor.GetInterfaceValueFunction(),
                FunctionActor.InterfaceValue);

            var OutInterfaceValue = FunctionActor.InterfaceValue;

            FunctionActor.OutInterfaceValueFunction(ref OutInterfaceValue);

            TestCoreSubsystem.TestEqual("BindingOutSetInterfaceFunction", OutInterfaceValue,
                FunctionActor.InterfaceValue);

            // TSubclassOf
            TestCoreSubsystem.TestEqual("BindingGetSubclassOfFunction", FunctionActor.GetSubclassOfValueFunction(),
                FunctionActor.GetClass());

            FunctionActor.SetSubclassOfValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("BindingSetSubclassOfFunction", FunctionActor.GetSubclassOfValueFunction(),
                GetClass());

            var OutSubclassOfValue = new TSubclassOf<UObject>(FunctionActor.GetClass());

            FunctionActor.OutSubclassOfValueFunction(ref OutSubclassOfValue);

            TestCoreSubsystem.TestEqual("BindingOutSetSubclassOfFunction", OutSubclassOfValue, GetClass());

            // TWeakObjectPtr
            TestCoreSubsystem.TestEqual("BindingGetWeakObjectPtrFunction",
                FunctionActor.GetWeakObjectPtrValueFunction(), FunctionActor);

            FunctionActor.SetWeakObjectPtrValueFunction(this);

            TestCoreSubsystem.TestEqual("BindingSetWeakObjectPtrFunction",
                FunctionActor.GetWeakObjectPtrValueFunction(),
                this);

            var OutWeakObjectPtrValue = new TWeakObjectPtr<UObject>(FunctionActor);

            FunctionActor.OutWeakObjectPtrValueFunction(ref OutWeakObjectPtrValue);

            TestCoreSubsystem.TestEqual("BindingOutSetWeakObjectPtrFunction", OutWeakObjectPtrValue, this);

            // TLazyObjectPtr
            TestCoreSubsystem.TestEqual("BindingGetLazyObjectPtrFunction",
                FunctionActor.GetLazyObjectPtrValueFunction(), FunctionActor);

            FunctionActor.SetLazyObjectPtrValueFunction(this);

            TestCoreSubsystem.TestEqual("BindingSetLazyObjectPtrFunction",
                FunctionActor.GetLazyObjectPtrValueFunction(),
                this);

            var OutLazyObjectPtrValue = new TLazyObjectPtr<UObject>(FunctionActor);

            FunctionActor.OutLazyObjectPtrValueFunction(ref OutLazyObjectPtrValue);

            TestCoreSubsystem.TestEqual("BindingOutSetLazyObjectPtrFunction", OutLazyObjectPtrValue, this);

            // TSoftObjectPtr
            TestCoreSubsystem.TestEqual("BindingGetSoftObjectPtrFunction",
                FunctionActor.GetSoftObjectPtrValueFunction(), FunctionActor);

            FunctionActor.SetSoftObjectPtrValueFunction(this);

            TestCoreSubsystem.TestEqual("BindingSetSoftObjectPtrFunction",
                FunctionActor.GetSoftObjectPtrValueFunction(), this);

            var OutSoftObjectPtrValue = new TSoftObjectPtr<UObject>(FunctionActor);

            FunctionActor.OutSoftObjectPtrValueFunction(ref OutSoftObjectPtrValue);

            TestCoreSubsystem.TestEqual("BindingOutSetSoftObjectPtrFunction", OutSoftObjectPtrValue, this);

            // TSoftClassPtr
            TestCoreSubsystem.TestEqual("BindingGetSoftClassPtrFunction",
                FunctionActor.GetSoftClassPtrValueFunction(), FunctionActor.GetClass());

            FunctionActor.SetSoftClassPtrValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("BindingSetSoftClassPtrFunction",
                FunctionActor.GetSoftClassPtrValueFunction(), GetClass());

            var OutSoftClassPtrValue = new TSoftClassPtr<UObject>(FunctionActor.GetClass());

            FunctionActor.OutSoftClassPtrValueFunction(ref OutSoftClassPtrValue);

            TestCoreSubsystem.TestEqual("BindingOutSetSoftClassPtrFunction", OutSoftClassPtrValue, GetClass());

            // TArray
            TestCoreSubsystem.TestEqual("BindingGetArrayFunction", FunctionActor.GetArrayValueFunction(),
                new TArray<Int32> { 1, 2 });

            FunctionActor.SetArrayValueFunction(new TArray<Int32> { 3, 4 });

            TestCoreSubsystem.TestEqual("BindingSetArrayFunction", FunctionActor.GetArrayValueFunction(),
                new TArray<Int32> { 3, 4 });

            var OutArrayValue = new TArray<Int32> { 1, 2 };

            FunctionActor.OutArrayValueFunction(ref OutArrayValue);

            TestCoreSubsystem.TestEqual("BindingOutSetArrayFunction", OutArrayValue, new TArray<Int32> { 3, 4 });

            // TSet
            TestCoreSubsystem.TestEqual("BindingGetSetFunction", FunctionActor.GetSetValueFunction(),
                new TSet<Int32> { 1, 2 });

            FunctionActor.SetSetValueFunction(new TSet<Int32> { 3, 4 });

            TestCoreSubsystem.TestEqual("BindingSetSetFunction", FunctionActor.GetSetValueFunction(),
                new TSet<Int32> { 3, 4 });

            var OutSetValue = new TSet<Int32> { 1, 2 };

            FunctionActor.OutSetValueFunction(ref OutSetValue);

            TestCoreSubsystem.TestEqual("BindingOutSetSetFunction", OutSetValue, new TSet<Int32> { 3, 4 });

            // TMap
            TestCoreSubsystem.TestEqual("BindingGetMapFunction", FunctionActor.GetMapValueFunction(),
                new TMap<Int32, Int32> { { 1, 1 }, { 2, 2 } });

            FunctionActor.SetMapValueFunction(new TMap<Int32, Int32> { { 3, 3 }, { 4, 4 } });

            TestCoreSubsystem.TestEqual("BindingSetMapFunction", FunctionActor.GetMapValueFunction(),
                new TMap<Int32, Int32> { { 3, 3 }, { 4, 4 } });

            var OutMapValue = new TMap<Int32, Int32> { { 1, 1 }, { 2, 2 } };

            FunctionActor.OutMapValueFunction(ref OutMapValue);

            TestCoreSubsystem.TestEqual("BindingOutSetMapFunction", OutMapValue,
                new TMap<Int32, Int32> { { 3, 3 }, { 4, 4 } });
        }
    }
}