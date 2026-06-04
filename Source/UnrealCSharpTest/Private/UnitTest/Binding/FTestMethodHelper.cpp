#include "UnitTest/Binding/FTestMethodHelper.h"
#include "Engine/World.h"
#include "Binding/Class/TBindingClassBuilder.inl"
#include "Binding/Function/TMethodBuilder.inl"
#include "Macro/NamespaceMacro.h"
#include "TestCore/TestCoreSubsystem.h"

BINDING_CLASS(FTestMethodHelper)

struct FRegisterTestMethodHelper
{
	FRegisterTestMethodHelper()
	{
		TBindingClassBuilder<FTestMethodHelper>(NAMESPACE_BINDING)
			.Property("TestCoreSubsystem", BINDING_PROPERTY(&FTestMethodHelper::TestCoreSubsystem))
			.Property("BoolValue", BINDING_PROPERTY(&FTestMethodHelper::BoolValue))
			.Property("Int8Value", BINDING_PROPERTY(&FTestMethodHelper::Int8Value))
			.Property("Int16Value", BINDING_PROPERTY(&FTestMethodHelper::Int16Value))
			.Property("Int32Value", BINDING_PROPERTY(&FTestMethodHelper::Int32Value))
			.Property("Int64Value", BINDING_PROPERTY(&FTestMethodHelper::Int64Value))
			.Property("UInt8Value", BINDING_PROPERTY(&FTestMethodHelper::UInt8Value))
			.Property("UInt16Value", BINDING_PROPERTY(&FTestMethodHelper::UInt16Value))
			.Property("UInt32Value", BINDING_PROPERTY(&FTestMethodHelper::UInt32Value))
			.Property("UInt64Value", BINDING_PROPERTY(&FTestMethodHelper::UInt64Value))
			.Property("FloatValue", BINDING_PROPERTY(&FTestMethodHelper::FloatValue))
			.Property("DoubleValue", BINDING_PROPERTY(&FTestMethodHelper::DoubleValue))
			.Property("NameValue", BINDING_PROPERTY(&FTestMethodHelper::NameValue))
			.Property("TextValue", BINDING_PROPERTY(&FTestMethodHelper::TextValue))
			.Property("StringValue", BINDING_PROPERTY(&FTestMethodHelper::StringValue))
			.Property("EnumValue", BINDING_PROPERTY(&FTestMethodHelper::EnumValue))
			.Property("EnumAsByteValue", BINDING_PROPERTY(&FTestMethodHelper::EnumAsByteValue))
			.Property("EnumClassValue", BINDING_PROPERTY(&FTestMethodHelper::EnumClassValue))
			.Property("RawEnumValue", BINDING_PROPERTY(&FTestMethodHelper::RawEnumValue))
			.Property("RawEnumClassValue", BINDING_PROPERTY(&FTestMethodHelper::RawEnumClassValue))
			.Property("StructValue", BINDING_PROPERTY(&FTestMethodHelper::StructValue))
			.Property("RawStructValue", BINDING_PROPERTY(&FTestMethodHelper::RawStructValue))
			.Property("ObjectValue", BINDING_PROPERTY(&FTestMethodHelper::ObjectValue))
			.Property("ClassValue", BINDING_PROPERTY(&FTestMethodHelper::ClassValue))
			.Property("SubclassOfValue", BINDING_PROPERTY(&FTestMethodHelper::SubclassOfValue))
			.Property("WeakObjectPtrValue", BINDING_PROPERTY(&FTestMethodHelper::WeakObjectPtrValue))
			.Property("LazyObjectPtrValue", BINDING_PROPERTY(&FTestMethodHelper::LazyObjectPtrValue))
			.Property("SoftObjectPtrValue", BINDING_PROPERTY(&FTestMethodHelper::SoftObjectPtrValue))
			.Property("SoftClassPtrValue", BINDING_PROPERTY(&FTestMethodHelper::SoftClassPtrValue))
			.Property("ArrayValue", BINDING_PROPERTY(&FTestMethodHelper::ArrayValue))
			.Property("SetValue", BINDING_PROPERTY(&FTestMethodHelper::SetValue))
			.Property("MapValue", BINDING_PROPERTY(&FTestMethodHelper::MapValue))
			.Function("Test", BINDING_FUNCTION(&FTestMethodHelper::Test));
	}
};

static FRegisterTestMethodHelper RegisterTestMethodHelper;

