using Script.Common;
using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestDynamicFunction()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            var FunctionActor = GetWorld().SpawnActor<ATestDynamicFunctionActor>(new FTransform());

            FunctionActor.TestCoreSubsystem = TestCoreSubsystem;

            // Static
            TestCoreSubsystem.TestEqual("DynamicStaticFunction", ATestDynamicFunctionActor.StaticFunction(),
                true);

            // Bool
            TestCoreSubsystem.TestEqual("DynamicGetBoolFunction", FunctionActor.GetBoolValueFunction(), true);

            FunctionActor.SetBoolValueFunction(false);

            TestCoreSubsystem.TestEqual("DynamicSetBoolFunction", FunctionActor.GetBoolValueFunction(), false);

            bool OutBoolValue = true;

            FunctionActor.OutBoolValueFunction(ref OutBoolValue);

            TestCoreSubsystem.TestEqual("DynamicOutSetBoolFunction", OutBoolValue, false);

            // Int8
            TestCoreSubsystem.TestEqual("DynamicGetInt8Function", FunctionActor.GetInt8ValueFunction(), (sbyte)12);

            FunctionActor.SetInt8ValueFunction(21);

            TestCoreSubsystem.TestEqual("DynamicSetInt8Function", FunctionActor.GetInt8ValueFunction(), (sbyte)21);

            sbyte OutInt8Value = 12;

            FunctionActor.OutInt8ValueFunction(ref OutInt8Value);

            TestCoreSubsystem.TestEqual("DynamicOutSetInt8Function", OutInt8Value, (sbyte)21);

            // Int16
            TestCoreSubsystem.TestEqual("DynamicGetInt16Function", FunctionActor.GetInt16ValueFunction(), (short)12);

            FunctionActor.SetInt16ValueFunction(21);

            TestCoreSubsystem.TestEqual("DynamicSetInt16Function", FunctionActor.GetInt16ValueFunction(), (short)21);

            short OutInt16Value = 12;

            FunctionActor.OutInt16ValueFunction(ref OutInt16Value);

            TestCoreSubsystem.TestEqual("DynamicOutSetInt16Function", OutInt16Value, (short)21);

            // Int32
            TestCoreSubsystem.TestEqual("DynamicGetInt32Function", FunctionActor.GetInt32ValueFunction(), (int)12);

            FunctionActor.SetInt32ValueFunction(21);

            TestCoreSubsystem.TestEqual("DynamicSetInt32Function", FunctionActor.GetInt32ValueFunction(), (int)21);

            int OutInt32Value = 12;

            FunctionActor.OutInt32ValueFunction(ref OutInt32Value);

            TestCoreSubsystem.TestEqual("DynamicOutSetInt32Function", OutInt32Value, (int)21);

            // Int64
            TestCoreSubsystem.TestEqual("DynamicGetInt64Function", FunctionActor.GetInt64ValueFunction(), (long)12);

            FunctionActor.SetInt64ValueFunction(21);

            TestCoreSubsystem.TestEqual("DynamicSetInt64Function", FunctionActor.GetInt64ValueFunction(), (long)21);

            long OutInt64Value = 12;

            FunctionActor.OutInt64ValueFunction(ref OutInt64Value);

            TestCoreSubsystem.TestEqual("DynamicOutSetInt64Function", OutInt64Value, (long)21);

            // UInt8
            TestCoreSubsystem.TestEqual("DynamicGetUInt8Function", FunctionActor.GetUInt8ValueFunction(), (byte)12);

            FunctionActor.SetUInt8ValueFunction(21);

            TestCoreSubsystem.TestEqual("DynamicSetUInt8Function", FunctionActor.GetUInt8ValueFunction(), (byte)21);

            byte OutUInt8Value = 12;

            FunctionActor.OutUInt8ValueFunction(ref OutUInt8Value);

            TestCoreSubsystem.TestEqual("DynamicOutSetUInt8Function", OutUInt8Value, (byte)21);

            // UInt16
            TestCoreSubsystem.TestEqual("DynamicGetUInt16Function", FunctionActor.GetUInt16ValueFunction(),
                (ushort)12);

            FunctionActor.SetUInt16ValueFunction(21);

            TestCoreSubsystem.TestEqual("DynamicSetUInt16Function", FunctionActor.GetUInt16ValueFunction(),
                (ushort)21);

            ushort OutUInt16Value = 12;

            FunctionActor.OutUInt16ValueFunction(ref OutUInt16Value);

            TestCoreSubsystem.TestEqual("DynamicOutSetUInt16Function", OutUInt16Value, (ushort)21);

            // UInt32
            TestCoreSubsystem.TestEqual("DynamicGetUInt32Function", FunctionActor.GetUInt32ValueFunction(),
                (uint)12);

            FunctionActor.SetUInt32ValueFunction(21);

            TestCoreSubsystem.TestEqual("DynamicSetUInt32Function", FunctionActor.GetUInt32ValueFunction(),
                (uint)21);

            uint OutUInt32Value = 12;

            FunctionActor.OutUInt32ValueFunction(ref OutUInt32Value);

            TestCoreSubsystem.TestEqual("DynamicOutSetUInt32Function", OutUInt32Value, (uint)21);

            // UInt64
            TestCoreSubsystem.TestEqual("DynamicGetUInt64Function", FunctionActor.GetUInt64ValueFunction(),
                (ulong)12);

            FunctionActor.SetUInt64ValueFunction(21);

            TestCoreSubsystem.TestEqual("DynamicSetUInt64Function", FunctionActor.GetUInt64ValueFunction(),
                (ulong)21);

            ulong OutUInt64Value = 12;

            FunctionActor.OutUInt64ValueFunction(ref OutUInt64Value);

            TestCoreSubsystem.TestEqual("DynamicOutSetUInt64Function", OutUInt64Value, (ulong)21);

            // Float
            TestCoreSubsystem.TestEqual("DynamicGetFloatFunction", FunctionActor.GetFloatValueFunction(), 12.3f);

            FunctionActor.SetFloatValueFunction(3.21f);

            TestCoreSubsystem.TestEqual("DynamicSetFloatFunction", FunctionActor.GetFloatValueFunction(), 3.21f);

            float OutFloatValue = 12.3f;

            FunctionActor.OutFloatValueFunction(ref OutFloatValue);

            TestCoreSubsystem.TestEqual("DynamicOutSetFloatFunction", OutFloatValue, 3.21f);

            // Double
            TestCoreSubsystem.TestEqual("DynamicGetDoubleFunction", FunctionActor.GetDoubleValueFunction(), 12.3);

            FunctionActor.SetDoubleValueFunction(3.21);

            TestCoreSubsystem.TestEqual("DynamicSetDoubleFunction", FunctionActor.GetDoubleValueFunction(), 3.21);

            double OutDoubleValue = 12.3;

            FunctionActor.OutDoubleValueFunction(ref OutDoubleValue);

            TestCoreSubsystem.TestEqual("DynamicOutSetDoubleFunction", OutDoubleValue, 3.21);

            // FName
            TestCoreSubsystem.TestEqual("DynamicGetNameFunction", FunctionActor.GetNameValueFunction(), "Name12");

            FunctionActor.SetNameValueFunction("21emaN");

            TestCoreSubsystem.TestEqual("DynamicSetNameFunction", FunctionActor.GetNameValueFunction(), "21emaN");

            var OutNameValue = new FName("Name12");

            FunctionActor.OutNameValueFunction(ref OutNameValue);

            TestCoreSubsystem.TestEqual("DynamicOutSetNameFunction", OutNameValue, "21emaN");

            // FText
            TestCoreSubsystem.TestEqual("DynamicGetTextFunction", FunctionActor.GetTextValueFunction(), "Text12");

            FunctionActor.SetTextValueFunction("21txeT");

            TestCoreSubsystem.TestEqual("DynamicSetTextFunction", FunctionActor.GetTextValueFunction(), "21txeT");

            var OutTextValue = new FText("Text12");

            FunctionActor.OutTextValueFunction(ref OutTextValue);

            TestCoreSubsystem.TestEqual("DynamicOutSetTextFunction", OutTextValue, "21txeT");

            // FString
            TestCoreSubsystem.TestEqual("DynamicGetStringFunction", FunctionActor.GetStringValueFunction(),
                "String12");

            FunctionActor.SetStringValueFunction("21gnirtS");

            TestCoreSubsystem.TestEqual("DynamicSetStringFunction", FunctionActor.GetStringValueFunction(),
                "21gnirtS");

            var OutStringValue = new FString("String12");

            FunctionActor.OutStringValueFunction(ref OutStringValue);

            TestCoreSubsystem.TestEqual("DynamicOutSetStringFunction", OutStringValue, "21gnirtS");

            // Enum
            TestCoreSubsystem.TestEqual("DynamicGetEnumFunction", FunctionActor.GetEnumValueFunction(),
                ETestDynamicEnum.TestDynamicOne);

            FunctionActor.SetEnumValueFunction(ETestDynamicEnum.TestDynamicTwo);

            TestCoreSubsystem.TestEqual("DynamicSetEnumFunction", FunctionActor.GetEnumValueFunction(),
                ETestDynamicEnum.TestDynamicTwo);

            var OutEnumValue = ETestDynamicEnum.TestDynamicOne;

            FunctionActor.OutEnumValueFunction(ref OutEnumValue);

            TestCoreSubsystem.TestEqual("DynamicOutSetEnumFunction", OutEnumValue, ETestDynamicEnum.TestDynamicTwo);

            // UStruct
            TestCoreSubsystem.TestEqual("DynamicGetStructFunction", FunctionActor.GetStructValueFunction(),
                new FTestDynamicStruct { Value = 1 });

            FunctionActor.SetStructValueFunction(new FTestDynamicStruct { Value = 2 });

            TestCoreSubsystem.TestEqual("DynamicSetStructFunction", FunctionActor.GetStructValueFunction(),
                new FTestDynamicStruct { Value = 2 });

            var OutStructValue = new FTestDynamicStruct { Value = 1 };

            FunctionActor.OutStructValueFunction(ref OutStructValue);

            TestCoreSubsystem.TestEqual("DynamicOutSetStructFunction", OutStructValue,
                new FTestDynamicStruct { Value = 2 });

            // UObject
            TestCoreSubsystem.TestEqual("DynamicGetObjectFunction", FunctionActor.GetObjectValueFunction(),
                FunctionActor);

            FunctionActor.SetObjectValueFunction(this);

            TestCoreSubsystem.TestEqual("DynamicSetObjectFunction", FunctionActor.GetObjectValueFunction(), this);

            UObject OutObjectValue = FunctionActor;

            FunctionActor.OutObjectValueFunction(ref OutObjectValue);

            TestCoreSubsystem.TestEqual("DynamicOutSetObjectFunction", OutObjectValue, this);

            // TSubclassOf
            TestCoreSubsystem.TestEqual("DynamicGetSubclassOfFunction", FunctionActor.GetSubclassOfValueFunction(),
                FunctionActor.GetClass());

            FunctionActor.SetSubclassOfValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("DynamicSetSubclassOfFunction", FunctionActor.GetSubclassOfValueFunction(),
                GetClass());

            var OutSubclassOfValue = new TSubclassOf<UObject>(FunctionActor.GetClass());

            FunctionActor.OutSubclassOfValueFunction(ref OutSubclassOfValue);

            TestCoreSubsystem.TestEqual("DynamicOutSetSubclassOfFunction", OutSubclassOfValue, GetClass());

            // TWeakObjectPtr
            TestCoreSubsystem.TestEqual("DynamicGetWeakObjectPtrFunction",
                FunctionActor.GetWeakObjectPtrValueFunction(), FunctionActor);

            // TSoftObjectPtr
            TestCoreSubsystem.TestEqual("DynamicGetSoftObjectPtrFunction",
                FunctionActor.GetSoftObjectPtrValueFunction(), FunctionActor);

            FunctionActor.SetSoftObjectPtrValueFunction(this);

            TestCoreSubsystem.TestEqual("DynamicSetSoftObjectPtrFunction",
                FunctionActor.GetSoftObjectPtrValueFunction(), this);

            var OutSoftObjectPtrValue = new TSoftObjectPtr<UObject>(FunctionActor);

            FunctionActor.OutSoftObjectPtrValueFunction(ref OutSoftObjectPtrValue);

            TestCoreSubsystem.TestEqual("DynamicOutSetSoftObjectPtrFunction", OutSoftObjectPtrValue, this);

            // TSoftClassPtr
            TestCoreSubsystem.TestEqual("DynamicGetSoftClassPtrFunction",
                FunctionActor.GetSoftClassPtrValueFunction(), FunctionActor.GetClass());

            FunctionActor.SetSoftClassPtrValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("DynamicSetSoftClassPtrFunction",
                FunctionActor.GetSoftClassPtrValueFunction(), GetClass());

            var OutSoftClassPtrValue = new TSoftClassPtr<UObject>(FunctionActor.GetClass());

            FunctionActor.OutSoftClassPtrValueFunction(ref OutSoftClassPtrValue);

            TestCoreSubsystem.TestEqual("DynamicOutSetSoftClassPtrFunction", OutSoftClassPtrValue, GetClass());

            // TArray
            TestCoreSubsystem.TestEqual("DynamicGetArrayFunction", FunctionActor.GetArrayValueFunction(),
                new TArray<int> { 1, 2 });

            FunctionActor.SetArrayValueFunction(new TArray<int> { 3, 4 });

            TestCoreSubsystem.TestEqual("DynamicSetArrayFunction", FunctionActor.GetArrayValueFunction(),
                new TArray<int> { 3, 4 });

            var OutArrayValue = new TArray<int> { 1, 2 };

            FunctionActor.OutArrayValueFunction(ref OutArrayValue);

            TestCoreSubsystem.TestEqual("DynamicOutSetArrayFunction", OutArrayValue, new TArray<int> { 3, 4 });

            // TSet
            TestCoreSubsystem.TestEqual("DynamicGetSetFunction", FunctionActor.GetSetValueFunction(),
                new TSet<int> { 1, 2 });

            FunctionActor.SetSetValueFunction(new TSet<int> { 3, 4 });

            TestCoreSubsystem.TestEqual("DynamicSetSetFunction", FunctionActor.GetSetValueFunction(),
                new TSet<int> { 3, 4 });

            var OutSetValue = new TSet<int> { 1, 2 };

            FunctionActor.OutSetValueFunction(ref OutSetValue);

            TestCoreSubsystem.TestEqual("DynamicOutSetSetFunction", OutSetValue, new TSet<int> { 3, 4 });

            // TMap
            TestCoreSubsystem.TestEqual("DynamicGetMapFunction", FunctionActor.GetMapValueFunction(),
                new TMap<int, int> { { 1, 1 }, { 2, 2 } });

            FunctionActor.SetMapValueFunction(new TMap<int, int> { { 3, 3 }, { 4, 4 } });

            TestCoreSubsystem.TestEqual("DynamicSetMapFunction", FunctionActor.GetMapValueFunction(),
                new TMap<int, int> { { 3, 3 }, { 4, 4 } });

            var OutMapValue = new TMap<int, int> { { 1, 1 }, { 2, 2 } };

            FunctionActor.OutMapValueFunction(ref OutMapValue);

            TestCoreSubsystem.TestEqual("DynamicOutSetMapFunction", OutMapValue,
                new TMap<int, int> { { 3, 3 }, { 4, 4 } });
        }
    }
}