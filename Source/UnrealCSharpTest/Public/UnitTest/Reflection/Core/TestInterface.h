// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "UObject/Interface.h"
#include "TestInterface.generated.h"

USTRUCT(BlueprintType)
struct FTestStruct
{
	GENERATED_BODY()

	UPROPERTY(BlueprintReadWrite)
	int32 Value;
};

UENUM(BlueprintType)
enum ETestEnum
{
	TestEnumZero,
	TestEnumOne,
	TestEnumTwo
};

UENUM(BlueprintType)
enum class ETestEnumClass : uint8
{
	TestEnumClassZero,
	TestEnumClassOne,
	TestEnumClassTwo
};

// This class does not need to be modified.
UINTERFACE(MinimalAPI)
class UTestInterface : public UInterface
{
	GENERATED_BODY()
};

/**
 * 
 */
class UNREALCSHARPTEST_API ITestInterface
{
	GENERATED_BODY()

	// Add interface functions to this class. This is the class that will be inherited to implement this interface.
public:
};
