// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "TestBindingFunctionActor.generated.h"

UCLASS()
class UNREALCSHARPTEST_API ATestBindingFunctionActor : public AActor
{
	GENERATED_BODY()

public:
	// Sets default values for this actor's properties
	ATestBindingFunctionActor();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

public:
	// Called every frame
	virtual void Tick(float DeltaTime) override;

public:
	static bool StaticFunction();

	void SetBoolValueFunction(bool InBoolValue);

	bool GetBoolValueFunction() const;

	void OutBoolValueFunction(bool& OutBoolValue) const;

	void SetInt8ValueFunction(int8 InInt8Value);

	int8 GetInt8ValueFunction() const;

	void OutInt8ValueFunction(int8& OutInt8Value) const;

	void SetInt16ValueFunction(int16 InInt16Value);

	int16 GetInt16ValueFunction() const;

	void OutInt16ValueFunction(int16& OutInt16Value) const;

	void SetInt32ValueFunction(int32 InInt32Value);

	int32 GetInt32ValueFunction() const;

	void OutInt32ValueFunction(int32& OutInt32Value) const;

	void SetInt64ValueFunction(int64 InInt64Value);

	int64 GetInt64ValueFunction() const;

	void OutInt64ValueFunction(int64& OutInt64Value) const;

	void SetUInt8ValueFunction(uint8 InUInt8Value);

	uint8 GetUInt8ValueFunction() const;

	void OutUInt8ValueFunction(uint8& OutUInt8Value) const;

	void SetUInt16ValueFunction(uint16 InUInt16Value);

	uint16 GetUInt16ValueFunction() const;

	void OutUInt16ValueFunction(uint16& OutUInt16Value) const;

	void SetUInt32ValueFunction(uint32 InUInt32Value);

	uint32 GetUInt32ValueFunction() const;

	void OutUInt32ValueFunction(uint32& OutUInt32Value) const;

	void SetUInt64ValueFunction(uint64 InUInt64Value);

	uint64 GetUInt64ValueFunction() const;

	void OutUInt64ValueFunction(uint64& OutUInt64Value) const;

	void SetFloatValueFunction(float InFloatValue);

	float GetFloatValueFunction() const;

	void OutFloatValueFunction(float& OutFloatValue) const;

	void SetDoubleValueFunction(double InDoubleValue);

	double GetDoubleValueFunction() const;

	void OutDoubleValueFunction(double& OutDoubleValue) const;

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
};
