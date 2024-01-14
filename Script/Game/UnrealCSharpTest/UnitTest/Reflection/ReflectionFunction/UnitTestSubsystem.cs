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

            FunctionActor.TestCoreSubsystem = TestCoreSubsystem;

            // Static
            TestCoreSubsystem.TestEqual("ReflectionStaticFunction", ATestReflectionFunctionActor.StaticFunction(),
                true);

            // Bool
            TestCoreSubsystem.TestEqual("ReflectionGetBoolFunction", FunctionActor.GetBoolValueFunction(), true);

            FunctionActor.SetBoolValueFunction(false);

            TestCoreSubsystem.TestEqual("ReflectionSetBoolFunction", FunctionActor.GetBoolValueFunction(), false);

            bool OutBoolValue = true;

            FunctionActor.OutBoolValueFunction(ref OutBoolValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetBoolFunction", OutBoolValue, false);

            // Int8
            TestCoreSubsystem.TestEqual("ReflectionGetInt8Function", FunctionActor.GetInt8ValueFunction(), (sbyte)12);

            FunctionActor.SetInt8ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetInt8Function", FunctionActor.GetInt8ValueFunction(), (sbyte)21);

            sbyte OutInt8Value = 12;

            FunctionActor.OutInt8ValueFunction(ref OutInt8Value);

            TestCoreSubsystem.TestEqual("ReflectionOutSetInt8Function", OutInt8Value, (sbyte)21);

            // Int16
            TestCoreSubsystem.TestEqual("ReflectionGetInt16Function", FunctionActor.GetInt16ValueFunction(), (short)12);

            FunctionActor.SetInt16ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetInt16Function", FunctionActor.GetInt16ValueFunction(), (short)21);

            short OutInt16Value = 12;

            FunctionActor.OutInt16ValueFunction(ref OutInt16Value);

            TestCoreSubsystem.TestEqual("ReflectionOutSetInt16Function", OutInt16Value, (short)21);

            // Int32
            TestCoreSubsystem.TestEqual("ReflectionGetInt32Function", FunctionActor.GetInt32ValueFunction(), (int)12);

            FunctionActor.SetInt32ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetInt32Function", FunctionActor.GetInt32ValueFunction(), (int)21);

            int OutInt32Value = 12;

            FunctionActor.OutInt32ValueFunction(ref OutInt32Value);

            TestCoreSubsystem.TestEqual("ReflectionOutSetInt32Function", OutInt32Value, (int)21);

            // Int64
            TestCoreSubsystem.TestEqual("ReflectionGetInt64Function", FunctionActor.GetInt64ValueFunction(), (long)12);

            FunctionActor.SetInt64ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetInt64Function", FunctionActor.GetInt64ValueFunction(), (long)21);

            long OutInt64Value = 12;

            FunctionActor.OutInt64ValueFunction(ref OutInt64Value);

            TestCoreSubsystem.TestEqual("ReflectionOutSetInt64Function", OutInt64Value, (long)21);

            // UInt8
            TestCoreSubsystem.TestEqual("ReflectionGetUInt8Function", FunctionActor.GetUInt8ValueFunction(), (byte)12);

            FunctionActor.SetUInt8ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetUInt8Function", FunctionActor.GetUInt8ValueFunction(), (byte)21);

            byte OutUInt8Value = 12;

            FunctionActor.OutUInt8ValueFunction(ref OutUInt8Value);

            TestCoreSubsystem.TestEqual("ReflectionOutSetUInt8Function", OutUInt8Value, (byte)21);

            // UInt16
            TestCoreSubsystem.TestEqual("ReflectionGetUInt16Function", FunctionActor.GetUInt16ValueFunction(),
                (ushort)12);

            FunctionActor.SetUInt16ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetUInt16Function", FunctionActor.GetUInt16ValueFunction(),
                (ushort)21);

            ushort OutUInt16Value = 12;

            FunctionActor.OutUInt16ValueFunction(ref OutUInt16Value);

            TestCoreSubsystem.TestEqual("ReflectionOutSetUInt16Function", OutUInt16Value, (ushort)21);

            // UInt32
            TestCoreSubsystem.TestEqual("ReflectionGetUInt32Function", FunctionActor.GetUInt32ValueFunction(),
                (uint)12);

            FunctionActor.SetUInt32ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetUInt32Function", FunctionActor.GetUInt32ValueFunction(),
                (uint)21);

            uint OutUInt32Value = 12;

            FunctionActor.OutUInt32ValueFunction(ref OutUInt32Value);

            TestCoreSubsystem.TestEqual("ReflectionOutSetUInt32Function", OutUInt32Value, (uint)21);

            // UInt64
            TestCoreSubsystem.TestEqual("ReflectionGetUInt64Function", FunctionActor.GetUInt64ValueFunction(),
                (ulong)12);

            FunctionActor.SetUInt64ValueFunction(21);

            TestCoreSubsystem.TestEqual("ReflectionSetUInt64Function", FunctionActor.GetUInt64ValueFunction(),
                (ulong)21);

            ulong OutUInt64Value = 12;

            FunctionActor.OutUInt64ValueFunction(ref OutUInt64Value);

            TestCoreSubsystem.TestEqual("ReflectionOutSetUInt64Function", OutUInt64Value, (ulong)21);

            // Float
            TestCoreSubsystem.TestEqual("ReflectionGetFloatFunction", FunctionActor.GetFloatValueFunction(), 12.3f);

            FunctionActor.SetFloatValueFunction(3.21f);

            TestCoreSubsystem.TestEqual("ReflectionSetFloatFunction", FunctionActor.GetFloatValueFunction(), 3.21f);

            float OutFloatValue = 12.3f;

            FunctionActor.OutFloatValueFunction(ref OutFloatValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetFloatFunction", OutFloatValue, 3.21f);

            // Double
            TestCoreSubsystem.TestEqual("ReflectionGetDoubleFunction", FunctionActor.GetDoubleValueFunction(), 12.3);

            FunctionActor.SetDoubleValueFunction(3.21);

            TestCoreSubsystem.TestEqual("ReflectionSetDoubleFunction", FunctionActor.GetDoubleValueFunction(), 3.21);

            double OutDoubleValue = 12.3;

            FunctionActor.OutDoubleValueFunction(ref OutDoubleValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetDoubleFunction", OutDoubleValue, 3.21);

            // FName
            TestCoreSubsystem.TestEqual("ReflectionGetNameFunction", FunctionActor.GetNameValueFunction(), "Name12");

            FunctionActor.SetNameValueFunction("21emaN");

            TestCoreSubsystem.TestEqual("ReflectionSetNameFunction", FunctionActor.GetNameValueFunction(), "21emaN");

            var OutNameValue = new FName("Name12");

            FunctionActor.OutNameValueFunction(ref OutNameValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetNameFunction", OutNameValue, "21emaN");

            // FText
            TestCoreSubsystem.TestEqual("ReflectionGetTextFunction", FunctionActor.GetTextValueFunction(), "Text12");

            FunctionActor.SetTextValueFunction("21txeT");

            TestCoreSubsystem.TestEqual("ReflectionSetTextFunction", FunctionActor.GetTextValueFunction(), "21txeT");

            var OutTextValue = new FText("Text12");

            FunctionActor.OutTextValueFunction(ref OutTextValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetTextFunction", OutTextValue, "21txeT");

            // FString
            TestCoreSubsystem.TestEqual("ReflectionGetStringFunction", FunctionActor.GetStringValueFunction(),
                "String12");

            FunctionActor.SetStringValueFunction("21gnirtS");

            TestCoreSubsystem.TestEqual("ReflectionSetStringFunction", FunctionActor.GetStringValueFunction(),
                "21gnirtS");

            var OutStringValue = new FString("String12");

            FunctionActor.OutStringValueFunction(ref OutStringValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetStringFunction", OutStringValue, "21gnirtS");

            // Enum
            TestCoreSubsystem.TestEqual("ReflectionGetEnumFunction", FunctionActor.GetEnumValueFunction(),
                ETestEnum.TestEnumOne);

            FunctionActor.SetEnumValueFunction(ETestEnum.TestEnumTwo);

            TestCoreSubsystem.TestEqual("ReflectionSetEnumFunction", FunctionActor.GetEnumValueFunction(),
                ETestEnum.TestEnumTwo);

            var OutEnumValue = ETestEnum.TestEnumOne;

            FunctionActor.OutEnumValueFunction(ref OutEnumValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetEnumFunction", OutEnumValue, ETestEnum.TestEnumTwo);

            // EnumClass
            TestCoreSubsystem.TestEqual("ReflectionGetEnumClassFunction", FunctionActor.GetEnumClassValueFunction(),
                ETestEnumClass.TestEnumClassOne);

            FunctionActor.SetEnumClassValueFunction(ETestEnumClass.TestEnumClassTwo);

            TestCoreSubsystem.TestEqual("ReflectionSetEnumClassFunction", FunctionActor.GetEnumClassValueFunction(),
                ETestEnumClass.TestEnumClassTwo);

            var OutEnumClassValue = ETestEnumClass.TestEnumClassOne;

            FunctionActor.OutEnumClassValueFunction(ref OutEnumClassValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetEnumClassFunction", OutEnumClassValue,
                ETestEnumClass.TestEnumClassTwo);

            // UStruct
            TestCoreSubsystem.TestEqual("ReflectionGetStructFunction", FunctionActor.GetStructValueFunction(),
                new FTestStruct { Value = 1 });

            FunctionActor.SetStructValueFunction(new FTestStruct { Value = 2 });

            TestCoreSubsystem.TestEqual("ReflectionSetStructFunction", FunctionActor.GetStructValueFunction(),
                new FTestStruct { Value = 2 });

            var OutStructValue = new FTestStruct { Value = 1 };

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

            var OutClassValue = new TSubclassOf<UObject>(FunctionActor.GetClass());

            FunctionActor.OutClassValueFunction(ref OutClassValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetClassFunction", OutClassValue, GetClass());

            // UInterface
            TestCoreSubsystem.TestEqual("ReflectionGetInterfaceFunction", FunctionActor.GetInterfaceValueFunction(),
                FunctionActor.InterfaceValue);

            FunctionActor.SetInterfaceValueFunction(FunctionActor.InterfaceValue);

            TestCoreSubsystem.TestEqual("ReflectionSetInterfaceFunction", FunctionActor.GetInterfaceValueFunction(),
                FunctionActor.InterfaceValue);

            var OutInterfaceValue = FunctionActor.InterfaceValue;

            FunctionActor.OutInterfaceValueFunction(ref OutInterfaceValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetInterfaceFunction", OutInterfaceValue,
                FunctionActor.InterfaceValue);

            // TSubclassOf
            TestCoreSubsystem.TestEqual("ReflectionGetSubclassOfFunction", FunctionActor.GetSubclassOfValueFunction(),
                FunctionActor.GetClass());

            FunctionActor.SetSubclassOfValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("ReflectionSetSubclassOfFunction", FunctionActor.GetSubclassOfValueFunction(),
                GetClass());

            var OutSubclassOfValue = new TSubclassOf<UObject>(FunctionActor.GetClass());

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

            var OutSoftObjectPtrValue = new TSoftObjectPtr<UObject>(FunctionActor);

            FunctionActor.OutSoftObjectPtrValueFunction(ref OutSoftObjectPtrValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetSoftObjectPtrFunction", OutSoftObjectPtrValue, this);

            // TSoftClassPtr
            TestCoreSubsystem.TestEqual("ReflectionGetSoftClassPtrFunction",
                FunctionActor.GetSoftClassPtrValueFunction(), FunctionActor.GetClass());

            FunctionActor.SetSoftClassPtrValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("ReflectionSetSoftClassPtrFunction",
                FunctionActor.GetSoftClassPtrValueFunction(), GetClass());

            var OutSoftClassPtrValue = new TSoftClassPtr<UObject>(FunctionActor.GetClass());

            FunctionActor.OutSoftClassPtrValueFunction(ref OutSoftClassPtrValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetSoftClassPtrFunction", OutSoftClassPtrValue, GetClass());

            // TArray
            TestCoreSubsystem.TestEqual("ReflectionGetArrayFunction", FunctionActor.GetArrayValueFunction(),
                new TArray<int> { 1, 2 });

            FunctionActor.SetArrayValueFunction(new TArray<int> { 3, 4 });

            TestCoreSubsystem.TestEqual("ReflectionSetArrayFunction", FunctionActor.GetArrayValueFunction(),
                new TArray<int> { 3, 4 });

            var OutArrayValue = new TArray<int> { 1, 2 };

            FunctionActor.OutArrayValueFunction(ref OutArrayValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetArrayFunction", OutArrayValue, new TArray<int> { 3, 4 });

            // TSet
            TestCoreSubsystem.TestEqual("ReflectionGetSetFunction", FunctionActor.GetSetValueFunction(),
                new TSet<int> { 1, 2 });

            FunctionActor.SetSetValueFunction(new TSet<int> { 3, 4 });

            TestCoreSubsystem.TestEqual("ReflectionSetSetFunction", FunctionActor.GetSetValueFunction(),
                new TSet<int> { 3, 4 });

            var OutSetValue = new TSet<int> { 1, 2 };

            FunctionActor.OutSetValueFunction(ref OutSetValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetSetFunction", OutSetValue, new TSet<int> { 3, 4 });

            // TMap
            TestCoreSubsystem.TestEqual("ReflectionGetMapFunction", FunctionActor.GetMapValueFunction(),
                new TMap<int, int> { { 1, 1 }, { 2, 2 } });

            FunctionActor.SetMapValueFunction(new TMap<int, int> { { 3, 3 }, { 4, 4 } });

            TestCoreSubsystem.TestEqual("ReflectionSetMapFunction", FunctionActor.GetMapValueFunction(),
                new TMap<int, int> { { 3, 3 }, { 4, 4 } });

            var OutMapValue = new TMap<int, int> { { 1, 1 }, { 2, 2 } };

            FunctionActor.OutMapValueFunction(ref OutMapValue);

            TestCoreSubsystem.TestEqual("ReflectionOutSetMapFunction", OutMapValue,
                new TMap<int, int> { { 3, 3 }, { 4, 4 } });
        }
    }
}