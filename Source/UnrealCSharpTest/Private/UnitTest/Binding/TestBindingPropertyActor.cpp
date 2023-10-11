// Fill out your copyright notice in the Description page of Project Settings.


#include "UnitTest/Binding/TestBindingPropertyActor.h"
#include "Binding/Class/TReflectionClassBuilder.inl"
#include "Macro/NamespaceMacro.h"

BINDING_REFLECTION_CLASS(ATestBindingPropertyActor);

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
	StringValue(TEXT("String12"))
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
