using Script.Dynamic;
using Script.Game.UnitTest.Core;
using Script.Library;

namespace Script.CoreUObject
{
    [UClass]
    [PathName("/Script/CoreUObject.CSharp_TestBlueprintDynamicPropertyActor_C")]
    public class CSharp_TestBlueprintDynamicPropertyActor_C : BP_TestClass_C, IStaticClass, ITestDynamicInterface
    {
        public CSharp_TestBlueprintDynamicPropertyActor_C()
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
                __UInt8Value, (byte)value);
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

        public new static UClass StaticClass()
        {
            return UObjectImplementation.UObject_StaticClassImplementation(
                "/Script/CoreUObject.CSharp_TestBlueprintDynamicPropertyActor_C");
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
    }
}