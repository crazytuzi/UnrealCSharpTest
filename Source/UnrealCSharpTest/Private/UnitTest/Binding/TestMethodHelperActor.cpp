// Fill out your copyright notice in the Description page of Project Settings.


#include "UnitTest/Binding/TestMethodHelperActor.h"
#include "Engine/World.h"
#include "Binding/Class/TBindingClassBuilder.inl"
#include "Binding/Function/TMethodBuilder.inl"
#include "Macro/NamespaceMacro.h"
#include "TestCore/TestCoreSubsystem.h"

struct FRegisterTestMethodHelperActor
{
	FRegisterTestMethodHelperActor()
	{
		TBindingClassBuilder<ATestMethodHelperActor>(NAMESPACE_BINDING)
			.Property("TestCoreSubsystem", BINDING_PROPERTY(&ATestMethodHelperActor::TestCoreSubsystem))
			.Property("BoolValue", BINDING_PROPERTY(&ATestMethodHelperActor::BoolValue))
			.Property("Int8Value", BINDING_PROPERTY(&ATestMethodHelperActor::Int8Value))
			.Property("Int16Value", BINDING_PROPERTY(&ATestMethodHelperActor::Int16Value))
			.Property("Int32Value", BINDING_PROPERTY(&ATestMethodHelperActor::Int32Value))
			.Property("Int64Value", BINDING_PROPERTY(&ATestMethodHelperActor::Int64Value))
			.Property("UInt8Value", BINDING_PROPERTY(&ATestMethodHelperActor::UInt8Value))
			.Property("UInt16Value", BINDING_PROPERTY(&ATestMethodHelperActor::UInt16Value))
			.Property("UInt32Value", BINDING_PROPERTY(&ATestMethodHelperActor::UInt32Value))
			.Property("UInt64Value", BINDING_PROPERTY(&ATestMethodHelperActor::UInt64Value))
			.Property("FloatValue", BINDING_PROPERTY(&ATestMethodHelperActor::FloatValue))
			.Property("DoubleValue", BINDING_PROPERTY(&ATestMethodHelperActor::DoubleValue))
			.Property("NameValue", BINDING_PROPERTY(&ATestMethodHelperActor::NameValue))
			.Property("TextValue", BINDING_PROPERTY(&ATestMethodHelperActor::TextValue))
			.Property("StringValue", BINDING_PROPERTY(&ATestMethodHelperActor::StringValue))
			.Property("EnumValue", BINDING_PROPERTY(&ATestMethodHelperActor::EnumValue))
			.Property("EnumAsByteValue", BINDING_PROPERTY(&ATestMethodHelperActor::EnumAsByteValue))
			.Property("EnumClassValue", BINDING_PROPERTY(&ATestMethodHelperActor::EnumClassValue))
			.Property("RawEnumValue", BINDING_PROPERTY(&ATestMethodHelperActor::RawEnumValue))
			.Property("RawEnumClassValue", BINDING_PROPERTY(&ATestMethodHelperActor::RawEnumClassValue))
			.Property("StructValue", BINDING_PROPERTY(&ATestMethodHelperActor::StructValue))
			.Property("RawStructValue", BINDING_PROPERTY(&ATestMethodHelperActor::RawStructValue))
			.Property("ObjectValue", BINDING_PROPERTY(&ATestMethodHelperActor::ObjectValue))
			.Property("InterfaceValue", BINDING_PROPERTY(&ATestMethodHelperActor::InterfaceValue))
			.Property("ClassValue", BINDING_PROPERTY(&ATestMethodHelperActor::ClassValue))
			.Property("SubclassOfValue", BINDING_PROPERTY(&ATestMethodHelperActor::SubclassOfValue))
			.Property("WeakObjectPtrValue", BINDING_PROPERTY(&ATestMethodHelperActor::WeakObjectPtrValue))
			.Property("LazyObjectPtrValue", BINDING_PROPERTY(&ATestMethodHelperActor::LazyObjectPtrValue))
			.Property("SoftObjectPtrValue", BINDING_PROPERTY(&ATestMethodHelperActor::SoftObjectPtrValue))
			.Property("SoftClassPtrValue", BINDING_PROPERTY(&ATestMethodHelperActor::SoftClassPtrValue))
			.Property("ArrayValue", BINDING_PROPERTY(&ATestMethodHelperActor::ArrayValue))
			.Property("SetValue", BINDING_PROPERTY(&ATestMethodHelperActor::SetValue))
			.Property("MapValue", BINDING_PROPERTY(&ATestMethodHelperActor::MapValue))
			.Function("Test", BINDING_FUNCTION(&ATestMethodHelperActor::Test));
	}
};

