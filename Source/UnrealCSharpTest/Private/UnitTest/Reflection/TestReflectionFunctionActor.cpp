// Fill out your copyright notice in the Description page of Project Settings.


#include "UnitTest/Reflection/TestReflectionFunctionActor.h"
#include "TestCore/TestCoreSubsystem.h"

// Sets default values
ATestReflectionFunctionActor::ATestReflectionFunctionActor():
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
	EnumClassValue(ETestEnumClass::TestEnumClassOne),
	StructValue({1}),
	ObjectValue(this),
	ClassValue(GetClass()),
	InterfaceValue(this),
	SubclassOfValue(GetClass()),
	WeakObjectPtrValue(this),
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
void ATestReflectionFunctionActor::BeginPlay()
{
	Super::BeginPlay();
}

// Called every frame
void ATestReflectionFunctionActor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);
}

bool ATestReflectionFunctionActor::StaticFunction()
{
	return true;
}

void ATestReflectionFunctionActor::SetBoolValueFunction(const bool InBoolValue)
{
	BoolValue = InBoolValue;
}

bool ATestReflectionFunctionActor::GetBoolValueFunction() const
{
	return BoolValue;
}

void ATestReflectionFunctionActor::OutBoolValueFunction(bool& OutBoolValue) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetBoolFunction", OutBoolValue, true);

	OutBoolValue = BoolValue;
}

void ATestReflectionFunctionActor::SetInt8ValueFunction(const int8 InInt8Value)
{
	Int8Value = InInt8Value;
}

int8 ATestReflectionFunctionActor::GetInt8ValueFunction() const
{
	return Int8Value;
}

void ATestReflectionFunctionActor::OutInt8ValueFunction(int8& OutInt8Value) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetInt8Function", OutInt8Value, static_cast<int8>(12));

	OutInt8Value = Int8Value;
}

void ATestReflectionFunctionActor::SetInt16ValueFunction(const int16 InInt16Value)
{
	Int16Value = InInt16Value;
}

int16 ATestReflectionFunctionActor::GetInt16ValueFunction() const
{
	return Int16Value;
}

void ATestReflectionFunctionActor::OutInt16ValueFunction(int16& OutInt16Value) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetInt16Function", OutInt16Value, static_cast<int16>(12));

	OutInt16Value = Int16Value;
}

void ATestReflectionFunctionActor::SetInt32ValueFunction(const int32 InInt32Value)
{
	Int32Value = InInt32Value;
}

int32 ATestReflectionFunctionActor::GetInt32ValueFunction() const
{
	return Int32Value;
}

void ATestReflectionFunctionActor::OutInt32ValueFunction(int32& OutInt32Value) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetInt32Function", OutInt32Value, static_cast<int32>(12));

	OutInt32Value = Int32Value;
}

void ATestReflectionFunctionActor::SetInt64ValueFunction(const int64 InInt64Value)
{
	Int64Value = InInt64Value;
}

int64 ATestReflectionFunctionActor::GetInt64ValueFunction() const
{
	return Int64Value;
}

void ATestReflectionFunctionActor::OutInt64ValueFunction(int64& OutInt64Value) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetInt64Function", OutInt64Value, static_cast<int64>(12));

	OutInt64Value = Int64Value;
}

void ATestReflectionFunctionActor::SetUInt8ValueFunction(const uint8 InUInt8Value)
{
	UInt8Value = InUInt8Value;
}

uint8 ATestReflectionFunctionActor::GetUInt8ValueFunction() const
{
	return UInt8Value;
}

void ATestReflectionFunctionActor::OutUInt8ValueFunction(uint8& OutUInt8Value) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetUInt8Function", OutUInt8Value, static_cast<uint8>(12));

	OutUInt8Value = UInt8Value;
}

void ATestReflectionFunctionActor::SetUInt16ValueFunction(const uint16 InUInt16Value)
{
	UInt16Value = InUInt16Value;
}

uint16 ATestReflectionFunctionActor::GetUInt16ValueFunction() const
{
	return UInt16Value;
}

void ATestReflectionFunctionActor::OutUInt16ValueFunction(uint16& OutUInt16Value) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetUInt16Function", OutUInt16Value, static_cast<uint16>(12));

	OutUInt16Value = UInt16Value;
}

void ATestReflectionFunctionActor::SetUInt32ValueFunction(const uint32 InUInt32Value)
{
	UInt32Value = InUInt32Value;
}

uint32 ATestReflectionFunctionActor::GetUInt32ValueFunction() const
{
	return UInt32Value;
}

void ATestReflectionFunctionActor::OutUInt32ValueFunction(uint32& OutUInt32Value) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetUInt32Function", OutUInt32Value, static_cast<uint32>(12));

	OutUInt32Value = UInt32Value;
}

