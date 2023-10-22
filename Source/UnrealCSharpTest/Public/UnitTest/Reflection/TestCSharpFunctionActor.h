// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "UnitTest/Core/TestInterface.h"
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

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void SetNameValueFunction(const FName& InNameValue);

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	FName GetNameValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void OutNameValueFunction(FName& OutNameValue) const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void SetTextValueFunction(const FText& InTextValue);

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	FText GetTextValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void OutTextValueFunction(FText& OutTextValue) const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void SetStringValueFunction(const FString& InStringValue);

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	FString GetStringValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void OutStringValueFunction(FString& OutStringValue) const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void SetEnumValueFunction(ETestEnum InEnumValue);

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	ETestEnum GetEnumValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void OutEnumValueFunction(TEnumAsByte<ETestEnum>& OutEnumValue) const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void SetEnumClassValueFunction(ETestEnumClass InEnumClassValue);

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	ETestEnumClass GetEnumClassValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void OutEnumClassValueFunction(ETestEnumClass& OutEnumClassValue) const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void SetStructValueFunction(const FTestStruct& InStructValue);

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	FTestStruct GetStructValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void OutStructValueFunction(FTestStruct& OutStructValue) const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void SetObjectValueFunction(UObject* InObjectValue);

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	UObject* GetObjectValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void OutObjectValueFunction(UObject*& OutObjectValue) const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void SetClassValueFunction(UClass* InClassValue);

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	UClass* GetClassValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
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

	UPROPERTY()
	class UTestCoreSubsystem* TestCoreSubsystem;
};
