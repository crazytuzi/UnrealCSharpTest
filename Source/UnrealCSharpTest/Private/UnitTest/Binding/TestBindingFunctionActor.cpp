// Fill out your copyright notice in the Description page of Project Settings.


#include "UnitTest/Binding/TestBindingFunctionActor.h"
#include "Binding/Class/TReflectionClassBuilder.inl"
#include "Macro/NamespaceMacro.h"

BINDING_REFLECTION_CLASS(ATestBindingFunctionActor);

struct FRegisterTestBindingFunctionActor
{
	FRegisterTestBindingFunctionActor()
	{
		TReflectionClassBuilder<ATestBindingFunctionActor>(NAMESPACE_BINDING)
			.Function("StaticFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::StaticFunction))
			.Function("SetBoolValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::SetBoolValueFunction))
			.Function("GetBoolValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::GetBoolValueFunction))
			.Function("OutBoolValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::OutBoolValueFunction))
			.Function("SetInt8ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::SetInt8ValueFunction))
			.Function("GetInt8ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::GetInt8ValueFunction))
			.Function("OutInt8ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::OutInt8ValueFunction))
			.Function("SetInt16ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::SetInt16ValueFunction))
			.Function("GetInt16ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::GetInt16ValueFunction))
			.Function("OutInt16ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::OutInt16ValueFunction))
			.Function("SetInt32ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::SetInt32ValueFunction))
			.Function("GetInt32ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::GetInt32ValueFunction))
			.Function("OutInt32ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::OutInt32ValueFunction))
			.Function("SetInt64ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::SetInt64ValueFunction))
			.Function("GetInt64ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::GetInt64ValueFunction))
			.Function("OutInt64ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::OutInt64ValueFunction))
			.Function("SetUInt8ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::SetUInt8ValueFunction))
			.Function("GetUInt8ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::GetUInt8ValueFunction))
			.Function("OutUInt8ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::OutUInt8ValueFunction))
			.Function("SetUInt16ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::SetUInt16ValueFunction))
			.Function("GetUInt16ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::GetUInt16ValueFunction))
			.Function("OutUInt16ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::OutUInt16ValueFunction))
			.Function("SetUInt32ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::SetUInt32ValueFunction))
			.Function("GetUInt32ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::GetUInt32ValueFunction))
			.Function("OutUInt32ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::OutUInt32ValueFunction))
			.Function("SetUInt64ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::SetUInt64ValueFunction))
			.Function("GetUInt64ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::GetUInt64ValueFunction))
			.Function("OutUInt64ValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::OutUInt64ValueFunction))
			.Function("SetFloatValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::SetFloatValueFunction))
			.Function("GetFloatValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::GetFloatValueFunction))
			.Function("OutFloatValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::OutFloatValueFunction))
			.Function("SetDoubleValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::SetDoubleValueFunction))
			.Function("GetDoubleValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::GetDoubleValueFunction))
			.Function("OutDoubleValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::OutDoubleValueFunction))
			.Function("SetNameValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::SetNameValueFunction))
			.Function("GetNameValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::GetNameValueFunction))
			.Function("OutNameValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::OutNameValueFunction))
			.Function("SetTextValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::SetTextValueFunction))
			.Function("GetTextValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::GetTextValueFunction))
			.Function("OutTextValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::OutTextValueFunction))
			.Function("SetStringValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::SetStringValueFunction))
			.Function("GetStringValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::GetStringValueFunction))
			.Function("OutStringValueFunction", BINDING_FUNCTION(&ATestBindingFunctionActor::OutStringValueFunction))
			.Register();
	}
};

static FRegisterTestBindingFunctionActor RegisterTestBindingFunctionActor;

// Sets default values
ATestBindingFunctionActor::ATestBindingFunctionActor():
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
	StringValue(TEXT("String12"))
{
	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;
}

// Called when the game starts or when spawned
void ATestBindingFunctionActor::BeginPlay()
{
	Super::BeginPlay();
}

// Called every frame
void ATestBindingFunctionActor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);
}

bool ATestBindingFunctionActor::StaticFunction()
{
	return true;
}

void ATestBindingFunctionActor::SetBoolValueFunction(const bool InBoolValue)
{
	BoolValue = InBoolValue;
}

bool ATestBindingFunctionActor::GetBoolValueFunction() const
{
	return BoolValue;
}

void ATestBindingFunctionActor::OutBoolValueFunction(bool& OutBoolValue) const
{
	OutBoolValue = BoolValue;
}

void ATestBindingFunctionActor::SetInt8ValueFunction(const int8 InInt8Value)
{
	Int8Value = InInt8Value;
}

int8 ATestBindingFunctionActor::GetInt8ValueFunction() const
{
	return Int8Value;
}

void ATestBindingFunctionActor::OutInt8ValueFunction(int8& OutInt8Value) const
{
	OutInt8Value = Int8Value;
}

void ATestBindingFunctionActor::SetInt16ValueFunction(const int16 InInt16Value)
{
	Int16Value = InInt16Value;
}

int16 ATestBindingFunctionActor::GetInt16ValueFunction() const
{
	return Int16Value;
}

void ATestBindingFunctionActor::OutInt16ValueFunction(int16& OutInt16Value) const
{
	OutInt16Value = Int16Value;
}

void ATestBindingFunctionActor::SetInt32ValueFunction(const int32 InInt32Value)
{
	Int32Value = InInt32Value;
}

int32 ATestBindingFunctionActor::GetInt32ValueFunction() const
{
	return Int32Value;
}

void ATestBindingFunctionActor::OutInt32ValueFunction(int32& OutInt32Value) const
{
	OutInt32Value = Int32Value;
}

void ATestBindingFunctionActor::SetInt64ValueFunction(const int64 InInt64Value)
{
	Int64Value = InInt64Value;
}

int64 ATestBindingFunctionActor::GetInt64ValueFunction() const
{
	return Int64Value;
}

void ATestBindingFunctionActor::OutInt64ValueFunction(int64& OutInt64Value) const
{
	OutInt64Value = Int64Value;
}

void ATestBindingFunctionActor::SetUInt8ValueFunction(const uint8 InUInt8Value)
{
	UInt8Value = InUInt8Value;
}

uint8 ATestBindingFunctionActor::GetUInt8ValueFunction() const
{
	return UInt8Value;
}

void ATestBindingFunctionActor::OutUInt8ValueFunction(uint8& OutUInt8Value) const
{
	OutUInt8Value = UInt8Value;
}

void ATestBindingFunctionActor::SetUInt16ValueFunction(const uint16 InUInt16Value)
{
	UInt16Value = InUInt16Value;
}

uint16 ATestBindingFunctionActor::GetUInt16ValueFunction() const
{
	return UInt16Value;
}

void ATestBindingFunctionActor::OutUInt16ValueFunction(uint16& OutUInt16Value) const
{
	OutUInt16Value = UInt16Value;
}

void ATestBindingFunctionActor::SetUInt32ValueFunction(const uint32 InUInt32Value)
{
	UInt32Value = InUInt32Value;
}

uint32 ATestBindingFunctionActor::GetUInt32ValueFunction() const
{
	return UInt32Value;
}

void ATestBindingFunctionActor::OutUInt32ValueFunction(uint32& OutUInt32Value) const
{
	OutUInt32Value = UInt32Value;
}

void ATestBindingFunctionActor::SetUInt64ValueFunction(const uint64 InUInt64Value)
{
	UInt64Value = InUInt64Value;
}

uint64 ATestBindingFunctionActor::GetUInt64ValueFunction() const
{
	return UInt64Value;
}

void ATestBindingFunctionActor::OutUInt64ValueFunction(uint64& OutUInt64Value) const
{
	OutUInt64Value = UInt64Value;
}

void ATestBindingFunctionActor::SetFloatValueFunction(const float InFloatValue)
{
	FloatValue = InFloatValue;
}

float ATestBindingFunctionActor::GetFloatValueFunction() const
{
	return FloatValue;
}

void ATestBindingFunctionActor::OutFloatValueFunction(float& OutFloatValue) const
{
	OutFloatValue = FloatValue;
}

void ATestBindingFunctionActor::SetDoubleValueFunction(const double InDoubleValue)
{
	DoubleValue = InDoubleValue;
}

double ATestBindingFunctionActor::GetDoubleValueFunction() const
{
	return DoubleValue;
}

void ATestBindingFunctionActor::OutDoubleValueFunction(double& OutDoubleValue) const
{
	OutDoubleValue = DoubleValue;
}

void ATestBindingFunctionActor::SetNameValueFunction(const FName& InNameValue)
{
	NameValue = InNameValue;
}

FName ATestBindingFunctionActor::GetNameValueFunction() const
{
	return NameValue;
}

void ATestBindingFunctionActor::OutNameValueFunction(FName& OutNameValue) const
{
	OutNameValue = NameValue;
}

void ATestBindingFunctionActor::SetTextValueFunction(const FText& InTextValue)
{
	TextValue = InTextValue;
}

FText ATestBindingFunctionActor::GetTextValueFunction() const
{
	return TextValue;
}

void ATestBindingFunctionActor::OutTextValueFunction(FText& OutTextValue) const
{
	OutTextValue = TextValue;
}

void ATestBindingFunctionActor::SetStringValueFunction(const FString& InStringValue)
{
	StringValue = InStringValue;
}

FString ATestBindingFunctionActor::GetStringValueFunction() const
{
	return StringValue;
}

void ATestBindingFunctionActor::OutStringValueFunction(FString& OutStringValue) const
{
	OutStringValue = StringValue;
}
