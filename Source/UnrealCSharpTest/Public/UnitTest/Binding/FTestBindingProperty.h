#pragma once

#include "UnitTest/Core/TestInterface.h"
#include "UnitTest/Core/ERawTestEnum.h"
#include "UnitTest/Core/ERawTestEnumClass.h"
#include "UnitTest/Core/FRawTestStruct.h"

class FTestBindingProperty
{
public:
	FTestBindingProperty();

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
