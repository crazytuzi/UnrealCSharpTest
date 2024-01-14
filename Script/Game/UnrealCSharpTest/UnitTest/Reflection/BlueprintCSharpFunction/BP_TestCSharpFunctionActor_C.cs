using Script.Common;
using Script.CoreUObject;
using Script.Game.UnitTest.Core;

namespace Script.Game.UnitTest.Reflection
{
    [Override]
    public partial class BP_TestCSharpFunctionActor_C
    {
        [Override]
        public void SetBoolValueFunction(bool InBoolValue = false)
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
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetBoolFunction", OutBoolValue, true);

            OutBoolValue = BoolValue;
        }

        [Override]
        public void SetInt32ValueFunction(int InInt32Value = 0)
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
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetInt32Function", OutInt32Value, (int)12);

            OutInt32Value = Int32Value;
        }

        [Override]
        public void SetInt64ValueFunction(long InInt64Value = 0)
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
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetInt64Function", OutInt64Value, (long)12);

            OutInt64Value = Int64Value;
        }

        [Override]
        public void SetUInt8ValueFunction(byte InUInt8Value = 0)
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
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetUInt8Function", OutUInt8Value, (byte)12);

            OutUInt8Value = UInt8Value;
        }

        [Override]
        public void SetDoubleValueFunction(double InDoubleValue = 0)
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
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetDoubleFunction", OutDoubleValue, 12.3);

            OutDoubleValue = DoubleValue;
        }

        [Override]
        public void SetNameValueFunction(FName InNameValue = null)
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
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetNameFunction", OutNameValue, "Name12");

            OutNameValue = NameValue;
        }

        [Override]
        public void SetTextValueFunction(FText InTextValue = null)
        {
            TextValue = InTextValue;
        }

        [Override]
        public FText GetTextValueFunction()
        {
            return TextValue;
        }

        [Override]
        public void OutTextValueFunction(ref FText OutTextValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetTextFunction", OutTextValue, "Text12");

            OutTextValue = TextValue;
        }

        [Override]
        public void SetStringValueFunction(FString InStringValue = null)
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
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetStringFunction", OutStringValue, "String12");

            OutStringValue = StringValue;
        }

        [Override]
        public void SetEnumValueFunction(BP_TestEnum InEnumValue = BP_TestEnum.BlueprintTestEnumZero)
        {
            EnumValue = InEnumValue;
        }

        [Override]
        public BP_TestEnum GetEnumValueFunction()
        {
            return EnumValue;
        }

        [Override]
        public void OutEnumValueFunction(ref BP_TestEnum OutEnumValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetEnumFunction", OutEnumValue,
                BP_TestEnum.BlueprintTestEnumOne);

            OutEnumValue = EnumValue;
        }

        [Override]
        public void SetStructValueFunction(BP_TestStruct InStructValue = null)
        {
            StructValue = InStructValue;
        }

        [Override]
        public BP_TestStruct GetStructValueFunction()
        {
            return StructValue;
        }

        [Override]
        public void OutStructValueFunction(ref BP_TestStruct OutStructValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetStructFunction", OutStructValue,
                new BP_TestStruct { Value = 1 });

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
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetObjectFunction", OutObjectValue, this);

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
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetClassFunction", OutClassValue, GetClass());

            OutClassValue = ClassValue;
        }

        [Override]
        public void SetInterfaceValueFunction(TScriptInterface<IBP_TestInterface_C> InInterfaceValue)
        {
            InterfaceValue = InInterfaceValue;
        }

        [Override]
        public TScriptInterface<IBP_TestInterface_C> GetInterfaceValueFunction()
        {
            return InterfaceValue;
        }

        [Override]
        public void OutInterfaceValueFunction(ref TScriptInterface<IBP_TestInterface_C> OutInterfaceValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetInterfaceFunction", OutInterfaceValue, InterfaceValue);

            OutInterfaceValue = InterfaceValue;
        }

        [Override]
        public void SetSoftObjectPtrValueFunction(TSoftObjectPtr<UObject> InSoftObjectPtrValue = null)
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
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetSoftObjectPtrFunction", OutSoftObjectPtrValue, this);

            OutSoftObjectPtrValue = SoftObjectPtrValue;
        }

        [Override]
        public void SetSoftClassPtrValueFunction(TSoftClassPtr<UObject> InSoftClassPtrValue = null)
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
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetSoftClassPtrFunction", OutSoftClassPtrValue, GetClass());

            OutSoftClassPtrValue = SoftClassPtrValue;
        }

        [Override]
        public void SetArrayValueFunction(ref TArray<int> InArrayValue)
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
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetArrayFunction", OutArrayValue,
                new TArray<int> { 1, 2 });

            OutArrayValue = ArrayValue;
        }

        [Override]
        public void SetSetValueFunction(TSet<int> InSetValue = null)
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
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetSetFunction", OutSetValue, new TSet<int> { 1, 2 });

            OutSetValue = SetValue;
        }

        [Override]
        public void SetMapValueFunction(TMap<int, int> InMapValue = null)
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
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetMapFunction", OutMapValue,
                new TMap<int, int> { { 1, 1 }, { 2, 2 } });

            OutMapValue = MapValue;
        }
    }
}