// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "UnitTest/Core/TestInterface.h"
#include "TestReflectionPropertyActor.generated.h"

UCLASS()
class UNREALCSHARPTEST_API ATestReflectionPropertyActor : public AActor, public ITestInterface
{
	GENERATED_BODY()

public:
	// Sets default values for this actor's properties
	ATestReflectionPropertyActor();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

public:
	// Called every frame
	virtual void Tick(float DeltaTime) override;

public:
	UPROPERTY(BlueprintReadWrite)
	bool BoolValue;

	UPROPERTY()
	int8 Int8Value;

	UPROPERTY()
	int16 Int16Value;

	UPROPERTY(BlueprintReadWrite)
	int32 Int32Value;

	UPROPERTY(BlueprintReadWrite)
	int64 Int64Value;

	UPROPERTY(BlueprintReadWrite)
	uint8 UInt8Value;

	UPROPERTY()
	uint16 UInt16Value;

	UPROPERTY()
	uint32 UInt32Value;

	UPROPERTY()
	uint64 UInt64Value;

	UPROPERTY(BlueprintReadWrite)
	float FloatValue;

	UPROPERTY(BlueprintReadWrite)
	double DoubleValue;

	UPROPERTY(BlueprintReadWrite)
	FName NameValue;

	UPROPERTY(BlueprintReadWrite)
	FText TextValue;

	UPROPERTY(BlueprintReadWrite)
	FString StringValue;

	UPROPERTY(BlueprintReadWrite)
	TEnumAsByte<ETestEnum> EnumValue;

	UPROPERTY(BlueprintReadWrite)
	ETestEnumClass EnumClassValue;

	UPROPERTY(BlueprintReadWrite)
	FTestStruct StructValue;

	UPROPERTY(BlueprintReadWrite)
	UObject* ObjectValue;

	UPROPERTY(BlueprintReadWrite)
	UClass* ClassValue;

	UPROPERTY(BlueprintReadWrite)
	TScriptInterface<ITestInterface> InterfaceValue;

	UPROPERTY(BlueprintReadWrite)
	TWeakObjectPtr<UObject> WeakObjectPtrValue;

	UPROPERTY()
	TLazyObjectPtr<UObject> LazyObjectPtrValue;

	UPROPERTY(BlueprintReadWrite)
	TSoftObjectPtr<UObject> SoftObjectPtrValue;

	UPROPERTY(BlueprintReadWrite)
	TSoftClassPtr<UObject> SoftClassPtrValue;

	UPROPERTY(BlueprintReadWrite)
	TArray<int32> ArrayValue;

	UPROPERTY(BlueprintReadWrite)
	TSet<int32> SetValue;

	UPROPERTY(BlueprintReadWrite)
	TMap<int32, int32> MapValue;
};
