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

            // FName
            TestCoreSubsystem.TestEqual("ReflectionGetNameFunction", FunctionActor.GetNameValueFunction(), "Name12");

            FunctionActor.SetNameValueFunction("21emaN");

            TestCoreSubsystem.TestEqual("ReflectionSetNameFunction", FunctionActor.GetNameValueFunction(), "21emaN");

            FunctionActor.OutNameValueFunction(out var OutNameValue);

            TestCoreSubsystem.TestEqual("ReflectionOutNameFunction", OutNameValue, "21emaN");

            // FText
            TestCoreSubsystem.TestEqual("ReflectionGetTextFunction", FunctionActor.GetTextValueFunction(), "Text12");

            FunctionActor.SetTextValueFunction("21txeT");

            TestCoreSubsystem.TestEqual("ReflectionSetTextFunction", FunctionActor.GetTextValueFunction(), "21txeT");

            FunctionActor.OutTextValueFunction(out var OutTextValue);

            TestCoreSubsystem.TestEqual("ReflectionOutTextFunction", OutTextValue, "21txeT");

            // FString
            TestCoreSubsystem.TestEqual("ReflectionGetStringFunction", FunctionActor.GetStringValueFunction(),
                "String12");

            FunctionActor.SetStringValueFunction("21gnirtS");

            TestCoreSubsystem.TestEqual("ReflectionSetStringFunction", FunctionActor.GetStringValueFunction(),
                "21gnirtS");

            FunctionActor.OutStringValueFunction(out var OutStringValue);

            TestCoreSubsystem.TestEqual("ReflectionOutStringFunction", OutStringValue, "21gnirtS");

            // Enum
            TestCoreSubsystem.TestEqual("ReflectionGetEnumFunction", FunctionActor.GetEnumValueFunction(),
                ETestEnum.TestEnumOne);

            FunctionActor.SetEnumValueFunction(ETestEnum.TestEnumTwo);

            TestCoreSubsystem.TestEqual("ReflectionSetEnumFunction", FunctionActor.GetEnumValueFunction(),
                ETestEnum.TestEnumTwo);

            FunctionActor.OutEnumValueFunction(out var OutEnumValue);

            TestCoreSubsystem.TestEqual("ReflectionOutEnumFunction", OutEnumValue, ETestEnum.TestEnumTwo);

            // EnumClass
            TestCoreSubsystem.TestEqual("ReflectionGetEnumClassFunction", FunctionActor.GetEnumClassValueFunction(),
                ETestEnumClass.TestEnumClassOne);

            FunctionActor.SetEnumClassValueFunction(ETestEnumClass.TestEnumClassTwo);

            TestCoreSubsystem.TestEqual("ReflectionSetEnumClassFunction", FunctionActor.GetEnumClassValueFunction(),
                ETestEnumClass.TestEnumClassTwo);

            FunctionActor.OutEnumClassValueFunction(out var OutEnumClassValue);

            TestCoreSubsystem.TestEqual("ReflectionOutEnumClassFunction", OutEnumClassValue,
                ETestEnumClass.TestEnumClassTwo);

            // UStruct
            TestCoreSubsystem.TestEqual("ReflectionGetStructFunction", FunctionActor.GetStructValueFunction(),
                new FTestStruct { Value = 1 });

            FunctionActor.SetStructValueFunction(new FTestStruct { Value = 2 });

            TestCoreSubsystem.TestEqual("ReflectionSetStructFunction", FunctionActor.GetStructValueFunction(),
                new FTestStruct { Value = 2 });

            FunctionActor.OutStructValueFunction(out var OutStructValue);

            TestCoreSubsystem.TestEqual("ReflectionOutStructFunction", OutStructValue, new FTestStruct { Value = 2 });

            // UObject
            TestCoreSubsystem.TestEqual("ReflectionGetObjectFunction", FunctionActor.GetObjectValueFunction(),
                FunctionActor);

            FunctionActor.SetObjectValueFunction(this);

            TestCoreSubsystem.TestEqual("ReflectionSetObjectFunction", FunctionActor.GetObjectValueFunction(), this);

            FunctionActor.OutObjectValueFunction(out var OutObjectValue);

            TestCoreSubsystem.TestEqual("ReflectionOutObjectFunction", OutObjectValue, this);

            // UClass
            TestCoreSubsystem.TestEqual("ReflectionGetClassFunction", FunctionActor.GetClassValueFunction(),
                FunctionActor.GetClass());

            FunctionActor.SetClassValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("ReflectionSetClassFunction", FunctionActor.GetClassValueFunction(),
                GetClass());

            FunctionActor.OutClassValueFunction(out var OutClassValue);

            TestCoreSubsystem.TestEqual("ReflectionOutClassFunction", OutClassValue, GetClass());

            // UInterface
            TestCoreSubsystem.TestEqual("ReflectionGetInterfaceFunction", FunctionActor.GetInterfaceValueFunction(),
                FunctionActor.InterfaceValue);

            FunctionActor.SetInterfaceValueFunction(FunctionActor.InterfaceValue);

            TestCoreSubsystem.TestEqual("ReflectionSetInterfaceFunction", FunctionActor.GetInterfaceValueFunction(),
                FunctionActor.InterfaceValue);

            FunctionActor.OutInterfaceValueFunction(out var OutInterfaceValue);

            TestCoreSubsystem.TestEqual("ReflectionOutInterfaceFunction", OutInterfaceValue,
                FunctionActor.InterfaceValue);

            // TSubclassOf
            TestCoreSubsystem.TestEqual("ReflectionGetSubclassOfFunction", FunctionActor.GetSubclassOfValueFunction(),
                FunctionActor.GetClass());

            FunctionActor.SetSubclassOfValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("ReflectionSetSubclassOfFunction", FunctionActor.GetSubclassOfValueFunction(),
                GetClass());

            FunctionActor.OutSubclassOfValueFunction(out var OutSubclassOfValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSubclassOfFunction", OutSubclassOfValue, GetClass());

            // TWeakObjectPtr
            TestCoreSubsystem.TestEqual("ReflectionGetWeakObjectPtrFunction",
                FunctionActor.GetWeakObjectPtrValueFunction(), FunctionActor);

            // TSoftObjectPtr
            TestCoreSubsystem.TestEqual("ReflectionGetSoftObjectPtrFunction",
                FunctionActor.GetSoftObjectPtrValueFunction(), FunctionActor);

            FunctionActor.SetSoftObjectPtrValueFunction(this);

            TestCoreSubsystem.TestEqual("ReflectionSetSoftObjectPtrFunction",
                FunctionActor.GetSoftObjectPtrValueFunction(), this);

            FunctionActor.OutSoftObjectPtrValueFunction(out var OutSoftObjectPtrValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSoftObjectPtrFunction", OutSoftObjectPtrValue, this);

            // TSoftClassPtr
            TestCoreSubsystem.TestEqual("ReflectionGetSoftClassPtrFunction",
                FunctionActor.GetSoftClassPtrValueFunction(), FunctionActor.GetClass());

            FunctionActor.SetSoftClassPtrValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("ReflectionSetSoftClassPtrFunction",
                FunctionActor.GetSoftClassPtrValueFunction(), GetClass());

            FunctionActor.OutSoftClassPtrValueFunction(out var OutSoftClassPtrValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSoftClassPtrFunction", OutSoftClassPtrValue, GetClass());

            // TArray
            TestCoreSubsystem.TestEqual("ReflectionGetArrayFunction", FunctionActor.GetArrayValueFunction(),
                new TArray<Int32> { 1, 2 });

            FunctionActor.SetArrayValueFunction(new TArray<Int32> { 3, 4 });

            TestCoreSubsystem.TestEqual("ReflectionSetArrayFunction", FunctionActor.GetArrayValueFunction(),
                new TArray<Int32> { 3, 4 });

            FunctionActor.OutArrayValueFunction(out var OutArrayValue);

            TestCoreSubsystem.TestEqual("ReflectionOutArrayFunction", OutArrayValue, new TArray<Int32> { 3, 4 });

            // TSet
            TestCoreSubsystem.TestEqual("ReflectionGetSetFunction", FunctionActor.GetSetValueFunction(),
                new TSet<Int32> { 1, 2 });

            FunctionActor.SetSetValueFunction(new TSet<Int32> { 3, 4 });

            TestCoreSubsystem.TestEqual("ReflectionSetSetFunction", FunctionActor.GetSetValueFunction(),
                new TSet<Int32> { 3, 4 });

            FunctionActor.OutSetValueFunction(out var OutSetValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetFunction", OutSetValue, new TSet<Int32> { 3, 4 });

            // TMap
            TestCoreSubsystem.TestEqual("ReflectionGetMapFunction", FunctionActor.GetMapValueFunction(),
                new TMap<Int32, Int32> { { 1, 1 }, { 2, 2 } });

            FunctionActor.SetMapValueFunction(new TMap<Int32, Int32> { { 3, 3 }, { 4, 4 } });

            TestCoreSubsystem.TestEqual("ReflectionSetMapFunction", FunctionActor.GetMapValueFunction(),
                new TMap<Int32, Int32> { { 3, 3 }, { 4, 4 } });

            FunctionActor.OutMapValueFunction(out var OutMapValue);

            TestCoreSubsystem.TestEqual("ReflectionOutMapFunction", OutMapValue,
                new TMap<Int32, Int32> { { 3, 3 }, { 4, 4 } });
        }
    }
}