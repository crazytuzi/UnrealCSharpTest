#include "UnitTest/Binding/FTestBindingFunction.h"
#include "Binding/Class/TBindingClassBuilder.inl"
#include "Macro/NamespaceMacro.h"
#include "TestCore/TestCoreSubsystem.h"

BINDING_CLASS(FTestBindingFunction)

struct FRegisterTestBindingFunction
{
	FRegisterTestBindingFunction()
	{
		TBindingClassBuilder<FTestBindingFunction>(NAMESPACE_BINDING)
			.Property("TestCoreSubsystem", BINDING_PROPERTY(&FTestBindingFunction::TestCoreSubsystem))
			.Function("StaticFunction", BINDING_FUNCTION(&FTestBindingFunction::StaticFunction))
			.Function("SetBoolValueFunction", BINDING_FUNCTION(&FTestBindingFunction::SetBoolValueFunction))
			.Function("GetBoolValueFunction", BINDING_FUNCTION(&FTestBindingFunction::GetBoolValueFunction))
			.Function("OutBoolValueFunction", BINDING_FUNCTION(&FTestBindingFunction::OutBoolValueFunction))
			.Function("SetInt8ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::SetInt8ValueFunction))
			.Function("GetInt8ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::GetInt8ValueFunction))
			.Function("OutInt8ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::OutInt8ValueFunction))
			.Function("SetInt16ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::SetInt16ValueFunction))
			.Function("GetInt16ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::GetInt16ValueFunction))
			.Function("OutInt16ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::OutInt16ValueFunction))
			.Function("SetInt32ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::SetInt32ValueFunction))
			.Function("GetInt32ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::GetInt32ValueFunction))
			.Function("OutInt32ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::OutInt32ValueFunction))
			.Function("SetInt64ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::SetInt64ValueFunction))
			.Function("GetInt64ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::GetInt64ValueFunction))
			.Function("OutInt64ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::OutInt64ValueFunction))
			.Function("SetUInt8ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::SetUInt8ValueFunction))
			.Function("GetUInt8ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::GetUInt8ValueFunction))
			.Function("OutUInt8ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::OutUInt8ValueFunction))
			.Function("SetUInt16ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::SetUInt16ValueFunction))
			.Function("GetUInt16ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::GetUInt16ValueFunction))
			.Function("OutUInt16ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::OutUInt16ValueFunction))
			.Function("SetUInt32ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::SetUInt32ValueFunction))
			.Function("GetUInt32ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::GetUInt32ValueFunction))
			.Function("OutUInt32ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::OutUInt32ValueFunction))
			.Function("SetUInt64ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::SetUInt64ValueFunction))
			.Function("GetUInt64ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::GetUInt64ValueFunction))
			.Function("OutUInt64ValueFunction", BINDING_FUNCTION(&FTestBindingFunction::OutUInt64ValueFunction))
			.Function("SetFloatValueFunction", BINDING_FUNCTION(&FTestBindingFunction::SetFloatValueFunction))
			.Function("GetFloatValueFunction", BINDING_FUNCTION(&FTestBindingFunction::GetFloatValueFunction))
			.Function("OutFloatValueFunction", BINDING_FUNCTION(&FTestBindingFunction::OutFloatValueFunction))
			.Function("SetDoubleValueFunction", BINDING_FUNCTION(&FTestBindingFunction::SetDoubleValueFunction))
			.Function("GetDoubleValueFunction", BINDING_FUNCTION(&FTestBindingFunction::GetDoubleValueFunction))
			.Function("OutDoubleValueFunction", BINDING_FUNCTION(&FTestBindingFunction::OutDoubleValueFunction))
			.Function("SetNameValueFunction", BINDING_FUNCTION(&FTestBindingFunction::SetNameValueFunction))
			.Function("GetNameValueFunction", BINDING_FUNCTION(&FTestBindingFunction::GetNameValueFunction))
			.Function("OutNameValueFunction", BINDING_FUNCTION(&FTestBindingFunction::OutNameValueFunction))
			.Function("SetTextValueFunction", BINDING_FUNCTION(&FTestBindingFunction::SetTextValueFunction))
			.Function("GetTextValueFunction", BINDING_FUNCTION(&FTestBindingFunction::GetTextValueFunction))
			.Function("OutTextValueFunction", BINDING_FUNCTION(&FTestBindingFunction::OutTextValueFunction))
			.Function("SetStringValueFunction", BINDING_FUNCTION(&FTestBindingFunction::SetStringValueFunction))
			.Function("GetStringValueFunction", BINDING_FUNCTION(&FTestBindingFunction::GetStringValueFunction))
			.Function("OutStringValueFunction", BINDING_FUNCTION(&FTestBindingFunction::OutStringValueFunction))
			.Function("SetEnumValueFunction", BINDING_FUNCTION(&FTestBindingFunction::SetEnumValueFunction))
			.Function("GetEnumValueFunction", BINDING_FUNCTION(&FTestBindingFunction::GetEnumValueFunction))
			.Function("OutEnumValueFunction", BINDING_FUNCTION(&FTestBindingFunction::OutEnumValueFunction))
			.Function("SetEnumAsByteValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::SetEnumAsByteValueFunction))
			.Function("GetEnumAsByteValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::GetEnumAsByteValueFunction))
			.Function("OutEnumAsByteValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::OutEnumAsByteValueFunction))
			.Function("SetEnumClassValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::SetEnumClassValueFunction))
			.Function("GetEnumClassValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::GetEnumClassValueFunction))
			.Function("OutEnumClassValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::OutEnumClassValueFunction))
			.Function("SetRawEnumValueFunction", BINDING_FUNCTION(&FTestBindingFunction::SetRawEnumValueFunction))
			.Function("GetRawEnumValueFunction", BINDING_FUNCTION(&FTestBindingFunction::GetRawEnumValueFunction))
			.Function("OutRawEnumValueFunction", BINDING_FUNCTION(&FTestBindingFunction::OutRawEnumValueFunction))
			.Function("SetRawEnumClassValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::SetRawEnumClassValueFunction))
			.Function("GetRawEnumClassValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::GetRawEnumClassValueFunction))
			.Function("OutRawEnumClassValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::OutRawEnumClassValueFunction))
			.Function("SetStructValueFunction", BINDING_FUNCTION(&FTestBindingFunction::SetStructValueFunction))
			.Function("GetStructValueFunction", BINDING_FUNCTION(&FTestBindingFunction::GetStructValueFunction))
			.Function("OutStructValueFunction", BINDING_FUNCTION(&FTestBindingFunction::OutStructValueFunction))
			.Function("SetRawStructValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::SetRawStructValueFunction))
			.Function("GetRawStructValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::GetRawStructValueFunction))
			.Function("OutRawStructValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::OutRawStructValueFunction))
			.Function("SetObjectValueFunction", BINDING_FUNCTION(&FTestBindingFunction::SetObjectValueFunction))
			.Function("GetObjectValueFunction", BINDING_FUNCTION(&FTestBindingFunction::GetObjectValueFunction))
			.Function("OutObjectValueFunction", BINDING_FUNCTION(&FTestBindingFunction::OutObjectValueFunction))
			.Function("SetClassValueFunction", BINDING_FUNCTION(&FTestBindingFunction::SetClassValueFunction))
			.Function("GetClassValueFunction", BINDING_FUNCTION(&FTestBindingFunction::GetClassValueFunction))
			.Function("OutClassValueFunction", BINDING_FUNCTION(&FTestBindingFunction::OutClassValueFunction))
			.Function("SetSubclassOfValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::SetSubclassOfValueFunction))
			.Function("GetSubclassOfValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::GetSubclassOfValueFunction))
			.Function("OutSubclassOfValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::OutSubclassOfValueFunction))
			.Function("SetWeakObjectPtrValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::SetWeakObjectPtrValueFunction))
			.Function("GetWeakObjectPtrValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::GetWeakObjectPtrValueFunction))
			.Function("OutWeakObjectPtrValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::OutWeakObjectPtrValueFunction))
			.Function("SetLazyObjectPtrValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::SetLazyObjectPtrValueFunction))
			.Function("GetLazyObjectPtrValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::GetLazyObjectPtrValueFunction))
			.Function("OutLazyObjectPtrValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::OutLazyObjectPtrValueFunction))
			.Function("SetSoftObjectPtrValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::SetSoftObjectPtrValueFunction))
			.Function("GetSoftObjectPtrValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::GetSoftObjectPtrValueFunction))
			.Function("OutSoftObjectPtrValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::OutSoftObjectPtrValueFunction))
			.Function("SetSoftClassPtrValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::SetSoftClassPtrValueFunction))
			.Function("GetSoftClassPtrValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::GetSoftClassPtrValueFunction))
			.Function("OutSoftClassPtrValueFunction",
			          BINDING_FUNCTION(&FTestBindingFunction::OutSoftClassPtrValueFunction))
			.Function("SetArrayValueFunction", BINDING_FUNCTION(&FTestBindingFunction::SetArrayValueFunction))
			.Function("GetArrayValueFunction", BINDING_FUNCTION(&FTestBindingFunction::GetArrayValueFunction))
			.Function("OutArrayValueFunction", BINDING_FUNCTION(&FTestBindingFunction::OutArrayValueFunction))
			.Function("SetSetValueFunction", BINDING_FUNCTION(&FTestBindingFunction::SetSetValueFunction))
			.Function("GetSetValueFunction", BINDING_FUNCTION(&FTestBindingFunction::GetSetValueFunction))
			.Function("OutSetValueFunction", BINDING_FUNCTION(&FTestBindingFunction::OutSetValueFunction))
			.Function("SetMapValueFunction", BINDING_FUNCTION(&FTestBindingFunction::SetMapValueFunction))
			.Function("GetMapValueFunction", BINDING_FUNCTION(&FTestBindingFunction::GetMapValueFunction))
			.Function("OutMapValueFunction", BINDING_FUNCTION(&FTestBindingFunction::OutMapValueFunction));
	}
};

static FRegisterTestBindingFunction RegisterTestBindingFunction;

FTestBindingFunction::FTestBindingFunction():
	BoolValue(true),
	Int8Value(12),
	Int16Value(12),
	Int32Value(12),
	Int64Value(12),
	UInt8Value(12),
	UInt16Value(12),
	UInt32Value(12),
	UInt64Value(12),
	FloatValue(12.3f),
	DoubleValue(12.3),
	NameValue(TEXT("Name12")),
	TextValue(FText::FromString(TEXT("Text12"))),
	StringValue(TEXT("String12")),
	EnumValue(ETestEnum::TestEnumOne),
	EnumAsByteValue(ETestEnum::TestEnumOne),
	EnumClassValue(ETestEnumClass::TestEnumClassOne),
	RawEnumValue(ERawTestEnum::RawTestEnumOne),
	RawEnumClassValue(ERawTestEnumClass::RawTestEnumClassOne),
	StructValue({1}),
	RawStructValue({1}),
	ObjectValue(GWorld->GetWorld()),
	ClassValue(GWorld->GetWorld()->GetClass()),
	SubclassOfValue(GWorld->GetWorld()->GetClass()),
	WeakObjectPtrValue(GWorld->GetWorld()),
	LazyObjectPtrValue(GWorld->GetWorld()),
	SoftObjectPtrValue(GWorld->GetWorld()),
	SoftClassPtrValue(GWorld->GetWorld()->GetClass()),
	ArrayValue({1, 2}),
	SetValue({1, 2}),
	MapValue({{1, 1}, {2, 2}}),
	TestCoreSubsystem(nullptr)
{
}

bool FTestBindingFunction::StaticFunction()
{
	return true;
}

void FTestBindingFunction::SetBoolValueFunction(const bool InBoolValue)
{
	BoolValue = InBoolValue;
}

bool FTestBindingFunction::GetBoolValueFunction() const
{
	return BoolValue;
}

void FTestBindingFunction::OutBoolValueFunction(bool& OutBoolValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetBoolFunction", OutBoolValue, true);

	OutBoolValue = BoolValue;
}

void FTestBindingFunction::SetInt8ValueFunction(const int8 InInt8Value)
{
	Int8Value = InInt8Value;
}

int8 FTestBindingFunction::GetInt8ValueFunction() const
{
	return Int8Value;
}

void FTestBindingFunction::OutInt8ValueFunction(int8& OutInt8Value) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetInt8Function", OutInt8Value, static_cast<int8>(12));

	OutInt8Value = Int8Value;
}

void FTestBindingFunction::SetInt16ValueFunction(const int16 InInt16Value)
{
	Int16Value = InInt16Value;
}

int16 FTestBindingFunction::GetInt16ValueFunction() const
{
	return Int16Value;
}

void FTestBindingFunction::OutInt16ValueFunction(int16& OutInt16Value) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetInt16Function", OutInt16Value, static_cast<int16>(12));

	OutInt16Value = Int16Value;
}

void FTestBindingFunction::SetInt32ValueFunction(const int32 InInt32Value)
{
	Int32Value = InInt32Value;
}

int32 FTestBindingFunction::GetInt32ValueFunction() const
{
	return Int32Value;
}

void FTestBindingFunction::OutInt32ValueFunction(int32& OutInt32Value) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetInt32Function", OutInt32Value, static_cast<int32>(12));

	OutInt32Value = Int32Value;
}

void FTestBindingFunction::SetInt64ValueFunction(const int64 InInt64Value)
{
	Int64Value = InInt64Value;
}

int64 FTestBindingFunction::GetInt64ValueFunction() const
{
	return Int64Value;
}

void FTestBindingFunction::OutInt64ValueFunction(int64& OutInt64Value) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetInt64Function", OutInt64Value, static_cast<int64>(12));

	OutInt64Value = Int64Value;
}

void FTestBindingFunction::SetUInt8ValueFunction(const uint8 InUInt8Value)
{
	UInt8Value = InUInt8Value;
}

uint8 FTestBindingFunction::GetUInt8ValueFunction() const
{
	return UInt8Value;
}

void FTestBindingFunction::OutUInt8ValueFunction(uint8& OutUInt8Value) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetUInt8Function", OutUInt8Value, static_cast<uint8>(12));

	OutUInt8Value = UInt8Value;
}

void FTestBindingFunction::SetUInt16ValueFunction(const uint16 InUInt16Value)
{
	UInt16Value = InUInt16Value;
}

uint16 FTestBindingFunction::GetUInt16ValueFunction() const
{
	return UInt16Value;
}

void FTestBindingFunction::OutUInt16ValueFunction(uint16& OutUInt16Value) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetUInt16Function", OutUInt16Value, static_cast<uint16>(12));

	OutUInt16Value = UInt16Value;
}

void FTestBindingFunction::SetUInt32ValueFunction(const uint32 InUInt32Value)
{
	UInt32Value = InUInt32Value;
}

uint32 FTestBindingFunction::GetUInt32ValueFunction() const
{
	return UInt32Value;
}

void FTestBindingFunction::OutUInt32ValueFunction(uint32& OutUInt32Value) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetUInt32Function", OutUInt32Value, static_cast<uint32>(12));

	OutUInt32Value = UInt32Value;
}

void FTestBindingFunction::SetUInt64ValueFunction(const uint64 InUInt64Value)
{
	UInt64Value = InUInt64Value;
}

uint64 FTestBindingFunction::GetUInt64ValueFunction() const
{
	return UInt64Value;
}

void FTestBindingFunction::OutUInt64ValueFunction(uint64& OutUInt64Value) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetUInt64Function", OutUInt64Value, static_cast<uint64>(12));

	OutUInt64Value = UInt64Value;
}

void FTestBindingFunction::SetFloatValueFunction(const float InFloatValue)
{
	FloatValue = InFloatValue;
}

float FTestBindingFunction::GetFloatValueFunction() const
{
	return FloatValue;
}

void FTestBindingFunction::OutFloatValueFunction(float& OutFloatValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetFloatFunction", OutFloatValue, 12.3f);

	OutFloatValue = FloatValue;
}

void FTestBindingFunction::SetDoubleValueFunction(const double InDoubleValue)
{
	DoubleValue = InDoubleValue;
}

double FTestBindingFunction::GetDoubleValueFunction() const
{
	return DoubleValue;
}

void FTestBindingFunction::OutDoubleValueFunction(double& OutDoubleValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetDoubleFunction", OutDoubleValue, 12.3);

	OutDoubleValue = DoubleValue;
}

void FTestBindingFunction::SetNameValueFunction(const FName& InNameValue)
{
	NameValue = InNameValue;
}

FName FTestBindingFunction::GetNameValueFunction() const
{
	return NameValue;
}

void FTestBindingFunction::OutNameValueFunction(FName& OutNameValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetNameFunction", OutNameValue, FName(TEXT("Name12")));

	OutNameValue = NameValue;
}

void FTestBindingFunction::SetTextValueFunction(const FText& InTextValue)
{
	TextValue = InTextValue;
}

FText FTestBindingFunction::GetTextValueFunction() const
{
	return TextValue;
}

void FTestBindingFunction::OutTextValueFunction(FText& OutTextValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetTextFunction", OutTextValue, FText::FromString(TEXT("Text12")));

	OutTextValue = TextValue;
}

void FTestBindingFunction::SetStringValueFunction(const FString& InStringValue)
{
	StringValue = InStringValue;
}

FString FTestBindingFunction::GetStringValueFunction() const
{
	return StringValue;
}

void FTestBindingFunction::OutStringValueFunction(FString& OutStringValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetStringFunction", OutStringValue, FString(TEXT("String12")));

	OutStringValue = StringValue;
}

void FTestBindingFunction::SetEnumValueFunction(const ETestEnum InEnumValue)
{
	EnumValue = InEnumValue;
}

ETestEnum FTestBindingFunction::GetEnumValueFunction() const
{
	return EnumValue;
}

void FTestBindingFunction::OutEnumValueFunction(ETestEnum& OutEnumValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetEnumFunction", OutEnumValue, ETestEnum::TestEnumOne);

	OutEnumValue = EnumValue;
}

void FTestBindingFunction::SetEnumAsByteValueFunction(const TEnumAsByte<ETestEnum> InEnumAsByteValue)
{
	EnumAsByteValue = InEnumAsByteValue;
}

TEnumAsByte<ETestEnum> FTestBindingFunction::GetEnumAsByteValueFunction() const
{
	return EnumAsByteValue;
}

void FTestBindingFunction::OutEnumAsByteValueFunction(TEnumAsByte<ETestEnum>& OutEnumAsByteValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetEnumAsByteFunction", OutEnumAsByteValue.GetValue(),
	                             ETestEnum::TestEnumOne);

	OutEnumAsByteValue = EnumAsByteValue;
}

void FTestBindingFunction::SetEnumClassValueFunction(const ETestEnumClass InEnumClassValue)
{
	EnumClassValue = InEnumClassValue;
}

ETestEnumClass FTestBindingFunction::GetEnumClassValueFunction() const
{
	return EnumClassValue;
}

void FTestBindingFunction::OutEnumClassValueFunction(ETestEnumClass& OutEnumClassValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetEnumClassFunction", OutEnumClassValue,
	                             ETestEnumClass::TestEnumClassOne);

	OutEnumClassValue = EnumClassValue;
}

void FTestBindingFunction::SetRawEnumValueFunction(const ERawTestEnum InRawEnumValue)
{
	RawEnumValue = InRawEnumValue;
}

ERawTestEnum FTestBindingFunction::GetRawEnumValueFunction() const
{
	return RawEnumValue;
}

void FTestBindingFunction::OutRawEnumValueFunction(ERawTestEnum& OutRawEnumValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetRawEnumFunction", OutRawEnumValue, ERawTestEnum::RawTestEnumOne);

	OutRawEnumValue = RawEnumValue;
}

void FTestBindingFunction::SetRawEnumClassValueFunction(const ERawTestEnumClass InRawEnumClassValue)
{
	RawEnumClassValue = InRawEnumClassValue;
}

ERawTestEnumClass FTestBindingFunction::GetRawEnumClassValueFunction() const
{
	return RawEnumClassValue;
}

void FTestBindingFunction::OutRawEnumClassValueFunction(ERawTestEnumClass& OutRawEnumClassValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetRawEnumClassFunction", OutRawEnumClassValue,
	                             ERawTestEnumClass::RawTestEnumClassOne);

	OutRawEnumClassValue = RawEnumClassValue;
}

void FTestBindingFunction::SetStructValueFunction(const FTestStruct& InStructValue)
{
	StructValue = InStructValue;
}

FTestStruct FTestBindingFunction::GetStructValueFunction() const
{
	return StructValue;
}

void FTestBindingFunction::OutStructValueFunction(FTestStruct& OutStructValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetStructFunction", OutStructValue, {1});

	OutStructValue = StructValue;
}

void FTestBindingFunction::SetRawStructValueFunction(const FRawTestStruct& InRawStructValue)
{
	RawStructValue = InRawStructValue;
}

FRawTestStruct FTestBindingFunction::GetRawStructValueFunction() const
{
	return RawStructValue;
}

void FTestBindingFunction::OutRawStructValueFunction(FRawTestStruct& OutRawStructValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetRawStructFunction", OutRawStructValue, {1});

	OutRawStructValue = RawStructValue;
}

void FTestBindingFunction::SetObjectValueFunction(UObject* InObjectValue)
{
	ObjectValue = InObjectValue;
}

UObject* FTestBindingFunction::GetObjectValueFunction() const
{
	return ObjectValue;
}

void FTestBindingFunction::OutObjectValueFunction(UObject*& OutObjectValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetObjectFunction", OutObjectValue,
	                             Cast<UObject>(GWorld->GetWorld()));

	OutObjectValue = ObjectValue;
}

void FTestBindingFunction::SetClassValueFunction(UClass* InClassValue)
{
	ClassValue = InClassValue;
}

UClass* FTestBindingFunction::GetClassValueFunction() const
{
	return ClassValue;
}

void FTestBindingFunction::OutClassValueFunction(UClass*& OutClassValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetClassFunction", OutClassValue, GWorld->GetClass());

	OutClassValue = ClassValue;
}

void FTestBindingFunction::SetSubclassOfValueFunction(const TSubclassOf<UObject>& InSubclassOfValue)
{
	SubclassOfValue = InSubclassOfValue;
}

TSubclassOf<UObject> FTestBindingFunction::GetSubclassOfValueFunction() const
{
	return SubclassOfValue;
}

void FTestBindingFunction::OutSubclassOfValueFunction(TSubclassOf<UObject>& OutSubclassOfValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetSubclassOfFunction", OutSubclassOfValue,
	                             TSubclassOf<UObject>(GWorld->GetClass()));

	OutSubclassOfValue = SubclassOfValue;
}

void FTestBindingFunction::SetWeakObjectPtrValueFunction(const TWeakObjectPtr<UObject>& InWeakObjectPtrValue)
{
	WeakObjectPtrValue = InWeakObjectPtrValue;
}

TWeakObjectPtr<UObject> FTestBindingFunction::GetWeakObjectPtrValueFunction() const
{
	return WeakObjectPtrValue;
}

void FTestBindingFunction::OutWeakObjectPtrValueFunction(TWeakObjectPtr<UObject>& OutWeakObjectPtrValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetWeakObjectPtrFunction", OutWeakObjectPtrValue,
	                             TWeakObjectPtr<UObject>(GWorld));

	OutWeakObjectPtrValue = WeakObjectPtrValue;
}

void FTestBindingFunction::SetLazyObjectPtrValueFunction(const TLazyObjectPtr<UObject>& InLazyObjectPtrValue)
{
	LazyObjectPtrValue = InLazyObjectPtrValue;
}

TLazyObjectPtr<UObject> FTestBindingFunction::GetLazyObjectPtrValueFunction() const
{
	return LazyObjectPtrValue;
}

void FTestBindingFunction::OutLazyObjectPtrValueFunction(TLazyObjectPtr<UObject>& OutLazyObjectPtrValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetLazyObjectPtrFunction", OutLazyObjectPtrValue,
	                             TLazyObjectPtr<UObject>(GWorld));

	OutLazyObjectPtrValue = LazyObjectPtrValue;
}

void FTestBindingFunction::SetSoftObjectPtrValueFunction(const TSoftObjectPtr<UObject>& InSoftObjectPtrValue)
{
	SoftObjectPtrValue = InSoftObjectPtrValue;
}

TSoftObjectPtr<UObject> FTestBindingFunction::GetSoftObjectPtrValueFunction() const
{
	return SoftObjectPtrValue;
}

void FTestBindingFunction::OutSoftObjectPtrValueFunction(TSoftObjectPtr<UObject>& OutSoftObjectPtrValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetSoftObjectPtrFunction", OutSoftObjectPtrValue,
	                             TSoftObjectPtr<UObject>(GWorld->GetWorld()));

	OutSoftObjectPtrValue = SoftObjectPtrValue;
}

void FTestBindingFunction::SetSoftClassPtrValueFunction(const TSoftClassPtr<UObject>& InSoftClassPtrValue)
{
	SoftClassPtrValue = InSoftClassPtrValue;
}

TSoftClassPtr<UObject> FTestBindingFunction::GetSoftClassPtrValueFunction() const
{
	return SoftClassPtrValue;
}

void FTestBindingFunction::OutSoftClassPtrValueFunction(TSoftClassPtr<UObject>& OutSoftClassPtrValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetSoftClassPtrFunction", OutSoftClassPtrValue,
	                             TSoftClassPtr<UObject>(GWorld->GetClass()));

	OutSoftClassPtrValue = SoftClassPtrValue;
}

void FTestBindingFunction::SetArrayValueFunction(const TArray<int32>& InArrayValue)
{
	ArrayValue = InArrayValue;
}

TArray<int32> FTestBindingFunction::GetArrayValueFunction() const
{
	return ArrayValue;
}

void FTestBindingFunction::OutArrayValueFunction(TArray<int32>& OutArrayValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetArrayFunction", OutArrayValue, {1, 2});

	OutArrayValue = ArrayValue;
}

void FTestBindingFunction::SetSetValueFunction(const TSet<int32>& InSetValue)
{
	SetValue = InSetValue;
}

TSet<int32> FTestBindingFunction::GetSetValueFunction() const
{
	return SetValue;
}

void FTestBindingFunction::OutSetValueFunction(TSet<int32>& OutSetValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetSetFunction", OutSetValue, {1, 2});

	OutSetValue = SetValue;
}

void FTestBindingFunction::SetMapValueFunction(const TMap<int32, int32>& InMapValue)
{
	MapValue = InMapValue;
}

TMap<int32, int32> FTestBindingFunction::GetMapValueFunction() const
{
	return MapValue;
}

void FTestBindingFunction::OutMapValueFunction(TMap<int32, int32>& OutMapValue) const
{
	TestCoreSubsystem->TestEqual("RawBindingOutGetMapFunction", OutMapValue, {{1, 1}, {2, 2}});

	OutMapValue = MapValue;
}