static FRegisterTestMethodHelperActor RegisterTestMethodHelperActor;

// Sets default values
ATestMethodHelperActor::ATestMethodHelperActor():
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
	ObjectValue(this),
	ClassValue(GetClass()),
	InterfaceValue(this),
	SubclassOfValue(GetClass()),
	WeakObjectPtrValue(this),
	LazyObjectPtrValue(this),
	SoftObjectPtrValue(this),
	SoftClassPtrValue(GetClass()),
	ArrayValue({1, 2}),
	SetValue({1, 2}),
	MapValue({{1, 1}, {2, 2}}),
	TestCoreSubsystem(nullptr)
{
	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;
}

// Called when the game starts or when spawned
void ATestMethodHelperActor::BeginPlay()
{
	Super::BeginPlay();
}

// Called every frame
void ATestMethodHelperActor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);
}

void ATestMethodHelperActor::Test()
{
	// Static
	TestCoreSubsystem->TestEqual("MethodHelperStaticFunction",
	                             TMethodBuilder<bool>::Invoke<ATestMethodHelperActor>(nullptr, TEXT("StaticFunction")),
	                             true);

	// Bool
	TestCoreSubsystem->TestEqual("MethodHelperGetBoolFunction",
	                             TMethodBuilder<bool>::Invoke(this, TEXT("GetBoolValueFunction")), true);

	TMethodBuilder<>::Invoke(this, TEXT("SetBoolValueFunction"), false);

	TestCoreSubsystem->TestEqual("MethodHelperSetBoolFunction",
	                             TMethodBuilder<bool>::Invoke(this, TEXT("GetBoolValueFunction")), false);

	bool OutBoolValue = true;

	TMethodBuilder<>::Invoke(this, TEXT("OutBoolValueFunction"), OutBoolValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetBoolFunction", OutBoolValue, false);

	// Int8
	TestCoreSubsystem->TestEqual("MethodHelperGetInt8Function",
	                             TMethodBuilder<int8>::Invoke(this, TEXT("GetInt8ValueFunction")),
	                             static_cast<int8>(12));

	TMethodBuilder<>::Invoke(this, TEXT("SetInt8ValueFunction"), static_cast<int8>(21));

	TestCoreSubsystem->TestEqual("MethodHelperSetInt8Function",
	                             TMethodBuilder<int8>::Invoke(this, TEXT("GetInt8ValueFunction")),
	                             static_cast<int8>(21));

	int8 OutInt8Value = 12;

	TMethodBuilder<>::Invoke(this, TEXT("OutInt8ValueFunction"), OutInt8Value);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetInt8Function", OutInt8Value, static_cast<int8>(21));

	// Int16
	TestCoreSubsystem->TestEqual("MethodHelperGetInt16Function",
	                             TMethodBuilder<int16>::Invoke(this, TEXT("GetInt16ValueFunction")),
	                             static_cast<int16>(12));

	TMethodBuilder<>::Invoke(this, TEXT("SetInt16ValueFunction"), static_cast<int16>(21));

	TestCoreSubsystem->TestEqual("MethodHelperSetInt16Function",
	                             TMethodBuilder<int16>::Invoke(this, TEXT("GetInt16ValueFunction")),
	                             static_cast<int16>(21));

	int16 OutInt16Value = 12;

	TMethodBuilder<>::Invoke(this, TEXT("OutInt16ValueFunction"), OutInt16Value);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetInt16Function", OutInt16Value, static_cast<int16>(21));

	// Int32
	TestCoreSubsystem->TestEqual("MethodHelperGetInt32Function",
	                             TMethodBuilder<int32>::Invoke(this, TEXT("GetInt32ValueFunction")),
	                             static_cast<int32>(12));

	TMethodBuilder<>::Invoke(this, TEXT("SetInt32ValueFunction"), static_cast<int32>(21));

	TestCoreSubsystem->TestEqual("MethodHelperSetInt32Function",
	                             TMethodBuilder<int32>::Invoke(this, TEXT("GetInt32ValueFunction")),
	                             static_cast<int32>(21));

	int32 OutInt32Value = 12;

	TMethodBuilder<>::Invoke(this, TEXT("OutInt32ValueFunction"), OutInt32Value);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetInt32Function", OutInt32Value, static_cast<int32>(21));

	// Int64
	TestCoreSubsystem->TestEqual("MethodHelperGetInt64Function",
	                             TMethodBuilder<int64>::Invoke(this, TEXT("GetInt64ValueFunction")),
	                             static_cast<int64>(12));

	TMethodBuilder<>::Invoke(this, TEXT("SetInt64ValueFunction"), static_cast<int64>(21));

	TestCoreSubsystem->TestEqual("MethodHelperSetInt64Function",
	                             TMethodBuilder<int64>::Invoke(this, TEXT("GetInt64ValueFunction")),
	                             static_cast<int64>(21));

	int64 OutInt64Value = 12;

	TMethodBuilder<>::Invoke(this, TEXT("OutInt64ValueFunction"), OutInt64Value);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetInt64Function", OutInt64Value, static_cast<int64>(21));

	// UInt8
	TestCoreSubsystem->TestEqual("MethodHelperGetUInt8Function",
	                             TMethodBuilder<uint8>::Invoke(this, TEXT("GetUInt8ValueFunction")),
	                             static_cast<uint8>(12));

	TMethodBuilder<>::Invoke(this, TEXT("SetUInt8ValueFunction"), static_cast<uint8>(21));

	TestCoreSubsystem->TestEqual("MethodHelperSetUInt8Function",
	                             TMethodBuilder<uint8>::Invoke(this, TEXT("GetUInt8ValueFunction")),
	                             static_cast<uint8>(21));

	uint8 OutUInt8Value = 12;

	TMethodBuilder<>::Invoke(this, TEXT("OutUInt8ValueFunction"), OutUInt8Value);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetUInt8Function", OutUInt8Value, static_cast<uint8>(21));

	// UInt16
	TestCoreSubsystem->TestEqual("MethodHelperGetUInt16Function",
	                             TMethodBuilder<uint16>::Invoke(this, TEXT("GetUInt16ValueFunction")),
	                             static_cast<uint16>(12));

	TMethodBuilder<>::Invoke(this, TEXT("SetUInt16ValueFunction"), static_cast<uint16>(21));

	TestCoreSubsystem->TestEqual("MethodHelperSetUInt16Function",
	                             TMethodBuilder<uint16>::Invoke(this, TEXT("GetUInt16ValueFunction")),
	                             static_cast<uint16>(21));

	uint16 OutUInt16Value = 12;

	TMethodBuilder<>::Invoke(this, TEXT("OutUInt16ValueFunction"), OutUInt16Value);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetUInt16Function", OutUInt16Value, static_cast<uint16>(21));

	// UInt32
	TestCoreSubsystem->TestEqual("MethodHelperGetUInt32Function",
	                             TMethodBuilder<uint32>::Invoke(this, TEXT("GetUInt32ValueFunction")),
	                             static_cast<uint32>(12));

	TMethodBuilder<>::Invoke(this, TEXT("SetUInt32ValueFunction"), static_cast<uint32>(21));

	TestCoreSubsystem->TestEqual("MethodHelperSetUInt32Function",
	                             TMethodBuilder<uint32>::Invoke(this, TEXT("GetUInt32ValueFunction")),
	                             static_cast<uint32>(21));

	uint32 OutUInt32Value = 12;

	TMethodBuilder<>::Invoke(this, TEXT("OutUInt32ValueFunction"), OutUInt32Value);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetUInt32Function", OutUInt32Value, static_cast<uint32>(21));

	// UInt64
	TestCoreSubsystem->TestEqual("MethodHelperGetUInt64Function",
	                             TMethodBuilder<uint64>::Invoke(this, TEXT("GetUInt64ValueFunction")),
	                             static_cast<uint64>(12));

	TMethodBuilder<>::Invoke(this, TEXT("SetUInt64ValueFunction"), static_cast<uint64>(21));

	TestCoreSubsystem->TestEqual("MethodHelperSetUInt64Function",
	                             TMethodBuilder<uint64>::Invoke(this, TEXT("GetUInt64ValueFunction")),
	                             static_cast<uint64>(21));

	uint64 OutUInt64Value = 12;

	TMethodBuilder<>::Invoke(this, TEXT("OutUInt64ValueFunction"), OutUInt64Value);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetUInt64Function", OutUInt64Value, static_cast<uint64>(21));

	// Float
	TestCoreSubsystem->TestEqual("MethodHelperGetFloatFunction",
	                             TMethodBuilder<float>::Invoke(this, TEXT("GetFloatValueFunction")), 12.3f);

	TMethodBuilder<>::Invoke(this, TEXT("SetFloatValueFunction"), 3.21f);

	TestCoreSubsystem->TestEqual("MethodHelperSetFloatFunction",
	                             TMethodBuilder<float>::Invoke(this, TEXT("GetFloatValueFunction")), 3.21f);

	float OutFloatValue = 12.3f;

	TMethodBuilder<>::Invoke(this, TEXT("OutFloatValueFunction"), OutFloatValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetFloatFunction", OutFloatValue, 3.21f);

	// Double
	TestCoreSubsystem->TestEqual("MethodHelperGetDoubleFunction",
	                             TMethodBuilder<double>::Invoke(this, TEXT("GetDoubleValueFunction")), 12.3);

	TMethodBuilder<>::Invoke(this, TEXT("SetDoubleValueFunction"), 3.21);

	TestCoreSubsystem->TestEqual("MethodHelperSetDoubleFunction",
	                             TMethodBuilder<double>::Invoke(this, TEXT("GetDoubleValueFunction")), 3.21);

	double OutDoubleValue = 12.3;

	TMethodBuilder<>::Invoke(this, TEXT("OutDoubleValueFunction"), OutDoubleValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetDoubleFunction", OutDoubleValue, 3.21);

	// FName
	TestCoreSubsystem->TestEqual("MethodHelperGetNameFunction",
	                             TMethodBuilder<FName>::Invoke(this, TEXT("GetNameValueFunction")),
	                             FName(TEXT("Name12")));

	TMethodBuilder<>::Invoke(this, TEXT("SetNameValueFunction"), FName(TEXT("21emaN")));

	TestCoreSubsystem->TestEqual("MethodHelperSetNameFunction",
	                             TMethodBuilder<FName>::Invoke(this, TEXT("GetNameValueFunction")),
	                             FName(TEXT("21emaN")));

	auto OutNameValue = FName(TEXT("Name12"));

	TMethodBuilder<>::Invoke(this, TEXT("OutNameValueFunction"), OutNameValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetNameFunction", OutNameValue, FName(TEXT("21emaN")));

	// FText
	TestCoreSubsystem->TestEqual("MethodHelperGetTextFunction",
	                             TMethodBuilder<FText>::Invoke(this, TEXT("GetTextValueFunction")),
	                             FText::FromString(TEXT("Text12")));

	TMethodBuilder<>::Invoke(this, TEXT("SetTextValueFunction"), FText::FromString(TEXT("21txeT")));

	TestCoreSubsystem->TestEqual("MethodHelperSetTextFunction",
	                             TMethodBuilder<FText>::Invoke(this, TEXT("GetTextValueFunction")),
	                             FText::FromString(TEXT("21txeT")));

	auto OutTextValue = FText::FromString(TEXT("Text12"));

	TMethodBuilder<>::Invoke(this, TEXT("OutTextValueFunction"), OutTextValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetTextFunction", OutTextValue, FText::FromString(TEXT("21txeT")));

	// FString
	TestCoreSubsystem->TestEqual("MethodHelperGetStringFunction",
	                             TMethodBuilder<FString>::Invoke(this, TEXT("GetStringValueFunction")),
	                             FString(TEXT("String12")));

	TMethodBuilder<>::Invoke(this, TEXT("SetStringValueFunction"), FString(TEXT("21gnirtS")));

	TestCoreSubsystem->TestEqual("MethodHelperSetStringFunction",
	                             TMethodBuilder<FString>::Invoke(this, TEXT("GetStringValueFunction")),
	                             FString(TEXT("21gnirtS")));

	auto OutStringValue = FString(TEXT("String12"));

	TMethodBuilder<>::Invoke(this, TEXT("OutStringValueFunction"), OutStringValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetStringFunction", OutStringValue, FString(TEXT("21gnirtS")));

	// Enum
	TestCoreSubsystem->TestEqual("MethodHelperGetEnumFunction",
	                             TMethodBuilder<ETestEnum>::Invoke(this, TEXT("GetEnumValueFunction")),
	                             ETestEnum::TestEnumOne);

	TMethodBuilder<>::Invoke(this, TEXT("SetEnumValueFunction"), ETestEnum::TestEnumTwo);

	TestCoreSubsystem->TestEqual("MethodHelperSetEnumFunction",
	                             TMethodBuilder<ETestEnum>::Invoke(this, TEXT("GetEnumValueFunction")),
	                             ETestEnum::TestEnumTwo);

	auto OutEnumValue = ETestEnum::TestEnumOne;

	TMethodBuilder<>::Invoke(this, TEXT("OutEnumValueFunction"), OutEnumValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetEnumFunction", OutEnumValue, ETestEnum::TestEnumTwo);

	// TEnumAsByte
	TestCoreSubsystem->TestEqual("MethodHelperGetEnumAsByteFunction",
	                             TMethodBuilder<TEnumAsByte<ETestEnum>>::Invoke(
		                             this, TEXT("GetEnumAsByteValueFunction")),
	                             TEnumAsByte<ETestEnum>(ETestEnum::TestEnumOne));

	TMethodBuilder<>::Invoke(this, TEXT("SetEnumAsByteValueFunction"), TEnumAsByte<ETestEnum>(ETestEnum::TestEnumTwo));

	TestCoreSubsystem->TestEqual("MethodHelperSetEnumAsByteFunction",
	                             TMethodBuilder<TEnumAsByte<ETestEnum>>::Invoke(
		                             this, TEXT("GetEnumAsByteValueFunction")),
	                             TEnumAsByte<ETestEnum>(ETestEnum::TestEnumTwo));

	auto OutEnumAsByteValue = TEnumAsByte<ETestEnum>(ETestEnum::TestEnumOne);

	TMethodBuilder<>::Invoke(this, TEXT("OutEnumAsByteValueFunction"), OutEnumAsByteValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetEnumAsByteFunction", OutEnumAsByteValue.GetValue(),
	                             ETestEnum::TestEnumTwo);

	// EnumClass
	TestCoreSubsystem->TestEqual("MethodHelperGetEnumClassFunction",
	                             TMethodBuilder<ETestEnumClass>::Invoke(this, TEXT("GetEnumClassValueFunction")),
	                             ETestEnumClass::TestEnumClassOne);

	TMethodBuilder<>::Invoke(this, TEXT("SetEnumClassValueFunction"), ETestEnumClass::TestEnumClassTwo);

	TestCoreSubsystem->TestEqual("MethodHelperSetEnumClassFunction",
	                             TMethodBuilder<ETestEnumClass>::Invoke(this, TEXT("GetEnumClassValueFunction")),
	                             ETestEnumClass::TestEnumClassTwo);

	auto OutEnumClassValue = ETestEnumClass::TestEnumClassOne;

	TMethodBuilder<>::Invoke(this, TEXT("OutEnumClassValueFunction"), OutEnumClassValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetEnumClassFunction", OutEnumClassValue,
	                             ETestEnumClass::TestEnumClassTwo);

	// RawEnum
	TestCoreSubsystem->TestEqual("MethodHelperGetRawEnumFunction",
	                             TMethodBuilder<ERawTestEnum>::Invoke(this, TEXT("GetRawEnumValueFunction")),
	                             ERawTestEnum::RawTestEnumOne);

	TMethodBuilder<>::Invoke(this, TEXT("SetRawEnumValueFunction"), ERawTestEnum::RawTestEnumTwo);

	TestCoreSubsystem->TestEqual("MethodHelperSetRawEnumFunction",
	                             TMethodBuilder<ERawTestEnum>::Invoke(this, TEXT("GetRawEnumValueFunction")),
	                             ERawTestEnum::RawTestEnumTwo);

	auto OutRawEnumValue = ERawTestEnum::RawTestEnumOne;

	TMethodBuilder<>::Invoke(this, TEXT("OutRawEnumValueFunction"), OutRawEnumValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetRawEnumFunction", OutRawEnumValue, ERawTestEnum::RawTestEnumTwo);

	// RawEnumClass
	TestCoreSubsystem->TestEqual("MethodHelperGetRawEnumClassFunction",
	                             TMethodBuilder<ERawTestEnumClass>::Invoke(this, TEXT("GetRawEnumClassValueFunction")),
	                             ERawTestEnumClass::RawTestEnumClassOne);

	TMethodBuilder<>::Invoke(this, TEXT("SetRawEnumClassValueFunction"), ERawTestEnumClass::RawTestEnumClassTwo);

	TestCoreSubsystem->TestEqual("MethodHelperSetRawEnumClassFunction",
	                             TMethodBuilder<ERawTestEnumClass>::Invoke(this, TEXT("GetRawEnumClassValueFunction")),
	                             ERawTestEnumClass::RawTestEnumClassTwo);

	auto OutRawEnumClassValue = ERawTestEnumClass::RawTestEnumClassOne;

	TMethodBuilder<>::Invoke(this, TEXT("OutRawEnumClassValueFunction"), OutRawEnumClassValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetRawEnumClassFunction", OutRawEnumClassValue,
	                             ERawTestEnumClass::RawTestEnumClassTwo);

	// UStruct
	TestCoreSubsystem->TestEqual("MethodHelperGetStructFunction",
	                             TMethodBuilder<FTestStruct>::Invoke(this, TEXT("GetStructValueFunction")),
	                             FTestStruct{1});

	TMethodBuilder<>::Invoke(this, TEXT("SetStructValueFunction"), FTestStruct{2});

	TestCoreSubsystem->TestEqual("MethodHelperSetStructFunction",
	                             TMethodBuilder<FTestStruct>::Invoke(this, TEXT("GetStructValueFunction")),
	                             FTestStruct{2});

	auto OutStructValue = FTestStruct{1};

	TMethodBuilder<>::Invoke(this, TEXT("OutStructValueFunction"), OutStructValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetStructFunction", OutStructValue, FTestStruct{2});

	// RawStruct
	TestCoreSubsystem->TestEqual("MethodHelperGetRawStructFunction",
	                             TMethodBuilder<FRawTestStruct>::Invoke(this, TEXT("GetRawStructValueFunction")),
	                             FRawTestStruct{1});

	TMethodBuilder<>::Invoke(this, TEXT("SetRawStructValueFunction"), FRawTestStruct{2});

	TestCoreSubsystem->TestEqual("MethodHelperSetRawStructFunction",
	                             TMethodBuilder<FRawTestStruct>::Invoke(this, TEXT("GetRawStructValueFunction")),
	                             FRawTestStruct{2});

	auto OutRawStructValue = FRawTestStruct{1};

	TMethodBuilder<>::Invoke(this, TEXT("OutRawStructValueFunction"), OutRawStructValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetRawStructFunction", OutRawStructValue, FRawTestStruct{2});

	// UObject
	TestCoreSubsystem->TestEqual("MethodHelperGetObjectFunction",
	                             TMethodBuilder<UObject*>::Invoke(this, TEXT("GetObjectValueFunction")),
	                             Cast<UObject>(this));

	TMethodBuilder<>::Invoke(this, TEXT("SetObjectValueFunction"), Cast<UObject>(TestCoreSubsystem));

	TestCoreSubsystem->TestEqual("MethodHelperSetObjectFunction",
	                             TMethodBuilder<UObject*>::Invoke(this, TEXT("GetObjectValueFunction")),
	                             Cast<UObject>(TestCoreSubsystem));

	UObject* OutObjectValue = this;

	TMethodBuilder<>::Invoke(this, TEXT("OutObjectValueFunction"), OutObjectValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetObjectFunction", OutObjectValue, Cast<UObject>(TestCoreSubsystem));

	// UClass
	TestCoreSubsystem->TestEqual("MethodHelperGetClassFunction",
	                             TMethodBuilder<UClass*>::Invoke(this, TEXT("GetClassValueFunction")),
	                             GetClass());

	TMethodBuilder<>::Invoke(this, TEXT("SetClassValueFunction"), TestCoreSubsystem->GetClass());

	TestCoreSubsystem->TestEqual("MethodHelperSetClassFunction",
	                             TMethodBuilder<UClass*>::Invoke(this, TEXT("GetClassValueFunction")),
	                             TestCoreSubsystem->GetClass());

	UClass* OutClassValue = GetClass();

	TMethodBuilder<>::Invoke(this, TEXT("OutClassValueFunction"), OutClassValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetClassFunction", OutClassValue, TestCoreSubsystem->GetClass());

	// UInterface
	TestCoreSubsystem->TestEqual("MethodHelperGetInterfaceFunction",
	                             TMethodBuilder<TScriptInterface<ITestInterface>>::Invoke(
		                             this, TEXT("GetInterfaceValueFunction")),
	                             InterfaceValue);

	TMethodBuilder<>::Invoke(this, TEXT("SetInterfaceValueFunction"), InterfaceValue);

	TestCoreSubsystem->TestEqual("MethodHelperSetInterfaceFunction",
	                             TMethodBuilder<TScriptInterface<ITestInterface>>::Invoke(
		                             this, TEXT("GetInterfaceValueFunction")),
	                             InterfaceValue);

	auto OutInterfaceValue = InterfaceValue;

	TMethodBuilder<>::Invoke(this, TEXT("OutInterfaceValueFunction"), OutInterfaceValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetInterfaceFunction", OutInterfaceValue, InterfaceValue);

	// TSubclassOf
	TestCoreSubsystem->TestEqual("MethodHelperGetSubclassOfFunction",
	                             TMethodBuilder<TSubclassOf<UObject>>::Invoke(this, TEXT("GetSubclassOfValueFunction")),
	                             TSubclassOf<UObject>(GetClass()));

	TMethodBuilder<>::Invoke(this, TEXT("SetSubclassOfValueFunction"),
	                         TSubclassOf<UObject>(TestCoreSubsystem->GetClass()));

	TestCoreSubsystem->TestEqual("MethodHelperSetSubclassOfFunction",
	                             TMethodBuilder<TSubclassOf<UObject>>::Invoke(this, TEXT("GetSubclassOfValueFunction")),
	                             TSubclassOf<UObject>(TestCoreSubsystem->GetClass()));

	auto OutSubclassOfValue = TSubclassOf<UObject>(GetClass());

	TMethodBuilder<>::Invoke(this, TEXT("OutSubclassOfValueFunction"), OutSubclassOfValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetSubclassOfFunction", OutSubclassOfValue,
	                             TSubclassOf<UObject>(TestCoreSubsystem->GetClass()));

	// TWeakObjectPtr
	TestCoreSubsystem->TestEqual("MethodHelperGetWeakObjectPtrFunction",
	                             TMethodBuilder<TWeakObjectPtr<UObject>>::Invoke(
		                             this, TEXT("GetWeakObjectPtrValueFunction")),
	                             TWeakObjectPtr<UObject>(this));

	TMethodBuilder<>::Invoke(this, TEXT("SetWeakObjectPtrValueFunction"), TWeakObjectPtr<UObject>(TestCoreSubsystem));

	TestCoreSubsystem->TestEqual("MethodHelperSetWeakObjectPtrFunction",
	                             TMethodBuilder<TWeakObjectPtr<UObject>>::Invoke(
		                             this, TEXT("GetWeakObjectPtrValueFunction")),
	                             TWeakObjectPtr<UObject>(TestCoreSubsystem));

	auto OutWeakObjectPtrValue = TWeakObjectPtr<UObject>(this);

	TMethodBuilder<>::Invoke(this, TEXT("OutWeakObjectPtrValueFunction"), OutWeakObjectPtrValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetWeakObjectPtrFunction", OutWeakObjectPtrValue,
	                             TWeakObjectPtr<UObject>(TestCoreSubsystem));

	// TLazyObjectPtr
	TestCoreSubsystem->TestEqual("MethodHelperGetLazyObjectPtrFunction",
	                             TMethodBuilder<TLazyObjectPtr<UObject>>::Invoke(
		                             this, TEXT("GetLazyObjectPtrValueFunction")),
	                             TLazyObjectPtr<UObject>(this));

	TMethodBuilder<>::Invoke(this, TEXT("SetLazyObjectPtrValueFunction"), TLazyObjectPtr<UObject>(TestCoreSubsystem));

	TestCoreSubsystem->TestEqual("MethodHelperSetLazyObjectPtrFunction",
	                             TMethodBuilder<TLazyObjectPtr<UObject>>::Invoke(
		                             this, TEXT("GetLazyObjectPtrValueFunction")),
	                             TLazyObjectPtr<UObject>(TestCoreSubsystem));

	auto OutLazyObjectPtrValue = TLazyObjectPtr<UObject>(this);

	TMethodBuilder<>::Invoke(this, TEXT("OutLazyObjectPtrValueFunction"), OutLazyObjectPtrValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetLazyObjectPtrFunction", OutLazyObjectPtrValue,
	                             TLazyObjectPtr<UObject>(TestCoreSubsystem));

	// TSoftObjectPtr
	TestCoreSubsystem->TestEqual("MethodHelperGetSoftObjectPtrFunction",
	                             TMethodBuilder<TSoftObjectPtr<UObject>>::Invoke(
		                             this, TEXT("GetSoftObjectPtrValueFunction")),
	                             TSoftObjectPtr<UObject>(this));

	TMethodBuilder<>::Invoke(this, TEXT("SetSoftObjectPtrValueFunction"), TSoftObjectPtr<UObject>(TestCoreSubsystem));

	TestCoreSubsystem->TestEqual("MethodHelperSetSoftObjectPtrFunction",
	                             TMethodBuilder<TSoftObjectPtr<UObject>>::Invoke(
		                             this, TEXT("GetSoftObjectPtrValueFunction")),
	                             TSoftObjectPtr<UObject>(TestCoreSubsystem));

	auto OutSoftObjectPtrValue = TSoftObjectPtr<UObject>(this);

	TMethodBuilder<>::Invoke(this, TEXT("OutSoftObjectPtrValueFunction"), OutSoftObjectPtrValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetSoftObjectPtrFunction", OutSoftObjectPtrValue,
	                             TSoftObjectPtr<UObject>(TestCoreSubsystem));

	// TSoftClassPtr
	TestCoreSubsystem->TestEqual("MethodHelperGetSoftClassPtrFunction",
	                             TMethodBuilder<TSoftClassPtr<UObject>>::Invoke(
		                             this, TEXT("GetSoftClassPtrValueFunction")),
	                             TSoftClassPtr<UObject>(GetClass()));

	TMethodBuilder<>::Invoke(this, TEXT("SetSoftClassPtrValueFunction"),
	                         TSoftClassPtr<UObject>(TestCoreSubsystem->GetClass()));

	TestCoreSubsystem->TestEqual("MethodHelperSetSoftClassPtrFunction",
	                             TMethodBuilder<TSoftClassPtr<UObject>>::Invoke(
		                             this, TEXT("GetSoftClassPtrValueFunction")),
	                             TSoftClassPtr<UObject>(TestCoreSubsystem->GetClass()));

	auto OutSoftClassPtrValue = TSoftClassPtr<UObject>(GetClass());

	TMethodBuilder<>::Invoke(this, TEXT("OutSoftClassPtrValueFunction"), OutSoftClassPtrValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetSoftClassPtrFunction", OutSoftClassPtrValue,
	                             TSoftClassPtr<UObject>(TestCoreSubsystem->GetClass()));

	// TArray
	TestCoreSubsystem->TestEqual("MethodHelperGetArrayFunction",
	                             TMethodBuilder<TArray<int32>>::Invoke(this, TEXT("GetArrayValueFunction")),
	                             TArray<int32>{1, 2});

	TMethodBuilder<>::Invoke(this, TEXT("SetArrayValueFunction"), TArray<int32>{3, 4});

	TestCoreSubsystem->TestEqual("MethodHelperSetArrayFunction",
	                             TMethodBuilder<TArray<int32>>::Invoke(this, TEXT("GetArrayValueFunction")),
	                             TArray<int32>{3, 4});

	auto OutArrayValue = TArray<int32>{1, 2};

	TMethodBuilder<>::Invoke(this, TEXT("OutArrayValueFunction"), OutArrayValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetArrayFunction", OutArrayValue, TArray<int32>{3, 4});

	// TSet
	TestCoreSubsystem->TestEqual("MethodHelperGetSetFunction",
	                             TMethodBuilder<TSet<int32>>::Invoke(this, TEXT("GetSetValueFunction")),
	                             TSet<int32>{1, 2});

	TMethodBuilder<>::Invoke(this, TEXT("SetSetValueFunction"), TSet<int32>{3, 4});

	TestCoreSubsystem->TestEqual("MethodHelperSetSetFunction",
	                             TMethodBuilder<TSet<int32>>::Invoke(this, TEXT("GetSetValueFunction")),
	                             TSet<int32>{3, 4});

	auto OutSetValue = TSet<int32>{1, 2};

	TMethodBuilder<>::Invoke(this, TEXT("OutSetValueFunction"), OutSetValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetSetFunction", OutSetValue, TSet<int32>{3, 4});

	// TMap
	TestCoreSubsystem->TestEqual("MethodHelperGetMapFunction",
	                             TMethodBuilder<TMap<int32, int32>>::Invoke(this, TEXT("GetMapValueFunction")),
	                             TMap<int32, int32>({{1, 1}, {2, 2}}));

	TMethodBuilder<>::Invoke(this, TEXT("SetMapValueFunction"), TMap<int32, int32>({{3, 3}, {4, 4}}));

	TestCoreSubsystem->TestEqual("MethodHelperSetMapFunction",
	                             TMethodBuilder<TMap<int32, int32>>::Invoke(this, TEXT("GetMapValueFunction")),
	                             TMap<int32, int32>({{3, 3}, {4, 4}}));

	auto OutMapValue = TMap<int32, int32>{{1, 1}, {2, 2}};

	TMethodBuilder<>::Invoke(this, TEXT("OutMapValueFunction"), OutMapValue);

	TestCoreSubsystem->TestEqual("MethodHelperOutSetMapFunction", OutMapValue, TMap<int32, int32>({{3, 3}, {4, 4}}));
}
