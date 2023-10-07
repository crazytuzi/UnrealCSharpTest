// Fill out your copyright notice in the Description page of Project Settings.


#include "TestCore/TestCoreSubsystem.h"
#include "TestBase/TestBaseSubsystem.h"

void UTestCoreSubsystem::Test() const
{
	auto TestSubsystemArray = GetWorld()->GetSubsystemArray<UTestBaseSubsystem>();

	for (const auto& TestSubsystem : TestSubsystemArray)
	{
		TestSubsystem->Test();
	}
}
