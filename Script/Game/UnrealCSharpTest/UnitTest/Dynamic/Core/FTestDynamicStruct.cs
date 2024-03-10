using Script.Dynamic;
using Script.Library;

namespace Script.CoreUObject
{
    [UStruct, BlueprintType]
    public class FTestDynamicStruct : IStaticStruct, IGarbageCollectionHandle
    {
        public static UScriptStruct StaticStruct()
        {
            return UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.TestDynamicStruct");
        }

        public FTestDynamicStruct() =>
            UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

        ~FTestDynamicStruct() =>
            UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

        public static bool operator ==(FTestDynamicStruct A, FTestDynamicStruct B) =>
            UStructImplementation.UStruct_IdenticalImplementation(StaticStruct().GarbageCollectionHandle,
                A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero);

        public static bool operator !=(FTestDynamicStruct A, FTestDynamicStruct B) =>
            !UStructImplementation.UStruct_IdenticalImplementation(StaticStruct().GarbageCollectionHandle,
                A?.GarbageCollectionHandle ?? nint.Zero, B?.GarbageCollectionHandle ?? nint.Zero);

        public override bool Equals(object Other) => this == Other as FTestDynamicStruct;

        public override int GetHashCode() => (int)GarbageCollectionHandle;

        [UProperty, BlueprintReadWrite]
        public int Value { get; set; }
        public nint GarbageCollectionHandle { get; set; }
    }
}