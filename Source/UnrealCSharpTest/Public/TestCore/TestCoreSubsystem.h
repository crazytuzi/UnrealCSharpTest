// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Subsystems/GameInstanceSubsystem.h"
#include "TestCoreSubsystem.generated.h"

USTRUCT()
struct FTestResult
{
	GENERATED_BODY()

	UPROPERTY()
	FString What;

	UPROPERTY()
	bool bIsPassed;
};

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

public:
	UFUNCTION(BlueprintCallable)
	void StartTest() const;

	UFUNCTION(BlueprintCallable)
	void ProcessTest() const;

	UFUNCTION(BlueprintCallable)
	void EndTest() const;

public:
	UPROPERTY()
	TArray<FTestResult> TestResults;

	UPROPERTY()
	TArray<int32> PassedIndex;

	UPROPERTY()
	TArray<int32> NotPassedIndex;
};
