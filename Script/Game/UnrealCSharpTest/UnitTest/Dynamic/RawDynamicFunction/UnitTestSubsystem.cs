using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestRawDynamicFunction()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            var FunctionActor = GetWorld().SpawnActor<ATestRawDynamicFunctionActor>(new FTransform());

            FunctionActor.TestCoreSubsystem = TestCoreSubsystem;

            // Bool
            TestCoreSubsystem.TestEqual("RawDynamicGetBoolFunction", FunctionActor.GetBoolValueFunction(), true);

            FunctionActor.SetBoolValueFunction(false);

            TestCoreSubsystem.TestEqual("RawDynamicSetBoolFunction", FunctionActor.GetBoolValueFunction(), false);

            bool OutBoolValue = true;

            FunctionActor.OutBoolValueFunction(ref OutBoolValue);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetBoolFunction", OutBoolValue, false);

            // Int8
            TestCoreSubsystem.TestEqual("RawDynamicGetInt8Function", FunctionActor.GetInt8ValueFunction(), (sbyte)12);

            FunctionActor.SetInt8ValueFunction(21);

            TestCoreSubsystem.TestEqual("RawDynamicSetInt8Function", FunctionActor.GetInt8ValueFunction(), (sbyte)21);

            sbyte OutInt8Value = 12;

            FunctionActor.OutInt8ValueFunction(ref OutInt8Value);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetInt8Function", OutInt8Value, (sbyte)21);

            // Int16
            TestCoreSubsystem.TestEqual("RawDynamicGetInt16Function", FunctionActor.GetInt16ValueFunction(), (short)12);

            FunctionActor.SetInt16ValueFunction(21);

            TestCoreSubsystem.TestEqual("RawDynamicSetInt16Function", FunctionActor.GetInt16ValueFunction(), (short)21);

            short OutInt16Value = 12;

            FunctionActor.OutInt16ValueFunction(ref OutInt16Value);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetInt16Function", OutInt16Value, (short)21);

            // Int32
            TestCoreSubsystem.TestEqual("RawDynamicGetInt32Function", FunctionActor.GetInt32ValueFunction(), (int)12);

            FunctionActor.SetInt32ValueFunction(21);

            TestCoreSubsystem.TestEqual("RawDynamicSetInt32Function", FunctionActor.GetInt32ValueFunction(), (int)21);

            int OutInt32Value = 12;

            FunctionActor.OutInt32ValueFunction(ref OutInt32Value);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetInt32Function", OutInt32Value, (int)21);

            // Int64
            TestCoreSubsystem.TestEqual("RawDynamicGetInt64Function", FunctionActor.GetInt64ValueFunction(), (long)12);

            FunctionActor.SetInt64ValueFunction(21);

            TestCoreSubsystem.TestEqual("RawDynamicSetInt64Function", FunctionActor.GetInt64ValueFunction(), (long)21);

            long OutInt64Value = 12;

            FunctionActor.OutInt64ValueFunction(ref OutInt64Value);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetInt64Function", OutInt64Value, (long)21);

            // UInt8
            TestCoreSubsystem.TestEqual("RawDynamicGetUInt8Function", FunctionActor.GetUInt8ValueFunction(), (byte)12);

            FunctionActor.SetUInt8ValueFunction(21);

            TestCoreSubsystem.TestEqual("RawDynamicSetUInt8Function", FunctionActor.GetUInt8ValueFunction(), (byte)21);

            byte OutUInt8Value = 12;

            FunctionActor.OutUInt8ValueFunction(ref OutUInt8Value);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetUInt8Function", OutUInt8Value, (byte)21);

            // UInt16
            TestCoreSubsystem.TestEqual("RawDynamicGetUInt16Function", FunctionActor.GetUInt16ValueFunction(),
                (ushort)12);

            FunctionActor.SetUInt16ValueFunction(21);

            TestCoreSubsystem.TestEqual("RawDynamicSetUInt16Function", FunctionActor.GetUInt16ValueFunction(),
                (ushort)21);

            ushort OutUInt16Value = 12;

            FunctionActor.OutUInt16ValueFunction(ref OutUInt16Value);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetUInt16Function", OutUInt16Value, (ushort)21);

            // UInt32
            TestCoreSubsystem.TestEqual("RawDynamicGetUInt32Function", FunctionActor.GetUInt32ValueFunction(),
                (uint)12);

            FunctionActor.SetUInt32ValueFunction(21);

            TestCoreSubsystem.TestEqual("RawDynamicSetUInt32Function", FunctionActor.GetUInt32ValueFunction(),
                (uint)21);

            uint OutUInt32Value = 12;

            FunctionActor.OutUInt32ValueFunction(ref OutUInt32Value);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetUInt32Function", OutUInt32Value, (uint)21);

            // UInt64
            TestCoreSubsystem.TestEqual("RawDynamicGetUInt64Function", FunctionActor.GetUInt64ValueFunction(),
                (ulong)12);

            FunctionActor.SetUInt64ValueFunction(21);

            TestCoreSubsystem.TestEqual("RawDynamicSetUInt64Function", FunctionActor.GetUInt64ValueFunction(),
                (ulong)21);

            ulong OutUInt64Value = 12;

            FunctionActor.OutUInt64ValueFunction(ref OutUInt64Value);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetUInt64Function", OutUInt64Value, (ulong)21);

            // Float
            TestCoreSubsystem.TestEqual("RawDynamicGetFloatFunction", FunctionActor.GetFloatValueFunction(), 12.3f);

            FunctionActor.SetFloatValueFunction(3.21f);

            TestCoreSubsystem.TestEqual("RawDynamicSetFloatFunction", FunctionActor.GetFloatValueFunction(), 3.21f);

            float OutFloatValue = 12.3f;

            FunctionActor.OutFloatValueFunction(ref OutFloatValue);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetFloatFunction", OutFloatValue, 3.21f);

            // Double
            TestCoreSubsystem.TestEqual("RawDynamicGetDoubleFunction", FunctionActor.GetDoubleValueFunction(), 12.3);

            FunctionActor.SetDoubleValueFunction(3.21);

            TestCoreSubsystem.TestEqual("RawDynamicSetDoubleFunction", FunctionActor.GetDoubleValueFunction(), 3.21);

            double OutDoubleValue = 12.3;

            FunctionActor.OutDoubleValueFunction(ref OutDoubleValue);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetDoubleFunction", OutDoubleValue, 3.21);

            // FName
            TestCoreSubsystem.TestEqual("RawDynamicGetNameFunction", FunctionActor.GetNameValueFunction(), "Name12");

            FunctionActor.SetNameValueFunction("21emaN");

            TestCoreSubsystem.TestEqual("RawDynamicSetNameFunction", FunctionActor.GetNameValueFunction(), "21emaN");

            var OutNameValue = new FName("Name12");

            FunctionActor.OutNameValueFunction(ref OutNameValue);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetNameFunction", OutNameValue, "21emaN");

            // FText
            TestCoreSubsystem.TestEqual("RawDynamicGetTextFunction", FunctionActor.GetTextValueFunction(), "Text12");

            FunctionActor.SetTextValueFunction("21txeT");

            TestCoreSubsystem.TestEqual("RawDynamicSetTextFunction", FunctionActor.GetTextValueFunction(), "21txeT");

            var OutTextValue = new FText("Text12");

            FunctionActor.OutTextValueFunction(ref OutTextValue);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetTextFunction", OutTextValue, "21txeT");

            // FString
            TestCoreSubsystem.TestEqual("RawDynamicGetStringFunction", FunctionActor.GetStringValueFunction(),
                "String12");

            FunctionActor.SetStringValueFunction("21gnirtS");

            TestCoreSubsystem.TestEqual("RawDynamicSetStringFunction", FunctionActor.GetStringValueFunction(),
                "21gnirtS");

            var OutStringValue = new FString("String12");

            FunctionActor.OutStringValueFunction(ref OutStringValue);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetStringFunction", OutStringValue, "21gnirtS");

            // Enum
            TestCoreSubsystem.TestEqual("RawDynamicGetEnumFunction", FunctionActor.GetEnumValueFunction(),
                ETestDynamicEnum.TestDynamicOne);

            FunctionActor.SetEnumValueFunction(ETestDynamicEnum.TestDynamicTwo);

            TestCoreSubsystem.TestEqual("RawDynamicSetEnumFunction", FunctionActor.GetEnumValueFunction(),
                ETestDynamicEnum.TestDynamicTwo);

            var OutEnumValue = ETestDynamicEnum.TestDynamicOne;

            FunctionActor.OutEnumValueFunction(ref OutEnumValue);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetEnumFunction", OutEnumValue, ETestDynamicEnum.TestDynamicTwo);

            // UStruct
            TestCoreSubsystem.TestEqual("RawDynamicGetStructFunction", FunctionActor.GetStructValueFunction(),
                new FTestDynamicStruct { Value = 1 });

            FunctionActor.SetStructValueFunction(new FTestDynamicStruct { Value = 2 });

            TestCoreSubsystem.TestEqual("RawDynamicSetStructFunction", FunctionActor.GetStructValueFunction(),
                new FTestDynamicStruct { Value = 2 });

            var OutStructValue = new FTestDynamicStruct { Value = 1 };

            FunctionActor.OutStructValueFunction(ref OutStructValue);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetStructFunction", OutStructValue,
                new FTestDynamicStruct { Value = 2 });

            // UObject
            TestCoreSubsystem.TestEqual("RawDynamicGetObjectFunction", FunctionActor.GetObjectValueFunction(),
                FunctionActor);

            FunctionActor.SetObjectValueFunction(this);

            TestCoreSubsystem.TestEqual("RawDynamicSetObjectFunction", FunctionActor.GetObjectValueFunction(), this);

            UObject OutObjectValue = FunctionActor;

            FunctionActor.OutObjectValueFunction(ref OutObjectValue);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetObjectFunction", OutObjectValue, this);

            // UInterface
            TestCoreSubsystem.TestEqual("RawDynamicGetInterfaceFunction", FunctionActor.GetInterfaceValueFunction(),
                FunctionActor.InterfaceValue);

            FunctionActor.SetInterfaceValueFunction(FunctionActor.InterfaceValue);

            TestCoreSubsystem.TestEqual("RawDynamicSetInterfaceFunction", FunctionActor.GetInterfaceValueFunction(),
                FunctionActor.InterfaceValue);

            var OutInterfaceValue = FunctionActor.InterfaceValue;

            FunctionActor.OutInterfaceValueFunction(ref OutInterfaceValue);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetInterfaceFunction", OutInterfaceValue,
                FunctionActor.InterfaceValue);

            // TSubclassOf
            TestCoreSubsystem.TestEqual("RawDynamicGetSubclassOfFunction", FunctionActor.GetSubclassOfValueFunction(),
                FunctionActor.GetClass());

            FunctionActor.SetSubclassOfValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("RawDynamicSetSubclassOfFunction", FunctionActor.GetSubclassOfValueFunction(),
                GetClass());

            var OutSubclassOfValue = new TSubclassOf<UObject>(FunctionActor.GetClass());

            FunctionActor.OutSubclassOfValueFunction(ref OutSubclassOfValue);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetSubclassOfFunction", OutSubclassOfValue, GetClass());

            // TWeakObjectPtr
            TestCoreSubsystem.TestEqual("RawDynamicGetWeakObjectPtrFunction",
                FunctionActor.GetWeakObjectPtrValueFunction(), FunctionActor);

            // TSoftObjectPtr
            TestCoreSubsystem.TestEqual("RawDynamicGetSoftObjectPtrFunction",
                FunctionActor.GetSoftObjectPtrValueFunction(), FunctionActor);

            FunctionActor.SetSoftObjectPtrValueFunction(this);

            TestCoreSubsystem.TestEqual("RawDynamicSetSoftObjectPtrFunction",
                FunctionActor.GetSoftObjectPtrValueFunction(), this);

            var OutSoftObjectPtrValue = new TSoftObjectPtr<UObject>(FunctionActor);

            FunctionActor.OutSoftObjectPtrValueFunction(ref OutSoftObjectPtrValue);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetSoftObjectPtrFunction", OutSoftObjectPtrValue, this);

            // TSoftClassPtr
            TestCoreSubsystem.TestEqual("RawDynamicGetSoftClassPtrFunction",
                FunctionActor.GetSoftClassPtrValueFunction(), FunctionActor.GetClass());

            FunctionActor.SetSoftClassPtrValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("RawDynamicSetSoftClassPtrFunction",
                FunctionActor.GetSoftClassPtrValueFunction(), GetClass());

            var OutSoftClassPtrValue = new TSoftClassPtr<UObject>(FunctionActor.GetClass());

            FunctionActor.OutSoftClassPtrValueFunction(ref OutSoftClassPtrValue);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetSoftClassPtrFunction", OutSoftClassPtrValue, GetClass());

            // TArray
            TestCoreSubsystem.TestEqual("RawDynamicGetArrayFunction", FunctionActor.GetArrayValueFunction(),
                new TArray<int> { 1, 2 });

            FunctionActor.SetArrayValueFunction(new TArray<int> { 3, 4 });

            TestCoreSubsystem.TestEqual("RawDynamicSetArrayFunction", FunctionActor.GetArrayValueFunction(),
                new TArray<int> { 3, 4 });

            var OutArrayValue = new TArray<int> { 1, 2 };

            FunctionActor.OutArrayValueFunction(ref OutArrayValue);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetArrayFunction", OutArrayValue, new TArray<int> { 3, 4 });

            // TSet
            TestCoreSubsystem.TestEqual("RawDynamicGetSetFunction", FunctionActor.GetSetValueFunction(),
                new TSet<int> { 1, 2 });

            FunctionActor.SetSetValueFunction(new TSet<int> { 3, 4 });

            TestCoreSubsystem.TestEqual("RawDynamicSetSetFunction", FunctionActor.GetSetValueFunction(),
                new TSet<int> { 3, 4 });

            var OutSetValue = new TSet<int> { 1, 2 };

            FunctionActor.OutSetValueFunction(ref OutSetValue);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetSetFunction", OutSetValue, new TSet<int> { 3, 4 });

            // TMap
            TestCoreSubsystem.TestEqual("RawDynamicGetMapFunction", FunctionActor.GetMapValueFunction(),
                new TMap<int, int> { { 1, 1 }, { 2, 2 } });

            FunctionActor.SetMapValueFunction(new TMap<int, int> { { 3, 3 }, { 4, 4 } });

            TestCoreSubsystem.TestEqual("RawDynamicSetMapFunction", FunctionActor.GetMapValueFunction(),
                new TMap<int, int> { { 3, 3 }, { 4, 4 } });

            var OutMapValue = new TMap<int, int> { { 1, 1 }, { 2, 2 } };

            FunctionActor.OutMapValueFunction(ref OutMapValue);

            TestCoreSubsystem.TestEqual("RawDynamicOutSetMapFunction", OutMapValue,
                new TMap<int, int> { { 3, 3 }, { 4, 4 } });
        }
    }
}