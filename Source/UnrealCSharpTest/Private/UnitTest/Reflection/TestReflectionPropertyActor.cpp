// Fill out your copyright notice in the Description page of Project Settings.


#include "UnitTest/Reflection/TestReflectionPropertyActor.h"

// Sets default values
ATestReflectionPropertyActor::ATestReflectionPropertyActor():
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
	StructValue({1})
{
	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;
}

// Called when the game starts or when spawned
void ATestReflectionPropertyActor::BeginPlay()
{
	Super::BeginPlay();
}

// Called every frame
void ATestReflectionPropertyActor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);
}
