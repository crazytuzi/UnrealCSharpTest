// Fill out your copyright notice in the Description page of Project Settings.


#include "UnitTest/Reflection/TestReflectionFunctionActor.h"

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
	InterfaceValue(this)
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
	OutClassValue = ClassValue;
}

void ATestReflectionFunctionActor::SetInterfaceValueFunction(const TScriptInterface<ITestInterface> InInterfaceValue)
{
	InterfaceValue = InInterfaceValue;
}

TScriptInterface<ITestInterface> ATestReflectionFunctionActor::GetInterfaceValueFunction() const
{
	return InterfaceValue;
}

void ATestReflectionFunctionActor::OutInterfaceValueFunction(TScriptInterface<ITestInterface>& OutInterfaceValue) const
{
	OutInterfaceValue = InterfaceValue;
}
