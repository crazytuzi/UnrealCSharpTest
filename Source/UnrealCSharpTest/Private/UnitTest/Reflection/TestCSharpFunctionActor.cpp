// Fill out your copyright notice in the Description page of Project Settings.


#include "UnitTest/Reflection/TestCSharpFunctionActor.h"

// Sets default values
ATestCSharpFunctionActor::ATestCSharpFunctionActor():
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
void ATestCSharpFunctionActor::BeginPlay()
{
	Super::BeginPlay();
}

// Called every frame
void ATestCSharpFunctionActor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);
}

void ATestCSharpFunctionActor::SetBoolValueFunction_Implementation(const bool InBoolValue)
{
	BoolValue = InBoolValue;
}

bool ATestCSharpFunctionActor::GetBoolValueFunction_Implementation() const
{
	return BoolValue;
}

void ATestCSharpFunctionActor::OutBoolValueFunction_Implementation(bool& OutBoolValue) const
{
	OutBoolValue = BoolValue;
}

void ATestCSharpFunctionActor::SetInt32ValueFunction_Implementation(const int32 InInt32Value)
{
	Int32Value = InInt32Value;
}

int32 ATestCSharpFunctionActor::GetInt32ValueFunction_Implementation() const
{
	return Int32Value;
}

void ATestCSharpFunctionActor::OutInt32ValueFunction_Implementation(int32& OutInt32Value) const
{
	OutInt32Value = Int32Value;
}

void ATestCSharpFunctionActor::SetInt64ValueFunction_Implementation(const int64 InInt64Value)
{
	Int64Value = InInt64Value;
}

int64 ATestCSharpFunctionActor::GetInt64ValueFunction_Implementation() const
{
	return Int64Value;
}

void ATestCSharpFunctionActor::OutInt64ValueFunction_Implementation(int64& OutInt64Value) const
{
	OutInt64Value = Int64Value;
}

void ATestCSharpFunctionActor::SetUInt8ValueFunction_Implementation(const uint8 InUInt8Value)
{
	UInt8Value = InUInt8Value;
}

uint8 ATestCSharpFunctionActor::GetUInt8ValueFunction_Implementation() const
{
	return UInt8Value;
}

void ATestCSharpFunctionActor::OutUInt8ValueFunction_Implementation(uint8& OutUInt8Value) const
{
	OutUInt8Value = UInt8Value;
}

void ATestCSharpFunctionActor::SetFloatValueFunction_Implementation(const float InFloatValue)
{
	FloatValue = InFloatValue;
}

float ATestCSharpFunctionActor::GetFloatValueFunction_Implementation() const
{
	return FloatValue;
}

void ATestCSharpFunctionActor::OutFloatValueFunction_Implementation(float& OutFloatValue) const
{
	OutFloatValue = FloatValue;
}

void ATestCSharpFunctionActor::SetDoubleValueFunction_Implementation(const double InDoubleValue)
{
	DoubleValue = InDoubleValue;
}

double ATestCSharpFunctionActor::GetDoubleValueFunction_Implementation() const
{
	return DoubleValue;
}

void ATestCSharpFunctionActor::OutDoubleValueFunction_Implementation(double& OutDoubleValue) const
{
	OutDoubleValue = DoubleValue;
}

void ATestCSharpFunctionActor::SetNameValueFunction_Implementation(const FName& InNameValue)
{
	NameValue = InNameValue;
}

FName ATestCSharpFunctionActor::GetNameValueFunction_Implementation() const
{
	return NameValue;
}

void ATestCSharpFunctionActor::OutNameValueFunction_Implementation(FName& OutNameValue) const
{
	OutNameValue = NameValue;
}

void ATestCSharpFunctionActor::SetTextValueFunction_Implementation(const FText& InTextValue)
{
	TextValue = InTextValue;
}

FText ATestCSharpFunctionActor::GetTextValueFunction_Implementation() const
{
	return TextValue;
}

void ATestCSharpFunctionActor::OutTextValueFunction_Implementation(FText& OutTextValue) const
{
	OutTextValue = TextValue;
}

void ATestCSharpFunctionActor::SetStringValueFunction_Implementation(const FString& InStringValue)
{
	StringValue = InStringValue;
}

FString ATestCSharpFunctionActor::GetStringValueFunction_Implementation() const
{
	return StringValue;
}

void ATestCSharpFunctionActor::OutStringValueFunction_Implementation(FString& OutStringValue) const
{
	OutStringValue = StringValue;
}

void ATestCSharpFunctionActor::SetEnumValueFunction_Implementation(const ETestEnum InEnumValue)
{
	EnumValue = InEnumValue;
}

ETestEnum ATestCSharpFunctionActor::GetEnumValueFunction_Implementation() const
{
	return EnumValue;
}

void ATestCSharpFunctionActor::OutEnumValueFunction_Implementation(TEnumAsByte<ETestEnum>& OutEnumValue) const
{
	OutEnumValue = EnumValue;
}

void ATestCSharpFunctionActor::SetEnumClassValueFunction_Implementation(const ETestEnumClass InEnumClassValue)
{
	EnumClassValue = InEnumClassValue;
}

ETestEnumClass ATestCSharpFunctionActor::GetEnumClassValueFunction_Implementation() const
{
	return EnumClassValue;
}

