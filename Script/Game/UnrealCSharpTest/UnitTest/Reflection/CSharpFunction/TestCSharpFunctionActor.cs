using Script.Common;
using Script.CoreUObject;

namespace Script.UnrealCSharpTest
{
    [Override]
    public partial class ATestCSharpFunctionActor
    {
        [Override]
        public void SetBoolValueFunction(bool InBoolValue)
        {
            BoolValue = InBoolValue;
        }

        [Override]
        public bool GetBoolValueFunction()
        {
            return BoolValue;
        }

        [Override]
        public void OutBoolValueFunction(ref bool OutBoolValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetBoolFunction", OutBoolValue, true);

            OutBoolValue = BoolValue;
        }

        [Override]
        public void SetInt32ValueFunction(int InInt32Value)
        {
            Int32Value = InInt32Value;
        }

        [Override]
        public int GetInt32ValueFunction()
        {
            return Int32Value;
        }

        [Override]
        public void OutInt32ValueFunction(ref int OutInt32Value)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetInt32Function", OutInt32Value, (int)12);

            OutInt32Value = Int32Value;
        }

        [Override]
        public void SetInt64ValueFunction(long InInt64Value)
        {
            Int64Value = InInt64Value;
        }

        [Override]
        public long GetInt64ValueFunction()
        {
            return Int64Value;
        }

        [Override]
        public void OutInt64ValueFunction(ref long OutInt64Value)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetInt64Function", OutInt64Value, (long)12);

