using Script.Common;
using Script.Dynamic;
using Script.Game.UnitTest.Core;
using Script.Library;
using Script.UnrealCSharpTest;

namespace Script.CoreUObject
{
    [UClass]
    [PathName("/Script/CoreUObject.CSharp_TestBlueprintBlueprintDynamicFunctionActor_C")]
    public class CSharp_TestBlueprintBlueprintDynamicFunctionActor_C : BP_TestClass_C, IStaticClass
    {
        public CSharp_TestBlueprintBlueprintDynamicFunctionActor_C()
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
        public bool BoolValue
        {
            get => FPropertyImplementation.FProperty_GetObjectBooleanPropertyImplementation(GarbageCollectionHandle,
                __BoolValue);

            set => FPropertyImplementation.FProperty_SetObjectBooleanPropertyImplementation(GarbageCollectionHandle,
                __BoolValue, value);
        }

        [UProperty, BlueprintReadWrite]
        public int Int32Value
        {
            get => FPropertyImplementation.FProperty_GetObjectInt32PropertyImplementation(GarbageCollectionHandle,
                __Int32Value);

            set => FPropertyImplementation.FProperty_SetObjectInt32PropertyImplementation(GarbageCollectionHandle,
                __Int32Value, value);
        }

        [UProperty, BlueprintReadWrite]
        public long Int64Value
        {
            get => FPropertyImplementation.FProperty_GetObjectInt64PropertyImplementation(GarbageCollectionHandle,
                __Int64Value);

            set => FPropertyImplementation.FProperty_SetObjectInt64PropertyImplementation(GarbageCollectionHandle,
                __Int64Value, value);
        }

        [UProperty, BlueprintReadWrite]
        public byte UInt8Value
        {
            get => FPropertyImplementation.FProperty_GetObjectBytePropertyImplementation(GarbageCollectionHandle,
                __UInt8Value);

            set => FPropertyImplementation.FProperty_SetObjectBytePropertyImplementation(GarbageCollectionHandle,
                __UInt8Value, value);
        }

        [UProperty, BlueprintReadWrite]
        public double DoubleValue
        {
            get => FPropertyImplementation.FProperty_GetObjectDoublePropertyImplementation(GarbageCollectionHandle,
                __DoubleValue);

            set => FPropertyImplementation.FProperty_SetObjectDoublePropertyImplementation(GarbageCollectionHandle,
                __DoubleValue, value);
        }

