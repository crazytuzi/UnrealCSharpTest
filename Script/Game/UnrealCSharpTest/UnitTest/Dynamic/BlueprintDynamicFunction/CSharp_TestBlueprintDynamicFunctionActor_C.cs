using Script.Dynamic;
using Script.Game.UnitTest.Core;
using Script.Library;
using Script.UnrealCSharpTest;

namespace Script.CoreUObject
{
    [UClass]
    public class CSharp_TestBlueprintDynamicFunctionActor_C : BP_TestClass_C, IStaticClass
    {
        public CSharp_TestBlueprintDynamicFunctionActor_C()
        {
            BoolValue = true;

            Int8Value = 12;

            Int16Value = 12;

            Int32Value = 12;

            Int64Value = 12;

            UInt8Value = 12;

            UInt16Value = 12;

            UInt32Value = 12;

            UInt64Value = 12;

            FloatValue = 12.3f;

            DoubleValue = 12.3;

            NameValue = new FName("Name12");

            TextValue = new FText("Text12");

            StringValue = new FString("String12");

            EnumValue = ETestDynamicEnum.TestDynamicOne;

            StructValue = new FTestDynamicStruct { Value = 1 };

            ObjectValue = this;

            SubclassOfValue = GetClass();

            WeakObjectPtrValue = this;

            LazyObjectPtrValue = this;

            SoftObjectPtrValue = this;

            SoftClassPtrValue = GetClass();

            ArrayValue = new TArray<int> { 1, 2 };

            SetValue = new TSet<int> { 1, 2 };

            MapValue = new TMap<int, int> { { 1, 1 }, { 2, 2 } };
        }

        [UProperty]
        public bool BoolValue { get; set; }

        [UProperty]
        public sbyte Int8Value { get; set; }

        [UProperty]
        public short Int16Value { get; set; }

        [UProperty]
        public int Int32Value { get; set; }

        [UProperty]
        public long Int64Value { get; set; }

        [UProperty]
        public byte UInt8Value { get; set; }

        [UProperty]
        public ushort UInt16Value { get; set; }

        [UProperty]
        public uint UInt32Value { get; set; }

        [UProperty]
        public ulong UInt64Value { get; set; }

        [UProperty]
        public float FloatValue { get; set; }

        [UProperty]
        public double DoubleValue { get; set; }
        [UProperty]
        public FName NameValue { get; set; }

        [UProperty]
        public FText TextValue { get; set; }

        [UProperty]
        public FString StringValue { get; set; }
        [UProperty]
        public ETestDynamicEnum EnumValue { get; set; }

        [UProperty]
        public FTestDynamicStruct StructValue { get; set; }

        [UProperty]
        public UObject ObjectValue { get; set; }

        [UProperty]
        public TSubclassOf<UObject> SubclassOfValue { get; set; }

        [UProperty]
        public TWeakObjectPtr<UObject> WeakObjectPtrValue { get; set; }
        [UProperty]
        public TLazyObjectPtr<UObject> LazyObjectPtrValue { get; set; }

        [UProperty]
        public TSoftObjectPtr<UObject> SoftObjectPtrValue { get; set; }

        [UProperty]
        public TSoftClassPtr<UObject> SoftClassPtrValue { get; set; }

        [UProperty]
        public TArray<int> ArrayValue { get; set; }

        [UProperty]
        public TSet<int> SetValue { get; set; }

        [UProperty]
        public TMap<int, int> MapValue { get; set; }

        [UProperty]
        public UTestCoreSubsystem TestCoreSubsystem { get; set; }
        public new static UClass StaticClass()
        {
            return UObjectImplementation.UObject_StaticClassImplementation(
                "/Script/CoreUObject.CSharp_TestBlueprintDynamicFunctionActor_C");
        }

        [UFunction]
        public void SetBoolValueFunction(bool InBoolValue)
        {
            BoolValue = InBoolValue;
        }

        [UFunction]
        public bool GetBoolValueFunction()
        {
            return BoolValue;
        }

        [UFunction]
        public void OutBoolValueFunction(ref bool OutBoolValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetBoolFunction", OutBoolValue, true);

            OutBoolValue = BoolValue;
        }

        [UFunction]
        public void SetInt8ValueFunction(sbyte InInt8Value)
        {
            Int8Value = InInt8Value;
        }

        [UFunction]
        public sbyte GetInt8ValueFunction()
        {
            return Int8Value;
        }

        [UFunction]
        public void OutInt8ValueFunction(ref sbyte OutInt8Value)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetInt8Function", OutInt8Value, (sbyte)12);

            OutInt8Value = Int8Value;
        }

        [UFunction]
        public void SetInt16ValueFunction(short InInt16Value)
        {
            Int16Value = InInt16Value;
        }

        [UFunction]
        public short GetInt16ValueFunction()
        {
            return Int16Value;
        }

        [UFunction]
        public void OutInt16ValueFunction(ref short OutInt16Value)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetInt16Function", OutInt16Value, (short)12);