            OutInt64Value = Int64Value;
        }

        [Override]
        public void SetUInt8ValueFunction(byte InUInt8Value)
        {
            UInt8Value = InUInt8Value;
        }

        [Override]
        public byte GetUInt8ValueFunction()
        {
            return UInt8Value;
        }

        [Override]
        public void OutUInt8ValueFunction(ref byte OutUInt8Value)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetUInt8Function", OutUInt8Value, (byte)12);

            OutUInt8Value = UInt8Value;
        }

        [Override]
        public void SetFloatValueFunction(float InFloatValue)
        {
            FloatValue = InFloatValue;
        }

        [Override]
        public float GetFloatValueFunction()
        {
            return FloatValue;
        }

        [Override]
        public void OutFloatValueFunction(ref float OutFloatValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetFloatFunction", OutFloatValue, 12.3f);

            OutFloatValue = FloatValue;
        }

        [Override]
        public void SetDoubleValueFunction(double InDoubleValue)
        {
            DoubleValue = InDoubleValue;
        }

        [Override]
        public double GetDoubleValueFunction()
        {
            return DoubleValue;
        }

        [Override]
        public void OutDoubleValueFunction(ref double OutDoubleValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetDoubleFunction", OutDoubleValue, 12.3);

            OutDoubleValue = DoubleValue;
        }

        [Override]
        public void SetNameValueFunction(FName InNameValue)
        {
            NameValue = InNameValue;
        }

        [Override]
        public FName GetNameValueFunction()
        {
            return NameValue;
        }

        [Override]
        public void OutNameValueFunction(ref FName OutNameValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetNameFunction", OutNameValue, "Name12");

            OutNameValue = NameValue;
        }

        [Override]
        public FText GetTextValueFunction()
        {
            return TextValue;
        }

        [Override]
        public void SetTextValueFunction(FText InTextValue)
        {
            TextValue = InTextValue;
        }

        [Override]
        public void OutTextValueFunction(ref FText OutTextValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetTextFunction", OutTextValue, "Text12");

            OutTextValue = TextValue;
        }

        [Override]
        public void SetStringValueFunction(FString InStringValue)
        {
            StringValue = InStringValue;
        }

        [Override]
        public FString GetStringValueFunction()
        {
            return StringValue;
        }

        [Override]
        public void OutStringValueFunction(ref FString OutStringValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetStringFunction", OutStringValue, "String12");

            OutStringValue = StringValue;
        }

        [Override]
        public void SetEnumValueFunction(ETestEnum InEnumValue)
        {
            EnumValue = InEnumValue;
        }

        [Override]
        public ETestEnum GetEnumValueFunction()
        {
            return EnumValue;
        }

        [Override]
        public void OutEnumValueFunction(ref ETestEnum OutEnumValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetEnumFunction", OutEnumValue, ETestEnum.TestEnumOne);

            OutEnumValue = EnumValue;
        }

        [Override]
        public void SetEnumClassValueFunction(ETestEnumClass InEnumClassValue)
        {
            EnumClassValue = InEnumClassValue;
        }

        [Override]
        public ETestEnumClass GetEnumClassValueFunction()
        {
            return EnumClassValue;
        }

        [Override]
        public void OutEnumClassValueFunction(ref ETestEnumClass OutEnumClassValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetEnumClassFunction", OutEnumClassValue,
                ETestEnumClass.TestEnumClassOne);

            OutEnumClassValue = EnumClassValue;
        }

        [Override]
        public void SetStructValueFunction(FTestStruct InStructValue)
        {
            StructValue = InStructValue;
        }

        [Override]
        public FTestStruct GetStructValueFunction()
        {
            return StructValue;
        }

        [Override]
        public void OutStructValueFunction(ref FTestStruct OutStructValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetStructFunction", OutStructValue, new FTestStruct { Value = 1 });

            OutStructValue = StructValue;
        }

        [Override]
        public void SetObjectValueFunction(UObject InObjectValue)
        {
            ObjectValue = InObjectValue;
        }

        [Override]
        public UObject GetObjectValueFunction()
        {
            return ObjectValue;
        }

        [Override]
        public void OutObjectValueFunction(ref UObject OutObjectValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetObjectFunction", OutObjectValue, this);

            OutObjectValue = ObjectValue;
        }

        [Override]
        public void SetClassValueFunction(TSubclassOf<UObject> InClassValue)
        {
            ClassValue = InClassValue;
        }

        [Override]
        public TSubclassOf<UObject> GetClassValueFunction()
        {
            return ClassValue;
        }

        [Override]
        public void OutClassValueFunction(ref TSubclassOf<UObject> OutClassValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetClassFunction", OutClassValue, GetClass());

            OutClassValue = ClassValue;
        }

        [Override]
        public void SetInterfaceValueFunction(TScriptInterface<ITestInterface> InInterfaceValue)
        {
            InterfaceValue = InInterfaceValue;
        }

        [Override]
        public TScriptInterface<ITestInterface> GetInterfaceValueFunction()
        {
            return InterfaceValue;
        }

        [Override]
        public void OutInterfaceValueFunction(ref TScriptInterface<ITestInterface> OutInterfaceValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetInterfaceFunction", OutInterfaceValue, InterfaceValue);

            OutInterfaceValue = InterfaceValue;
        }

        [Override]
        public void SetSubclassOfValueFunction(TSubclassOf<UObject> InSubclassOfValue)
        {
            SubclassOfValue = InSubclassOfValue;
        }

        [Override]
        public TSubclassOf<UObject> GetSubclassOfValueFunction()
        {
            return SubclassOfValue;
        }

        [Override]
        public void OutSubclassOfValueFunction(ref TSubclassOf<UObject> OutSubclassOfValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetSubclassOfFunction", OutSubclassOfValue, GetClass());

            OutSubclassOfValue = SubclassOfValue;
        }

        [Override]
        public void SetSoftObjectPtrValueFunction(TSoftObjectPtr<UObject> InSoftObjectPtrValue)
        {
            SoftObjectPtrValue = InSoftObjectPtrValue;
        }

        [Override]
        public TSoftObjectPtr<UObject> GetSoftObjectPtrValueFunction()
        {
            return SoftObjectPtrValue;
        }

        [Override]
        public void OutSoftObjectPtrValueFunction(ref TSoftObjectPtr<UObject> OutSoftObjectPtrValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetSoftObjectPtrFunction", OutSoftObjectPtrValue, this);

            OutSoftObjectPtrValue = SoftObjectPtrValue;
        }

        [Override]
        public void SetSoftClassPtrValueFunction(TSoftClassPtr<UObject> InSoftClassPtrValue)
        {
            SoftClassPtrValue = InSoftClassPtrValue;
        }

        [Override]
        public TSoftClassPtr<UObject> GetSoftClassPtrValueFunction()
        {
            return SoftClassPtrValue;
        }

        [Override]
        public void OutSoftClassPtrValueFunction(ref TSoftClassPtr<UObject> OutSoftClassPtrValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetSoftClassPtrFunction", OutSoftClassPtrValue, GetClass());

            OutSoftClassPtrValue = SoftClassPtrValue;
        }

        [Override]
        public void SetArrayValueFunction(TArray<int> InArrayValue)
        {
            ArrayValue = InArrayValue;
        }

        [Override]
        public TArray<int> GetArrayValueFunction()
        {
            return ArrayValue;
        }

        [Override]
        public void OutArrayValueFunction(ref TArray<int> OutArrayValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetArrayFunction", OutArrayValue, new TArray<int> { 1, 2 });

            OutArrayValue = ArrayValue;
        }

        [Override]
        public void SetSetValueFunction(TSet<int> InSetValue)
        {
            SetValue = InSetValue;
        }

        [Override]
        public TSet<int> GetSetValueFunction()
        {
            return SetValue;
        }

        [Override]
        public void OutSetValueFunction(ref TSet<int> OutSetValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetSetFunction", OutSetValue, new TSet<int> { 1, 2 });

            OutSetValue = SetValue;
        }

        [Override]
        public void SetMapValueFunction(TMap<int, int> InMapValue)
        {
            MapValue = InMapValue;
        }

        [Override]
        public TMap<int, int> GetMapValueFunction()
        {
            return MapValue;
        }

        [Override]
        public void OutMapValueFunction(ref TMap<int, int> OutMapValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetMapFunction", OutMapValue,
                new TMap<int, int> { { 1, 1 }, { 2, 2 } });

            OutMapValue = MapValue;
        }
    }
}