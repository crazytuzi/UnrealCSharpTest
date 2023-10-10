// Fill out your copyright notice in the Description page of Project Settings.


#include "UnitTest/Reflection/TestReflectionFunctionActor.h"

// Sets default values
ATestReflectionFunctionActor::ATestReflectionFunctionActor()
{
	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;
}

// Called when the game starts or when spawned
void ATestReflectionFunctionActor::BeginPlay()
{
	Super::BeginPlay();
}

// Called every frame
void ATestReflectionFunctionActor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);
}

bool ATestReflectionFunctionActor::StaticFunction()
{
	return true;
}