            OutInt16Value = Int16Value;
        }

        [UFunction]
        public void SetInt32ValueFunction(int InInt32Value)
        {
            Int32Value = InInt32Value;
        }

        [UFunction]
        public int GetInt32ValueFunction()
        {
            return Int32Value;
        }

        [UFunction]
        public void OutInt32ValueFunction(ref int OutInt32Value)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetInt32Function", OutInt32Value, (int)12);

            OutInt32Value = Int32Value;
        }

        [UFunction]
        public void SetInt64ValueFunction(long InInt64Value)
        {
            Int64Value = InInt64Value;
        }

        [UFunction]
        public long GetInt64ValueFunction()
        {
            return Int64Value;
        }

        [UFunction]
        public void OutInt64ValueFunction(ref long OutInt64Value)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetInt64Function", OutInt64Value, (long)12);

            OutInt64Value = Int64Value;
        }

        [UFunction]
        public void SetUInt8ValueFunction(byte InUInt8Value)
        {
            UInt8Value = InUInt8Value;
        }

        [UFunction]
        public byte GetUInt8ValueFunction()
        {
            return UInt8Value;
        }

        [UFunction]
        public void OutUInt8ValueFunction(ref byte OutUInt8Value)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetUInt8Function", OutUInt8Value, (byte)12);

            OutUInt8Value = UInt8Value;
        }

        [UFunction]
        public void SetUInt16ValueFunction(ushort InUInt16Value)
        {
            UInt16Value = InUInt16Value;
        }

        [UFunction]
        public ushort GetUInt16ValueFunction()
        {
            return UInt16Value;
        }

        [UFunction]
        public void OutUInt16ValueFunction(ref ushort OutUInt16Value)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetUInt16Function", OutUInt16Value, (ushort)12);

            OutUInt16Value = UInt16Value;
        }

        [UFunction]
        public void SetUInt32ValueFunction(uint InUInt32Value)
        {
            UInt32Value = InUInt32Value;
        }

        [UFunction]
        public uint GetUInt32ValueFunction()
        {
            return UInt32Value;
        }

        [UFunction]
        public void OutUInt32ValueFunction(ref uint OutUInt32Value)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetUInt32Function", OutUInt32Value, (uint)12);

            OutUInt32Value = UInt32Value;
        }

        [UFunction]
        public void SetUInt64ValueFunction(ulong InUInt64Value)
        {
            UInt64Value = InUInt64Value;
        }

        [UFunction]
        public ulong GetUInt64ValueFunction()
        {
            return UInt64Value;
        }

        [UFunction]
        public void OutUInt64ValueFunction(ref ulong OutUInt64Value)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetUInt64Function", OutUInt64Value, (ulong)12);

            OutUInt64Value = UInt64Value;
        }

        [UFunction]
        public void SetFloatValueFunction(float InFloatValue)
        {
            FloatValue = InFloatValue;
        }

        [UFunction]
        public float GetFloatValueFunction()
        {
            return FloatValue;
        }

        [UFunction]
        public void OutFloatValueFunction(ref float OutFloatValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetFloatFunction", OutFloatValue, 12.3f);

            OutFloatValue = FloatValue;
        }

        [UFunction]
        public void SetDoubleValueFunction(double InDoubleValue)
        {
            DoubleValue = InDoubleValue;
        }

        [UFunction]
        public double GetDoubleValueFunction()
        {
            return DoubleValue;
        }

        [UFunction]
        public void OutDoubleValueFunction(ref double OutDoubleValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetDoubleFunction", OutDoubleValue, 12.3);

            OutDoubleValue = DoubleValue;
        }

        [UFunction]
        public void SetNameValueFunction(FName InNameValue)
        {
            NameValue = InNameValue;
        }

        [UFunction]
        public FName GetNameValueFunction()
        {
            return NameValue;
        }

        [UFunction]
        public void OutNameValueFunction(ref FName OutNameValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetNameFunction", OutNameValue, new FName("Name12"));

            OutNameValue = NameValue;
        }

        [UFunction]
        public void SetTextValueFunction(FText InTextValue)
        {
            TextValue = InTextValue;
        }

        [UFunction]
        public FText GetTextValueFunction()
        {
            return TextValue;
        }

        [UFunction]
        public void OutTextValueFunction(ref FText OutTextValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetTextFunction", OutTextValue, new FText("Text12"));

            OutTextValue = TextValue;
        }

        [UFunction]
        public void SetStringValueFunction(FString InStringValue)
        {
            StringValue = InStringValue;
        }

        [UFunction]
        public FString GetStringValueFunction()
        {
            return StringValue;
        }

        [UFunction]
        public void OutStringValueFunction(ref FString OutStringValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetStringFunction", OutStringValue,
                new FString("String12"));

            OutStringValue = StringValue;
        }

        [UFunction]
        public void SetEnumValueFunction(ETestDynamicEnum InEnumValue)
        {
            EnumValue = InEnumValue;
        }

        [UFunction]
        public ETestDynamicEnum GetEnumValueFunction()
        {
            return EnumValue;
        }

        [UFunction]
        public void OutEnumValueFunction(ref ETestDynamicEnum OutEnumValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetEnumFunction", OutEnumValue,
                ETestDynamicEnum.TestDynamicOne);

            OutEnumValue = EnumValue;
        }

        [UFunction]
        public void SetStructValueFunction(FTestDynamicStruct InStructValue)
        {
            StructValue = InStructValue;
        }

        [UFunction]
        public FTestDynamicStruct GetStructValueFunction()
        {
            return StructValue;
        }

        [UFunction]
        public void OutStructValueFunction(ref FTestDynamicStruct OutStructValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetStructFunction", OutStructValue,
                new FTestDynamicStruct { Value = 1 });

            OutStructValue = StructValue;
        }

        [UFunction]
        public void SetObjectValueFunction(UObject InObjectValue)
        {
            ObjectValue = InObjectValue;
        }

        [UFunction]
        public UObject GetObjectValueFunction()
        {
            return ObjectValue;
        }

        [UFunction]
        public void OutObjectValueFunction(ref UObject OutObjectValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetObjectFunction", OutObjectValue, this);

            OutObjectValue = ObjectValue;
        }

        [UFunction]
        public void SetSubclassOfValueFunction(TSubclassOf<UObject> InSubclassOfValue)
        {
            SubclassOfValue = InSubclassOfValue;
        }

        [UFunction]
        public TSubclassOf<UObject> GetSubclassOfValueFunction()
        {
            return SubclassOfValue;
        }

        [UFunction]
        public void OutSubclassOfValueFunction(ref TSubclassOf<UObject> OutSubclassOfValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetClassFunction", OutSubclassOfValue, GetClass());

            OutSubclassOfValue = SubclassOfValue;
        }

        [UFunction]
        public TWeakObjectPtr<UObject> GetWeakObjectPtrValueFunction()
        {
            return WeakObjectPtrValue;
        }

        [UFunction]
        public void SetSoftObjectPtrValueFunction(TSoftObjectPtr<UObject> InSoftObjectPtrValue)
        {
            SoftObjectPtrValue = InSoftObjectPtrValue;
        }

        [UFunction]
        public TSoftObjectPtr<UObject> GetSoftObjectPtrValueFunction()
        {
            return SoftObjectPtrValue;
        }

        [UFunction]
        public void OutSoftObjectPtrValueFunction(ref TSoftObjectPtr<UObject> OutSoftObjectPtrValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetSoftObjectPtrFunction", OutSoftObjectPtrValue, this);

            OutSoftObjectPtrValue = SoftObjectPtrValue;
        }

        [UFunction]
        public void SetSoftClassPtrValueFunction(TSoftClassPtr<UObject> InSoftClassPtrValue)
        {
            SoftClassPtrValue = InSoftClassPtrValue;
        }

        [UFunction]
        public TSoftClassPtr<UObject> GetSoftClassPtrValueFunction()
        {
            return SoftClassPtrValue;
        }

        [UFunction]
        public void OutSoftClassPtrValueFunction(ref TSoftClassPtr<UObject> OutSoftClassPtrValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetSoftClassPtrFunction", OutSoftClassPtrValue, GetClass());

            OutSoftClassPtrValue = SoftClassPtrValue;
        }

        [UFunction]
        public void SetArrayValueFunction(TArray<int> InArrayValue)
        {
            ArrayValue = InArrayValue;
        }

        [UFunction]
        public TArray<int> GetArrayValueFunction()
        {
            return ArrayValue;
        }

        [UFunction]
        public void OutArrayValueFunction(ref TArray<int> OutArrayValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetArrayFunction", OutArrayValue, new TArray<int> { 1, 2 });

            OutArrayValue = ArrayValue;
        }

        [UFunction]
        public void SetSetValueFunction(TSet<int> InSetValue)
        {
            SetValue = InSetValue;
        }

        [UFunction]
        public TSet<int> GetSetValueFunction()
        {
            return SetValue;
        }

        [UFunction]
        public void OutSetValueFunction(ref TSet<int> OutSetValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetSetFunction", OutSetValue, new TSet<int> { 1, 2 });

            OutSetValue = SetValue;
        }

        [UFunction]
        public void SetMapValueFunction(TMap<int, int> InMapValue)
        {
            MapValue = InMapValue;
        }

        [UFunction]
        public TMap<int, int> GetMapValueFunction()
        {
            return MapValue;
        }

        [UFunction]
        public void OutMapValueFunction(ref TMap<int, int> OutMapValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintDynamicOutGetMapFunction", OutMapValue,
                new TMap<int, int> { { 1, 1 }, { 2, 2 } });

            OutMapValue = MapValue;
        }
    }
}