void ATestCSharpFunctionActor::OutEnumClassValueFunction_Implementation(ETestEnumClass& OutEnumClassValue) const
{
	OutEnumClassValue = EnumClassValue;
}

void ATestCSharpFunctionActor::SetStructValueFunction_Implementation(const FTestStruct& InStructValue)
{
	StructValue = InStructValue;
}

FTestStruct ATestCSharpFunctionActor::GetStructValueFunction_Implementation() const
{
	return StructValue;
}

void ATestCSharpFunctionActor::OutStructValueFunction_Implementation(FTestStruct& OutStructValue) const
{
	OutStructValue = StructValue;
}

void ATestCSharpFunctionActor::SetObjectValueFunction_Implementation(UObject* InObjectValue)
{
	ObjectValue = InObjectValue;
}

UObject* ATestCSharpFunctionActor::GetObjectValueFunction_Implementation() const
{
	return ObjectValue;
}

void ATestCSharpFunctionActor::OutObjectValueFunction_Implementation(UObject*& OutObjectValue) const
{
	OutObjectValue = ObjectValue;
}

void ATestCSharpFunctionActor::SetClassValueFunction_Implementation(UClass* InClassValue)
{
	ClassValue = InClassValue;
}

UClass* ATestCSharpFunctionActor::GetClassValueFunction_Implementation() const
{
	return ClassValue;
}

void ATestCSharpFunctionActor::OutClassValueFunction_Implementation(UClass*& OutClassValue) const
{
	OutClassValue = ClassValue;
}

void ATestCSharpFunctionActor::SetInterfaceValueFunction_Implementation(
	const TScriptInterface<ITestInterface>& InInterfaceValue)
{
	InterfaceValue = InInterfaceValue;
}

TScriptInterface<ITestInterface> ATestCSharpFunctionActor::GetInterfaceValueFunction_Implementation() const
{
	return InterfaceValue;
}

void ATestCSharpFunctionActor::OutInterfaceValueFunction_Implementation(
	TScriptInterface<ITestInterface>& OutInterfaceValue) const
{
	OutInterfaceValue = InterfaceValue;
}

void ATestCSharpFunctionActor::SetSubclassOfValueFunction_Implementation(const TSubclassOf<UObject> InSubclassOfValue)
{
	SubclassOfValue = InSubclassOfValue;
}

TSubclassOf<UObject> ATestCSharpFunctionActor::GetSubclassOfValueFunction_Implementation() const
{
	return SubclassOfValue;
}

void ATestCSharpFunctionActor::OutSubclassOfValueFunction_Implementation(TSubclassOf<UObject>& OutSubclassOfValue) const
{
	OutSubclassOfValue = SubclassOfValue;
}

void ATestCSharpFunctionActor::SetSoftObjectPtrValueFunction_Implementation(
	const TSoftObjectPtr<UObject>& InSoftObjectPtrValue)
{
	SoftObjectPtrValue = InSoftObjectPtrValue;
}

TSoftObjectPtr<UObject> ATestCSharpFunctionActor::GetSoftObjectPtrValueFunction_Implementation() const
{
	return SoftObjectPtrValue;
}

void ATestCSharpFunctionActor::OutSoftObjectPtrValueFunction_Implementation(
	TSoftObjectPtr<UObject>& OutSoftObjectPtrValue) const
{
	OutSoftObjectPtrValue = SoftObjectPtrValue;
}

void ATestCSharpFunctionActor::SetSoftClassPtrValueFunction_Implementation(
	const TSoftClassPtr<UObject>& InSoftClassPtrValue)
{
	SoftClassPtrValue = InSoftClassPtrValue;
}

TSoftClassPtr<UObject> ATestCSharpFunctionActor::GetSoftClassPtrValueFunction_Implementation() const
{
	return SoftClassPtrValue;
}

void ATestCSharpFunctionActor::OutSoftClassPtrValueFunction_Implementation(
	TSoftClassPtr<UObject>& OutSoftClassPtrValue) const
{
	OutSoftClassPtrValue = SoftClassPtrValue;
}

void ATestCSharpFunctionActor::SetArrayValueFunction_Implementation(const TArray<int32>& InArrayValue)
{
	ArrayValue = InArrayValue;
}

TArray<int32> ATestCSharpFunctionActor::GetArrayValueFunction_Implementation() const
{
	return ArrayValue;
}

void ATestCSharpFunctionActor::OutArrayValueFunction_Implementation(TArray<int32>& OutArrayValue) const
{
	OutArrayValue = ArrayValue;
}

void ATestCSharpFunctionActor::SetSetValueFunction_Implementation(const TSet<int32>& InSetValue)
{
	SetValue = InSetValue;
}

TSet<int32> ATestCSharpFunctionActor::GetSetValueFunction_Implementation() const
{
	return SetValue;
}

void ATestCSharpFunctionActor::OutSetValueFunction_Implementation(TSet<int32>& OutSetValue) const
{
	OutSetValue = SetValue;
}

void ATestCSharpFunctionActor::SetMapValueFunction_Implementation(const TMap<int32, int32>& InMapValue)
{
	MapValue = InMapValue;
}

TMap<int32, int32> ATestCSharpFunctionActor::GetMapValueFunction_Implementation() const
{
	return MapValue;
}

void ATestCSharpFunctionActor::OutMapValueFunction_Implementation(TMap<int32, int32>& OutMapValue) const
{
	OutMapValue = MapValue;
}
