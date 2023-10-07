// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Subsystems/GameInstanceSubsystem.h"
#include "TestCoreSubsystem.generated.h"

/**
 * 
 */
UCLASS()
class UNREALCSHARPTEST_API UTestCoreSubsystem : public UGameInstanceSubsystem
{
	GENERATED_BODY()

public:
	UFUNCTION(BlueprintCallable)
	void Test() const;
};
