using Script.Common;
using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestBlueprintDynamicFunction()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            var FunctionActor = GetWorld().SpawnActor<CSharp_TestBlueprintDynamicFunctionActor_C>(new FTransform());

            FunctionActor.TestCoreSubsystem = TestCoreSubsystem;

            // Bool
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetBoolFunction", FunctionActor.GetBoolValueFunction(), true);

            FunctionActor.SetBoolValueFunction(false);

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetBoolFunction", FunctionActor.GetBoolValueFunction(), false);

            bool OutBoolValue = true;

            FunctionActor.OutBoolValueFunction(ref OutBoolValue);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetBoolFunction", OutBoolValue, false);

            // Int8
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetInt8Function", FunctionActor.GetInt8ValueFunction(),
                (sbyte)12);

            FunctionActor.SetInt8ValueFunction(21);

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetInt8Function", FunctionActor.GetInt8ValueFunction(),
                (sbyte)21);

            sbyte OutInt8Value = 12;

            FunctionActor.OutInt8ValueFunction(ref OutInt8Value);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetInt8Function", OutInt8Value, (sbyte)21);

            // Int16
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetInt16Function", FunctionActor.GetInt16ValueFunction(),
                (short)12);

            FunctionActor.SetInt16ValueFunction(21);

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetInt16Function", FunctionActor.GetInt16ValueFunction(),
                (short)21);

            short OutInt16Value = 12;

            FunctionActor.OutInt16ValueFunction(ref OutInt16Value);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetInt16Function", OutInt16Value, (short)21);

            // Int32
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetInt32Function", FunctionActor.GetInt32ValueFunction(),
                (int)12);

            FunctionActor.SetInt32ValueFunction(21);

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetInt32Function", FunctionActor.GetInt32ValueFunction(),
                (int)21);

            int OutInt32Value = 12;

            FunctionActor.OutInt32ValueFunction(ref OutInt32Value);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetInt32Function", OutInt32Value, (int)21);

            // Int64
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetInt64Function", FunctionActor.GetInt64ValueFunction(),
                (long)12);

            FunctionActor.SetInt64ValueFunction(21);

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetInt64Function", FunctionActor.GetInt64ValueFunction(),
                (long)21);

            long OutInt64Value = 12;

            FunctionActor.OutInt64ValueFunction(ref OutInt64Value);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetInt64Function", OutInt64Value, (long)21);

            // UInt8
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetUInt8Function", FunctionActor.GetUInt8ValueFunction(),
                (byte)12);

            FunctionActor.SetUInt8ValueFunction(21);

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetUInt8Function", FunctionActor.GetUInt8ValueFunction(),
                (byte)21);

            byte OutUInt8Value = 12;

            FunctionActor.OutUInt8ValueFunction(ref OutUInt8Value);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetUInt8Function", OutUInt8Value, (byte)21);

            // UInt16
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetUInt16Function", FunctionActor.GetUInt16ValueFunction(),
                (ushort)12);

            FunctionActor.SetUInt16ValueFunction(21);

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetUInt16Function", FunctionActor.GetUInt16ValueFunction(),
                (ushort)21);

            ushort OutUInt16Value = 12;

            FunctionActor.OutUInt16ValueFunction(ref OutUInt16Value);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetUInt16Function", OutUInt16Value, (ushort)21);

            // UInt32
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetUInt32Function", FunctionActor.GetUInt32ValueFunction(),
                (uint)12);

            FunctionActor.SetUInt32ValueFunction(21);

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetUInt32Function", FunctionActor.GetUInt32ValueFunction(),
                (uint)21);

            uint OutUInt32Value = 12;

            FunctionActor.OutUInt32ValueFunction(ref OutUInt32Value);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetUInt32Function", OutUInt32Value, (uint)21);

            // UInt64
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetUInt64Function", FunctionActor.GetUInt64ValueFunction(),
                (ulong)12);

            FunctionActor.SetUInt64ValueFunction(21);

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetUInt64Function", FunctionActor.GetUInt64ValueFunction(),
                (ulong)21);

            ulong OutUInt64Value = 12;

            FunctionActor.OutUInt64ValueFunction(ref OutUInt64Value);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetUInt64Function", OutUInt64Value, (ulong)21);

            // Float
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetFloatFunction", FunctionActor.GetFloatValueFunction(),
                12.3f);

            FunctionActor.SetFloatValueFunction(3.21f);

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetFloatFunction", FunctionActor.GetFloatValueFunction(),
                3.21f);

            float OutFloatValue = 12.3f;

            FunctionActor.OutFloatValueFunction(ref OutFloatValue);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetFloatFunction", OutFloatValue, 3.21f);

            // Double
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetDoubleFunction", FunctionActor.GetDoubleValueFunction(),
                12.3);

            FunctionActor.SetDoubleValueFunction(3.21);

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetDoubleFunction", FunctionActor.GetDoubleValueFunction(),
                3.21);

            double OutDoubleValue = 12.3;

            FunctionActor.OutDoubleValueFunction(ref OutDoubleValue);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetDoubleFunction", OutDoubleValue, 3.21);

            // FName
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetNameFunction", FunctionActor.GetNameValueFunction(),
                "Name12");

            FunctionActor.SetNameValueFunction("21emaN");

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetNameFunction", FunctionActor.GetNameValueFunction(),
                "21emaN");

            var OutNameValue = new FName("Name12");

            FunctionActor.OutNameValueFunction(ref OutNameValue);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetNameFunction", OutNameValue, "21emaN");

            // FText
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetTextFunction", FunctionActor.GetTextValueFunction(),
                "Text12");

            FunctionActor.SetTextValueFunction("21txeT");

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetTextFunction", FunctionActor.GetTextValueFunction(),
                "21txeT");

            var OutTextValue = new FText("Text12");

            FunctionActor.OutTextValueFunction(ref OutTextValue);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetTextFunction", OutTextValue, "21txeT");

            // FString
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetStringFunction", FunctionActor.GetStringValueFunction(),
                "String12");

            FunctionActor.SetStringValueFunction("21gnirtS");

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetStringFunction", FunctionActor.GetStringValueFunction(),
                "21gnirtS");

            var OutStringValue = new FString("String12");

            FunctionActor.OutStringValueFunction(ref OutStringValue);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetStringFunction", OutStringValue, "21gnirtS");

            // Enum
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetEnumFunction", FunctionActor.GetEnumValueFunction(),
                ETestDynamicEnum.TestDynamicOne);

            FunctionActor.SetEnumValueFunction(ETestDynamicEnum.TestDynamicTwo);

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetEnumFunction", FunctionActor.GetEnumValueFunction(),
                ETestDynamicEnum.TestDynamicTwo);

            var OutEnumValue = ETestDynamicEnum.TestDynamicOne;

            FunctionActor.OutEnumValueFunction(ref OutEnumValue);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetEnumFunction", OutEnumValue,
                ETestDynamicEnum.TestDynamicTwo);

            // UStruct
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetStructFunction", FunctionActor.GetStructValueFunction(),
                new FTestDynamicStruct { Value = 1 });

            FunctionActor.SetStructValueFunction(new FTestDynamicStruct { Value = 2 });

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetStructFunction", FunctionActor.GetStructValueFunction(),
                new FTestDynamicStruct { Value = 2 });

            var OutStructValue = new FTestDynamicStruct { Value = 1 };

            FunctionActor.OutStructValueFunction(ref OutStructValue);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetStructFunction", OutStructValue,
                new FTestDynamicStruct { Value = 2 });

            // UObject
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetObjectFunction", FunctionActor.GetObjectValueFunction(),
                FunctionActor);

            FunctionActor.SetObjectValueFunction(this);

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetObjectFunction", FunctionActor.GetObjectValueFunction(),
                this);

            UObject OutObjectValue = FunctionActor;

            FunctionActor.OutObjectValueFunction(ref OutObjectValue);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetObjectFunction", OutObjectValue, this);

            // TSubclassOf
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetSubclassOfFunction",
                FunctionActor.GetSubclassOfValueFunction(),
                FunctionActor.GetClass());

            FunctionActor.SetSubclassOfValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetSubclassOfFunction",
                FunctionActor.GetSubclassOfValueFunction(),
                GetClass());

            var OutSubclassOfValue = new TSubclassOf<UObject>(FunctionActor.GetClass());

            FunctionActor.OutSubclassOfValueFunction(ref OutSubclassOfValue);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetSubclassOfFunction", OutSubclassOfValue, GetClass());

            // TWeakObjectPtr
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetWeakObjectPtrFunction",
                FunctionActor.GetWeakObjectPtrValueFunction(), FunctionActor);

            // TSoftObjectPtr
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetSoftObjectPtrFunction",
                FunctionActor.GetSoftObjectPtrValueFunction(), FunctionActor);

            FunctionActor.SetSoftObjectPtrValueFunction(this);

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetSoftObjectPtrFunction",
                FunctionActor.GetSoftObjectPtrValueFunction(), this);

            var OutSoftObjectPtrValue = new TSoftObjectPtr<UObject>(FunctionActor);

            FunctionActor.OutSoftObjectPtrValueFunction(ref OutSoftObjectPtrValue);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetSoftObjectPtrFunction", OutSoftObjectPtrValue, this);

            // TSoftClassPtr
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetSoftClassPtrFunction",
                FunctionActor.GetSoftClassPtrValueFunction(), FunctionActor.GetClass());

            FunctionActor.SetSoftClassPtrValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetSoftClassPtrFunction",
                FunctionActor.GetSoftClassPtrValueFunction(), GetClass());

            var OutSoftClassPtrValue = new TSoftClassPtr<UObject>(FunctionActor.GetClass());

            FunctionActor.OutSoftClassPtrValueFunction(ref OutSoftClassPtrValue);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetSoftClassPtrFunction", OutSoftClassPtrValue, GetClass());

            // TArray
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetArrayFunction", FunctionActor.GetArrayValueFunction(),
                new TArray<int> { 1, 2 });

            FunctionActor.SetArrayValueFunction(new TArray<int> { 3, 4 });

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetArrayFunction", FunctionActor.GetArrayValueFunction(),
                new TArray<int> { 3, 4 });

            var OutArrayValue = new TArray<int> { 1, 2 };

            FunctionActor.OutArrayValueFunction(ref OutArrayValue);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetArrayFunction", OutArrayValue, new TArray<int> { 3, 4 });

            // TSet
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetSetFunction", FunctionActor.GetSetValueFunction(),
                new TSet<int> { 1, 2 });

            FunctionActor.SetSetValueFunction(new TSet<int> { 3, 4 });

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetSetFunction", FunctionActor.GetSetValueFunction(),
                new TSet<int> { 3, 4 });

            var OutSetValue = new TSet<int> { 1, 2 };

            FunctionActor.OutSetValueFunction(ref OutSetValue);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetSetFunction", OutSetValue, new TSet<int> { 3, 4 });

            // TMap
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetMapFunction", FunctionActor.GetMapValueFunction(),
                new TMap<int, int> { { 1, 1 }, { 2, 2 } });

            FunctionActor.SetMapValueFunction(new TMap<int, int> { { 3, 3 }, { 4, 4 } });

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetMapFunction", FunctionActor.GetMapValueFunction(),
                new TMap<int, int> { { 3, 3 }, { 4, 4 } });

            var OutMapValue = new TMap<int, int> { { 1, 1 }, { 2, 2 } };

            FunctionActor.OutMapValueFunction(ref OutMapValue);

            TestCoreSubsystem.TestEqual("BlueprintDynamicOutSetMapFunction", OutMapValue,
                new TMap<int, int> { { 3, 3 }, { 4, 4 } });
        }
    }
}