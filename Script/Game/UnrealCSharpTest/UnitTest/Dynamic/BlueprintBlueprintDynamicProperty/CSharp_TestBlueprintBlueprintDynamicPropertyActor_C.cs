using Script.Dynamic;
using Script.Game.UnitTest.Core;
using Script.Library;

namespace Script.CoreUObject
{
    [UClass]
    [PathName("/Script/CoreUObject.CSharp_TestBlueprintBlueprintDynamicPropertyActor_C")]
    public class CSharp_TestBlueprintBlueprintDynamicPropertyActor_C : BP_TestClass_C, IStaticClass
    {
        public CSharp_TestBlueprintBlueprintDynamicPropertyActor_C()
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
                __UInt8Value, (byte)value);
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

        public new static UClass StaticClass()
        {
            return UObjectImplementation.UObject_StaticClassImplementation(
                "/Script/CoreUObject.CSharp_TestBlueprintBlueprintDynamicPropertyActor_C");
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
    }
}