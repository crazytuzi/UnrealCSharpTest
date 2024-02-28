using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestRawBindingFunction()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(Unreal.GWorld, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            var Function = new FTestBindingFunction
            {
                TestCoreSubsystem = TestCoreSubsystem
            };

            // Static
            TestCoreSubsystem.TestEqual("RawBindingStaticFunction", ATestBindingFunctionActor.StaticFunction(),
                true);

            // Bool
            TestCoreSubsystem.TestEqual("RawBindingGetBoolFunction", Function.GetBoolValueFunction(), true);

            Function.SetBoolValueFunction(false);

            TestCoreSubsystem.TestEqual("RawBindingSetBoolFunction", Function.GetBoolValueFunction(), false);

            bool OutBoolValue = true;

            Function.OutBoolValueFunction(ref OutBoolValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetBoolFunction", OutBoolValue, false);

            // Int8
            TestCoreSubsystem.TestEqual("RawBindingGetInt8Function", Function.GetInt8ValueFunction(), (sbyte)12);

            Function.SetInt8ValueFunction(21);

            TestCoreSubsystem.TestEqual("RawBindingSetInt8Function", Function.GetInt8ValueFunction(), (sbyte)21);

            sbyte OutInt8Value = 12;

            Function.OutInt8ValueFunction(ref OutInt8Value);

            TestCoreSubsystem.TestEqual("RawBindingOutSetInt8Function", OutInt8Value, (sbyte)21);

            // Int16
            TestCoreSubsystem.TestEqual("RawBindingGetInt16Function", Function.GetInt16ValueFunction(), (short)12);

            Function.SetInt16ValueFunction(21);

            TestCoreSubsystem.TestEqual("RawBindingSetInt16Function", Function.GetInt16ValueFunction(), (short)21);

            short OutInt16Value = 12;

            Function.OutInt16ValueFunction(ref OutInt16Value);

            TestCoreSubsystem.TestEqual("RawBindingOutSetInt16Function", OutInt16Value, (short)21);

            // Int32
            TestCoreSubsystem.TestEqual("RawBindingGetInt32Function", Function.GetInt32ValueFunction(), (int)12);

            Function.SetInt32ValueFunction(21);

            TestCoreSubsystem.TestEqual("RawBindingSetInt32Function", Function.GetInt32ValueFunction(), (int)21);

            int OutInt32Value = 12;

            Function.OutInt32ValueFunction(ref OutInt32Value);

            TestCoreSubsystem.TestEqual("RawBindingOutSetInt32Function", OutInt32Value, (int)21);

            // Int64
            TestCoreSubsystem.TestEqual("RawBindingGetInt64Function", Function.GetInt64ValueFunction(), (long)12);

            Function.SetInt64ValueFunction(21);

            TestCoreSubsystem.TestEqual("RawBindingSetInt64Function", Function.GetInt64ValueFunction(), (long)21);

            long OutInt64Value = 12;

            Function.OutInt64ValueFunction(ref OutInt64Value);

            TestCoreSubsystem.TestEqual("RawBindingOutSetInt64Function", OutInt64Value, (long)21);

            // UInt8
            TestCoreSubsystem.TestEqual("RawBindingGetUInt8Function", Function.GetUInt8ValueFunction(), (byte)12);

            Function.SetUInt8ValueFunction(21);

            TestCoreSubsystem.TestEqual("RawBindingSetUInt8Function", Function.GetUInt8ValueFunction(), (byte)21);

            byte OutUInt8Value = 12;

            Function.OutUInt8ValueFunction(ref OutUInt8Value);

            TestCoreSubsystem.TestEqual("RawBindingOutSetUInt8Function", OutUInt8Value, (byte)21);

            // UInt16
            TestCoreSubsystem.TestEqual("RawBindingGetUInt16Function", Function.GetUInt16ValueFunction(),
                (ushort)12);

            Function.SetUInt16ValueFunction(21);

            TestCoreSubsystem.TestEqual("RawBindingSetUInt16Function", Function.GetUInt16ValueFunction(),
                (ushort)21);

            ushort OutUInt16Value = 12;

            Function.OutUInt16ValueFunction(ref OutUInt16Value);

            TestCoreSubsystem.TestEqual("RawBindingOutSetUInt16Function", OutUInt16Value, (ushort)21);

            // UInt32
            TestCoreSubsystem.TestEqual("RawBindingGetUInt32Function", Function.GetUInt32ValueFunction(),
                (uint)12);

            Function.SetUInt32ValueFunction(21);

            TestCoreSubsystem.TestEqual("RawBindingSetUInt32Function", Function.GetUInt32ValueFunction(),
                (uint)21);

            uint OutUInt32Value = 12;

            Function.OutUInt32ValueFunction(ref OutUInt32Value);

            TestCoreSubsystem.TestEqual("RawBindingOutSetUInt32Function", OutUInt32Value, (uint)21);

            // UInt64
            TestCoreSubsystem.TestEqual("RawBindingGetUInt64Function", Function.GetUInt64ValueFunction(),
                (ulong)12);

            Function.SetUInt64ValueFunction(21);

            TestCoreSubsystem.TestEqual("RawBindingSetUInt64Function", Function.GetUInt64ValueFunction(),
                (ulong)21);

            ulong OutUInt64Value = 12;

            Function.OutUInt64ValueFunction(ref OutUInt64Value);

            TestCoreSubsystem.TestEqual("RawBindingOutSetUInt64Function", OutUInt64Value, (ulong)21);

            // Float
            TestCoreSubsystem.TestEqual("RawBindingGetFloatFunction", Function.GetFloatValueFunction(), 12.3f);

            Function.SetFloatValueFunction(3.21f);

            TestCoreSubsystem.TestEqual("RawBindingSetFloatFunction", Function.GetFloatValueFunction(), 3.21f);

            float OutFloatValue = 12.3f;

            Function.OutFloatValueFunction(ref OutFloatValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetFloatFunction", OutFloatValue, 3.21f);

            // Double
            TestCoreSubsystem.TestEqual("RawBindingGetDoubleFunction", Function.GetDoubleValueFunction(), 12.3);

            Function.SetDoubleValueFunction(3.21);

            TestCoreSubsystem.TestEqual("RawBindingSetDoubleFunction", Function.GetDoubleValueFunction(), 3.21);

            double OutDoubleValue = 12.3;

            Function.OutDoubleValueFunction(ref OutDoubleValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetDoubleFunction", OutDoubleValue, 3.21);

            // FName
            TestCoreSubsystem.TestEqual("RawBindingGetNameFunction", Function.GetNameValueFunction(), "Name12");

            Function.SetNameValueFunction("21emaN");

            TestCoreSubsystem.TestEqual("RawBindingSetNameFunction", Function.GetNameValueFunction(), "21emaN");

            var OutNameValue = new FName("Name12");

            Function.OutNameValueFunction(ref OutNameValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetNameFunction", OutNameValue, "21emaN");

            // FText
            TestCoreSubsystem.TestEqual("RawBindingGetTextFunction", Function.GetTextValueFunction(), "Text12");

            Function.SetTextValueFunction("21txeT");

            TestCoreSubsystem.TestEqual("RawBindingSetTextFunction", Function.GetTextValueFunction(), "21txeT");

            var OutTextValue = new FText("Text12");

            Function.OutTextValueFunction(ref OutTextValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetTextFunction", OutTextValue, "21txeT");

            // FString
            TestCoreSubsystem.TestEqual("RawBindingGetStringFunction", Function.GetStringValueFunction(),
                "String12");

            Function.SetStringValueFunction("21gnirtS");

            TestCoreSubsystem.TestEqual("RawBindingSetStringFunction", Function.GetStringValueFunction(),
                "21gnirtS");

            var OutStringValue = new FString("String12");

            Function.OutStringValueFunction(ref OutStringValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetStringFunction", OutStringValue, "21gnirtS");

            // Enum
            TestCoreSubsystem.TestEqual("RawBindingGetEnumFunction", Function.GetEnumValueFunction(),
                ETestEnum.TestEnumOne);

            Function.SetEnumValueFunction(ETestEnum.TestEnumTwo);

            TestCoreSubsystem.TestEqual("RawBindingSetEnumFunction", Function.GetEnumValueFunction(),
                ETestEnum.TestEnumTwo);

            var OutEnumValue = ETestEnum.TestEnumOne;

            Function.OutEnumValueFunction(ref OutEnumValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetEnumFunction", OutEnumValue, ETestEnum.TestEnumTwo);

            // TEnumAsByte
            TestCoreSubsystem.TestEqual("RawBindingGetEnumAsByteFunction", Function.GetEnumAsByteValueFunction(),
                ETestEnum.TestEnumOne);

            Function.SetEnumAsByteValueFunction(ETestEnum.TestEnumTwo);

            TestCoreSubsystem.TestEqual("RawBindingSetEnumAsByteFunction", Function.GetEnumAsByteValueFunction(),
                ETestEnum.TestEnumTwo);

            var OutEnumAsByteValue = ETestEnum.TestEnumOne;

            Function.OutEnumAsByteValueFunction(ref OutEnumAsByteValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetEnumAsByteFunction", OutEnumAsByteValue,
                ETestEnum.TestEnumTwo);

            // EnumClass
            TestCoreSubsystem.TestEqual("RawBindingGetEnumClassFunction", Function.GetEnumClassValueFunction(),
                ETestEnumClass.TestEnumClassOne);

            Function.SetEnumClassValueFunction(ETestEnumClass.TestEnumClassTwo);

            TestCoreSubsystem.TestEqual("RawBindingSetEnumClassFunction", Function.GetEnumClassValueFunction(),
                ETestEnumClass.TestEnumClassTwo);

            var OutEnumClassValue = ETestEnumClass.TestEnumClassOne;

            Function.OutEnumClassValueFunction(ref OutEnumClassValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetEnumClassFunction", OutEnumClassValue,
                ETestEnumClass.TestEnumClassTwo);

            // RawEnum
            TestCoreSubsystem.TestEqual("RawBindingGetRawEnumFunction", Function.GetRawEnumValueFunction(),
                ERawTestEnum.RawTestEnumOne);

            Function.SetRawEnumValueFunction(ERawTestEnum.RawTestEnumTwo);

            TestCoreSubsystem.TestEqual("RawBindingSetRawEnumFunction", Function.GetRawEnumValueFunction(),
                ERawTestEnum.RawTestEnumTwo);

            var OutRawEnumValue = ERawTestEnum.RawTestEnumOne;

            Function.OutRawEnumValueFunction(ref OutRawEnumValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetRawEnumFunction", OutRawEnumValue,
                ERawTestEnum.RawTestEnumTwo);

            // RawEnumClass
            TestCoreSubsystem.TestEqual("RawBindingGetRawEnumClassFunction", Function.GetRawEnumClassValueFunction(),
                ERawTestEnumClass.RawTestEnumClassOne);

            Function.SetRawEnumClassValueFunction(ERawTestEnumClass.RawTestEnumClassTwo);

            TestCoreSubsystem.TestEqual("RawBindingSetRawEnumClassFunction", Function.GetRawEnumClassValueFunction(),
                ERawTestEnumClass.RawTestEnumClassTwo);

            var OutRawEnumClassValue = ERawTestEnumClass.RawTestEnumClassOne;

            Function.OutRawEnumClassValueFunction(ref OutRawEnumClassValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetRawEnumClassFunction", OutRawEnumClassValue,
                ERawTestEnumClass.RawTestEnumClassTwo);

            // UStruct
            TestCoreSubsystem.TestEqual("RawBindingGetStructFunction", Function.GetStructValueFunction(),
                new FTestStruct { Value = 1 });

            Function.SetStructValueFunction(new FTestStruct { Value = 2 });

            TestCoreSubsystem.TestEqual("RawBindingSetStructFunction", Function.GetStructValueFunction(),
                new FTestStruct { Value = 2 });

            var OutStructValue = new FTestStruct { Value = 1 };

            Function.OutStructValueFunction(OutStructValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetStructFunction", OutStructValue,
                new FTestStruct { Value = 2 });

            // RawStruct
            TestCoreSubsystem.TestEqual("RawBindingGetRawStructFunction", Function.GetRawStructValueFunction(),
                new FRawTestStruct { Value = 1 });

            Function.SetRawStructValueFunction(new FRawTestStruct { Value = 2 });

            TestCoreSubsystem.TestEqual("RawBindingSetRawStructFunction", Function.GetRawStructValueFunction(),
                new FRawTestStruct { Value = 2 });

            var OutRawStructValue = new FRawTestStruct { Value = 1 };

            Function.OutRawStructValueFunction(OutRawStructValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetRawStructFunction", OutRawStructValue,
                new FRawTestStruct { Value = 2 });

            // UObject
            TestCoreSubsystem.TestEqual("RawBindingGetObjectFunction", Function.GetObjectValueFunction(),
                Unreal.GWorld);

            Function.SetObjectValueFunction(this);

            TestCoreSubsystem.TestEqual("RawBindingSetObjectFunction", Function.GetObjectValueFunction(), this);

            UObject OutObjectValue = Unreal.GWorld;

            Function.OutObjectValueFunction(ref OutObjectValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetObjectFunction", OutObjectValue, this);

            // UClass
            TestCoreSubsystem.TestEqual("RawBindingGetClassFunction", Function.GetClassValueFunction(),
                Unreal.GWorld.GetClass());

            Function.SetClassValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("RawBindingSetClassFunction", Function.GetClassValueFunction(),
                GetClass());

            var OutClassValue = new TSubclassOf<UObject>(Unreal.GWorld.GetClass());

            Function.OutClassValueFunction(ref OutClassValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetClassFunction", OutClassValue, GetClass());

            // TSubclassOf
            TestCoreSubsystem.TestEqual("RawBindingGetSubclassOfFunction", Function.GetSubclassOfValueFunction(),
                Unreal.GWorld.GetClass());

            Function.SetSubclassOfValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("RawBindingSetSubclassOfFunction", Function.GetSubclassOfValueFunction(),
                GetClass());

            var OutSubclassOfValue = new TSubclassOf<UObject>(Unreal.GWorld.GetClass());

            Function.OutSubclassOfValueFunction(OutSubclassOfValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetSubclassOfFunction", OutSubclassOfValue, GetClass());

            // TWeakObjectPtr
            TestCoreSubsystem.TestEqual("RawBindingGetWeakObjectPtrFunction",
                Function.GetWeakObjectPtrValueFunction(), Unreal.GWorld);

            Function.SetWeakObjectPtrValueFunction(this);

            TestCoreSubsystem.TestEqual("RawBindingSetWeakObjectPtrFunction",
                Function.GetWeakObjectPtrValueFunction(),
                this);

            var OutWeakObjectPtrValue = new TWeakObjectPtr<UObject>(Unreal.GWorld);

            Function.OutWeakObjectPtrValueFunction(OutWeakObjectPtrValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetWeakObjectPtrFunction", OutWeakObjectPtrValue, this);

            // TLazyObjectPtr
            TestCoreSubsystem.TestEqual("RawBindingGetLazyObjectPtrFunction",
                Function.GetLazyObjectPtrValueFunction(), Unreal.GWorld);

            Function.SetLazyObjectPtrValueFunction(this);

            TestCoreSubsystem.TestEqual("RawBindingSetLazyObjectPtrFunction",
                Function.GetLazyObjectPtrValueFunction(),
                this);

            var OutLazyObjectPtrValue = new TLazyObjectPtr<UObject>(Unreal.GWorld);

            Function.OutLazyObjectPtrValueFunction(OutLazyObjectPtrValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetLazyObjectPtrFunction", OutLazyObjectPtrValue, this);

            // TSoftObjectPtr
            TestCoreSubsystem.TestEqual("RawBindingGetSoftObjectPtrFunction",
                Function.GetSoftObjectPtrValueFunction(), Unreal.GWorld);

            Function.SetSoftObjectPtrValueFunction(this);

            TestCoreSubsystem.TestEqual("RawBindingSetSoftObjectPtrFunction",
                Function.GetSoftObjectPtrValueFunction(), this);

            var OutSoftObjectPtrValue = new TSoftObjectPtr<UObject>(Unreal.GWorld);

            Function.OutSoftObjectPtrValueFunction(OutSoftObjectPtrValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetSoftObjectPtrFunction", OutSoftObjectPtrValue, this);

            // TSoftClassPtr
            TestCoreSubsystem.TestEqual("RawBindingGetSoftClassPtrFunction",
                Function.GetSoftClassPtrValueFunction(), Unreal.GWorld.GetClass());

            Function.SetSoftClassPtrValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("RawBindingSetSoftClassPtrFunction",
                Function.GetSoftClassPtrValueFunction(), GetClass());

            var OutSoftClassPtrValue = new TSoftClassPtr<UObject>(Unreal.GWorld.GetClass());

            Function.OutSoftClassPtrValueFunction(OutSoftClassPtrValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetSoftClassPtrFunction", OutSoftClassPtrValue, GetClass());

            // TArray
            TestCoreSubsystem.TestEqual("RawBindingGetArrayFunction", Function.GetArrayValueFunction(),
                new TArray<int> { 1, 2 });

            Function.SetArrayValueFunction(new TArray<int> { 3, 4 });

            TestCoreSubsystem.TestEqual("RawBindingSetArrayFunction", Function.GetArrayValueFunction(),
                new TArray<int> { 3, 4 });

            var OutArrayValue = new TArray<int> { 1, 2 };

            Function.OutArrayValueFunction(ref OutArrayValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetArrayFunction", OutArrayValue, new TArray<int> { 3, 4 });

            // TSet
            TestCoreSubsystem.TestEqual("RawBindingGetSetFunction", Function.GetSetValueFunction(),
                new TSet<int> { 1, 2 });

            Function.SetSetValueFunction(new TSet<int> { 3, 4 });

            TestCoreSubsystem.TestEqual("RawBindingSetSetFunction", Function.GetSetValueFunction(),
                new TSet<int> { 3, 4 });

            var OutSetValue = new TSet<int> { 1, 2 };

            Function.OutSetValueFunction(ref OutSetValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetSetFunction", OutSetValue, new TSet<int> { 3, 4 });

            // TMap
            TestCoreSubsystem.TestEqual("RawBindingGetMapFunction", Function.GetMapValueFunction(),
                new TMap<int, int> { { 1, 1 }, { 2, 2 } });

            Function.SetMapValueFunction(new TMap<int, int> { { 3, 3 }, { 4, 4 } });

            TestCoreSubsystem.TestEqual("RawBindingSetMapFunction", Function.GetMapValueFunction(),
                new TMap<int, int> { { 3, 3 }, { 4, 4 } });

            var OutMapValue = new TMap<int, int> { { 1, 1 }, { 2, 2 } };

            Function.OutMapValueFunction(ref OutMapValue);

            TestCoreSubsystem.TestEqual("RawBindingOutSetMapFunction", OutMapValue,
                new TMap<int, int> { { 3, 3 }, { 4, 4 } });
        }
    }
}