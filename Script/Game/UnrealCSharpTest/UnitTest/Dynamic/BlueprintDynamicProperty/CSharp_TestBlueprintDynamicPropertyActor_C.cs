using Script.Dynamic;
using Script.Game.UnitTest.Core;
using Script.Library;

namespace Script.CoreUObject
{
    [UClass]
    public class CSharp_TestBlueprintDynamicPropertyActor_C : BP_TestClass_C, IStaticClass
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

        public new static UClass StaticClass()
        {
            return UObjectImplementation.UObject_StaticClassImplementation(
                "/Script/CoreUObject.CSharp_TestBlueprintDynamicPropertyActor_C");
        }

    }
}