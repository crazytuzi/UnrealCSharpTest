using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestBlueprintDynamicProperty()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            var PropertyActor = GetWorld().SpawnActor<CSharp_TestBlueprintDynamicPropertyActor_C>(new FTransform());

            // Bool
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetBoolProperty", PropertyActor.BoolValue, true);

            PropertyActor.BoolValue = false;

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetBoolProperty", PropertyActor.BoolValue, false);

            // Int8
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetInt8Property", PropertyActor.Int8Value, (sbyte)12);

            PropertyActor.Int8Value = 21;

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetInt8Property", PropertyActor.Int8Value, (sbyte)21);

            // Int16
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetInt16Property", PropertyActor.Int16Value, (short)12);

            PropertyActor.Int16Value = 21;

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetInt16Property", PropertyActor.Int16Value, (short)21);

            // Int32
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetInt32Property", PropertyActor.Int32Value, (int)12);

            PropertyActor.Int32Value = 21;

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetInt32Property", PropertyActor.Int32Value, (int)21);

            // Int64
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetInt64Property", PropertyActor.Int64Value, (long)12);

            PropertyActor.Int64Value = 21;

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetInt64Property", PropertyActor.Int64Value, (long)21);

            // UInt8
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetUInt8Property", PropertyActor.UInt8Value, (byte)12);

            PropertyActor.UInt8Value = 21;

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetUInt8Property", PropertyActor.UInt8Value, (byte)21);

            // UInt16
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetUInt16Property", PropertyActor.UInt16Value, (ushort)12);

            PropertyActor.UInt16Value = 21;

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetUInt16Property", PropertyActor.UInt16Value, (ushort)21);

            // UInt32
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetUInt32Property", PropertyActor.UInt32Value, (uint)12);

            PropertyActor.UInt32Value = 21;

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetUInt32Property", PropertyActor.UInt32Value, (uint)21);

            // UInt64
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetUInt64Property", PropertyActor.UInt64Value, (ulong)12);

            PropertyActor.UInt64Value = 21;

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetUInt64Property", PropertyActor.UInt64Value, (ulong)21);

            // Float
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetFloatProperty", PropertyActor.FloatValue, 12.3f);

            PropertyActor.FloatValue = 3.21f;

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetFloatProperty", PropertyActor.FloatValue, 3.21f);

            // Double
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetDoubleProperty", PropertyActor.DoubleValue, 12.3);

            PropertyActor.DoubleValue = 3.21;

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetDoubleProperty", PropertyActor.DoubleValue, 3.21);

            // FName
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetNameProperty", PropertyActor.NameValue, "Name12");

            PropertyActor.NameValue = "21emaN";

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetNameProperty", PropertyActor.NameValue, "21emaN");

            // FText
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetTextProperty", PropertyActor.TextValue, "Text12");

            PropertyActor.TextValue = "21txeT";

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetTextProperty", PropertyActor.TextValue, "21txeT");

            // FString
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetStringProperty", PropertyActor.StringValue, "String12");

            PropertyActor.StringValue = "21gnirtS";

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetStringProperty", PropertyActor.StringValue, "21gnirtS");

            // Enum
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetEnumProperty", PropertyActor.EnumValue,
                ETestDynamicEnum.TestDynamicOne);

            PropertyActor.EnumValue = ETestDynamicEnum.TestDynamicTwo;

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetEnumProperty", PropertyActor.EnumValue,
                ETestDynamicEnum.TestDynamicTwo);

            // UStruct
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetStructProperty", PropertyActor.StructValue,
                new FTestDynamicStruct { Value = 1 });

            PropertyActor.StructValue = new FTestDynamicStruct { Value = 2 };

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetStructProperty", PropertyActor.StructValue,
                new FTestDynamicStruct { Value = 2 });

            // UObject
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetObjectProperty", PropertyActor.ObjectValue,
                PropertyActor);

            PropertyActor.ObjectValue = this;

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetObjectProperty", PropertyActor.ObjectValue, this);

            // TSubclassOf
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetSubclassOfProperty", PropertyActor.SubclassOfValue,
                PropertyActor.GetClass());

            PropertyActor.SubclassOfValue = GetClass();

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetSubclassOfProperty", PropertyActor.SubclassOfValue,
                GetClass());

            // TWeakObjectPtr
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetWeakObjectPtrProperty", PropertyActor.WeakObjectPtrValue,
                PropertyActor);

            PropertyActor.WeakObjectPtrValue = this;

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetWeakObjectPtrProperty", PropertyActor.WeakObjectPtrValue,
                this);

            // TLazyObjectPtr
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetLazyObjectPtrProperty", PropertyActor.LazyObjectPtrValue,
                PropertyActor);

            PropertyActor.LazyObjectPtrValue = this;

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetLazyObjectPtrProperty", PropertyActor.LazyObjectPtrValue,
                this);

            // TSoftObjectPtr
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetSoftObjectPtrProperty", PropertyActor.SoftObjectPtrValue,
                PropertyActor);

            PropertyActor.SoftObjectPtrValue = this;

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetSoftObjectPtrProperty", PropertyActor.SoftObjectPtrValue,
                this);

            // TSoftClassPtrValue
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetSoftClassPtrProperty", PropertyActor.SoftClassPtrValue,
                PropertyActor.GetClass());

            PropertyActor.SoftClassPtrValue = GetClass();

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetSoftClassPtrProperty", PropertyActor.SoftClassPtrValue,
                GetClass());

            // TArray
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetArrayProperty", PropertyActor.ArrayValue,
                new TArray<int> { 1, 2 });

            PropertyActor.ArrayValue = new TArray<int> { 3, 4 };

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetArrayProperty", PropertyActor.ArrayValue,
                new TArray<int> { 3, 4 });

            // TSet
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetSetProperty", PropertyActor.SetValue,
                new TSet<int> { 1, 2 });

            PropertyActor.SetValue = new TSet<int> { 3, 4 };

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetSetProperty", PropertyActor.SetValue,
                new TSet<int> { 3, 4 });

            // TMap
            TestCoreSubsystem.TestEqual("BlueprintDynamicGetMapProperty", PropertyActor.MapValue,
                new TMap<int, int> { { 1, 1 }, { 2, 2 } });

            PropertyActor.MapValue = new TMap<int, int> { { 3, 3 }, { 4, 4 } };

            TestCoreSubsystem.TestEqual("BlueprintDynamicSetMapProperty", PropertyActor.MapValue,
                new TMap<int, int> { { 3, 3 }, { 4, 4 } });
        }
    }
}