// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "UnitTest/Core/TestInterface.h"
#include "TestCSharpFunctionActor.generated.h"

UCLASS()
class UNREALCSHARPTEST_API ATestCSharpFunctionActor : public AActor, public ITestInterface
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
	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void SetBoolValueFunction(bool InBoolValue);

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	bool GetBoolValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void OutBoolValueFunction(bool& OutBoolValue) const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void SetInt32ValueFunction(int32 InInt32Value);

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	int32 GetInt32ValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void OutInt32ValueFunction(int32& OutInt32Value) const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void SetInt64ValueFunction(int64 InInt64Value);

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	int64 GetInt64ValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void OutInt64ValueFunction(int64& OutInt64Value) const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void SetUInt8ValueFunction(uint8 InUInt8Value);

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	uint8 GetUInt8ValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void OutUInt8ValueFunction(uint8& OutUInt8Value) const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void SetFloatValueFunction(float InFloatValue);

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	float GetFloatValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void OutFloatValueFunction(float& OutFloatValue) const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void SetDoubleValueFunction(double InDoubleValue);

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	double GetDoubleValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void OutDoubleValueFunction(double& OutDoubleValue) const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void SetNameValueFunction(const FName& InNameValue);

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	FName GetNameValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void OutNameValueFunction(FName& OutNameValue) const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void SetTextValueFunction(const FText& InTextValue);

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	FText GetTextValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void OutTextValueFunction(FText& OutTextValue) const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void SetStringValueFunction(const FString& InStringValue);

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	FString GetStringValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void OutStringValueFunction(FString& OutStringValue) const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void SetEnumValueFunction(ETestEnum InEnumValue);

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	ETestEnum GetEnumValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void OutEnumValueFunction(TEnumAsByte<ETestEnum>& OutEnumValue) const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void SetEnumClassValueFunction(ETestEnumClass InEnumClassValue);

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	ETestEnumClass GetEnumClassValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void OutEnumClassValueFunction(ETestEnumClass& OutEnumClassValue) const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void SetStructValueFunction(const FTestStruct& InStructValue);

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	FTestStruct GetStructValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void OutStructValueFunction(FTestStruct& OutStructValue) const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void SetObjectValueFunction(UObject* InObjectValue);

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	UObject* GetObjectValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void OutObjectValueFunction(UObject*& OutObjectValue) const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void SetClassValueFunction(UClass* InClassValue);

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	UClass* GetClassValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void OutClassValueFunction(UClass*& OutClassValue) const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void SetInterfaceValueFunction(const TScriptInterface<ITestInterface>& InInterfaceValue);

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	TScriptInterface<ITestInterface> GetInterfaceValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void OutInterfaceValueFunction(TScriptInterface<ITestInterface>& OutInterfaceValue) const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void SetSubclassOfValueFunction(TSubclassOf<UObject> InSubclassOfValue);

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	TSubclassOf<UObject> GetSubclassOfValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void OutSubclassOfValueFunction(TSubclassOf<UObject>& OutSubclassOfValue) const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void SetSoftObjectPtrValueFunction(const TSoftObjectPtr<UObject>& InSoftObjectPtrValue);

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	TSoftObjectPtr<UObject> GetSoftObjectPtrValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void OutSoftObjectPtrValueFunction(TSoftObjectPtr<UObject>& OutSoftObjectPtrValue) const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void SetSoftClassPtrValueFunction(const TSoftClassPtr<UObject>& InSoftClassPtrValue);

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	TSoftClassPtr<UObject> GetSoftClassPtrValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void OutSoftClassPtrValueFunction(TSoftClassPtr<UObject>& OutSoftClassPtrValue) const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void SetArrayValueFunction(const TArray<int32>& InArrayValue);

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	TArray<int32> GetArrayValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void OutArrayValueFunction(TArray<int32>& OutArrayValue) const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void SetSetValueFunction(const TSet<int32>& InSetValue);

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	TSet<int32> GetSetValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void OutSetValueFunction(TSet<int32>& OutSetValue) const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void SetMapValueFunction(const TMap<int32, int32>& InMapValue);

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	TMap<int32, int32> GetMapValueFunction() const;

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void OutMapValueFunction(TMap<int32, int32>& OutMapValue) const;

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
	TSubclassOf<UObject> SubclassOfValue;

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

	UPROPERTY()
	class UTestCoreSubsystem* TestCoreSubsystem;
};
