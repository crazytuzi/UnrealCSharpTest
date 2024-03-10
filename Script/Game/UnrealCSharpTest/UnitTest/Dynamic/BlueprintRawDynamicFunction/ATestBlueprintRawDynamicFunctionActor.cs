using Script.Dynamic;
using Script.Engine;
using Script.Library;
using Script.UnrealCSharpTest;

namespace Script.CoreUObject
{
    [UClass]
    public class ATestBlueprintRawDynamicFunctionActor : AActor, IStaticClass
    {
        public ATestBlueprintRawDynamicFunctionActor()
        {
            BoolValue = true;

            Int32Value = 12;

            Int64Value = 12;

            UInt8Value = 12;

            DoubleValue = 12.3;

            NameValue = new FName("Name12");

            TextValue = new FText("Text12");

            StringValue = new FString("String12");

            EnumValue = ETestDynamicEnum.TestDynamicOne;

            StructValue = new FTestDynamicStruct { Value = 1 };

            ObjectValue = this;

            SubclassOfValue = GetClass();

            SoftObjectPtrValue = this;

            SoftClassPtrValue = GetClass();

            ArrayValue = new TArray<int> { 1, 2 };

            SetValue = new TSet<int> { 1, 2 };

            MapValue = new TMap<int, int> { { 1, 1 }, { 2, 2 } };
        }

        [UProperty, BlueprintReadWrite]
        public bool BoolValue { get; set; }

        [UProperty, BlueprintReadWrite]
        public int Int32Value { get; set; }

        [UProperty, BlueprintReadWrite]
        public long Int64Value { get; set; }

        [UProperty, BlueprintReadWrite]
        public byte UInt8Value { get; set; }

        [UProperty, BlueprintReadWrite]
        public double DoubleValue { get; set; }

        [UProperty, BlueprintReadWrite]
        public FName NameValue { get; set; }

        [UProperty, BlueprintReadWrite]
        public FText TextValue { get; set; }

        [UProperty, BlueprintReadWrite]
        public FString StringValue { get; set; }

        [UProperty, BlueprintReadWrite]
        public ETestDynamicEnum EnumValue { get; set; }

        [UProperty, BlueprintReadWrite]
        public FTestDynamicStruct StructValue { get; set; }

        [UProperty, BlueprintReadWrite]
        public UObject ObjectValue { get; set; }

        [UProperty, BlueprintReadWrite]
        public TSubclassOf<UObject> SubclassOfValue { get; set; }

        [UProperty, BlueprintReadWrite]
        public TSoftObjectPtr<UObject> SoftObjectPtrValue { get; set; }

        [UProperty, BlueprintReadWrite]
        public TSoftClassPtr<UObject> SoftClassPtrValue { get; set; }

        [UProperty, BlueprintReadWrite]
        public TArray<int> ArrayValue { get; set; }

        [UProperty, BlueprintReadWrite]
        public TSet<int> SetValue { get; set; }

        [UProperty, BlueprintReadWrite]
        public TMap<int, int> MapValue { get; set; }

        [UProperty, BlueprintReadWrite]
        public UTestCoreSubsystem TestCoreSubsystem { get; set; }

