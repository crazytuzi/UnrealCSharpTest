using Script.CoreUObject;
using Script.Engine;
using Script.Game.UnitTest.Core;
using Script.Game.UnitTest.Reflection;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestBlueprintReflectionFunction()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            var FunctionActor = GetWorld().SpawnActor<BP_TestReflectionFunctionActor_C>(new FTransform());

            FunctionActor.TestCoreSubsystem = TestCoreSubsystem;

            // Bool
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetBoolFunction", FunctionActor.GetBoolValueFunction(),
                true);

            FunctionActor.SetBoolValueFunction(false);

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetBoolFunction", FunctionActor.GetBoolValueFunction(),
                false);

            bool OutBoolValue = true;

            FunctionActor.OutBoolValueFunction(ref OutBoolValue);

            TestCoreSubsystem.TestEqual("BlueprintReflectionOutSetBoolFunction", OutBoolValue, false);

            // Int32
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetInt32Function", FunctionActor.GetInt32ValueFunction(),
                (int)12);

            FunctionActor.SetInt32ValueFunction(21);

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetInt32Function", FunctionActor.GetInt32ValueFunction(),
                (int)21);

            int OutInt32Value = 12;

            FunctionActor.OutInt32ValueFunction(ref OutInt32Value);

            TestCoreSubsystem.TestEqual("BlueprintReflectionOutSetInt32Function", OutInt32Value, (int)21);

            // Int64
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetInt64Function", FunctionActor.GetInt64ValueFunction(),
                (long)12);

            FunctionActor.SetInt64ValueFunction(21);

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetInt64Function", FunctionActor.GetInt64ValueFunction(),
                (long)21);

            long OutInt64Value = 12;

            FunctionActor.OutInt64ValueFunction(ref OutInt64Value);

            TestCoreSubsystem.TestEqual("BlueprintReflectionOutSetInt64Function", OutInt64Value, (long)21);

            // UInt8
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetUInt8Function", FunctionActor.GetUInt8ValueFunction(),
                (byte)12);

            FunctionActor.SetUInt8ValueFunction(21);

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetUInt8Function", FunctionActor.GetUInt8ValueFunction(),
                (byte)21);

            byte OutUInt8Value = 12;

            FunctionActor.OutUInt8ValueFunction(ref OutUInt8Value);

            TestCoreSubsystem.TestEqual("BlueprintReflectionOutSetUInt8Function", OutUInt8Value, (byte)21);

            // Double
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetDoubleFunction", FunctionActor.GetDoubleValueFunction(),
                12.3);

            FunctionActor.SetDoubleValueFunction(3.21);

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetDoubleFunction", FunctionActor.GetDoubleValueFunction(),
                3.21);

            double OutDoubleValue = 12.3;

            FunctionActor.OutDoubleValueFunction(ref OutDoubleValue);

            TestCoreSubsystem.TestEqual("BlueprintReflectionOutSetDoubleFunction", OutDoubleValue, 3.21);

            // FName
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetNameFunction", FunctionActor.GetNameValueFunction(),
                "Name12");

            FunctionActor.SetNameValueFunction("21emaN");

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetNameFunction", FunctionActor.GetNameValueFunction(),
                "21emaN");

            var OutNameValue = new FName("Name12");

            FunctionActor.OutNameValueFunction(ref OutNameValue);

            TestCoreSubsystem.TestEqual("BlueprintReflectionOutSetNameFunction", OutNameValue, "21emaN");

            // FText
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetTextFunction", FunctionActor.GetTextValueFunction(),
                "Text12");

            FunctionActor.SetTextValueFunction("21txeT");

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetTextFunction", FunctionActor.GetTextValueFunction(),
                "21txeT");

            var OutTextValue = new FText("Text12");

            FunctionActor.OutTextValueFunction(ref OutTextValue);

            TestCoreSubsystem.TestEqual("BlueprintReflectionOutSetTextFunction", OutTextValue, "21txeT");

            // FString
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetStringFunction", FunctionActor.GetStringValueFunction(),
                "String12");

            FunctionActor.SetStringValueFunction("21gnirtS");

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetStringFunction", FunctionActor.GetStringValueFunction(),
                "21gnirtS");

            var OutStringValue = new FString("String12");

            FunctionActor.OutStringValueFunction(ref OutStringValue);

            TestCoreSubsystem.TestEqual("BlueprintReflectionOutSetStringFunction", OutStringValue, "21gnirtS");

            // Enum
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetEnumFunction", FunctionActor.GetEnumValueFunction(),
                BP_TestEnum.BlueprintTestEnumOne);

            FunctionActor.SetEnumValueFunction(BP_TestEnum.BlueprintTestEnumTwo);

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetEnumFunction", FunctionActor.GetEnumValueFunction(),
                BP_TestEnum.BlueprintTestEnumTwo);

            var OutEnumValue = BP_TestEnum.BlueprintTestEnumOne;

            FunctionActor.OutEnumValueFunction(ref OutEnumValue);

            TestCoreSubsystem.TestEqual("BlueprintReflectionOutSetEnumFunction", OutEnumValue,
                BP_TestEnum.BlueprintTestEnumTwo);

            // UStruct
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetStructFunction", FunctionActor.GetStructValueFunction(),
                new BP_TestStruct { Value = 1 });

            FunctionActor.SetStructValueFunction(new BP_TestStruct { Value = 2 });

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetStructFunction", FunctionActor.GetStructValueFunction(),
                new BP_TestStruct { Value = 2 });

            var OutStructValue = new BP_TestStruct { Value = 1 };

            FunctionActor.OutStructValueFunction(ref OutStructValue);

            TestCoreSubsystem.TestEqual("BlueprintReflectionOutSetStructFunction", OutStructValue,
                new BP_TestStruct { Value = 2 });

            // UObject
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetObjectFunction", FunctionActor.GetObjectValueFunction(),
                FunctionActor);

            FunctionActor.SetObjectValueFunction(this);

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetObjectFunction", FunctionActor.GetObjectValueFunction(),
                this);

            UObject OutObjectValue = FunctionActor;

            FunctionActor.OutObjectValueFunction(ref OutObjectValue);

            TestCoreSubsystem.TestEqual("BlueprintReflectionOutSetObjectFunction", OutObjectValue, this);

            // UClass
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetClassFunction", FunctionActor.GetClassValueFunction(),
                FunctionActor.GetClass());

            FunctionActor.SetClassValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetClassFunction", FunctionActor.GetClassValueFunction(),
                GetClass());

            var OutClassValue = FunctionActor.GetClass();

            FunctionActor.OutClassValueFunction(ref OutClassValue);

            TestCoreSubsystem.TestEqual("BlueprintReflectionOutSetClassFunction", OutClassValue, GetClass());

            // UInterface
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetInterfaceFunction",
                FunctionActor.GetInterfaceValueFunction(),
                FunctionActor.InterfaceValue);

            FunctionActor.SetInterfaceValueFunction(FunctionActor.InterfaceValue);

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetInterfaceFunction",
                FunctionActor.GetInterfaceValueFunction(),
                FunctionActor.InterfaceValue);

            var OutInterfaceValue = FunctionActor.InterfaceValue;

            FunctionActor.OutInterfaceValueFunction(ref OutInterfaceValue);

            TestCoreSubsystem.TestEqual("BlueprintReflectionOutSetInterfaceFunction", OutInterfaceValue,
                FunctionActor.InterfaceValue);

            // TSoftObjectPtr
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetSoftObjectPtrFunction",
                FunctionActor.GetSoftObjectPtrValueFunction(), FunctionActor);

            FunctionActor.SetSoftObjectPtrValueFunction(this);

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetSoftObjectPtrFunction",
                FunctionActor.GetSoftObjectPtrValueFunction(), this);

            var OutSoftObjectPtrValue = new TSoftObjectPtr<UObject>(FunctionActor);

            FunctionActor.OutSoftObjectPtrValueFunction(ref OutSoftObjectPtrValue);

            TestCoreSubsystem.TestEqual("BlueprintReflectionOutSetSoftObjectPtrFunction", OutSoftObjectPtrValue, this);

            // TSoftClassPtr
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetSoftClassPtrFunction",
                FunctionActor.GetSoftClassPtrValueFunction(), FunctionActor.GetClass());

            FunctionActor.SetSoftClassPtrValueFunction(GetClass());

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetSoftClassPtrFunction",
                FunctionActor.GetSoftClassPtrValueFunction(), GetClass());

            var OutSoftClassPtrValue = new TSoftClassPtr<UObject>(FunctionActor.GetClass());

            FunctionActor.OutSoftClassPtrValueFunction(ref OutSoftClassPtrValue);

            TestCoreSubsystem.TestEqual("BlueprintReflectionOutSetSoftClassPtrFunction", OutSoftClassPtrValue,
                GetClass());

            // TArray
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetArrayFunction", FunctionActor.GetArrayValueFunction(),
                new TArray<int> { 1, 2 });

            TArray<int> InArrayValue = new TArray<int> { 3, 4 };

            FunctionActor.SetArrayValueFunction(ref InArrayValue);

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetArrayFunction", FunctionActor.GetArrayValueFunction(),
                new TArray<int> { 3, 4 });

            var OutArrayValue = new TArray<int> { 1, 2 };

            FunctionActor.OutArrayValueFunction(ref OutArrayValue);

            TestCoreSubsystem.TestEqual("BlueprintReflectionOutSetArrayFunction", OutArrayValue,
                new TArray<int> { 3, 4 });

            // TSet
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetSetFunction", FunctionActor.GetSetValueFunction(),
                new TSet<int> { 1, 2 });

            FunctionActor.SetSetValueFunction(new TSet<int> { 3, 4 });

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetSetFunction", FunctionActor.GetSetValueFunction(),
                new TSet<int> { 3, 4 });

            var OutSetValue = new TSet<int> { 1, 2 };

            FunctionActor.OutSetValueFunction(ref OutSetValue);

            TestCoreSubsystem.TestEqual("BlueprintReflectionOutSetSetFunction", OutSetValue, new TSet<int> { 3, 4 });

            // TMap
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetMapFunction", FunctionActor.GetMapValueFunction(),
                new TMap<int, int> { { 1, 1 }, { 2, 2 } });

            FunctionActor.SetMapValueFunction(new TMap<int, int> { { 3, 3 }, { 4, 4 } });

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetMapFunction", FunctionActor.GetMapValueFunction(),
                new TMap<int, int> { { 3, 3 }, { 4, 4 } });

            var OutMapValue = new TMap<int, int> { { 1, 1 }, { 2, 2 } };

            FunctionActor.OutMapValueFunction(ref OutMapValue);

            TestCoreSubsystem.TestEqual("BlueprintReflectionOutSetMapFunction", OutMapValue,
                new TMap<int, int> { { 3, 3 }, { 4, 4 } });
        }
    }
}