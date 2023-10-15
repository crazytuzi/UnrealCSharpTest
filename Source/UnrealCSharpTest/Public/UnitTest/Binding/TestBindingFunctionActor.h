// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "UnitTest/Core/TestInterface.h"
#include "UnitTest/Core/ERawTestEnum.h"
#include "UnitTest/Core/ERawTestEnumClass.h"
#include "UnitTest/Core/FRawTestStruct.h"
#include "TestBindingFunctionActor.generated.h"

UCLASS()
class UNREALCSHARPTEST_API ATestBindingFunctionActor : public AActor, public ITestInterface
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

	void SetNameValueFunction(const FName& InNameValue);

	FName GetNameValueFunction() const;

	void OutNameValueFunction(FName& OutNameValue) const;

	void SetTextValueFunction(const FText& InTextValue);

	FText GetTextValueFunction() const;

	void OutTextValueFunction(FText& OutTextValue) const;

	void SetStringValueFunction(const FString& InStringValue);

	FString GetStringValueFunction() const;

	void OutStringValueFunction(FString& OutStringValue) const;

	void SetEnumValueFunction(ETestEnum InEnumValue);

	ETestEnum GetEnumValueFunction() const;

	void OutEnumValueFunction(ETestEnum& OutEnumValue) const;

	void SetEnumAsByteValueFunction(TEnumAsByte<ETestEnum> InEnumAsByteValue);

	TEnumAsByte<ETestEnum> GetEnumAsByteValueFunction() const;

	void OutEnumAsByteValueFunction(TEnumAsByte<ETestEnum>& OutEnumAsByteValue) const;

	void SetEnumClassValueFunction(ETestEnumClass InEnumClassValue);

	ETestEnumClass GetEnumClassValueFunction() const;

	void OutEnumClassValueFunction(ETestEnumClass& OutEnumClassValue) const;

	void SetRawEnumValueFunction(ERawTestEnum InRawEnumValue);

	ERawTestEnum GetRawEnumValueFunction() const;

	void OutRawEnumValueFunction(ERawTestEnum& OutRawEnumValue) const;

	void SetRawEnumClassValueFunction(ERawTestEnumClass InRawEnumClassValue);

	ERawTestEnumClass GetRawEnumClassValueFunction() const;

	void OutRawEnumClassValueFunction(ERawTestEnumClass& OutRawEnumClassValue) const;

	void SetStructValueFunction(const FTestStruct& InStructValue);

	FTestStruct GetStructValueFunction() const;

	void OutStructValueFunction(FTestStruct& OutStructValue) const;

	void SetRawStructValueFunction(const FRawTestStruct& InRawStructValue);

	FRawTestStruct GetRawStructValueFunction() const;

	void OutRawStructValueFunction(FRawTestStruct& OutRawStructValue) const;

	void SetObjectValueFunction(UObject* InObjectValue);

	UObject* GetObjectValueFunction() const;

	void OutObjectValueFunction(UObject*& OutObjectValue) const;

	void SetClassValueFunction(UClass* InClassValue);

	UClass* GetClassValueFunction() const;

	void OutClassValueFunction(UClass*& OutClassValue) const;

	void SetInterfaceValueFunction(const TScriptInterface<ITestInterface>& InInterfaceValue);

	TScriptInterface<ITestInterface> GetInterfaceValueFunction() const;

	void OutInterfaceValueFunction(TScriptInterface<ITestInterface>& OutInterfaceValue) const;

	void SetSubclassOfValueFunction(const TSubclassOf<UObject>& InSubclassOfValue);

	TSubclassOf<UObject> GetSubclassOfValueFunction() const;

	void OutSubclassOfValueFunction(TSubclassOf<UObject>& OutSubclassOfValue) const;

	void SetWeakObjectPtrValueFunction(const TWeakObjectPtr<UObject>& InWeakObjectPtrValue);

	TWeakObjectPtr<UObject> GetWeakObjectPtrValueFunction() const;

	void OutWeakObjectPtrValueFunction(TWeakObjectPtr<UObject>& OutWeakObjectPtrValue) const;

	void SetLazyObjectPtrValueFunction(const TLazyObjectPtr<UObject>& InLazyObjectPtrValue);

	TLazyObjectPtr<UObject> GetLazyObjectPtrValueFunction() const;

	void OutLazyObjectPtrValueFunction(TLazyObjectPtr<UObject>& OutLazyObjectPtrValue) const;

	void SetSoftObjectPtrValueFunction(const TSoftObjectPtr<UObject>& InSoftObjectPtrValue);

	TSoftObjectPtr<UObject> GetSoftObjectPtrValueFunction() const;

	void OutSoftObjectPtrValueFunction(TSoftObjectPtr<UObject>& OutSoftObjectPtrValue) const;

	void SetSoftClassPtrValueFunction(const TSoftClassPtr<UObject>& InSoftClassPtrValue);

	TSoftClassPtr<UObject> GetSoftClassPtrValueFunction() const;

	void OutSoftClassPtrValueFunction(TSoftClassPtr<UObject>& OutSoftClassPtrValue) const;

	void SetArrayValueFunction(const TArray<int32>& InArrayValue);

	TArray<int32> GetArrayValueFunction() const;

	void OutArrayValueFunction(TArray<int32>& OutArrayValue) const;

	void SetSetValueFunction(const TSet<int32>& InSetValue);

	TSet<int32> GetSetValueFunction() const;

	void OutSetValueFunction(TSet<int32>& OutSetValue) const;

	void SetMapValueFunction(const TMap<int32, int32>& InMapValue);

	TMap<int32, int32> GetMapValueFunction() const;

	void OutMapValueFunction(TMap<int32, int32>& OutMapValue) const;

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
