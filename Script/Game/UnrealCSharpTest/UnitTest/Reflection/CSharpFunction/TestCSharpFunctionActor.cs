using System;
using Script.Common;
using Script.CoreUObject;

namespace Script.UnrealCSharpTest
{
    [IsOverride]
    public partial class ATestCSharpFunctionActor
    {
        [IsOverride]
        public void SetBoolValueFunction(Boolean InBoolValue)
        {
            BoolValue = InBoolValue;
        }

        [IsOverride]
        public Boolean GetBoolValueFunction()
        {
            return BoolValue;
        }

        [IsOverride]
        public void OutBoolValueFunction(ref Boolean OutBoolValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetBoolFunction", OutBoolValue, true);

            OutBoolValue = BoolValue;
        }

        [IsOverride]
        public void SetInt32ValueFunction(Int32 InInt32Value)
        {
            Int32Value = InInt32Value;
        }

        [IsOverride]
        public Int32 GetInt32ValueFunction()
        {
            return Int32Value;
        }

        [IsOverride]
        public void OutInt32ValueFunction(ref Int32 OutInt32Value)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetInt32Function", OutInt32Value, (Int32)12);

            OutInt32Value = Int32Value;
        }

        [IsOverride]
        public void SetInt64ValueFunction(Int64 InInt64Value)
        {
            Int64Value = InInt64Value;
        }

        [IsOverride]
        public Int64 GetInt64ValueFunction()
        {
            return Int64Value;
        }

        [IsOverride]
        public void OutInt64ValueFunction(ref Int64 OutInt64Value)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetInt64Function", OutInt64Value, (Int64)12);

