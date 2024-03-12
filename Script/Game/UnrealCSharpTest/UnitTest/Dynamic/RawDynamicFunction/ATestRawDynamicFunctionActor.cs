using Script.Dynamic;
using Script.Engine;
using Script.Library;
using Script.UnrealCSharpTest;

namespace Script.CoreUObject
{
    [UClass]
    [PathName("/Script/CoreUObject.TestRawDynamicFunctionActor")]
    public class ATestRawDynamicFunctionActor : AActor, IStaticClass, ITestDynamicInterface
    {
        public ATestRawDynamicFunctionActor()
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

            InterfaceValue = this;

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
        public bool BoolValue
        {
            get => FPropertyImplementation.FProperty_GetObjectBooleanPropertyImplementation(GarbageCollectionHandle,
                __BoolValue);

            set => FPropertyImplementation.FProperty_SetObjectBooleanPropertyImplementation(GarbageCollectionHandle,
                __BoolValue, value);
        }

        [UProperty]
        public sbyte Int8Value
        {
            get => FPropertyImplementation.FProperty_GetObjectSBytePropertyImplementation(GarbageCollectionHandle,
                __Int8Value);

            set => FPropertyImplementation.FProperty_SetObjectSBytePropertyImplementation(GarbageCollectionHandle,
                __Int8Value, value);
        }

        [UProperty]
        public short Int16Value
        {
            get => FPropertyImplementation.FProperty_GetObjectInt16PropertyImplementation(GarbageCollectionHandle,
                __Int16Value);

            set => FPropertyImplementation.FProperty_SetObjectInt16PropertyImplementation(GarbageCollectionHandle,
                __Int16Value, value);
        }

        [UProperty]
        public int Int32Value
        {
            get => FPropertyImplementation.FProperty_GetObjectInt32PropertyImplementation(GarbageCollectionHandle,
                __Int32Value);

            set => FPropertyImplementation.FProperty_SetObjectInt32PropertyImplementation(GarbageCollectionHandle,
                __Int32Value, value);
        }

        [UProperty]
        public long Int64Value
        {
            get => FPropertyImplementation.FProperty_GetObjectInt64PropertyImplementation(GarbageCollectionHandle,
                __Int64Value);

            set => FPropertyImplementation.FProperty_SetObjectInt64PropertyImplementation(GarbageCollectionHandle,
                __Int64Value, value);
        }

        [UProperty]
        public byte UInt8Value
        {
            get => FPropertyImplementation.FProperty_GetObjectBytePropertyImplementation(GarbageCollectionHandle,
                __UInt8Value);

            set => FPropertyImplementation.FProperty_SetObjectBytePropertyImplementation(GarbageCollectionHandle,
                __UInt8Value, value);
        }

        [UProperty]
        public ushort UInt16Value
        {
            get => FPropertyImplementation.FProperty_GetObjectUInt16PropertyImplementation(GarbageCollectionHandle,
                __UInt16Value);

            set => FPropertyImplementation.FProperty_SetObjectUInt16PropertyImplementation(GarbageCollectionHandle,
                __UInt16Value, value);
        }

        [UProperty]
        public uint UInt32Value
        {
            get => FPropertyImplementation.FProperty_GetObjectUInt32PropertyImplementation(GarbageCollectionHandle,
                __UInt32Value);

            set => FPropertyImplementation.FProperty_SetObjectUInt32PropertyImplementation(GarbageCollectionHandle,
                __UInt32Value, value);
        }

        [UProperty]
        public ulong UInt64Value
        {
            get => FPropertyImplementation.FProperty_GetObjectUInt64PropertyImplementation(GarbageCollectionHandle,
                __UInt64Value);

            set => FPropertyImplementation.FProperty_SetObjectUInt64PropertyImplementation(GarbageCollectionHandle,
                __UInt64Value, value);
        }

        [UProperty]
        public float FloatValue
        {
            get => FPropertyImplementation.FProperty_GetObjectSinglePropertyImplementation(GarbageCollectionHandle,
                __FloatValue);

            set => FPropertyImplementation.FProperty_SetObjectSinglePropertyImplementation(GarbageCollectionHandle,
                __FloatValue, value);
        }

        [UProperty]
        public double DoubleValue
        {
            get => FPropertyImplementation.FProperty_GetObjectDoublePropertyImplementation(GarbageCollectionHandle,
                __DoubleValue);

            set => FPropertyImplementation.FProperty_SetObjectDoublePropertyImplementation(GarbageCollectionHandle,
                __DoubleValue, value);
        }

