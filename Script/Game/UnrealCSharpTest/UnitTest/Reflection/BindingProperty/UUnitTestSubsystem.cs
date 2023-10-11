using System;
using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestBindingProperty()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            var PropertyActor = GetWorld().SpawnActor<ATestBindingPropertyActor>(new FTransform());

            // Bool
            TestCoreSubsystem.TestEqual("BindingGetBoolProperty", PropertyActor.BoolValue, true);

            PropertyActor.BoolValue = false;

            TestCoreSubsystem.TestEqual("BindingSetBoolProperty", PropertyActor.BoolValue, false);

            // Int8
            TestCoreSubsystem.TestEqual("BindingGetInt8Property", PropertyActor.Int8Value, (SByte)12);

            PropertyActor.Int8Value = 21;

            TestCoreSubsystem.TestEqual("BindingSetInt8Property", PropertyActor.Int8Value, (SByte)21);

            // Int16
            TestCoreSubsystem.TestEqual("BindingGetInt16Property", PropertyActor.Int16Value, (Int16)12);

            PropertyActor.Int16Value = 21;

            TestCoreSubsystem.TestEqual("BindingSetInt16Property", PropertyActor.Int16Value, (Int16)21);

            // Int32
            TestCoreSubsystem.TestEqual("BindingGetInt32Property", PropertyActor.Int32Value, (Int32)12);

            PropertyActor.Int32Value = 21;

            TestCoreSubsystem.TestEqual("BindingSetInt32Property", PropertyActor.Int32Value, (Int32)21);

            // Int64
            TestCoreSubsystem.TestEqual("BindingGetInt64Property", PropertyActor.Int64Value, (Int64)12);

            PropertyActor.Int64Value = 21;

            TestCoreSubsystem.TestEqual("BindingSetInt64Property", PropertyActor.Int64Value, (Int64)21);

            // UInt8
            TestCoreSubsystem.TestEqual("BindingGetUInt8Property", PropertyActor.UInt8Value, (Byte)12);

            PropertyActor.UInt8Value = 21;

            TestCoreSubsystem.TestEqual("BindingSetUInt8Property", PropertyActor.UInt8Value, (Byte)21);

            // UInt16
            TestCoreSubsystem.TestEqual("BindingGetUInt16Property", PropertyActor.UInt16Value, (UInt16)12);

            PropertyActor.UInt16Value = 21;

            TestCoreSubsystem.TestEqual("BindingSetUInt16Property", PropertyActor.UInt16Value, (UInt16)21);

            // UInt32
            TestCoreSubsystem.TestEqual("BindingGetUInt32Property", PropertyActor.UInt32Value, (UInt32)12);

            PropertyActor.UInt32Value = 21;

            TestCoreSubsystem.TestEqual("BindingSetUInt32Property", PropertyActor.UInt32Value, (UInt32)21);

            // UInt64
            TestCoreSubsystem.TestEqual("BindingGetUInt64Property", PropertyActor.UInt64Value, (UInt64)12);

            PropertyActor.UInt64Value = 21;

            TestCoreSubsystem.TestEqual("BindingSetUInt64Property", PropertyActor.UInt64Value, (UInt64)21);

            // Float
            TestCoreSubsystem.TestEqual("BindingGetFloatProperty", PropertyActor.FloatValue, 12.3f);

            PropertyActor.FloatValue = 3.21f;

            TestCoreSubsystem.TestEqual("BindingSetFloatProperty", PropertyActor.FloatValue, 3.21f);

            // Double
            TestCoreSubsystem.TestEqual("BindingGetDoubleProperty", PropertyActor.DoubleValue, 12.3);

            PropertyActor.DoubleValue = 3.21;

            TestCoreSubsystem.TestEqual("BindingSetDoubleProperty", PropertyActor.DoubleValue, 3.21);

            // FName
            TestCoreSubsystem.TestEqual("BindingGetNameProperty", PropertyActor.NameValue, "Name12");

            PropertyActor.NameValue = "21emaN";

            TestCoreSubsystem.TestEqual("BindingSetNameProperty", PropertyActor.NameValue, "21emaN");

            // FText
            TestCoreSubsystem.TestEqual("BindingGetTextProperty", PropertyActor.TextValue, "Text12");

            PropertyActor.TextValue = "21txeT";

            TestCoreSubsystem.TestEqual("BindingSetTextProperty", PropertyActor.TextValue, "21txeT");

            // FString
            TestCoreSubsystem.TestEqual("BindingGetStringProperty", PropertyActor.StringValue, "String12");

            PropertyActor.StringValue = "21gnirtS";

            TestCoreSubsystem.TestEqual("BindingSetStringProperty", PropertyActor.StringValue, "21gnirtS");
        }
    }
}