            OutInt64Value = Int64Value;
        }

        [IsOverride]
        public void SetUInt8ValueFunction(Byte InUInt8Value)
        {
            UInt8Value = InUInt8Value;
        }

        [IsOverride]
        public Byte GetUInt8ValueFunction()
        {
            return UInt8Value;
        }

        [IsOverride]
        public void OutUInt8ValueFunction(ref Byte OutUInt8Value)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetUInt8Function", OutUInt8Value, (Byte)12);

            OutUInt8Value = UInt8Value;
        }

        [IsOverride]
        public void SetFloatValueFunction(Single InFloatValue)
        {
            FloatValue = InFloatValue;
        }

        [IsOverride]
        public Single GetFloatValueFunction()
        {
            return FloatValue;
        }

        [IsOverride]
        public void OutFloatValueFunction(ref Single OutFloatValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetFloatFunction", OutFloatValue, 12.3f);

            OutFloatValue = FloatValue;
        }

        [IsOverride]
        public void SetDoubleValueFunction(Double InDoubleValue)
        {
            DoubleValue = InDoubleValue;
        }

        [IsOverride]
        public Double GetDoubleValueFunction()
        {
            return DoubleValue;
        }

        [IsOverride]
        public void OutDoubleValueFunction(ref Double OutDoubleValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetDoubleFunction", OutDoubleValue, 12.3);

            OutDoubleValue = DoubleValue;
        }

        [IsOverride]
        public void SetNameValueFunction(FName InNameValue)
        {
            NameValue = InNameValue;
        }

        [IsOverride]
        public FName GetNameValueFunction()
        {
            return NameValue;
        }

        [IsOverride]
        public void OutNameValueFunction(ref FName OutNameValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetNameFunction", OutNameValue, "Name12");

            OutNameValue = NameValue;
        }

        [IsOverride]
        public FText GetTextValueFunction()
        {
            return TextValue;
        }

        [IsOverride]
        public void SetTextValueFunction(FText InTextValue)
        {
            TextValue = InTextValue;
        }

        [IsOverride]
        public void OutTextValueFunction(ref FText OutTextValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetTextFunction", OutTextValue, "Text12");

            OutTextValue = TextValue;
        }

        [IsOverride]
        public void SetStringValueFunction(FString InStringValue)
        {
            StringValue = InStringValue;
        }

        [IsOverride]
        public FString GetStringValueFunction()
        {
            return StringValue;
        }

        [IsOverride]
        public void OutStringValueFunction(ref FString OutStringValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetStringFunction", OutStringValue, "String12");

            OutStringValue = StringValue;
        }

        [IsOverride]
        public ETestEnum GetEnumValueFunction()
        {
            return EnumValue;
        }

        [IsOverride]
        public void SetEnumValueFunction(ETestEnum InEnumValue)
        {
            EnumValue = InEnumValue;
        }

        [IsOverride]
        public void OutEnumValueFunction(ref ETestEnum OutEnumValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetEnumFunction", OutEnumValue, ETestEnum.TestEnumOne);

            OutEnumValue = EnumValue;
        }

        [IsOverride]
        public ETestEnumClass GetEnumClassValueFunction()
        {
            return EnumClassValue;
        }

        [IsOverride]
        public void SetEnumClassValueFunction(ETestEnumClass InEnumClassValue)
        {
            EnumClassValue = InEnumClassValue;
        }

        [IsOverride]
        public void OutEnumClassValueFunction(ref ETestEnumClass OutEnumClassValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetEnumClassFunction", OutEnumClassValue,
                ETestEnumClass.TestEnumClassOne);

            OutEnumClassValue = EnumClassValue;
        }

        [IsOverride]
        public FTestStruct GetStructValueFunction()
        {
            return StructValue;
        }

        [IsOverride]
        public void SetStructValueFunction(FTestStruct InStructValue)
        {
            StructValue = InStructValue;
        }

        [IsOverride]
        public void OutStructValueFunction(ref FTestStruct OutStructValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetStructFunction", OutStructValue, new FTestStruct { Value = 1 });

            OutStructValue = StructValue;
        }

        [IsOverride]
        public UObject GetObjectValueFunction()
        {
            return ObjectValue;
        }

        [IsOverride]
        public void SetObjectValueFunction(UObject InObjectValue)
        {
            ObjectValue = InObjectValue;
        }

        [IsOverride]
        public void OutObjectValueFunction(ref UObject OutObjectValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetObjectFunction", OutObjectValue, this);

            OutObjectValue = ObjectValue;
        }

        [IsOverride]
        public TSubclassOf<UObject> GetClassValueFunction()
        {
            return ClassValue;
        }

        [IsOverride]
        public void SetClassValueFunction(TSubclassOf<UObject> InClassValue)
        {
            ClassValue = InClassValue;
        }

        [IsOverride]
        public void OutClassValueFunction(ref TSubclassOf<UObject> OutClassValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetClassFunction", OutClassValue, GetClass());

            OutClassValue = ClassValue;
        }

        [IsOverride]
        public TScriptInterface<ITestInterface> GetInterfaceValueFunction()
        {
            return InterfaceValue;
        }

        [IsOverride]
        public void SetInterfaceValueFunction(TScriptInterface<ITestInterface> InInterfaceValue)
        {
            InterfaceValue = InInterfaceValue;
        }

        [IsOverride]
        public void OutInterfaceValueFunction(ref TScriptInterface<ITestInterface> OutInterfaceValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetInterfaceFunction", OutInterfaceValue, InterfaceValue);

            OutInterfaceValue = InterfaceValue;
        }

        [IsOverride]
        public void SetSubclassOfValueFunction(TSubclassOf<UObject> InSubclassOfValue)
        {
            SubclassOfValue = InSubclassOfValue;
        }

        [IsOverride]
        public TSubclassOf<UObject> GetSubclassOfValueFunction()
        {
            return SubclassOfValue;
        }

        [IsOverride]
        public void OutSubclassOfValueFunction(ref TSubclassOf<UObject> OutSubclassOfValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetSubclassOfFunction", OutSubclassOfValue, GetClass());

            OutSubclassOfValue = SubclassOfValue;
        }

        [IsOverride]
        public void SetSoftObjectPtrValueFunction(TSoftObjectPtr<UObject> InSoftObjectPtrValue)
        {
            SoftObjectPtrValue = InSoftObjectPtrValue;
        }

        [IsOverride]
        public TSoftObjectPtr<UObject> GetSoftObjectPtrValueFunction()
        {
            return SoftObjectPtrValue;
        }

        [IsOverride]
        public void OutSoftObjectPtrValueFunction(ref TSoftObjectPtr<UObject> OutSoftObjectPtrValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetSoftObjectPtrFunction", OutSoftObjectPtrValue, this);

            OutSoftObjectPtrValue = SoftObjectPtrValue;
        }

        [IsOverride]
        public TSoftClassPtr<UObject> GetSoftClassPtrValueFunction()
        {
            return SoftClassPtrValue;
        }

        [IsOverride]
        public void SetSoftClassPtrValueFunction(TSoftClassPtr<UObject> InSoftClassPtrValue)
        {
            SoftClassPtrValue = InSoftClassPtrValue;
        }

        [IsOverride]
        public void OutSoftClassPtrValueFunction(ref TSoftClassPtr<UObject> OutSoftClassPtrValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetSoftClassPtrFunction", OutSoftClassPtrValue, GetClass());

            OutSoftClassPtrValue = SoftClassPtrValue;
        }

        [IsOverride]
        public void SetArrayValueFunction(TArray<Int32> InArrayValue)
        {
            ArrayValue = InArrayValue;
        }

        [IsOverride]
        public TArray<Int32> GetArrayValueFunction()
        {
            return ArrayValue;
        }

        [IsOverride]
        public void OutArrayValueFunction(ref TArray<Int32> OutArrayValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetArrayFunction", OutArrayValue, new TArray<Int32> { 1, 2 });

            OutArrayValue = ArrayValue;
        }

        [IsOverride]
        public void SetSetValueFunction(TSet<Int32> InSetValue)
        {
            SetValue = InSetValue;
        }

        [IsOverride]
        public TSet<Int32> GetSetValueFunction()
        {
            return SetValue;
        }

        [IsOverride]
        public void OutSetValueFunction(ref TSet<Int32> OutSetValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetSetFunction", OutSetValue, new TSet<Int32> { 1, 2 });

            OutSetValue = SetValue;
        }

        [IsOverride]
        public void SetMapValueFunction(TMap<Int32, Int32> InMapValue)
        {
            MapValue = InMapValue;
        }

        [IsOverride]
        public TMap<Int32, Int32> GetMapValueFunction()
        {
            return MapValue;
        }

        [IsOverride]
        public void OutMapValueFunction(ref TMap<Int32, Int32> OutMapValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetMapFunction", OutMapValue,
                new TMap<Int32, Int32> { { 1, 1 }, { 2, 2 } });

            OutMapValue = MapValue;
        }
    }
}