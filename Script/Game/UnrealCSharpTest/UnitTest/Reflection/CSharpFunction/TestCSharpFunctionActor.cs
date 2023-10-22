using System;
using Script.Common;

namespace Script.UnrealCSharpTest
{
    [IsOverride]
    public partial class ATestCSharpFunctionActor
    {
        [IsOverride]
        public void SetBoolValueFunction(Boolean InBoolValue)
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
            TestCoreSubsystem.TestEqual("CSharpOutGetBoolFunction", OutBoolValue, true);

            OutBoolValue = BoolValue;
        }

        [IsOverride]
        public void SetInt32ValueFunction(Int32 InInt32Value)
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
            TestCoreSubsystem.TestEqual("CSharpOutGetInt32Function", OutInt32Value, (Int32)12);

            OutInt32Value = Int32Value;
        }

        [IsOverride]
        public void SetInt64ValueFunction(Int64 InInt64Value)
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
            TestCoreSubsystem.TestEqual("CSharpOutGetInt64Function", OutInt64Value, (Int64)12);

            OutInt64Value = Int64Value;
        }

        [IsOverride]
        public void SetUInt8ValueFunction(Byte InUInt8Value)
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
            TestCoreSubsystem.TestEqual("CSharpOutGetUInt8Function", OutUInt8Value, (Byte)12);

            OutUInt8Value = UInt8Value;
        }

        [IsOverride]
        public void SetFloatValueFunction(Single InFloatValue)
        {
            FloatValue = InFloatValue;
        }

        [IsOverride]
        public Single GetFloatValueFunction()
        {
            return FloatValue;
        }

        [IsOverride]
        public void OutFloatValueFunction(ref Single OutFloatValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetFloatFunction", OutFloatValue, 12.3f);

            OutFloatValue = FloatValue;
        }

        [IsOverride]
        public void SetDoubleValueFunction(Double InDoubleValue)
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
            TestCoreSubsystem.TestEqual("CSharpOutGetDoubleFunction", OutDoubleValue, 12.3);

            OutDoubleValue = DoubleValue;
        }

        [IsOverride]
        public void SetNameValueFunction(FName InNameValue)
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
            TestCoreSubsystem.TestEqual("CSharpOutGetNameFunction", OutNameValue, "Name12");

            OutNameValue = NameValue;
        }

        [IsOverride]
        public FText GetTextValueFunction()
        {
            return TextValue;
        }

        [IsOverride]
        public void SetTextValueFunction(FText InTextValue)
        {
            TextValue = InTextValue;
        }

        [IsOverride]
        public virtual void OutTextValueFunction(ref FText OutTextValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetTextFunction", OutTextValue, "Text12");

            OutTextValue = TextValue;
        }

        [IsOverride]
        public void SetStringValueFunction(FString InStringValue)
        {
            StringValue = InStringValue;
        }

        [IsOverride]
        public virtual FString GetStringValueFunction()
        {
            return StringValue;
        }

        [IsOverride]
        public void OutStringValueFunction(ref FString OutStringValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetStringFunction", OutStringValue, "String12");

            OutStringValue = StringValue;
        }

        [IsOverride]
        public virtual ETestEnum GetEnumValueFunction()
        {
            return EnumValue;
        }

        [IsOverride]
        public virtual void SetEnumValueFunction(ETestEnum InEnumValue)
        {
            EnumValue = InEnumValue;
        }

        [IsOverride]
        public virtual void OutEnumValueFunction(ref ETestEnum OutEnumValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetEnumFunction", OutEnumValue, ETestEnum.TestEnumOne);

            OutEnumValue = EnumValue;
        }

        [IsOverride]
        public virtual ETestEnumClass GetEnumClassValueFunction()
        {
            return EnumClassValue;
        }

        [IsOverride]
        public virtual void SetEnumClassValueFunction(ETestEnumClass InEnumClassValue)
        {
            EnumClassValue = InEnumClassValue;
        }

        [IsOverride]
        public virtual void OutEnumClassValueFunction(ref ETestEnumClass OutEnumClassValue)
        {
            TestCoreSubsystem.TestEqual("CSharpOutGetEnumClassFunction", OutEnumClassValue,
                ETestEnumClass.TestEnumClassOne);

            OutEnumClassValue = EnumClassValue;
        }
    }
}