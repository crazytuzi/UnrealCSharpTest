using Script.CoreUObject;
using Script.Engine;

namespace Script.UnrealCSharpTest
{
    public partial class FTestMethodHelper
    {
        public static bool StaticFunction()
        {
            return true;
        }

        public bool GetBoolValueFunction()
        {
            return BoolValue;
        }

        public void SetBoolValueFunction(bool InBoolValue)
        {
            BoolValue = InBoolValue;
        }

        public void OutBoolValueFunction(ref bool OutBoolValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetBoolFunction", OutBoolValue, true);

            OutBoolValue = BoolValue;
        }

        public sbyte GetInt8ValueFunction()
        {
            return Int8Value;
        }

        public void SetInt8ValueFunction(sbyte InInt8Value)
        {
            Int8Value = InInt8Value;
        }

        public void OutInt8ValueFunction(ref sbyte OutInt8Value)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetInt8Function", OutInt8Value, (sbyte)12);

            OutInt8Value = Int8Value;
        }

        public short GetInt16ValueFunction()
        {
            return Int16Value;
        }

        public void SetInt16ValueFunction(short InInt16Value)
        {
            Int16Value = InInt16Value;
        }

        public void OutInt16ValueFunction(ref short OutInt16Value)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetInt16Function", OutInt16Value, (short)12);

