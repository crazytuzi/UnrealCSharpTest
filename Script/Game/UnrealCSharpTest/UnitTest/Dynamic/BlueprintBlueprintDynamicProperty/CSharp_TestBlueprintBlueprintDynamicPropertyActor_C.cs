using Script.Dynamic;
using Script.Game.UnitTest.Core;
using Script.Library;

namespace Script.CoreUObject
{
    [UClass]
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
        public new static UClass StaticClass()
        {
            return UObjectImplementation.UObject_StaticClassImplementation(
                "/Script/CoreUObject.CSharp_TestBlueprintBlueprintDynamicPropertyActor_C");
        }

    }
}