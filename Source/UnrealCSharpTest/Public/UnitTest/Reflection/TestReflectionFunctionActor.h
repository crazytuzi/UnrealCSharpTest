// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "Core/TestInterface.h"
#include "TestReflectionFunctionActor.generated.h"

UCLASS()
class UNREALCSHARPTEST_API ATestReflectionFunctionActor : public AActor
{
	GENERATED_BODY()

public:
	// Sets default values for this actor's properties
	ATestReflectionFunctionActor();

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

public:
	// Called every frame
	virtual void Tick(float DeltaTime) override;

public:
	UFUNCTION(BlueprintCallable)
	static bool StaticFunction();

	UFUNCTION(BlueprintCallable)
	void SetBoolValueFunction(bool InBoolValue);

	UFUNCTION(BlueprintCallable)
	bool GetBoolValueFunction() const;

	UFUNCTION(BlueprintCallable)
	void OutBoolValueFunction(bool& OutBoolValue) const;

	UFUNCTION()
	void SetInt8ValueFunction(int8 InInt8Value);

	UFUNCTION()
	int8 GetInt8ValueFunction() const;

	UFUNCTION()
	void OutInt8ValueFunction(int8& OutInt8Value) const;

	UFUNCTION()
	void SetInt16ValueFunction(int16 InInt16Value);

	UFUNCTION()
	int16 GetInt16ValueFunction() const;

	UFUNCTION()
	void OutInt16ValueFunction(int16& OutInt16Value) const;

	UFUNCTION(BlueprintCallable)
	void SetInt32ValueFunction(int32 InInt32Value);

	UFUNCTION(BlueprintCallable)
	int32 GetInt32ValueFunction() const;

	UFUNCTION(BlueprintCallable)
	void OutInt32ValueFunction(int32& OutInt32Value) const;

	UFUNCTION(BlueprintCallable)
	void SetInt64ValueFunction(int64 InInt64Value);

	UFUNCTION(BlueprintCallable)
	int64 GetInt64ValueFunction() const;

	UFUNCTION(BlueprintCallable)
	void OutInt64ValueFunction(int64& OutInt64Value) const;

	UFUNCTION(BlueprintCallable)
	void SetUInt8ValueFunction(uint8 InUInt8Value);

	UFUNCTION(BlueprintCallable)
	uint8 GetUInt8ValueFunction() const;

	UFUNCTION(BlueprintCallable)
	void OutUInt8ValueFunction(uint8& OutUInt8Value) const;

	UFUNCTION()
	void SetUInt16ValueFunction(uint16 InUInt16Value);

	UFUNCTION()
	uint16 GetUInt16ValueFunction() const;

	UFUNCTION()
	void OutUInt16ValueFunction(uint16& OutUInt16Value) const;

	UFUNCTION()
	void SetUInt32ValueFunction(uint32 InUInt32Value);

	UFUNCTION()
	uint32 GetUInt32ValueFunction() const;

	UFUNCTION()
	void OutUInt32ValueFunction(uint32& OutUInt32Value) const;

	UFUNCTION()
	void SetUInt64ValueFunction(uint64 InUInt64Value);

	UFUNCTION()
	uint64 GetUInt64ValueFunction() const;

	UFUNCTION()
	void OutUInt64ValueFunction(uint64& OutUInt64Value) const;

	UFUNCTION(BlueprintCallable)
	void SetFloatValueFunction(float InFloatValue);

	UFUNCTION(BlueprintCallable)
	float GetFloatValueFunction() const;

	UFUNCTION(BlueprintCallable)
	void OutFloatValueFunction(float& OutFloatValue) const;

	UFUNCTION(BlueprintCallable)
	void SetDoubleValueFunction(double InDoubleValue);

	UFUNCTION(BlueprintCallable)
	double GetDoubleValueFunction() const;

	UFUNCTION(BlueprintCallable)
	void OutDoubleValueFunction(double& OutDoubleValue) const;

	UFUNCTION(BlueprintCallable)
	void SetNameValueFunction(const FName& InNameValue);

	UFUNCTION(BlueprintCallable)
	FName GetNameValueFunction() const;

	UFUNCTION(BlueprintCallable)
	void OutNameValueFunction(FName& OutNameValue) const;

	UFUNCTION(BlueprintCallable)
	void SetTextValueFunction(const FText& InTextValue);

	UFUNCTION(BlueprintCallable)
	FText GetTextValueFunction() const;

	UFUNCTION(BlueprintCallable)
	void OutTextValueFunction(FText& OutTextValue) const;

	UFUNCTION(BlueprintCallable)
	void SetStringValueFunction(const FString& InStringValue);

	UFUNCTION(BlueprintCallable)
	FString GetStringValueFunction() const;

	UFUNCTION(BlueprintCallable)
	void OutStringValueFunction(FString& OutStringValue) const;

	UFUNCTION(BlueprintCallable)
	void SetEnumValueFunction(ETestEnum InEnumValue);

	UFUNCTION(BlueprintCallable)
	ETestEnum GetEnumValueFunction() const;

	UFUNCTION(BlueprintCallable)
	void OutEnumValueFunction(TEnumAsByte<ETestEnum>& OutEnumValue) const;

	UFUNCTION(BlueprintCallable)
	void SetEnumClassValueFunction(ETestEnumClass InEnumClassValue);

	UFUNCTION(BlueprintCallable)
	ETestEnumClass GetEnumClassValueFunction() const;

	UFUNCTION(BlueprintCallable)
	void OutEnumClassValueFunction(ETestEnumClass& OutEnumClassValue) const;

	UFUNCTION(BlueprintCallable)
	void SetStructValueFunction(const FTestStruct& InStructValue);

	UFUNCTION(BlueprintCallable)
	FTestStruct GetStructValueFunction() const;

	UFUNCTION(BlueprintCallable)
	void OutStructValueFunction(FTestStruct& OutStructValue) const;

	UFUNCTION(BlueprintCallable)
	void SetObjectValueFunction(UObject* InObjectValue);

	UFUNCTION(BlueprintCallable)
	UObject* GetObjectValueFunction() const;

	UFUNCTION(BlueprintCallable)
	void OutObjectValueFunction(UObject*& OutObjectValue) const;

	UFUNCTION(BlueprintCallable)
	void SetClassValueFunction(UClass* InClassValue);

	UFUNCTION(BlueprintCallable)
	UClass* GetClassValueFunction() const;

	UFUNCTION(BlueprintCallable)
	void OutClassValueFunction(UClass*& OutClassValue) const;

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
};