        [UProperty]
        public FName NameValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __NameValue) as FName;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __NameValue, value);
        }

        [UProperty]
        public FText TextValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __TextValue) as FText;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __TextValue, value);
        }

        [UProperty]
        public FString StringValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __StringValue) as FString;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __StringValue, value);
        }

        [UProperty]
        public ETestDynamicEnum EnumValue
        {
            get => (ETestDynamicEnum)FPropertyImplementation.FProperty_GetObjectInt32PropertyImplementation(
                GarbageCollectionHandle, __EnumValue);

            set => FPropertyImplementation.FProperty_SetObjectInt32PropertyImplementation(GarbageCollectionHandle,
                __EnumValue, (int)value);
        }

        [UProperty]
        public FTestDynamicStruct StructValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __StructValue) as FTestDynamicStruct;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __StructValue, value);
        }

        [UProperty]
        public UObject ObjectValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __ObjectValue) as UObject;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __ObjectValue, value);
        }

        [UProperty]
        public TScriptInterface<ITestDynamicInterface> InterfaceValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __InterfaceValue) as TScriptInterface<ITestDynamicInterface>;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __InterfaceValue, value);
        }

        [UProperty]
        public TSubclassOf<UObject> SubclassOfValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __SubclassOfValue) as TSubclassOf<UObject>;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __SubclassOfValue, value);
        }

        [UProperty]
        public TWeakObjectPtr<UObject> WeakObjectPtrValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __WeakObjectPtrValue) as TWeakObjectPtr<UObject>;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __WeakObjectPtrValue, value);
        }

        [UProperty]
        public TLazyObjectPtr<UObject> LazyObjectPtrValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __LazyObjectPtrValue) as TLazyObjectPtr<UObject>;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __LazyObjectPtrValue, value);
        }

        [UProperty]
        public TSoftObjectPtr<UObject> SoftObjectPtrValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __SoftObjectPtrValue) as TSoftObjectPtr<UObject>;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __SoftObjectPtrValue, value);
        }

        [UProperty]
        public TSoftClassPtr<UObject> SoftClassPtrValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __SoftClassPtrValue) as TSoftClassPtr<UObject>;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __SoftClassPtrValue, value);
        }

        [UProperty]
        public TArray<int> ArrayValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __ArrayValue) as TArray<int>;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __ArrayValue, value);
        }

        [UProperty]
        public TSet<int> SetValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __SetValue) as TSet<int>;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __SetValue, value);
        }

        [UProperty]
        public TMap<int, int> MapValue
        {
            get => FPropertyImplementation.FProperty_GetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __MapValue) as TMap<int, int>;

            set => FPropertyImplementation.FProperty_SetObjectCompoundPropertyImplementation(GarbageCollectionHandle,
                __MapValue, value);
        }

        [UProperty]
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
                "/Script/CoreUObject.TestRawDynamicFunctionActor");
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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetBoolFunction", OutBoolValue, true);

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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetInt8Function", OutInt8Value, (sbyte)12);

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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetInt16Function", OutInt16Value, (short)12);

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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetInt32Function", OutInt32Value, (int)12);

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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetInt64Function", OutInt64Value, (long)12);

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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetUInt8Function", OutUInt8Value, (byte)12);

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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetUInt16Function", OutUInt16Value, (ushort)12);

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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetUInt32Function", OutUInt32Value, (uint)12);

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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetUInt64Function", OutUInt64Value, (ulong)12);

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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetFloatFunction", OutFloatValue, 12.3f);

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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetDoubleFunction", OutDoubleValue, 12.3);

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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetNameFunction", OutNameValue, new FName("Name12"));

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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetTextFunction", OutTextValue, new FText("Text12"));

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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetStringFunction", OutStringValue, new FString("String12"));

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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetEnumFunction", OutEnumValue, ETestDynamicEnum.TestDynamicOne);

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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetStructFunction", OutStructValue,
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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetObjectFunction", OutObjectValue, this);

            OutObjectValue = ObjectValue;
        }

        [UFunction]
        public void SetInterfaceValueFunction(TScriptInterface<ITestDynamicInterface> InInterfaceValue)
        {
            InterfaceValue = InInterfaceValue;
        }

        [UFunction]
        public TScriptInterface<ITestDynamicInterface> GetInterfaceValueFunction()
        {
            return InterfaceValue;
        }

        [UFunction]
        public void OutInterfaceValueFunction(ref TScriptInterface<ITestDynamicInterface> OutInterfaceValue)
        {
            TestCoreSubsystem.TestEqual("RawDynamicOutGetInterfaceFunction", OutInterfaceValue, InterfaceValue);

            OutInterfaceValue = InterfaceValue;
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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetSubclassOfFunction", OutSubclassOfValue, GetClass());

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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetSoftObjectPtrFunction", OutSoftObjectPtrValue, this);

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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetSoftClassPtrFunction", OutSoftClassPtrValue, GetClass());

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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetArrayFunction", OutArrayValue, new TArray<int> { 1, 2 });

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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetSetFunction", OutSetValue, new TSet<int> { 1, 2 });

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
            TestCoreSubsystem.TestEqual("RawDynamicOutGetMapFunction", OutMapValue,
                new TMap<int, int> { { 1, 1 }, { 2, 2 } });

            OutMapValue = MapValue;
        }

        private static uint __BoolValue = 0;

        private static uint __Int8Value = 0;

        private static uint __Int16Value = 0;

        private static uint __Int32Value = 0;

        private static uint __Int64Value = 0;

        private static uint __UInt8Value = 0;

        private static uint __UInt16Value = 0;

        private static uint __UInt32Value = 0;

        private static uint __UInt64Value = 0;

        private static uint __FloatValue = 0;

        private static uint __DoubleValue = 0;

        private static uint __NameValue = 0;

        private static uint __TextValue = 0;

        private static uint __StringValue = 0;

        private static uint __EnumValue = 0;

        private static uint __StructValue = 0;

        private static uint __ObjectValue = 0;

        private static uint __InterfaceValue = 0;

        private static uint __SubclassOfValue = 0;

        private static uint __WeakObjectPtrValue = 0;

        private static uint __LazyObjectPtrValue = 0;

        private static uint __SoftObjectPtrValue = 0;

        private static uint __SoftClassPtrValue = 0;

        private static uint __ArrayValue = 0;

        private static uint __SetValue = 0;

        private static uint __MapValue = 0;

        private static uint __TestCoreSubsystem = 0;
    }
}