            OutInt16Value = Int16Value;
        }

        public int GetInt32ValueFunction()
        {
            return Int32Value;
        }

        public void SetInt32ValueFunction(int InInt32Value)
        {
            Int32Value = InInt32Value;
        }

        public void OutInt32ValueFunction(ref int OutInt32Value)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetInt32Function", OutInt32Value, (int)12);

            OutInt32Value = Int32Value;
        }

        public long GetInt64ValueFunction()
        {
            return Int64Value;
        }

        public void SetInt64ValueFunction(long InInt64Value)
        {
            Int64Value = InInt64Value;
        }

        public void OutInt64ValueFunction(ref long OutInt64Value)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetInt64Function", OutInt64Value, (long)12);

            OutInt64Value = Int64Value;
        }

        public byte GetUInt8ValueFunction()
        {
            return UInt8Value;
        }

        public void SetUInt8ValueFunction(byte InUInt8Value)
        {
            UInt8Value = InUInt8Value;
        }

        public void OutUInt8ValueFunction(ref byte OutUInt8Value)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetUInt8Function", OutUInt8Value, (byte)12);

            OutUInt8Value = UInt8Value;
        }

        public ushort GetUInt16ValueFunction()
        {
            return UInt16Value;
        }

        public void SetUInt16ValueFunction(ushort InUInt16Value)
        {
            UInt16Value = InUInt16Value;
        }

        public void OutUInt16ValueFunction(ref ushort OutUInt16Value)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetUInt16Function", OutUInt16Value, (ushort)12);

            OutUInt16Value = UInt16Value;
        }

        public uint GetUInt32ValueFunction()
        {
            return UInt32Value;
        }

        public void SetUInt32ValueFunction(uint InUInt32Value)
        {
            UInt32Value = InUInt32Value;
        }

        public void OutUInt32ValueFunction(ref uint OutUInt32Value)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetUInt32Function", OutUInt32Value, (uint)12);

            OutUInt32Value = UInt32Value;
        }

        public ulong GetUInt64ValueFunction()
        {
            return UInt64Value;
        }

        public void SetUInt64ValueFunction(ulong InUInt64Value)
        {
            UInt64Value = InUInt64Value;
        }

        public void OutUInt64ValueFunction(ref ulong OutUInt64Value)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetUInt64Function", OutUInt64Value, (ulong)12);

            OutUInt64Value = UInt64Value;
        }

        public float GetFloatValueFunction()
        {
            return FloatValue;
        }

        public void SetFloatValueFunction(float InFloatValue)
        {
            FloatValue = InFloatValue;
        }

        public void OutFloatValueFunction(ref float OutFloatValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetFloatFunction", OutFloatValue, 12.3f);

            OutFloatValue = FloatValue;
        }

        public double GetDoubleValueFunction()
        {
            return DoubleValue;
        }

        public void SetDoubleValueFunction(double InDoubleValue)
        {
            DoubleValue = InDoubleValue;
        }

        public void OutDoubleValueFunction(ref double OutDoubleValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetDoubleFunction", OutDoubleValue, 12.3);

            OutDoubleValue = DoubleValue;
        }

        public FName GetNameValueFunction()
        {
            return NameValue;
        }

        public void SetNameValueFunction(FName InNameValue)
        {
            NameValue = InNameValue;
        }

        public void OutNameValueFunction(ref FName OutNameValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetNameFunction", OutNameValue, "Name12");

            OutNameValue = NameValue;
        }

        public FText GetTextValueFunction()
        {
            return TextValue;
        }

        public void SetTextValueFunction(FText InTextValue)
        {
            TextValue = InTextValue;
        }

        public void OutTextValueFunction(ref FText OutTextValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetTextFunction", OutTextValue, "Text12");

            OutTextValue = TextValue;
        }

        public FString GetStringValueFunction()
        {
            return StringValue;
        }

        public void SetStringValueFunction(FString InStringValue)
        {
            StringValue = InStringValue;
        }

        public void OutStringValueFunction(ref FString OutStringValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetStringFunction", OutStringValue, "String12");

            OutStringValue = StringValue;
        }

        public ETestEnum GetEnumValueFunction()
        {
            return EnumValue;
        }

        public void SetEnumValueFunction(ETestEnum InEnumValue)
        {
            EnumValue = InEnumValue;
        }

        public void OutEnumValueFunction(ref ETestEnum OutEnumValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetEnumFunction", OutEnumValue, ETestEnum.TestEnumOne);

            OutEnumValue = EnumValue;
        }

        public ETestEnum GetEnumAsByteValueFunction()
        {
            return EnumAsByteValue;
        }

        public void SetEnumAsByteValueFunction(ETestEnum InEnumAsByteValue)
        {
            EnumAsByteValue = InEnumAsByteValue;
        }

        public void OutEnumAsByteValueFunction(ref ETestEnum OutEnumAsByteValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetEnumAsByteFunction", OutEnumAsByteValue,
                ETestEnum.TestEnumOne);

            OutEnumAsByteValue = EnumAsByteValue;
        }

        public ETestEnumClass GetEnumClassValueFunction()
        {
            return EnumClassValue;
        }

        public void SetEnumClassValueFunction(ETestEnumClass InEnumClassValue)
        {
            EnumClassValue = InEnumClassValue;
        }

        public void OutEnumClassValueFunction(ref ETestEnumClass OutEnumClassValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetEnumClassFunction", OutEnumClassValue,
                ETestEnumClass.TestEnumClassOne);

            OutEnumClassValue = EnumClassValue;
        }

        public ERawTestEnum GetRawEnumValueFunction()
        {
            return RawEnumValue;
        }

        public void SetRawEnumValueFunction(ERawTestEnum InRawEnumValue)
        {
            RawEnumValue = InRawEnumValue;
        }

        public void OutRawEnumValueFunction(ref ERawTestEnum OutRawEnumValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetRawEnumFunction", OutRawEnumValue,
                ERawTestEnum.RawTestEnumOne);

            OutRawEnumValue = RawEnumValue;
        }

        public ERawTestEnumClass GetRawEnumClassValueFunction()
        {
            return RawEnumClassValue;
        }

        public void SetRawEnumClassValueFunction(ERawTestEnumClass InRawEnumClassValue)
        {
            RawEnumClassValue = InRawEnumClassValue;
        }

        public void OutRawEnumClassValueFunction(ref ERawTestEnumClass OutRawEnumClassValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetRawEnumClassFunction", OutRawEnumClassValue,
                ERawTestEnumClass.RawTestEnumClassOne);

            OutRawEnumClassValue = RawEnumClassValue;
        }

        public FTestStruct GetStructValueFunction()
        {
            return StructValue;
        }

        public void SetStructValueFunction(FTestStruct InStructValue)
        {
            StructValue = InStructValue;
        }

        public void OutStructValueFunction(ref FTestStruct OutStructValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetStructFunction", OutStructValue,
                new FTestStruct { Value = 1 });

            OutStructValue = StructValue;
        }

        public FRawTestStruct GetRawStructValueFunction()
        {
            return RawStructValue;
        }

        public void SetRawStructValueFunction(FRawTestStruct InRawStructValue)
        {
            RawStructValue = InRawStructValue;
        }

        public void OutRawStructValueFunction(ref FRawTestStruct OutRawStructValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetRawStructFunction", OutRawStructValue,
                new FRawTestStruct { Value = 1 });

            OutRawStructValue = RawStructValue;
        }

        public UObject GetObjectValueFunction()
        {
            return ObjectValue;
        }

        public void SetObjectValueFunction(UObject InObjectValue)
        {
            ObjectValue = InObjectValue;
        }

        public void OutObjectValueFunction(ref UObject OutObjectValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetObjectFunction", OutObjectValue, (UObject)null);

            OutObjectValue = ObjectValue;
        }

        public UClass GetClassValueFunction()
        {
            return ClassValue;
        }

        public void SetClassValueFunction(UClass InClassValue)
        {
            ClassValue = InClassValue;
        }

        public void OutClassValueFunction(ref UClass OutClassValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetClassFunction", OutClassValue, (UClass)null);

            OutClassValue = ClassValue;
        }

        public TSubclassOf<UObject> GetSubclassOfValueFunction()
        {
            return SubclassOfValue;
        }

        public void SetSubclassOfValueFunction(TSubclassOf<UObject> InSubclassOfValue)
        {
            SubclassOfValue = InSubclassOfValue;
        }

        public void OutSubclassOfValueFunction(ref TSubclassOf<UObject> OutSubclassOfValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetSubclassOfFunction", OutSubclassOfValue,
                TestCoreSubsystem.GetClass());

            OutSubclassOfValue = SubclassOfValue;
        }

        public TWeakObjectPtr<UObject> GetWeakObjectPtrValueFunction()
        {
            return WeakObjectPtrValue;
        }

        public void SetWeakObjectPtrValueFunction(TWeakObjectPtr<UObject> InWeakObjectPtrValue)
        {
            WeakObjectPtrValue = InWeakObjectPtrValue;
        }

        public void OutWeakObjectPtrValueFunction(ref TWeakObjectPtr<UObject> OutWeakObjectPtrValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetWeakObjectPtrFunction", OutWeakObjectPtrValue,
                TestCoreSubsystem);

            OutWeakObjectPtrValue = WeakObjectPtrValue;
        }

        public TLazyObjectPtr<UObject> GetLazyObjectPtrValueFunction()
        {
            return LazyObjectPtrValue;
        }

        public void SetLazyObjectPtrValueFunction(TLazyObjectPtr<UObject> InLazyObjectPtrValue)
        {
            LazyObjectPtrValue = InLazyObjectPtrValue;
        }

        public void OutLazyObjectPtrValueFunction(ref TLazyObjectPtr<UObject> OutLazyObjectPtrValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetLazyObjectPtrFunction", OutLazyObjectPtrValue,
                TestCoreSubsystem);

            OutLazyObjectPtrValue = LazyObjectPtrValue;
        }

        public TSoftObjectPtr<UObject> GetSoftObjectPtrValueFunction()
        {
            return SoftObjectPtrValue;
        }

        public void SetSoftObjectPtrValueFunction(TSoftObjectPtr<UObject> InSoftObjectPtrValue)
        {
            SoftObjectPtrValue = InSoftObjectPtrValue;
        }

        public void OutSoftObjectPtrValueFunction(ref TSoftObjectPtr<UObject> OutSoftObjectPtrValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetSoftObjectPtrFunction", OutSoftObjectPtrValue,
                TestCoreSubsystem);

            OutSoftObjectPtrValue = SoftObjectPtrValue;
        }

        public TSoftClassPtr<UObject> GetSoftClassPtrValueFunction()
        {
            return SoftClassPtrValue;
        }

        public void SetSoftClassPtrValueFunction(TSoftClassPtr<UObject> InSoftClassPtrValue)
        {
            SoftClassPtrValue = InSoftClassPtrValue;
        }

        public void OutSoftClassPtrValueFunction(ref TSoftClassPtr<UObject> OutSoftClassPtrValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetSoftClassPtrFunction", OutSoftClassPtrValue,
                TestCoreSubsystem.GetClass());

            OutSoftClassPtrValue = SoftClassPtrValue;
        }

        public TArray<int> GetArrayValueFunction()
        {
            return ArrayValue;
        }

        public void SetArrayValueFunction(TArray<int> InArrayValue)
        {
            ArrayValue = InArrayValue;
        }

        public void OutArrayValueFunction(ref TArray<int> OutArrayValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetArrayFunction", OutArrayValue,
                new TArray<int> { 1, 2 });

            OutArrayValue = ArrayValue;
        }

        public TSet<int> GetSetValueFunction()
        {
            return SetValue;
        }

        public void SetSetValueFunction(TSet<int> InSetValue)
        {
            SetValue = InSetValue;
        }

        public void OutSetValueFunction(ref TSet<int> OutSetValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetSetFunction", OutSetValue, new TSet<int> { 1, 2 });

            OutSetValue = SetValue;
        }

        public TMap<int, int> GetMapValueFunction()
        {
            return MapValue;
        }

        public void SetMapValueFunction(TMap<int, int> InMapValue)
        {
            MapValue = InMapValue;
        }

        public void OutMapValueFunction(ref TMap<int, int> OutMapValue)
        {
            TestCoreSubsystem.TestEqual("RawMethodHelperOutGetMapFunction", OutMapValue,
                new TMap<int, int> { { 1, 1 }, { 2, 2 } });

            OutMapValue = MapValue;
        }
    }
}
