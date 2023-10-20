using System;
using Script.Common;
using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestReflectionFunction()
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

            Boolean OutBoolValue = true;

            FunctionActor.OutBoolValueFunction(ref OutBoolValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetBoolFunction", OutBoolValue, false);

            // Int8
            TestCoreSubsystem.TestEqual("ReflectionGetInt8Function", FunctionActor.GetInt8ValueFunction(), (SByte)12);

            FunctionActor.SetInt8ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetInt8Function", FunctionActor.GetInt8ValueFunction(), (SByte)21);

            SByte OutInt8Value = 12;

            FunctionActor.OutInt8ValueFunction(ref OutInt8Value);

            TestCoreSubsystem.TestEqual("ReflectionOutSetInt8Function", OutInt8Value, (SByte)21);

            // Int16
            TestCoreSubsystem.TestEqual("ReflectionGetInt16Function", FunctionActor.GetInt16ValueFunction(), (Int16)12);

            FunctionActor.SetInt16ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetInt16Function", FunctionActor.GetInt16ValueFunction(), (Int16)21);

            Int16 OutInt16Value = 12;

            FunctionActor.OutInt16ValueFunction(ref OutInt16Value);

            TestCoreSubsystem.TestEqual("ReflectionOutSetInt16Function", OutInt16Value, (Int16)21);

            // Int32
            TestCoreSubsystem.TestEqual("ReflectionGetInt32Function", FunctionActor.GetInt32ValueFunction(), (Int32)12);

            FunctionActor.SetInt32ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetInt32Function", FunctionActor.GetInt32ValueFunction(), (Int32)21);

            Int32 OutInt32Value = 12;

            FunctionActor.OutInt32ValueFunction(ref OutInt32Value);

            TestCoreSubsystem.TestEqual("ReflectionOutSetInt32Function", OutInt32Value, (Int32)21);

            // Int64
            TestCoreSubsystem.TestEqual("ReflectionGetInt64Function", FunctionActor.GetInt64ValueFunction(), (Int64)12);

            FunctionActor.SetInt64ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetInt64Function", FunctionActor.GetInt64ValueFunction(), (Int64)21);

            Int64 OutInt64Value = 12;

            FunctionActor.OutInt64ValueFunction(ref OutInt64Value);

            TestCoreSubsystem.TestEqual("ReflectionOutSetInt64Function", OutInt64Value, (Int64)21);

            // UInt8
            TestCoreSubsystem.TestEqual("ReflectionGetUInt8Function", FunctionActor.GetUInt8ValueFunction(), (Byte)12);

            FunctionActor.SetUInt8ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetUInt8Function", FunctionActor.GetUInt8ValueFunction(), (Byte)21);

            Byte OutUInt8Value = 12;

            FunctionActor.OutUInt8ValueFunction(ref OutUInt8Value);

            TestCoreSubsystem.TestEqual("ReflectionOutSetUInt8Function", OutUInt8Value, (Byte)21);

            // UInt16
            TestCoreSubsystem.TestEqual("ReflectionGetUInt16Function", FunctionActor.GetUInt16ValueFunction(),
                (UInt16)12);

            FunctionActor.SetUInt16ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetUInt16Function", FunctionActor.GetUInt16ValueFunction(),
                (UInt16)21);

            UInt16 OutUInt16Value = 12;

            FunctionActor.OutUInt16ValueFunction(ref OutUInt16Value);

            TestCoreSubsystem.TestEqual("ReflectionOutSetUInt16Function", OutUInt16Value, (UInt16)21);

            // UInt32
            TestCoreSubsystem.TestEqual("ReflectionGetUInt32Function", FunctionActor.GetUInt32ValueFunction(),
                (UInt32)12);

            FunctionActor.SetUInt32ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetUInt32Function", FunctionActor.GetUInt32ValueFunction(),
                (UInt32)21);

            UInt32 OutUInt32Value = 12;

            FunctionActor.OutUInt32ValueFunction(ref OutUInt32Value);

            TestCoreSubsystem.TestEqual("ReflectionOutSetUInt32Function", OutUInt32Value, (UInt32)21);

            // UInt64
            TestCoreSubsystem.TestEqual("ReflectionGetUInt64Function", FunctionActor.GetUInt64ValueFunction(),
                (UInt64)12);

            FunctionActor.SetUInt64ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetUInt64Function", FunctionActor.GetUInt64ValueFunction(),
                (UInt64)21);

            UInt64 OutUInt64Value = 12;

            FunctionActor.OutUInt64ValueFunction(ref OutUInt64Value);

            TestCoreSubsystem.TestEqual("ReflectionOutSetUInt64Function", OutUInt64Value, (UInt64)21);

            // Float
            TestCoreSubsystem.TestEqual("ReflectionGetFloatFunction", FunctionActor.GetFloatValueFunction(), 12.3f);

            FunctionActor.SetFloatValueFunction(3.21f);

            TestCoreSubsystem.TestEqual("ReflectionSetFloatFunction", FunctionActor.GetFloatValueFunction(), 3.21f);

            Single OutFloatValue = 12.3f;

            FunctionActor.OutFloatValueFunction(ref OutFloatValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetFloatFunction", OutFloatValue, 3.21f);

            // Double
            TestCoreSubsystem.TestEqual("ReflectionGetDoubleFunction", FunctionActor.GetDoubleValueFunction(), 12.3);

            FunctionActor.SetDoubleValueFunction(3.21);

            TestCoreSubsystem.TestEqual("ReflectionSetDoubleFunction", FunctionActor.GetDoubleValueFunction(), 3.21);

            Double OutDoubleValue = 12.3;

            FunctionActor.OutDoubleValueFunction(ref OutDoubleValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetDoubleFunction", OutDoubleValue, 3.21);

            // FName
            TestCoreSubsystem.TestEqual("ReflectionGetNameFunction", FunctionActor.GetNameValueFunction(), "Name12");

            FunctionActor.SetNameValueFunction("21emaN");

            TestCoreSubsystem.TestEqual("ReflectionSetNameFunction", FunctionActor.GetNameValueFunction(), "21emaN");

            FName OutNameValue = new FName("Name12");

            FunctionActor.OutNameValueFunction(ref OutNameValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetNameFunction", OutNameValue, "21emaN");

            // FText
            TestCoreSubsystem.TestEqual("ReflectionGetTextFunction", FunctionActor.GetTextValueFunction(), "Text12");

            FunctionActor.SetTextValueFunction("21txeT");

            TestCoreSubsystem.TestEqual("ReflectionSetTextFunction", FunctionActor.GetTextValueFunction(), "21txeT");

            FText OutTextValue = new FText("Text12");

            FunctionActor.OutTextValueFunction(ref OutTextValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetTextFunction", OutTextValue, "21txeT");

            // FString
            TestCoreSubsystem.TestEqual("ReflectionGetStringFunction", FunctionActor.GetStringValueFunction(),
                "String12");

            FunctionActor.SetStringValueFunction("21gnirtS");

            TestCoreSubsystem.TestEqual("ReflectionSetStringFunction", FunctionActor.GetStringValueFunction(),
                "21gnirtS");

            FString OutStringValue = new FString("String12");

            FunctionActor.OutStringValueFunction(ref OutStringValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetStringFunction", OutStringValue, "21gnirtS");

            // Enum
            TestCoreSubsystem.TestEqual("ReflectionGetEnumFunction", FunctionActor.GetEnumValueFunction(),
                ETestEnum.TestEnumOne);

            FunctionActor.SetEnumValueFunction(ETestEnum.TestEnumTwo);

            TestCoreSubsystem.TestEqual("ReflectionSetEnumFunction", FunctionActor.GetEnumValueFunction(),
                ETestEnum.TestEnumTwo);

            ETestEnum OutEnumValue = ETestEnum.TestEnumOne;

            FunctionActor.OutEnumValueFunction(ref OutEnumValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetEnumFunction", OutEnumValue, ETestEnum.TestEnumTwo);

            // EnumClass
            TestCoreSubsystem.TestEqual("ReflectionGetEnumClassFunction", FunctionActor.GetEnumClassValueFunction(),
                ETestEnumClass.TestEnumClassOne);

            FunctionActor.SetEnumClassValueFunction(ETestEnumClass.TestEnumClassTwo);

            TestCoreSubsystem.TestEqual("ReflectionSetEnumClassFunction", FunctionActor.GetEnumClassValueFunction(),
                ETestEnumClass.TestEnumClassTwo);

            ETestEnumClass OutEnumClassValue = ETestEnumClass.TestEnumClassOne;

            FunctionActor.OutEnumClassValueFunction(ref OutEnumClassValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetEnumClassFunction", OutEnumClassValue,
                ETestEnumClass.TestEnumClassTwo);

            // UStruct
            TestCoreSubsystem.TestEqual("ReflectionGetStructFunction", FunctionActor.GetStructValueFunction(),
                new FTestStruct { Value = 1 });

            FunctionActor.SetStructValueFunction(new FTestStruct { Value = 2 });

            TestCoreSubsystem.TestEqual("ReflectionSetStructFunction", FunctionActor.GetStructValueFunction(),
                new FTestStruct { Value = 2 });

            FTestStruct OutStructValue = new FTestStruct { Value = 1 };

            FunctionActor.OutStructValueFunction(ref OutStructValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetStructFunction", OutStructValue,
                new FTestStruct { Value = 2 });

            // UObject
            TestCoreSubsystem.TestEqual("ReflectionGetObjectFunction", FunctionActor.GetObjectValueFunction(),
                FunctionActor);

            FunctionActor.SetObjectValueFunction(this);

            TestCoreSubsystem.TestEqual("ReflectionSetObjectFunction", FunctionActor.GetObjectValueFunction(), this);

            UObject OutObjectValue = FunctionActor;

            FunctionActor.OutObjectValueFunction(ref OutObjectValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetObjectFunction", OutObjectValue, this);

            // UClass
            TestCoreSubsystem.TestEqual("ReflectionGetClassFunction", FunctionActor.GetClassValueFunction(),
                FunctionActor.GetClass());

            FunctionActor.SetClassValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("ReflectionSetClassFunction", FunctionActor.GetClassValueFunction(),
                GetClass());

            TSubclassOf<UObject> OutClassValue = new TSubclassOf<UObject>(FunctionActor.GetClass());

            FunctionActor.OutClassValueFunction(ref OutClassValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetClassFunction", OutClassValue, GetClass());

            // UInterface
            TestCoreSubsystem.TestEqual("ReflectionGetInterfaceFunction", FunctionActor.GetInterfaceValueFunction(),
                FunctionActor.InterfaceValue);

            FunctionActor.SetInterfaceValueFunction(FunctionActor.InterfaceValue);

            TestCoreSubsystem.TestEqual("ReflectionSetInterfaceFunction", FunctionActor.GetInterfaceValueFunction(),
                FunctionActor.InterfaceValue);

            TScriptInterface<ITestInterface> OutInterfaceValue = FunctionActor.InterfaceValue;

            FunctionActor.OutInterfaceValueFunction(ref OutInterfaceValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetInterfaceFunction", OutInterfaceValue,
                FunctionActor.InterfaceValue);

            // TSubclassOf
            TestCoreSubsystem.TestEqual("ReflectionGetSubclassOfFunction", FunctionActor.GetSubclassOfValueFunction(),
                FunctionActor.GetClass());

            FunctionActor.SetSubclassOfValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("ReflectionSetSubclassOfFunction", FunctionActor.GetSubclassOfValueFunction(),
                GetClass());

            TSubclassOf<UObject> OutSubclassOfValue = new TSubclassOf<UObject>(FunctionActor.GetClass());

            FunctionActor.OutSubclassOfValueFunction(ref OutSubclassOfValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetSubclassOfFunction", OutSubclassOfValue, GetClass());

            // TWeakObjectPtr
            TestCoreSubsystem.TestEqual("ReflectionGetWeakObjectPtrFunction",
                FunctionActor.GetWeakObjectPtrValueFunction(), FunctionActor);

            // TSoftObjectPtr
            TestCoreSubsystem.TestEqual("ReflectionGetSoftObjectPtrFunction",
                FunctionActor.GetSoftObjectPtrValueFunction(), FunctionActor);

            FunctionActor.SetSoftObjectPtrValueFunction(this);

            TestCoreSubsystem.TestEqual("ReflectionSetSoftObjectPtrFunction",
                FunctionActor.GetSoftObjectPtrValueFunction(), this);

            TSoftObjectPtr<UObject> OutSoftObjectPtrValue = new TSoftObjectPtr<UObject>(FunctionActor);

            FunctionActor.OutSoftObjectPtrValueFunction(ref OutSoftObjectPtrValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetSoftObjectPtrFunction", OutSoftObjectPtrValue, this);

            // TSoftClassPtr
            TestCoreSubsystem.TestEqual("ReflectionGetSoftClassPtrFunction",
                FunctionActor.GetSoftClassPtrValueFunction(), FunctionActor.GetClass());

            FunctionActor.SetSoftClassPtrValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("ReflectionSetSoftClassPtrFunction",
                FunctionActor.GetSoftClassPtrValueFunction(), GetClass());

            TSoftClassPtr<UObject> OutSoftClassPtrValue = new TSoftClassPtr<UObject>(FunctionActor.GetClass());

            FunctionActor.OutSoftClassPtrValueFunction(ref OutSoftClassPtrValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetSoftClassPtrFunction", OutSoftClassPtrValue, GetClass());

            // TArray
            TestCoreSubsystem.TestEqual("ReflectionGetArrayFunction", FunctionActor.GetArrayValueFunction(),
                new TArray<Int32> { 1, 2 });

            FunctionActor.SetArrayValueFunction(new TArray<Int32> { 3, 4 });

            TestCoreSubsystem.TestEqual("ReflectionSetArrayFunction", FunctionActor.GetArrayValueFunction(),
                new TArray<Int32> { 3, 4 });

            TArray<Int32> OutArrayValue = new TArray<Int32> { 1, 2 };

            FunctionActor.OutArrayValueFunction(ref OutArrayValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetArrayFunction", OutArrayValue, new TArray<Int32> { 3, 4 });

            // TSet
            TestCoreSubsystem.TestEqual("ReflectionGetSetFunction", FunctionActor.GetSetValueFunction(),
                new TSet<Int32> { 1, 2 });

            FunctionActor.SetSetValueFunction(new TSet<Int32> { 3, 4 });

            TestCoreSubsystem.TestEqual("ReflectionSetSetFunction", FunctionActor.GetSetValueFunction(),
                new TSet<Int32> { 3, 4 });

            TSet<Int32> OutSetValue = new TSet<Int32> { 1, 2 };

            FunctionActor.OutSetValueFunction(ref OutSetValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetSetFunction", OutSetValue, new TSet<Int32> { 3, 4 });

            // TMap
            TestCoreSubsystem.TestEqual("ReflectionGetMapFunction", FunctionActor.GetMapValueFunction(),
                new TMap<Int32, Int32> { { 1, 1 }, { 2, 2 } });

            FunctionActor.SetMapValueFunction(new TMap<Int32, Int32> { { 3, 3 }, { 4, 4 } });

            TestCoreSubsystem.TestEqual("ReflectionSetMapFunction", FunctionActor.GetMapValueFunction(),
                new TMap<Int32, Int32> { { 3, 3 }, { 4, 4 } });

            TMap<Int32, Int32> OutMapValue = new TMap<Int32, Int32> { { 1, 1 }, { 2, 2 } };

            FunctionActor.OutMapValueFunction(ref OutMapValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetMapFunction", OutMapValue,
                new TMap<Int32, Int32> { { 3, 3 }, { 4, 4 } });
        }
    }
}