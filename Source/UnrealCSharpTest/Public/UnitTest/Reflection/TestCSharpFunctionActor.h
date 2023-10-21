// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "TestCSharpFunctionActor.generated.h"

UCLASS()
class UNREALCSHARPTEST_API ATestCSharpFunctionActor : public AActor
{
	GENERATED_BODY()

public:
	// Sets default values for this actor's properties
	ATestCSharpFunctionActor();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

public:
	// Called every frame
	virtual void Tick(float DeltaTime) override;

public:
	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void SetBoolValueFunction(bool InBoolValue);

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	bool GetBoolValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void OutBoolValueFunction(bool& OutBoolValue) const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void SetInt32ValueFunction(int32 InInt32Value);

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	int32 GetInt32ValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void OutInt32ValueFunction(int32& OutInt32Value) const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void SetInt64ValueFunction(int64 InInt64Value);

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	int64 GetInt64ValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void OutInt64ValueFunction(int64& OutInt64Value) const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void SetUInt8ValueFunction(uint8 InUInt8Value);

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	uint8 GetUInt8ValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void OutUInt8ValueFunction(uint8& OutUInt8Value) const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void SetFloatValueFunction(float InFloatValue);

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	float GetFloatValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void OutFloatValueFunction(float& OutFloatValue) const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void SetDoubleValueFunction(double InDoubleValue);

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	double GetDoubleValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void OutDoubleValueFunction(double& OutDoubleValue) const;

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

	UPROPERTY()
	class UTestCoreSubsystem* TestCoreSubsystem;
};
