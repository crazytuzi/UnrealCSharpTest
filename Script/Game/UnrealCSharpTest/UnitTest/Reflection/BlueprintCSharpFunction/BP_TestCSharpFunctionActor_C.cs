using System;
using Script.Common;
using Script.CoreUObject;
using Script.Game.UnitTest.Core;

namespace Script.Game.UnitTest.Reflection
{
    [IsOverride]
    public partial class BP_TestCSharpFunctionActor_C
    {
        [IsOverride]
        public void SetBoolValueFunction(Boolean InBoolValue = false)
        {
            BoolValue = InBoolValue;
        }

        [IsOverride]
        public Boolean GetBoolValueFunction()
        {
            return BoolValue;
        }

        [IsOverride]
        public void OutBoolValueFunction(ref Boolean OutBoolValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetBoolFunction", OutBoolValue, true);

            OutBoolValue = BoolValue;
        }

        [IsOverride]
        public void SetInt32ValueFunction(Int32 InInt32Value = 0)
        {
            Int32Value = InInt32Value;
        }

        [IsOverride]
        public Int32 GetInt32ValueFunction()
        {
            return Int32Value;
        }

        [IsOverride]
        public void OutInt32ValueFunction(ref Int32 OutInt32Value)
        {
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetInt32Function", OutInt32Value, (Int32)12);

            OutInt32Value = Int32Value;
        }

        [IsOverride]
        public void SetInt64ValueFunction(Int64 InInt64Value = 0)
        {
            Int64Value = InInt64Value;
        }

        [IsOverride]
        public Int64 GetInt64ValueFunction()
        {
            return Int64Value;
        }

        [IsOverride]
        public void OutInt64ValueFunction(ref Int64 OutInt64Value)
        {
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetInt64Function", OutInt64Value, (Int64)12);

            OutInt64Value = Int64Value;
        }

        [IsOverride]
        public void SetUInt8ValueFunction(Byte InUInt8Value = 0)
        {
            UInt8Value = InUInt8Value;
        }

        [IsOverride]
        public Byte GetUInt8ValueFunction()
        {
            return UInt8Value;
        }

        [IsOverride]
        public void OutUInt8ValueFunction(ref Byte OutUInt8Value)
        {
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetUInt8Function", OutUInt8Value, (Byte)12);

            OutUInt8Value = UInt8Value;
        }

        [IsOverride]
        public void SetDoubleValueFunction(Double InDoubleValue = 0)
        {
            DoubleValue = InDoubleValue;
        }

        [IsOverride]
        public Double GetDoubleValueFunction()
        {
            return DoubleValue;
        }

        [IsOverride]
        public void OutDoubleValueFunction(ref Double OutDoubleValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetDoubleFunction", OutDoubleValue, 12.3);

            OutDoubleValue = DoubleValue;
        }

        [IsOverride]
        public void SetNameValueFunction(FName InNameValue = null)
        {
            NameValue = InNameValue;
        }

        [IsOverride]
        public FName GetNameValueFunction()
        {
            return NameValue;
        }

        [IsOverride]
        public void OutNameValueFunction(ref FName OutNameValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetNameFunction", OutNameValue, "Name12");

            OutNameValue = NameValue;
        }

        [IsOverride]
        public void SetTextValueFunction(FText InTextValue = null)
        {
            TextValue = InTextValue;
        }

        [IsOverride]
        public FText GetTextValueFunction()
        {
            return TextValue;
        }

        [IsOverride]
        public void OutTextValueFunction(ref FText OutTextValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetTextFunction", OutTextValue, "Text12");

            OutTextValue = TextValue;
        }

        [IsOverride]
        public void SetStringValueFunction(FString InStringValue = null)
        {
            StringValue = InStringValue;
        }

        [IsOverride]
        public FString GetStringValueFunction()
        {
            return StringValue;
        }

        [IsOverride]
        public void OutStringValueFunction(ref FString OutStringValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetStringFunction", OutStringValue, "String12");

            OutStringValue = StringValue;
        }

        [IsOverride]
        public void SetEnumValueFunction(BP_TestEnum InEnumValue = BP_TestEnum.BlueprintTestEnumZero)
        {
            EnumValue = InEnumValue;
        }

        [IsOverride]
        public BP_TestEnum GetEnumValueFunction()
        {
            return EnumValue;
        }

        [IsOverride]
        public void OutEnumValueFunction(ref BP_TestEnum OutEnumValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetEnumFunction", OutEnumValue,
                BP_TestEnum.BlueprintTestEnumOne);

            OutEnumValue = EnumValue;
        }

        [IsOverride]
        public void SetStructValueFunction(BP_TestStruct InStructValue = null)
        {
            StructValue = InStructValue;
        }

        [IsOverride]
        public BP_TestStruct GetStructValueFunction()
        {
            return StructValue;
        }

        [IsOverride]
        public void OutStructValueFunction(ref BP_TestStruct OutStructValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetStructFunction", OutStructValue,
                new BP_TestStruct { Value = 1 });

            OutStructValue = StructValue;
        }

        [IsOverride]
        public void SetObjectValueFunction(UObject InObjectValue)
        {
            ObjectValue = InObjectValue;
        }

        [IsOverride]
        public UObject GetObjectValueFunction()
        {
            return ObjectValue;
        }

        [IsOverride]
        public void OutObjectValueFunction(ref UObject OutObjectValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetObjectFunction", OutObjectValue, this);

            OutObjectValue = ObjectValue;
        }

        [IsOverride]
        public void SetClassValueFunction(TSubclassOf<UObject> InClassValue)
        {
            ClassValue = InClassValue;
        }

        [IsOverride]
        public TSubclassOf<UObject> GetClassValueFunction()
        {
            return ClassValue;
        }

        [IsOverride]
        public void OutClassValueFunction(ref TSubclassOf<UObject> OutClassValue)
        {
            TestCoreSubsystem.TestEqual("BlueprintCSharpOutGetClassFunction", OutClassValue, GetClass());

            OutClassValue = ClassValue;
        }
    }
}