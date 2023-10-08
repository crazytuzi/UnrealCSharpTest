// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Kismet/BlueprintFunctionLibrary.h"
#include "TestCoreBlueprintFunctionLibrary.generated.h"

/**
 * 
 */
UCLASS()
class UNREALCSHARPTEST_API UTestCoreBlueprintFunctionLibrary : public UBlueprintFunctionLibrary
{
	GENERATED_BODY()

public:
	UFUNCTION(BlueprintCallable)
	static FString GetPlatform();

	UFUNCTION(BlueprintCallable)
	static FString GetBuildConfiguration();

	UFUNCTION(BlueprintCallable)
	static void SaveStringToFile(FString FileName, const FString& String);
};
