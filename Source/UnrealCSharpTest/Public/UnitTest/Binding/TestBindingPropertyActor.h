// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "UnitTest/Core/TestInterface.h"
#include "UnitTest/Core/ERawTestEnum.h"
#include "UnitTest/Core/ERawTestEnumClass.h"
#include "UnitTest/Core/FRawTestStruct.h"
#include "TestBindingPropertyActor.generated.h"

UCLASS()
class UNREALCSHARPTEST_API ATestBindingPropertyActor : public AActor, public ITestInterface
{
	GENERATED_BODY()

public:
	// Sets default values for this actor's properties
	ATestBindingPropertyActor();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

public:
	// Called every frame
	virtual void Tick(float DeltaTime) override;

public:
	bool BoolValue;

	int8 Int8Value;

	int16 Int16Value;

	int32 Int32Value;

	int64 Int64Value;

	uint8 UInt8Value;

	uint16 UInt16Value;

	uint32 UInt32Value;

	uint64 UInt64Value;

	float FloatValue;

	double DoubleValue;

	FName NameValue;

	FText TextValue;

	FString StringValue;

	ETestEnum EnumValue;

	TEnumAsByte<ETestEnum> EnumAsByteValue;

	ETestEnumClass EnumClassValue;

	ERawTestEnum RawEnumValue;

	ERawTestEnumClass RawEnumClassValue;

	FTestStruct StructValue;

	FRawTestStruct RawStructValue;

	UObject* ObjectValue;

	UClass* ClassValue;

	TScriptInterface<ITestInterface> InterfaceValue;

	TSubclassOf<UObject> SubclassOfValue;

	TWeakObjectPtr<UObject> WeakObjectPtrValue;

	TLazyObjectPtr<UObject> LazyObjectPtrValue;

	TSoftObjectPtr<UObject> SoftObjectPtrValue;

	TSoftClassPtr<UObject> SoftClassPtrValue;

	TArray<int32> ArrayValue;

	TSet<int32> SetValue;

	TMap<int32, int32> MapValue;
};
