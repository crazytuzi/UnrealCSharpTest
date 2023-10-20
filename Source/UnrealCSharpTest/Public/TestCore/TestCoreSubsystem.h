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
	template <typename T>
	void TestEqual(const FString& InWhat, const T& InActual, const T& InExpected)
	{
		Test(InWhat, InActual == InExpected);
	}

	void TestEqual(const FString& InWhat, const FText& InActual, const FText& InExpected);

	template <typename T>
	void TestEqual(const FString& InWhat, const TSet<T>& InActual, const TSet<T>& InExpected)
	{
		auto bIsPassed = true;

		if (InActual.Num() == InExpected.Num())
		{
			for (auto Elem : InActual)
			{
				if (!InExpected.Contains(Elem))
				{
					bIsPassed = false;

					break;
				}
			}
		}
		else
		{
			bIsPassed = false;
		}

		Test(InWhat, bIsPassed);
	}

	template <typename TKey, typename TValue>
	void TestEqual(const FString& InWhat, const TMap<TKey, TValue>& InActual, const TMap<TKey, TValue>& InExpected)
	{
		auto bIsPassed = true;

		if (InActual.Num() == InExpected.Num())
		{
			for (auto Elem : InActual)
			{
				if (!InExpected.Contains(Elem.Key))
				{
					bIsPassed = false;

					break;
				}
				else
				{
					if (InExpected[Elem.Key] != Elem.Value)
					{
						bIsPassed = false;

						break;
					}
				}
			}
		}
		else
		{
			bIsPassed = false;
		}

		Test(InWhat, bIsPassed);
	}

private:
	void Test(const FString& InWhat, const bool bIsPassed);

public:
	UPROPERTY()
	TArray<FTestResult> TestResults;

	UPROPERTY()
	TArray<int32> PassedIndex;

	UPROPERTY()
	TArray<int32> NotPassedIndex;
};
