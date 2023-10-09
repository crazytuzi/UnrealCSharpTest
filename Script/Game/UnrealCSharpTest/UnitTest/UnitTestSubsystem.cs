using System;
using Script.Common;
using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    [IsOverride]
    public partial class UUnitTestSubsystem
    {
        [IsOverride]
        public override void Test()
        {
            TestProperty();
        }

        private void TestProperty()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            var PropertyActor = GetWorld().SpawnActor<ATestReflectionPropertyActor>(new FTransform());

            // Bool
            TestCoreSubsystem.TestEqual("ReflectionGetBoolProperty", PropertyActor.BoolValue, true);

            PropertyActor.BoolValue = false;

            TestCoreSubsystem.TestEqual("ReflectionSetBoolProperty", PropertyActor.BoolValue, false);

            // Int8
            TestCoreSubsystem.TestEqual("ReflectionGetInt8Property", PropertyActor.Int8Value, (SByte)12);

            PropertyActor.Int8Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetInt8Property", PropertyActor.Int8Value, (SByte)21);

            // Int16
            TestCoreSubsystem.TestEqual("ReflectionGetInt16Property", PropertyActor.Int16Value, (Int16)12);

            PropertyActor.Int16Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetInt16Property", PropertyActor.Int16Value, (Int16)21);

            // Int32
            TestCoreSubsystem.TestEqual("ReflectionGetInt32Property", PropertyActor.Int32Value, (Int32)12);

            PropertyActor.Int32Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetInt32Property", PropertyActor.Int32Value, (Int32)21);

            // Int64
            TestCoreSubsystem.TestEqual("ReflectionGetInt64Property", PropertyActor.Int64Value, (Int64)12);

            PropertyActor.Int64Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetInt64Property", PropertyActor.Int64Value, (Int64)21);

            // UInt8
            TestCoreSubsystem.TestEqual("ReflectionGetUInt8Property", PropertyActor.UInt8Value, (Byte)12);

            PropertyActor.UInt8Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetUInt8Property", PropertyActor.UInt8Value, (Byte)21);

            // UInt16
            TestCoreSubsystem.TestEqual("ReflectionGetUInt16Property", PropertyActor.UInt16Value, (UInt16)12);

            PropertyActor.UInt16Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetUInt16Property", PropertyActor.UInt16Value, (UInt16)21);

            // UInt32
            TestCoreSubsystem.TestEqual("ReflectionGetUInt32Property", PropertyActor.UInt32Value, (UInt32)12);

            PropertyActor.UInt32Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetUInt32Property", PropertyActor.UInt32Value, (UInt32)21);

            // UInt64
            TestCoreSubsystem.TestEqual("ReflectionGetUInt64Property", PropertyActor.UInt64Value, (UInt64)12);

            PropertyActor.UInt64Value = 21;

            TestCoreSubsystem.TestEqual("ReflectionSetUInt64Property", PropertyActor.UInt64Value, (UInt64)21);

            // Float
            TestCoreSubsystem.TestEqual("ReflectionGetFloatProperty", PropertyActor.FloatValue, 12.3f);

            PropertyActor.FloatValue = 3.21f;

            TestCoreSubsystem.TestEqual("ReflectionSetFloatProperty", PropertyActor.FloatValue, 3.21f);

            // Double
            TestCoreSubsystem.TestEqual("ReflectionGetDoubleProperty", PropertyActor.DoubleValue, 12.3);

            PropertyActor.DoubleValue = 3.21;

            TestCoreSubsystem.TestEqual("ReflectionSetDoubleProperty", PropertyActor.DoubleValue, 3.21);

            // FName
            TestCoreSubsystem.TestEqual("ReflectionGetTextProperty", PropertyActor.NameValue, "Name12");

            PropertyActor.NameValue = "21emaN";

            TestCoreSubsystem.TestEqual("ReflectionSetNameProperty", PropertyActor.NameValue, "21emaN");

            // FText
            TestCoreSubsystem.TestEqual("ReflectionGetTextProperty", PropertyActor.TextValue, "Text12");

            PropertyActor.TextValue = "21txeT";

            TestCoreSubsystem.TestEqual("ReflectionSetTextProperty", PropertyActor.TextValue, "21txeT");

            // FString
            TestCoreSubsystem.TestEqual("ReflectionGetStringProperty", PropertyActor.StringValue, "String12");

            PropertyActor.StringValue = "21gnirtS";

            TestCoreSubsystem.TestEqual("ReflectionSetStringProperty", PropertyActor.StringValue, "21gnirtS");

            // Enum
            TestCoreSubsystem.TestEqual("ReflectionGetEnumProperty", PropertyActor.EnumValue, ETestEnum.TestEnumOne);

            PropertyActor.EnumValue = ETestEnum.TestEnumTwo;

            TestCoreSubsystem.TestEqual("ReflectionSetEnumProperty", PropertyActor.EnumValue, ETestEnum.TestEnumTwo);

            // EnumClass
            TestCoreSubsystem.TestEqual("ReflectionGetEnumClassProperty", PropertyActor.EnumClassValue,
                ETestEnumClass.TestEnumClassOne);

            PropertyActor.EnumClassValue = ETestEnumClass.TestEnumClassTwo;

            TestCoreSubsystem.TestEqual("ReflectionSetEnumClassProperty", PropertyActor.EnumClassValue,
                ETestEnumClass.TestEnumClassTwo);

            // UStruct
            TestCoreSubsystem.TestEqual("ReflectionGetStructProperty", PropertyActor.StructValue,
                new FTestStruct { Value = 1 });

            PropertyActor.StructValue = new FTestStruct { Value = 2 };

            TestCoreSubsystem.TestEqual("ReflectionSetStructProperty", PropertyActor.StructValue,
                new FTestStruct { Value = 2 });

            // UObject
            TestCoreSubsystem.TestEqual("ReflectionGetObjectProperty", PropertyActor.ObjectValue, PropertyActor);

            PropertyActor.ObjectValue = this;

            TestCoreSubsystem.TestEqual("ReflectionSetObjectProperty", PropertyActor.ObjectValue, this);
        }
    }
}