FTestMethodHelper::FTestMethodHelper():
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
	ObjectValue(nullptr),
	ClassValue(nullptr),
	SubclassOfValue(nullptr),
	WeakObjectPtrValue(nullptr),
	LazyObjectPtrValue(nullptr),
	SoftObjectPtrValue(nullptr),
	SoftClassPtrValue(nullptr),
	ArrayValue({1, 2}),
	SetValue({1, 2}),
	MapValue({{1, 1}, {2, 2}}),
	TestCoreSubsystem(nullptr)
{
}

void FTestMethodHelper::Test()
{
	// Static
	TestCoreSubsystem->TestEqual("RawMethodHelperStaticFunction",
	                             TMethodBuilder<bool>::Invoke<FTestMethodHelper>(nullptr, TEXT("StaticFunction")),
	                             true);

	// Bool
	TestCoreSubsystem->TestEqual("RawMethodHelperGetBoolFunction",
	                             TMethodBuilder<bool>::Invoke(this, TEXT("GetBoolValueFunction")), true);

	TMethodBuilder<>::Invoke(this, TEXT("SetBoolValueFunction"), false);

	TestCoreSubsystem->TestEqual("RawMethodHelperSetBoolFunction",
	                             TMethodBuilder<bool>::Invoke(this, TEXT("GetBoolValueFunction")), false);

	bool OutBoolValue = true;

	TMethodBuilder<>::Invoke(this, TEXT("OutBoolValueFunction"), OutBoolValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetBoolFunction", OutBoolValue, false);

	// Int8
	TestCoreSubsystem->TestEqual("RawMethodHelperGetInt8Function",
	                             TMethodBuilder<int8>::Invoke(this, TEXT("GetInt8ValueFunction")),
	                             static_cast<int8>(12));

	TMethodBuilder<>::Invoke(this, TEXT("SetInt8ValueFunction"), static_cast<int8>(21));

	TestCoreSubsystem->TestEqual("RawMethodHelperSetInt8Function",
	                             TMethodBuilder<int8>::Invoke(this, TEXT("GetInt8ValueFunction")),
	                             static_cast<int8>(21));

	int8 OutInt8Value = 12;

	TMethodBuilder<>::Invoke(this, TEXT("OutInt8ValueFunction"), OutInt8Value);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetInt8Function", OutInt8Value, static_cast<int8>(21));

	// Int16
	TestCoreSubsystem->TestEqual("RawMethodHelperGetInt16Function",
	                             TMethodBuilder<int16>::Invoke(this, TEXT("GetInt16ValueFunction")),
	                             static_cast<int16>(12));

	TMethodBuilder<>::Invoke(this, TEXT("SetInt16ValueFunction"), static_cast<int16>(21));

	TestCoreSubsystem->TestEqual("RawMethodHelperSetInt16Function",
	                             TMethodBuilder<int16>::Invoke(this, TEXT("GetInt16ValueFunction")),
	                             static_cast<int16>(21));

	int16 OutInt16Value = 12;

	TMethodBuilder<>::Invoke(this, TEXT("OutInt16ValueFunction"), OutInt16Value);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetInt16Function", OutInt16Value, static_cast<int16>(21));

	// Int32
	TestCoreSubsystem->TestEqual("RawMethodHelperGetInt32Function",
	                             TMethodBuilder<int32>::Invoke(this, TEXT("GetInt32ValueFunction")),
	                             static_cast<int32>(12));

	TMethodBuilder<>::Invoke(this, TEXT("SetInt32ValueFunction"), static_cast<int32>(21));

	TestCoreSubsystem->TestEqual("RawMethodHelperSetInt32Function",
	                             TMethodBuilder<int32>::Invoke(this, TEXT("GetInt32ValueFunction")),
	                             static_cast<int32>(21));

	int32 OutInt32Value = 12;

	TMethodBuilder<>::Invoke(this, TEXT("OutInt32ValueFunction"), OutInt32Value);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetInt32Function", OutInt32Value, static_cast<int32>(21));

	// Int64
	TestCoreSubsystem->TestEqual("RawMethodHelperGetInt64Function",
	                             TMethodBuilder<int64>::Invoke(this, TEXT("GetInt64ValueFunction")),
	                             static_cast<int64>(12));

	TMethodBuilder<>::Invoke(this, TEXT("SetInt64ValueFunction"), static_cast<int64>(21));

	TestCoreSubsystem->TestEqual("RawMethodHelperSetInt64Function",
	                             TMethodBuilder<int64>::Invoke(this, TEXT("GetInt64ValueFunction")),
	                             static_cast<int64>(21));

	int64 OutInt64Value = 12;

	TMethodBuilder<>::Invoke(this, TEXT("OutInt64ValueFunction"), OutInt64Value);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetInt64Function", OutInt64Value, static_cast<int64>(21));

	// UInt8
	TestCoreSubsystem->TestEqual("RawMethodHelperGetUInt8Function",
	                             TMethodBuilder<uint8>::Invoke(this, TEXT("GetUInt8ValueFunction")),
	                             static_cast<uint8>(12));

	TMethodBuilder<>::Invoke(this, TEXT("SetUInt8ValueFunction"), static_cast<uint8>(21));

	TestCoreSubsystem->TestEqual("RawMethodHelperSetUInt8Function",
	                             TMethodBuilder<uint8>::Invoke(this, TEXT("GetUInt8ValueFunction")),
	                             static_cast<uint8>(21));

	uint8 OutUInt8Value = 12;

	TMethodBuilder<>::Invoke(this, TEXT("OutUInt8ValueFunction"), OutUInt8Value);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetUInt8Function", OutUInt8Value, static_cast<uint8>(21));

	// UInt16
	TestCoreSubsystem->TestEqual("RawMethodHelperGetUInt16Function",
	                             TMethodBuilder<uint16>::Invoke(this, TEXT("GetUInt16ValueFunction")),
	                             static_cast<uint16>(12));

	TMethodBuilder<>::Invoke(this, TEXT("SetUInt16ValueFunction"), static_cast<uint16>(21));

	TestCoreSubsystem->TestEqual("RawMethodHelperSetUInt16Function",
	                             TMethodBuilder<uint16>::Invoke(this, TEXT("GetUInt16ValueFunction")),
	                             static_cast<uint16>(21));

	uint16 OutUInt16Value = 12;

	TMethodBuilder<>::Invoke(this, TEXT("OutUInt16ValueFunction"), OutUInt16Value);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetUInt16Function", OutUInt16Value, static_cast<uint16>(21));

	// UInt32
	TestCoreSubsystem->TestEqual("RawMethodHelperGetUInt32Function",
	                             TMethodBuilder<uint32>::Invoke(this, TEXT("GetUInt32ValueFunction")),
	                             static_cast<uint32>(12));

	TMethodBuilder<>::Invoke(this, TEXT("SetUInt32ValueFunction"), static_cast<uint32>(21));

	TestCoreSubsystem->TestEqual("RawMethodHelperSetUInt32Function",
	                             TMethodBuilder<uint32>::Invoke(this, TEXT("GetUInt32ValueFunction")),
	                             static_cast<uint32>(21));

	uint32 OutUInt32Value = 12;

	TMethodBuilder<>::Invoke(this, TEXT("OutUInt32ValueFunction"), OutUInt32Value);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetUInt32Function", OutUInt32Value, static_cast<uint32>(21));

	// UInt64
	TestCoreSubsystem->TestEqual("RawMethodHelperGetUInt64Function",
	                             TMethodBuilder<uint64>::Invoke(this, TEXT("GetUInt64ValueFunction")),
	                             static_cast<uint64>(12));

	TMethodBuilder<>::Invoke(this, TEXT("SetUInt64ValueFunction"), static_cast<uint64>(21));

	TestCoreSubsystem->TestEqual("RawMethodHelperSetUInt64Function",
	                             TMethodBuilder<uint64>::Invoke(this, TEXT("GetUInt64ValueFunction")),
	                             static_cast<uint64>(21));

	uint64 OutUInt64Value = 12;

	TMethodBuilder<>::Invoke(this, TEXT("OutUInt64ValueFunction"), OutUInt64Value);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetUInt64Function", OutUInt64Value, static_cast<uint64>(21));

	// Float
	TestCoreSubsystem->TestEqual("RawMethodHelperGetFloatFunction",
	                             TMethodBuilder<float>::Invoke(this, TEXT("GetFloatValueFunction")), 12.3f);

	TMethodBuilder<>::Invoke(this, TEXT("SetFloatValueFunction"), 3.21f);

	TestCoreSubsystem->TestEqual("RawMethodHelperSetFloatFunction",
	                             TMethodBuilder<float>::Invoke(this, TEXT("GetFloatValueFunction")), 3.21f);

	float OutFloatValue = 12.3f;

	TMethodBuilder<>::Invoke(this, TEXT("OutFloatValueFunction"), OutFloatValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetFloatFunction", OutFloatValue, 3.21f);

	// Double
	TestCoreSubsystem->TestEqual("RawMethodHelperGetDoubleFunction",
	                             TMethodBuilder<double>::Invoke(this, TEXT("GetDoubleValueFunction")), 12.3);

	TMethodBuilder<>::Invoke(this, TEXT("SetDoubleValueFunction"), 3.21);

	TestCoreSubsystem->TestEqual("RawMethodHelperSetDoubleFunction",
	                             TMethodBuilder<double>::Invoke(this, TEXT("GetDoubleValueFunction")), 3.21);

	double OutDoubleValue = 12.3;

	TMethodBuilder<>::Invoke(this, TEXT("OutDoubleValueFunction"), OutDoubleValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetDoubleFunction", OutDoubleValue, 3.21);

	// FName
	TestCoreSubsystem->TestEqual("RawMethodHelperGetNameFunction",
	                             TMethodBuilder<FName>::Invoke(this, TEXT("GetNameValueFunction")),
	                             FName(TEXT("Name12")));

	TMethodBuilder<>::Invoke(this, TEXT("SetNameValueFunction"), FName(TEXT("21emaN")));

	TestCoreSubsystem->TestEqual("RawMethodHelperSetNameFunction",
	                             TMethodBuilder<FName>::Invoke(this, TEXT("GetNameValueFunction")),
	                             FName(TEXT("21emaN")));

	auto OutNameValue = FName(TEXT("Name12"));

	TMethodBuilder<>::Invoke(this, TEXT("OutNameValueFunction"), OutNameValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetNameFunction", OutNameValue, FName(TEXT("21emaN")));

	// FText
	TestCoreSubsystem->TestEqual("RawMethodHelperGetTextFunction",
	                             TMethodBuilder<FText>::Invoke(this, TEXT("GetTextValueFunction")),
	                             FText::FromString(TEXT("Text12")));

	TMethodBuilder<>::Invoke(this, TEXT("SetTextValueFunction"), FText::FromString(TEXT("21txeT")));

	TestCoreSubsystem->TestEqual("RawMethodHelperSetTextFunction",
	                             TMethodBuilder<FText>::Invoke(this, TEXT("GetTextValueFunction")),
	                             FText::FromString(TEXT("21txeT")));

	auto OutTextValue = FText::FromString(TEXT("Text12"));

	TMethodBuilder<>::Invoke(this, TEXT("OutTextValueFunction"), OutTextValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetTextFunction", OutTextValue, FText::FromString(TEXT("21txeT")));

	// FString
	TestCoreSubsystem->TestEqual("RawMethodHelperGetStringFunction",
	                             TMethodBuilder<FString>::Invoke(this, TEXT("GetStringValueFunction")),
	                             FString(TEXT("String12")));

	TMethodBuilder<>::Invoke(this, TEXT("SetStringValueFunction"), FString(TEXT("21gnirtS")));

	TestCoreSubsystem->TestEqual("RawMethodHelperSetStringFunction",
	                             TMethodBuilder<FString>::Invoke(this, TEXT("GetStringValueFunction")),
	                             FString(TEXT("21gnirtS")));

	auto OutStringValue = FString(TEXT("String12"));

	TMethodBuilder<>::Invoke(this, TEXT("OutStringValueFunction"), OutStringValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetStringFunction", OutStringValue, FString(TEXT("21gnirtS")));

	// Enum
	TestCoreSubsystem->TestEqual("RawMethodHelperGetEnumFunction",
	                             TMethodBuilder<ETestEnum>::Invoke(this, TEXT("GetEnumValueFunction")),
	                             ETestEnum::TestEnumOne);

	TMethodBuilder<>::Invoke(this, TEXT("SetEnumValueFunction"), ETestEnum::TestEnumTwo);

	TestCoreSubsystem->TestEqual("RawMethodHelperSetEnumFunction",
	                             TMethodBuilder<ETestEnum>::Invoke(this, TEXT("GetEnumValueFunction")),
	                             ETestEnum::TestEnumTwo);

	auto OutEnumValue = ETestEnum::TestEnumOne;

	TMethodBuilder<>::Invoke(this, TEXT("OutEnumValueFunction"), OutEnumValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetEnumFunction", OutEnumValue, ETestEnum::TestEnumTwo);

	// TEnumAsByte
	TestCoreSubsystem->TestEqual("RawMethodHelperGetEnumAsByteFunction",
	                             TMethodBuilder<TEnumAsByte<ETestEnum>>::Invoke(
		                             this, TEXT("GetEnumAsByteValueFunction")),
	                             TEnumAsByte<ETestEnum>(ETestEnum::TestEnumOne));

	TMethodBuilder<>::Invoke(this, TEXT("SetEnumAsByteValueFunction"), TEnumAsByte<ETestEnum>(ETestEnum::TestEnumTwo));

	TestCoreSubsystem->TestEqual("RawMethodHelperSetEnumAsByteFunction",
	                             TMethodBuilder<TEnumAsByte<ETestEnum>>::Invoke(
		                             this, TEXT("GetEnumAsByteValueFunction")),
	                             TEnumAsByte<ETestEnum>(ETestEnum::TestEnumTwo));

	auto OutEnumAsByteValue = TEnumAsByte<ETestEnum>(ETestEnum::TestEnumOne);

	TMethodBuilder<>::Invoke(this, TEXT("OutEnumAsByteValueFunction"), OutEnumAsByteValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetEnumAsByteFunction", OutEnumAsByteValue.GetValue(),
	                             ETestEnum::TestEnumTwo);

	// EnumClass
	TestCoreSubsystem->TestEqual("RawMethodHelperGetEnumClassFunction",
	                             TMethodBuilder<ETestEnumClass>::Invoke(this, TEXT("GetEnumClassValueFunction")),
	                             ETestEnumClass::TestEnumClassOne);

	TMethodBuilder<>::Invoke(this, TEXT("SetEnumClassValueFunction"), ETestEnumClass::TestEnumClassTwo);

	TestCoreSubsystem->TestEqual("RawMethodHelperSetEnumClassFunction",
	                             TMethodBuilder<ETestEnumClass>::Invoke(this, TEXT("GetEnumClassValueFunction")),
	                             ETestEnumClass::TestEnumClassTwo);

	auto OutEnumClassValue = ETestEnumClass::TestEnumClassOne;

	TMethodBuilder<>::Invoke(this, TEXT("OutEnumClassValueFunction"), OutEnumClassValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetEnumClassFunction", OutEnumClassValue,
	                             ETestEnumClass::TestEnumClassTwo);

	// RawEnum
	TestCoreSubsystem->TestEqual("RawMethodHelperGetRawEnumFunction",
	                             TMethodBuilder<ERawTestEnum>::Invoke(this, TEXT("GetRawEnumValueFunction")),
	                             ERawTestEnum::RawTestEnumOne);

	TMethodBuilder<>::Invoke(this, TEXT("SetRawEnumValueFunction"), ERawTestEnum::RawTestEnumTwo);

	TestCoreSubsystem->TestEqual("RawMethodHelperSetRawEnumFunction",
	                             TMethodBuilder<ERawTestEnum>::Invoke(this, TEXT("GetRawEnumValueFunction")),
	                             ERawTestEnum::RawTestEnumTwo);

	auto OutRawEnumValue = ERawTestEnum::RawTestEnumOne;

	TMethodBuilder<>::Invoke(this, TEXT("OutRawEnumValueFunction"), OutRawEnumValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetRawEnumFunction", OutRawEnumValue, ERawTestEnum::RawTestEnumTwo);

	// RawEnumClass
	TestCoreSubsystem->TestEqual("RawMethodHelperGetRawEnumClassFunction",
	                             TMethodBuilder<ERawTestEnumClass>::Invoke(this, TEXT("GetRawEnumClassValueFunction")),
	                             ERawTestEnumClass::RawTestEnumClassOne);

	TMethodBuilder<>::Invoke(this, TEXT("SetRawEnumClassValueFunction"), ERawTestEnumClass::RawTestEnumClassTwo);

	TestCoreSubsystem->TestEqual("RawMethodHelperSetRawEnumClassFunction",
	                             TMethodBuilder<ERawTestEnumClass>::Invoke(this, TEXT("GetRawEnumClassValueFunction")),
	                             ERawTestEnumClass::RawTestEnumClassTwo);

	auto OutRawEnumClassValue = ERawTestEnumClass::RawTestEnumClassOne;

	TMethodBuilder<>::Invoke(this, TEXT("OutRawEnumClassValueFunction"), OutRawEnumClassValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetRawEnumClassFunction", OutRawEnumClassValue,
	                             ERawTestEnumClass::RawTestEnumClassTwo);

	// UStruct
	TestCoreSubsystem->TestEqual("RawMethodHelperGetStructFunction",
	                             TMethodBuilder<FTestStruct>::Invoke(this, TEXT("GetStructValueFunction")),
	                             FTestStruct{1});

	TMethodBuilder<>::Invoke(this, TEXT("SetStructValueFunction"), FTestStruct{2});

	TestCoreSubsystem->TestEqual("RawMethodHelperSetStructFunction",
	                             TMethodBuilder<FTestStruct>::Invoke(this, TEXT("GetStructValueFunction")),
	                             FTestStruct{2});

	auto OutStructValue = FTestStruct{1};

	TMethodBuilder<>::Invoke(this, TEXT("OutStructValueFunction"), OutStructValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetStructFunction", OutStructValue, FTestStruct{2});

	// RawStruct
	TestCoreSubsystem->TestEqual("RawMethodHelperGetRawStructFunction",
	                             TMethodBuilder<FRawTestStruct>::Invoke(this, TEXT("GetRawStructValueFunction")),
	                             FRawTestStruct{1});

	TMethodBuilder<>::Invoke(this, TEXT("SetRawStructValueFunction"), FRawTestStruct{2});

	TestCoreSubsystem->TestEqual("RawMethodHelperSetRawStructFunction",
	                             TMethodBuilder<FRawTestStruct>::Invoke(this, TEXT("GetRawStructValueFunction")),
	                             FRawTestStruct{2});

	auto OutRawStructValue = FRawTestStruct{1};

	TMethodBuilder<>::Invoke(this, TEXT("OutRawStructValueFunction"), OutRawStructValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetRawStructFunction", OutRawStructValue, FRawTestStruct{2});

	// UObject
	TestCoreSubsystem->TestEqual("RawMethodHelperGetObjectFunction",
	                             TMethodBuilder<UObject*>::Invoke(this, TEXT("GetObjectValueFunction")),
	                             static_cast<UObject*>(nullptr));

	TMethodBuilder<>::Invoke(this, TEXT("SetObjectValueFunction"), Cast<UObject>(TestCoreSubsystem));

	TestCoreSubsystem->TestEqual("RawMethodHelperSetObjectFunction",
	                             TMethodBuilder<UObject*>::Invoke(this, TEXT("GetObjectValueFunction")),
	                             Cast<UObject>(TestCoreSubsystem));

	UObject* OutObjectValue = nullptr;

	TMethodBuilder<>::Invoke(this, TEXT("OutObjectValueFunction"), OutObjectValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetObjectFunction", OutObjectValue,
	                             Cast<UObject>(TestCoreSubsystem));

	// UClass
	TestCoreSubsystem->TestEqual("RawMethodHelperGetClassFunction",
	                             TMethodBuilder<UClass*>::Invoke(this, TEXT("GetClassValueFunction")),
	                             static_cast<UClass*>(nullptr));

	TMethodBuilder<>::Invoke(this, TEXT("SetClassValueFunction"), TestCoreSubsystem->GetClass());

	TestCoreSubsystem->TestEqual("RawMethodHelperSetClassFunction",
	                             TMethodBuilder<UClass*>::Invoke(this, TEXT("GetClassValueFunction")),
	                             TestCoreSubsystem->GetClass());

	UClass* OutClassValue = nullptr;

	TMethodBuilder<>::Invoke(this, TEXT("OutClassValueFunction"), OutClassValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetClassFunction", OutClassValue, TestCoreSubsystem->GetClass());

	// TSubclassOf
	TestCoreSubsystem->TestEqual("RawMethodHelperGetSubclassOfFunction",
	                             TMethodBuilder<TSubclassOf<UObject>>::Invoke(this, TEXT("GetSubclassOfValueFunction")),
	                             TSubclassOf<UObject>(nullptr));

	TMethodBuilder<>::Invoke(this, TEXT("SetSubclassOfValueFunction"),
	                         TSubclassOf<UObject>(TestCoreSubsystem->GetClass()));

	TestCoreSubsystem->TestEqual("RawMethodHelperSetSubclassOfFunction",
	                             TMethodBuilder<TSubclassOf<UObject>>::Invoke(this, TEXT("GetSubclassOfValueFunction")),
	                             TSubclassOf<UObject>(TestCoreSubsystem->GetClass()));

	auto OutSubclassOfValue = TSubclassOf<UObject>(TestCoreSubsystem->GetClass());

	TMethodBuilder<>::Invoke(this, TEXT("OutSubclassOfValueFunction"), OutSubclassOfValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetSubclassOfFunction", OutSubclassOfValue,
	                             TSubclassOf<UObject>(TestCoreSubsystem->GetClass()));

	// TWeakObjectPtr
	TestCoreSubsystem->TestEqual("RawMethodHelperGetWeakObjectPtrFunction",
	                             TMethodBuilder<TWeakObjectPtr<UObject>>::Invoke(
		                             this, TEXT("GetWeakObjectPtrValueFunction")),
	                             TWeakObjectPtr<UObject>(nullptr));

	TMethodBuilder<>::Invoke(this, TEXT("SetWeakObjectPtrValueFunction"), TWeakObjectPtr<UObject>(TestCoreSubsystem));

	TestCoreSubsystem->TestEqual("RawMethodHelperSetWeakObjectPtrFunction",
	                             TMethodBuilder<TWeakObjectPtr<UObject>>::Invoke(
		                             this, TEXT("GetWeakObjectPtrValueFunction")),
	                             TWeakObjectPtr<UObject>(TestCoreSubsystem));

	auto OutWeakObjectPtrValue = TWeakObjectPtr<UObject>(TestCoreSubsystem);

	TMethodBuilder<>::Invoke(this, TEXT("OutWeakObjectPtrValueFunction"), OutWeakObjectPtrValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetWeakObjectPtrFunction", OutWeakObjectPtrValue,
	                             TWeakObjectPtr<UObject>(TestCoreSubsystem));

	// TLazyObjectPtr
	TestCoreSubsystem->TestEqual("RawMethodHelperGetLazyObjectPtrFunction",
	                             TMethodBuilder<TLazyObjectPtr<UObject>>::Invoke(
		                             this, TEXT("GetLazyObjectPtrValueFunction")),
	                             TLazyObjectPtr<UObject>(nullptr));

	TMethodBuilder<>::Invoke(this, TEXT("SetLazyObjectPtrValueFunction"), TLazyObjectPtr<UObject>(TestCoreSubsystem));

	TestCoreSubsystem->TestEqual("RawMethodHelperSetLazyObjectPtrFunction",
	                             TMethodBuilder<TLazyObjectPtr<UObject>>::Invoke(
		                             this, TEXT("GetLazyObjectPtrValueFunction")),
	                             TLazyObjectPtr<UObject>(TestCoreSubsystem));

	auto OutLazyObjectPtrValue = TLazyObjectPtr<UObject>(TestCoreSubsystem);

	TMethodBuilder<>::Invoke(this, TEXT("OutLazyObjectPtrValueFunction"), OutLazyObjectPtrValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetLazyObjectPtrFunction", OutLazyObjectPtrValue,
	                             TLazyObjectPtr<UObject>(TestCoreSubsystem));

	// TSoftObjectPtr
	TestCoreSubsystem->TestEqual("RawMethodHelperGetSoftObjectPtrFunction",
	                             TMethodBuilder<TSoftObjectPtr<UObject>>::Invoke(
		                             this, TEXT("GetSoftObjectPtrValueFunction")),
	                             TSoftObjectPtr<UObject>(nullptr));

	TMethodBuilder<>::Invoke(this, TEXT("SetSoftObjectPtrValueFunction"), TSoftObjectPtr<UObject>(TestCoreSubsystem));

	TestCoreSubsystem->TestEqual("RawMethodHelperSetSoftObjectPtrFunction",
	                             TMethodBuilder<TSoftObjectPtr<UObject>>::Invoke(
		                             this, TEXT("GetSoftObjectPtrValueFunction")),
	                             TSoftObjectPtr<UObject>(TestCoreSubsystem));

	auto OutSoftObjectPtrValue = TSoftObjectPtr<UObject>(TestCoreSubsystem);

	TMethodBuilder<>::Invoke(this, TEXT("OutSoftObjectPtrValueFunction"), OutSoftObjectPtrValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetSoftObjectPtrFunction", OutSoftObjectPtrValue,
	                             TSoftObjectPtr<UObject>(TestCoreSubsystem));

	// TSoftClassPtr
	TestCoreSubsystem->TestEqual("RawMethodHelperGetSoftClassPtrFunction",
	                             TMethodBuilder<TSoftClassPtr<UObject>>::Invoke(
		                             this, TEXT("GetSoftClassPtrValueFunction")),
	                             TSoftClassPtr<UObject>(nullptr));

	TMethodBuilder<>::Invoke(this, TEXT("SetSoftClassPtrValueFunction"),
	                         TSoftClassPtr<UObject>(TestCoreSubsystem->GetClass()));

	TestCoreSubsystem->TestEqual("RawMethodHelperSetSoftClassPtrFunction",
	                             TMethodBuilder<TSoftClassPtr<UObject>>::Invoke(
		                             this, TEXT("GetSoftClassPtrValueFunction")),
	                             TSoftClassPtr<UObject>(TestCoreSubsystem->GetClass()));

	auto OutSoftClassPtrValue = TSoftClassPtr<UObject>(TestCoreSubsystem->GetClass());

	TMethodBuilder<>::Invoke(this, TEXT("OutSoftClassPtrValueFunction"), OutSoftClassPtrValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetSoftClassPtrFunction", OutSoftClassPtrValue,
	                             TSoftClassPtr<UObject>(TestCoreSubsystem->GetClass()));

	// TArray
	TestCoreSubsystem->TestEqual("RawMethodHelperGetArrayFunction",
	                             TMethodBuilder<TArray<int32>>::Invoke(this, TEXT("GetArrayValueFunction")),
	                             TArray<int32>{1, 2});

	TMethodBuilder<>::Invoke(this, TEXT("SetArrayValueFunction"), TArray<int32>{3, 4});

	TestCoreSubsystem->TestEqual("RawMethodHelperSetArrayFunction",
	                             TMethodBuilder<TArray<int32>>::Invoke(this, TEXT("GetArrayValueFunction")),
	                             TArray<int32>{3, 4});

	auto OutArrayValue = TArray<int32>{1, 2};

	TMethodBuilder<>::Invoke(this, TEXT("OutArrayValueFunction"), OutArrayValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetArrayFunction", OutArrayValue, TArray<int32>{3, 4});

	// TSet
	TestCoreSubsystem->TestEqual("RawMethodHelperGetSetFunction",
	                             TMethodBuilder<TSet<int32>>::Invoke(this, TEXT("GetSetValueFunction")),
	                             TSet<int32>{1, 2});

	TMethodBuilder<>::Invoke(this, TEXT("SetSetValueFunction"), TSet<int32>{3, 4});

	TestCoreSubsystem->TestEqual("RawMethodHelperSetSetFunction",
	                             TMethodBuilder<TSet<int32>>::Invoke(this, TEXT("GetSetValueFunction")),
	                             TSet<int32>{3, 4});

	auto OutSetValue = TSet<int32>{1, 2};

	TMethodBuilder<>::Invoke(this, TEXT("OutSetValueFunction"), OutSetValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetSetFunction", OutSetValue, TSet<int32>{3, 4});

	// TMap
	TestCoreSubsystem->TestEqual("RawMethodHelperGetMapFunction",
	                             TMethodBuilder<TMap<int32, int32>>::Invoke(this, TEXT("GetMapValueFunction")),
	                             TMap<int32, int32>({{1, 1}, {2, 2}}));

	TMethodBuilder<>::Invoke(this, TEXT("SetMapValueFunction"), TMap<int32, int32>({{3, 3}, {4, 4}}));

	TestCoreSubsystem->TestEqual("RawMethodHelperSetMapFunction",
	                             TMethodBuilder<TMap<int32, int32>>::Invoke(this, TEXT("GetMapValueFunction")),
	                             TMap<int32, int32>({{3, 3}, {4, 4}}));

	auto OutMapValue = TMap<int32, int32>{{1, 1}, {2, 2}};

	TMethodBuilder<>::Invoke(this, TEXT("OutMapValueFunction"), OutMapValue);

	TestCoreSubsystem->TestEqual("RawMethodHelperOutSetMapFunction", OutMapValue, TMap<int32, int32>({{3, 3}, {4, 4}}));
}