void ATestReflectionFunctionActor::SetUInt64ValueFunction(const uint64 InUInt64Value)
{
	UInt64Value = InUInt64Value;
}

uint64 ATestReflectionFunctionActor::GetUInt64ValueFunction() const
{
	return UInt64Value;
}

void ATestReflectionFunctionActor::OutUInt64ValueFunction(uint64& OutUInt64Value) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetUInt64Function", OutUInt64Value, static_cast<uint64>(12));

	OutUInt64Value = UInt64Value;
}

void ATestReflectionFunctionActor::SetFloatValueFunction(const float InFloatValue)
{
	FloatValue = InFloatValue;
}

float ATestReflectionFunctionActor::GetFloatValueFunction() const
{
	return FloatValue;
}

void ATestReflectionFunctionActor::OutFloatValueFunction(float& OutFloatValue) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetFloatFunction", OutFloatValue, 12.3f);

	OutFloatValue = FloatValue;
}

void ATestReflectionFunctionActor::SetDoubleValueFunction(const double InDoubleValue)
{
	DoubleValue = InDoubleValue;
}

double ATestReflectionFunctionActor::GetDoubleValueFunction() const
{
	return DoubleValue;
}

void ATestReflectionFunctionActor::OutDoubleValueFunction(double& OutDoubleValue) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetDoubleFunction", OutDoubleValue, 12.3);

	OutDoubleValue = DoubleValue;
}

void ATestReflectionFunctionActor::SetNameValueFunction(const FName& InNameValue)
{
	NameValue = InNameValue;
}

FName ATestReflectionFunctionActor::GetNameValueFunction() const
{
	return NameValue;
}

void ATestReflectionFunctionActor::OutNameValueFunction(FName& OutNameValue) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetNameFunction", OutNameValue, FName(TEXT("Name12")));

	OutNameValue = NameValue;
}

void ATestReflectionFunctionActor::SetTextValueFunction(const FText& InTextValue)
{
	TextValue = InTextValue;
}

FText ATestReflectionFunctionActor::GetTextValueFunction() const
{
	return TextValue;
}

void ATestReflectionFunctionActor::OutTextValueFunction(FText& OutTextValue) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetTextFunction", OutTextValue, FText::FromString(TEXT("Text12")));

	OutTextValue = TextValue;
}

void ATestReflectionFunctionActor::SetStringValueFunction(const FString& InStringValue)
{
	StringValue = InStringValue;
}

FString ATestReflectionFunctionActor::GetStringValueFunction() const
{
	return StringValue;
}

void ATestReflectionFunctionActor::OutStringValueFunction(FString& OutStringValue) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetStringFunction", OutStringValue, FString(TEXT("String12")));

	OutStringValue = StringValue;
}

void ATestReflectionFunctionActor::SetEnumValueFunction(const ETestEnum InEnumValue)
{
	EnumValue = InEnumValue;
}

ETestEnum ATestReflectionFunctionActor::GetEnumValueFunction() const
{
	return EnumValue;
}

void ATestReflectionFunctionActor::OutEnumValueFunction(TEnumAsByte<ETestEnum>& OutEnumValue) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetEnumFunction", OutEnumValue.GetValue(), ETestEnum::TestEnumOne);

	OutEnumValue = EnumValue;
}

void ATestReflectionFunctionActor::SetEnumClassValueFunction(const ETestEnumClass InEnumClassValue)
{
	EnumClassValue = InEnumClassValue;
}

ETestEnumClass ATestReflectionFunctionActor::GetEnumClassValueFunction() const
{
	return EnumClassValue;
}

void ATestReflectionFunctionActor::OutEnumClassValueFunction(ETestEnumClass& OutEnumClassValue) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetEnumClassFunction", OutEnumClassValue,
	                             ETestEnumClass::TestEnumClassOne);

	OutEnumClassValue = EnumClassValue;
}

void ATestReflectionFunctionActor::SetStructValueFunction(const FTestStruct& InStructValue)
{
	StructValue = InStructValue;
}

FTestStruct ATestReflectionFunctionActor::GetStructValueFunction() const
{
	return StructValue;
}

void ATestReflectionFunctionActor::OutStructValueFunction(FTestStruct& OutStructValue) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetStructFunction", OutStructValue, {1});

	OutStructValue = StructValue;
}

void ATestReflectionFunctionActor::SetObjectValueFunction(UObject* InObjectValue)
{
	ObjectValue = InObjectValue;
}

UObject* ATestReflectionFunctionActor::GetObjectValueFunction() const
{
	return ObjectValue;
}

void ATestReflectionFunctionActor::OutObjectValueFunction(UObject*& OutObjectValue) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetObjectFunction", OutObjectValue,
	                             Cast<UObject>(const_cast<ATestReflectionFunctionActor*>(this)));

	OutObjectValue = ObjectValue;
}

