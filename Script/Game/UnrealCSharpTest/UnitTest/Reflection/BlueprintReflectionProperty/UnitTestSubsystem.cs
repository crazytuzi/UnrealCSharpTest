﻿using System;
using Script.Common;
using Script.CoreUObject;
using Script.Engine;
using Script.Game.UnitTest.Core;
using Script.Game.UnitTest.Reflection;

namespace Script.UnrealCSharpTest
{
    public partial class UUnitTestSubsystem
    {
        private void TestBlueprintReflectionProperty()
        {
            var TestCoreSubsystem =
                USubsystemBlueprintLibrary.GetGameInstanceSubsystem(this, UTestCoreSubsystem.StaticClass())
                    as UTestCoreSubsystem;

            var PropertyActor = GetWorld().SpawnActor<BP_TestReflectionPropertyActor_C>(new FTransform());

            // Bool
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetBoolProperty", PropertyActor.BoolValue, true);

            PropertyActor.BoolValue = false;

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetBoolProperty", PropertyActor.BoolValue, false);

            // Int32
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetInt32Property", PropertyActor.Int32Value, (Int32)12);

            PropertyActor.Int32Value = 21;

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetInt32Property", PropertyActor.Int32Value, (Int32)21);

            // Int64
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetInt64Property", PropertyActor.Int64Value, (Int64)12);

            PropertyActor.Int64Value = 21;

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetInt64Property", PropertyActor.Int64Value, (Int64)21);

            // UInt8
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetUInt8Property", PropertyActor.UInt8Value, (Byte)12);

            PropertyActor.UInt8Value = 21;

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetUInt8Property", PropertyActor.UInt8Value, (Byte)21);

            // Double
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetDoubleProperty", PropertyActor.DoubleValue, 12.3);

            PropertyActor.DoubleValue = 3.21;

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetDoubleProperty", PropertyActor.DoubleValue, 3.21);

            // FName
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetNameProperty", PropertyActor.NameValue, "Name12");

            PropertyActor.NameValue = "21emaN";

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetNameProperty", PropertyActor.NameValue, "21emaN");

            // FText
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetTextProperty", PropertyActor.TextValue, "Text12");

            PropertyActor.TextValue = "21txeT";

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetTextProperty", PropertyActor.TextValue, "21txeT");

            // FString
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetStringProperty", PropertyActor.StringValue, "String12");

            PropertyActor.StringValue = "21gnirtS";

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetStringProperty", PropertyActor.StringValue, "21gnirtS");

            // Enum
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetEnumProperty", PropertyActor.EnumValue,
                BP_TestEnum.BlueprintTestEnumOne);

            PropertyActor.EnumValue = BP_TestEnum.BlueprintTestEnumTwo;

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetEnumProperty", PropertyActor.EnumValue,
                BP_TestEnum.BlueprintTestEnumTwo);

            // UStruct
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetStructProperty", PropertyActor.StructValue,
                new BP_TestStruct { Value = 1 });

            PropertyActor.StructValue = new BP_TestStruct { Value = 2 };

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetStructProperty", PropertyActor.StructValue,
                new BP_TestStruct { Value = 2 });

            // UObject
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetObjectProperty", PropertyActor.ObjectValue,
                PropertyActor);

            PropertyActor.ObjectValue = this;

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetObjectProperty", PropertyActor.ObjectValue, this);

            // UClass
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetClassProperty", PropertyActor.ClassValue,
                PropertyActor.GetClass());

            PropertyActor.ClassValue = GetClass();

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetClassProperty", PropertyActor.ClassValue, GetClass());

            // UInterface
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetInterfaceProperty", PropertyActor.InterfaceValue,
                PropertyActor.InterfaceValue);

            PropertyActor.InterfaceValue = PropertyActor.InterfaceValue;

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetInterfaceProperty", PropertyActor.InterfaceValue,
                PropertyActor.InterfaceValue);

            // TArray
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetArrayProperty", PropertyActor.ArrayValue,
                new TArray<Int32> { 1, 2 });

            PropertyActor.ArrayValue = new TArray<Int32> { 3, 4 };

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetArrayProperty", PropertyActor.ArrayValue,
                new TArray<Int32> { 3, 4 });

            // TSet
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetSetProperty", PropertyActor.SetValue,
                new TSet<Int32> { 1, 2 });

            PropertyActor.SetValue = new TSet<Int32> { 3, 4 };

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetSetProperty", PropertyActor.SetValue,
                new TSet<Int32> { 3, 4 });

            // TMap
            TestCoreSubsystem.TestEqual("BlueprintReflectionGetMapProperty", PropertyActor.MapValue,
                new TMap<Int32, Int32> { { 1, 1 }, { 2, 2 } });

            PropertyActor.MapValue = new TMap<Int32, Int32> { { 3, 3 }, { 4, 4 } };

            TestCoreSubsystem.TestEqual("BlueprintReflectionSetMapProperty", PropertyActor.MapValue,
                new TMap<Int32, Int32> { { 3, 3 }, { 4, 4 } });
        }
    }
}