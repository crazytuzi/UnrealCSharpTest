// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "TestBase/TestBaseSubsystem.h"
#include "UnitTestSubsystem.generated.h"

/**
 * 
 */
UCLASS()
class UNREALCSHARPTEST_API UUnitTestSubsystem : public UTestBaseSubsystem
{
	GENERATED_BODY()

public:
	UFUNCTION(BlueprintCallable)
	void TestCSharpFunction();
};