        [UProperty, BlueprintReadWrite]
        public FName NameValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __NameValue) as FName;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __NameValue, value);
        }

        [UProperty, BlueprintReadWrite]
        public FText TextValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __TextValue) as FText;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __TextValue, value);
        }

        [UProperty, BlueprintReadWrite]
        public FString StringValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __StringValue) as FString;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __StringValue, value);
        }

        [UProperty, BlueprintReadWrite]
        public ETestDynamicEnum EnumValue
        {
            get => (ETestDynamicEnum)FPropertyImplementation.FProperty_GetObjectInt32PropertyImplementation(
                GarbageCollectionHandle, __EnumValue);

            set => FPropertyImplementation.FProperty_SetObjectInt32PropertyImplementation(GarbageCollectionHandle,
                __EnumValue, (int)value);
        }

        [UProperty, BlueprintReadWrite]
        public FTestDynamicStruct StructValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __StructValue) as FTestDynamicStruct;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __StructValue, value);
        }

        [UProperty, BlueprintReadWrite]
        public UObject ObjectValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __ObjectValue) as UObject;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __ObjectValue, value);
        }

        [UProperty, BlueprintReadWrite]
        public TSubclassOf<UObject> SubclassOfValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __SubclassOfValue) as TSubclassOf<UObject>;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __SubclassOfValue, value);
        }

        [UProperty, BlueprintReadWrite]
        public TSoftObjectPtr<UObject> SoftObjectPtrValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __SoftObjectPtrValue) as TSoftObjectPtr<UObject>;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __SoftObjectPtrValue, value);
        }

        [UProperty, BlueprintReadWrite]
        public TSoftClassPtr<UObject> SoftClassPtrValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __SoftClassPtrValue) as TSoftClassPtr<UObject>;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __SoftClassPtrValue, value);
        }

        [UProperty, BlueprintReadWrite]
        public TArray<int> ArrayValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __ArrayValue) as TArray<int>;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __ArrayValue, value);
        }

        [UProperty, BlueprintReadWrite]
        public TSet<int> SetValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __SetValue) as TSet<int>;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __SetValue, value);
        }

        [UProperty, BlueprintReadWrite]
        public TMap<int, int> MapValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __MapValue) as TMap<int, int>;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __MapValue, value);
        }

        [UProperty, BlueprintReadWrite]
        public UTestCoreSubsystem TestCoreSubsystem
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __TestCoreSubsystem) as UTestCoreSubsystem;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __TestCoreSubsystem, value);
        }

        public new static UClass StaticClass()
        {
            return UObjectImplementation.UObject_StaticClassImplementation(
                "/Script/CoreUObject.CSharp_TestBlueprintBlueprintDynamicFunctionActor_C");
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
            TestCoreSubsystem.TestEqual("BlueprintBlueprintDynamicOutGetBoolFunction", OutBoolValue, true);

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
            TestCoreSubsystem.TestEqual("BlueprintBlueprintDynamicOutGetInt32Function", OutInt32Value, (int)12);

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
            TestCoreSubsystem.TestEqual("BlueprintBlueprintDynamicOutGetInt64Function", OutInt64Value, (long)12);

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
            TestCoreSubsystem.TestEqual("BlueprintBlueprintDynamicOutGetUInt8Function", OutUInt8Value, (byte)12);

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
            TestCoreSubsystem.TestEqual("BlueprintBlueprintDynamicOutGetDoubleFunction", OutDoubleValue, 12.3);

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
            TestCoreSubsystem.TestEqual("BlueprintBlueprintDynamicOutGetNameFunction", OutNameValue,
                new FName("Name12"));

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
            TestCoreSubsystem.TestEqual("BlueprintBlueprintDynamicOutGetTextFunction", OutTextValue,
                new FText("Text12"));

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
            TestCoreSubsystem.TestEqual("BlueprintBlueprintDynamicOutGetStringFunction", OutStringValue,
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
            TestCoreSubsystem.TestEqual("BlueprintBlueprintDynamicOutGetEnumFunction", OutEnumValue,
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
            TestCoreSubsystem.TestEqual("BlueprintBlueprintDynamicOutGetStructFunction", OutStructValue,
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
            TestCoreSubsystem.TestEqual("BlueprintBlueprintDynamicOutGetObjectFunction", OutObjectValue, this);

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
            TestCoreSubsystem.TestEqual("BlueprintBlueprintDynamicOutGetClassFunction", OutSubclassOfValue, GetClass());

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
            TestCoreSubsystem.TestEqual("BlueprintBlueprintDynamicOutGetSoftObjectPtrFunction", OutSoftObjectPtrValue,
                this);

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
            TestCoreSubsystem.TestEqual("BlueprintBlueprintDynamicOutGetSoftClassPtrFunction", OutSoftClassPtrValue,
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
            TestCoreSubsystem.TestEqual("BlueprintBlueprintDynamicOutGetArrayFunction", OutArrayValue,
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
            TestCoreSubsystem.TestEqual("BlueprintBlueprintDynamicOutGetSetFunction", OutSetValue,
                new TSet<int> { 1, 2 });

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
            TestCoreSubsystem.TestEqual("BlueprintBlueprintDynamicOutGetMapFunction", OutMapValue,
                new TMap<int, int> { { 1, 1 }, { 2, 2 } });

            OutMapValue = MapValue;
        }

        private static uint __BoolValue = 0;

        private static uint __Int32Value = 0;

        private static uint __Int64Value = 0;

        private static uint __UInt8Value = 0;

        private static uint __DoubleValue = 0;

        private static uint __NameValue = 0;

        private static uint __TextValue = 0;

        private static uint __StringValue = 0;

        private static uint __EnumValue = 0;

        private static uint __StructValue = 0;

        private static uint __ObjectValue = 0;

        private static uint __SubclassOfValue = 0;

        private static uint __SoftObjectPtrValue = 0;

        private static uint __SoftClassPtrValue = 0;

        private static uint __ArrayValue = 0;

        private static uint __SetValue = 0;

        private static uint __MapValue = 0;

        private static uint __TestCoreSubsystem = 0;
    }
}