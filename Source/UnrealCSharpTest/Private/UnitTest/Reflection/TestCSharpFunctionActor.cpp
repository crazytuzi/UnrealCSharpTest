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