        public new static UClass StaticClass()
        {
            return UObjectImplementation.UObject_StaticClassImplementation(
                "/Script/CoreUObject.TestBlueprintRawDynamicFunctionActor");
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void SetBoolValueFunction(bool InBoolValue)
        {
            BoolValue = InBoolValue;
        }

        [UFunction, BlueprintCallable, BlueprintNativeEvent]
        public bool GetBoolValueFunction()
        {
            return BoolValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void OutBoolValueFunction(ref bool OutBoolValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintRawDynamicOutGetBoolFunction", OutBoolValue, true);

            OutBoolValue = BoolValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void SetInt32ValueFunction(int InInt32Value)
        {
            Int32Value = InInt32Value;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public int GetInt32ValueFunction()
        {
            return Int32Value;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void OutInt32ValueFunction(ref int OutInt32Value)
        {
            TestCoreSubsystem.TestEqual("BlueprintRawDynamicOutGetInt32Function", OutInt32Value, (int)12);

            OutInt32Value = Int32Value;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void SetInt64ValueFunction(long InInt64Value)
        {
            Int64Value = InInt64Value;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public long GetInt64ValueFunction()
        {
            return Int64Value;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void OutInt64ValueFunction(ref long OutInt64Value)
        {
            TestCoreSubsystem.TestEqual("BlueprintRawDynamicOutGetInt64Function", OutInt64Value, (long)12);

            OutInt64Value = Int64Value;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void SetUInt8ValueFunction(byte InUInt8Value)
        {
            UInt8Value = InUInt8Value;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public byte GetUInt8ValueFunction()
        {
            return UInt8Value;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void OutUInt8ValueFunction(ref byte OutUInt8Value)
        {
            TestCoreSubsystem.TestEqual("BlueprintRawDynamicOutGetUInt8Function", OutUInt8Value, (byte)12);

            OutUInt8Value = UInt8Value;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void SetDoubleValueFunction(double InDoubleValue)
        {
            DoubleValue = InDoubleValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public double GetDoubleValueFunction()
        {
            return DoubleValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void OutDoubleValueFunction(ref double OutDoubleValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintRawDynamicOutGetDoubleFunction", OutDoubleValue, 12.3);

            OutDoubleValue = DoubleValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void SetNameValueFunction(FName InNameValue)
        {
            NameValue = InNameValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public FName GetNameValueFunction()
        {
            return NameValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void OutNameValueFunction(ref FName OutNameValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintRawDynamicOutGetNameFunction", OutNameValue, new FName("Name12"));

            OutNameValue = NameValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void SetTextValueFunction(FText InTextValue)
        {
            TextValue = InTextValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public FText GetTextValueFunction()
        {
            return TextValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void OutTextValueFunction(ref FText OutTextValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintRawDynamicOutGetTextFunction", OutTextValue, new FText("Text12"));

            OutTextValue = TextValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void SetStringValueFunction(FString InStringValue)
        {
            StringValue = InStringValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public FString GetStringValueFunction()
        {
            return StringValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void OutStringValueFunction(ref FString OutStringValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintRawDynamicOutGetStringFunction", OutStringValue,
                new FString("String12"));

            OutStringValue = StringValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void SetEnumValueFunction(ETestDynamicEnum InEnumValue)
        {
            EnumValue = InEnumValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public ETestDynamicEnum GetEnumValueFunction()
        {
            return EnumValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void OutEnumValueFunction(ref ETestDynamicEnum OutEnumValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintRawDynamicOutGetEnumFunction", OutEnumValue,
                ETestDynamicEnum.TestDynamicOne);

            OutEnumValue = EnumValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void SetStructValueFunction(FTestDynamicStruct InStructValue)
        {
            StructValue = InStructValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public FTestDynamicStruct GetStructValueFunction()
        {
            return StructValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void OutStructValueFunction(ref FTestDynamicStruct OutStructValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintRawDynamicOutGetStructFunction", OutStructValue,
                new FTestDynamicStruct { Value = 1 });

            OutStructValue = StructValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void SetObjectValueFunction(UObject InObjectValue)
        {
            ObjectValue = InObjectValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public UObject GetObjectValueFunction()
        {
            return ObjectValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void OutObjectValueFunction(ref UObject OutObjectValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintRawDynamicOutGetObjectFunction", OutObjectValue, this);

            OutObjectValue = ObjectValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void SetSubclassOfValueFunction(TSubclassOf<UObject> InSubclassOfValue)
        {
            SubclassOfValue = InSubclassOfValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public TSubclassOf<UObject> GetSubclassOfValueFunction()
        {
            return SubclassOfValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void OutSubclassOfValueFunction(ref TSubclassOf<UObject> OutSubclassOfValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintRawDynamicOutGetClassFunction", OutSubclassOfValue, GetClass());

            OutSubclassOfValue = SubclassOfValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void SetSoftObjectPtrValueFunction(TSoftObjectPtr<UObject> InSoftObjectPtrValue)
        {
            SoftObjectPtrValue = InSoftObjectPtrValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public TSoftObjectPtr<UObject> GetSoftObjectPtrValueFunction()
        {
            return SoftObjectPtrValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void OutSoftObjectPtrValueFunction(ref TSoftObjectPtr<UObject> OutSoftObjectPtrValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintRawDynamicOutGetSoftObjectPtrFunction", OutSoftObjectPtrValue, this);

            OutSoftObjectPtrValue = SoftObjectPtrValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void SetSoftClassPtrValueFunction(TSoftClassPtr<UObject> InSoftClassPtrValue)
        {
            SoftClassPtrValue = InSoftClassPtrValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public TSoftClassPtr<UObject> GetSoftClassPtrValueFunction()
        {
            return SoftClassPtrValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void OutSoftClassPtrValueFunction(ref TSoftClassPtr<UObject> OutSoftClassPtrValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintRawDynamicOutGetSoftClassPtrFunction", OutSoftClassPtrValue,
                GetClass());

            OutSoftClassPtrValue = SoftClassPtrValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void SetArrayValueFunction(TArray<int> InArrayValue)
        {
            ArrayValue = InArrayValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public TArray<int> GetArrayValueFunction()
        {
            return ArrayValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void OutArrayValueFunction(ref TArray<int> OutArrayValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintRawDynamicOutGetArrayFunction", OutArrayValue,
                new TArray<int> { 1, 2 });

            OutArrayValue = ArrayValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void SetSetValueFunction(TSet<int> InSetValue)
        {
            SetValue = InSetValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public TSet<int> GetSetValueFunction()
        {
            return SetValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void OutSetValueFunction(ref TSet<int> OutSetValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintRawDynamicOutGetSetFunction", OutSetValue, new TSet<int> { 1, 2 });

            OutSetValue = SetValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void SetMapValueFunction(TMap<int, int> InMapValue)
        {
            MapValue = InMapValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public TMap<int, int> GetMapValueFunction()
        {
            return MapValue;
        }

        [UFunction, BlueprintCallable, BlueprintImplementableEvent]
        public void OutMapValueFunction(ref TMap<int, int> OutMapValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintRawDynamicOutGetMapFunction", OutMapValue,
                new TMap<int, int> { { 1, 1 }, { 2, 2 } });

            OutMapValue = MapValue;
        }
    }
}