void ATestReflectionFunctionActor::SetClassValueFunction(UClass* InClassValue)
{
	ClassValue = InClassValue;
}

UClass* ATestReflectionFunctionActor::GetClassValueFunction() const
{
	return ClassValue;
}

void ATestReflectionFunctionActor::OutClassValueFunction(UClass*& OutClassValue) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetClassFunction", OutClassValue, GetClass());

	OutClassValue = ClassValue;
}

void ATestReflectionFunctionActor::SetInterfaceValueFunction(const TScriptInterface<ITestInterface>& InInterfaceValue)
{
	InterfaceValue = InInterfaceValue;
}

TScriptInterface<ITestInterface> ATestReflectionFunctionActor::GetInterfaceValueFunction() const
{
	return InterfaceValue;
}

void ATestReflectionFunctionActor::OutInterfaceValueFunction(TScriptInterface<ITestInterface>& OutInterfaceValue) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetInterfaceFunction", OutInterfaceValue, InterfaceValue);

	OutInterfaceValue = InterfaceValue;
}

void ATestReflectionFunctionActor::SetSubclassOfValueFunction(const TSubclassOf<UObject>& InSubclassOfValue)
{
	SubclassOfValue = InSubclassOfValue;
}

TSubclassOf<UObject> ATestReflectionFunctionActor::GetSubclassOfValueFunction() const
{
	return SubclassOfValue;
}

void ATestReflectionFunctionActor::OutSubclassOfValueFunction(TSubclassOf<UObject>& OutSubclassOfValue) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetSubclassOfFunction", OutSubclassOfValue,
	                             TSubclassOf<UObject>(GetClass()));

	OutSubclassOfValue = SubclassOfValue;
}

TWeakObjectPtr<UObject> ATestReflectionFunctionActor::GetWeakObjectPtrValueFunction() const
{
	return WeakObjectPtrValue;
}

void ATestReflectionFunctionActor::SetSoftObjectPtrValueFunction(const TSoftObjectPtr<UObject>& InSoftObjectPtrValue)
{
	SoftObjectPtrValue = InSoftObjectPtrValue;
}

TSoftObjectPtr<UObject> ATestReflectionFunctionActor::GetSoftObjectPtrValueFunction() const
{
	return SoftObjectPtrValue;
}

void ATestReflectionFunctionActor::OutSoftObjectPtrValueFunction(TSoftObjectPtr<UObject>& OutSoftObjectPtrValue) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetSoftObjectPtrFunction", OutSoftObjectPtrValue,
	                             TSoftObjectPtr<UObject>(this));

	OutSoftObjectPtrValue = SoftObjectPtrValue;
}

void ATestReflectionFunctionActor::SetSoftClassPtrValueFunction(const TSoftClassPtr<UObject>& InSoftClassPtrValue)
{
	SoftClassPtrValue = InSoftClassPtrValue;
}

TSoftClassPtr<UObject> ATestReflectionFunctionActor::GetSoftClassPtrValueFunction() const
{
	return SoftClassPtrValue;
}

void ATestReflectionFunctionActor::OutSoftClassPtrValueFunction(TSoftClassPtr<UObject>& OutSoftClassPtrValue) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetSoftClassPtrFunction", OutSoftClassPtrValue,
	                             TSoftClassPtr<UObject>(GetClass()));

	OutSoftClassPtrValue = SoftClassPtrValue;
}

void ATestReflectionFunctionActor::SetArrayValueFunction(const TArray<int32>& InArrayValue)
{
	ArrayValue = InArrayValue;
}

TArray<int32> ATestReflectionFunctionActor::GetArrayValueFunction() const
{
	return ArrayValue;
}

void ATestReflectionFunctionActor::OutArrayValueFunction(TArray<int32>& OutArrayValue) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetArrayFunction", OutArrayValue, {1, 2});

	OutArrayValue = ArrayValue;
}

void ATestReflectionFunctionActor::SetSetValueFunction(const TSet<int32>& InSetValue)
{
	SetValue = InSetValue;
}

TSet<int32> ATestReflectionFunctionActor::GetSetValueFunction() const
{
	return SetValue;
}

void ATestReflectionFunctionActor::OutSetValueFunction(TSet<int32>& OutSetValue) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetSetFunction", OutSetValue, {1, 2});

	OutSetValue = SetValue;
}

void ATestReflectionFunctionActor::SetMapValueFunction(const TMap<int32, int32>& InMapValue)
{
	MapValue = InMapValue;
}

TMap<int32, int32> ATestReflectionFunctionActor::GetMapValueFunction() const
{
	return MapValue;
}

void ATestReflectionFunctionActor::OutMapValueFunction(TMap<int32, int32>& OutMapValue) const
{
	TestCoreSubsystem->TestEqual("ReflectionOutGetMapFunction", OutMapValue, {{1, 1}, {2, 2}});

	OutMapValue = MapValue;
}
