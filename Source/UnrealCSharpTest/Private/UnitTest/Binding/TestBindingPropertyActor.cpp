// Fill out your copyright notice in the Description page of Project Settings.


#include "UnitTest/Binding/TestBindingPropertyActor.h"
#include "Binding/Class/TReflectionClassBuilder.inl"
#include "Macro/NamespaceMacro.h"

BINDING_REFLECTION_CLASS(ATestBindingPropertyActor)

struct FRegisterTestBindingPropertyActor
{
	FRegisterTestBindingPropertyActor()
	{
		TReflectionClassBuilder<ATestBindingPropertyActor>(NAMESPACE_BINDING)
			.Property("BoolValue", BINDING_PROPERTY(&ATestBindingPropertyActor::BoolValue))
			.Property("Int8Value", BINDING_PROPERTY(&ATestBindingPropertyActor::Int8Value))
			.Property("Int16Value", BINDING_PROPERTY(&ATestBindingPropertyActor::Int16Value))
			.Property("Int32Value", BINDING_PROPERTY(&ATestBindingPropertyActor::Int32Value))
			.Property("Int64Value", BINDING_PROPERTY(&ATestBindingPropertyActor::Int64Value))
			.Property("UInt8Value", BINDING_PROPERTY(&ATestBindingPropertyActor::UInt8Value))
			.Property("UInt16Value", BINDING_PROPERTY(&ATestBindingPropertyActor::UInt16Value))
			.Property("UInt32Value", BINDING_PROPERTY(&ATestBindingPropertyActor::UInt32Value))
			.Property("UInt64Value", BINDING_PROPERTY(&ATestBindingPropertyActor::UInt64Value))
			.Property("FloatValue", BINDING_PROPERTY(&ATestBindingPropertyActor::FloatValue))
			.Property("DoubleValue", BINDING_PROPERTY(&ATestBindingPropertyActor::DoubleValue))
			.Property("NameValue", BINDING_PROPERTY(&ATestBindingPropertyActor::NameValue))
			.Property("TextValue", BINDING_PROPERTY(&ATestBindingPropertyActor::TextValue))
			.Property("StringValue", BINDING_PROPERTY(&ATestBindingPropertyActor::StringValue))
			.Property("EnumValue", BINDING_PROPERTY(&ATestBindingPropertyActor::EnumValue))
			.Property("EnumAsByteValue", BINDING_PROPERTY(&ATestBindingPropertyActor::EnumAsByteValue))
			.Property("EnumClassValue", BINDING_PROPERTY(&ATestBindingPropertyActor::EnumClassValue))
			.Property("RawEnumValue", BINDING_PROPERTY(&ATestBindingPropertyActor::RawEnumValue))
			.Property("RawEnumClassValue", BINDING_PROPERTY(&ATestBindingPropertyActor::RawEnumClassValue))
			.Property("StructValue", BINDING_PROPERTY(&ATestBindingPropertyActor::StructValue))
			.Property("RawStructValue", BINDING_PROPERTY(&ATestBindingPropertyActor::RawStructValue))
			.Property("ObjectValue", BINDING_PROPERTY(&ATestBindingPropertyActor::ObjectValue))
			.Property("ClassValue", BINDING_PROPERTY(&ATestBindingPropertyActor::ClassValue))
			.Property("InterfaceValue", BINDING_PROPERTY(&ATestBindingPropertyActor::InterfaceValue))
			.Property("SubclassOfValue", BINDING_PROPERTY(&ATestBindingPropertyActor::SubclassOfValue))
			.Property("WeakObjectPtrValue", BINDING_PROPERTY(&ATestBindingPropertyActor::WeakObjectPtrValue))
			.Property("LazyObjectPtrValue", BINDING_PROPERTY(&ATestBindingPropertyActor::LazyObjectPtrValue))
			.Property("SoftObjectPtrValue", BINDING_PROPERTY(&ATestBindingPropertyActor::SoftObjectPtrValue))
			.Property("SoftClassPtrValue", BINDING_PROPERTY(&ATestBindingPropertyActor::SoftClassPtrValue))
			.Property("ArrayValue", BINDING_PROPERTY(&ATestBindingPropertyActor::ArrayValue))
			.Property("SetValue", BINDING_PROPERTY(&ATestBindingPropertyActor::SetValue))
			.Property("MapValue", BINDING_PROPERTY(&ATestBindingPropertyActor::MapValue))
			.Register();
	}
};

static FRegisterTestBindingPropertyActor RegisterTestBindingPropertyActor;

// Sets default values
ATestBindingPropertyActor::ATestBindingPropertyActor():
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
	MapValue({{1, 1}, {2, 2}})
{
	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;
}

// Called when the game starts or when spawned
void ATestBindingPropertyActor::BeginPlay()
{
	Super::BeginPlay();
}

// Called every frame
void ATestBindingPropertyActor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);
}
