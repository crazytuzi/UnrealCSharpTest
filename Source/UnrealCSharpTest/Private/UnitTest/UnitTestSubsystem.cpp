// Fill out your copyright notice in the Description page of Project Settings.


#include "UnitTest/UnitTestSubsystem.h"
#include "Subsystems/SubsystemBlueprintLibrary.h"
#include "TestCore/TestCoreSubsystem.h"
#include "UnitTest/Reflection/TestCSharpFunctionActor.h"

void UUnitTestSubsystem::TestCSharpFunction()
{
	const auto TestCoreSubsystem = Cast<UTestCoreSubsystem>(
		USubsystemBlueprintLibrary::GetGameInstanceSubsystem(this, UTestCoreSubsystem::StaticClass()));

	const auto FunctionActor = GetWorld()->SpawnActor<ATestCSharpFunctionActor>();

	FunctionActor->TestCoreSubsystem = TestCoreSubsystem;

	// Bool
	TestCoreSubsystem->TestEqual("CSharpGetBoolFunction", FunctionActor->GetBoolValueFunction(), true);

	FunctionActor->SetBoolValueFunction(false);

	TestCoreSubsystem->TestEqual("CSharpSetBoolFunction", FunctionActor->GetBoolValueFunction(), false);

	bool OutBoolValue = true;

	FunctionActor->OutBoolValueFunction(OutBoolValue);

	TestCoreSubsystem->TestEqual("CSharpOutSetBoolFunction", OutBoolValue, false);

	// Int32
	TestCoreSubsystem->TestEqual("CSharpGetInt32Function", FunctionActor->GetInt32ValueFunction(),
	                             static_cast<int32>(12));

	FunctionActor->SetInt32ValueFunction(21);

	TestCoreSubsystem->TestEqual("CSharpSetInt32Function", FunctionActor->GetInt32ValueFunction(),
	                             static_cast<int32>(21));

	int32 OutInt32Value = 12;

	FunctionActor->OutInt32ValueFunction(OutInt32Value);

	TestCoreSubsystem->TestEqual("CSharpOutSetInt32Function", OutInt32Value, 21);

	// Int64
	TestCoreSubsystem->TestEqual("CSharpGetInt64Function", FunctionActor->GetInt64ValueFunction(),
	                             static_cast<int64>(12));

	FunctionActor->SetInt64ValueFunction(21);

	TestCoreSubsystem->TestEqual("CSharpSetInt64Function", FunctionActor->GetInt64ValueFunction(),
	                             static_cast<int64>(21));

	int64 OutInt64Value = 12;

	FunctionActor->OutInt64ValueFunction(OutInt64Value);

	TestCoreSubsystem->TestEqual("CSharpOutSetInt64Function", OutInt64Value, static_cast<int64>(21));

	// UInt8
	TestCoreSubsystem->TestEqual("CSharpGetUInt8Function", FunctionActor->GetUInt8ValueFunction(),
	                             static_cast<uint8>(12));

	FunctionActor->SetUInt8ValueFunction(21);

	TestCoreSubsystem->TestEqual("CSharpSetUInt8Function", FunctionActor->GetUInt8ValueFunction(),
	                             static_cast<uint8>(21));

	uint8 OutUInt8Value = 12;

	FunctionActor->OutUInt8ValueFunction(OutUInt8Value);

	TestCoreSubsystem->TestEqual("CSharpOutSetUInt8Function", OutUInt8Value, static_cast<uint8>(21));

	// Float
	TestCoreSubsystem->TestEqual("CSharpGetFloatFunction", FunctionActor->GetFloatValueFunction(), 12.3f);

	FunctionActor->SetFloatValueFunction(3.21f);

	TestCoreSubsystem->TestEqual("CSharpSetFloatFunction", FunctionActor->GetFloatValueFunction(), 3.21f);

	float OutFloatValue = 12.3f;

	FunctionActor->OutFloatValueFunction(OutFloatValue);

	TestCoreSubsystem->TestEqual("CSharpOutSetFloatFunction", OutFloatValue, 3.21f);

	// Double
	TestCoreSubsystem->TestEqual("CSharpGetDoubleFunction", FunctionActor->GetDoubleValueFunction(), 12.3);

	FunctionActor->SetDoubleValueFunction(3.21);

	TestCoreSubsystem->TestEqual("CSharpSetDoubleFunction", FunctionActor->GetDoubleValueFunction(), 3.21);

	double OutDoubleValue = 12.3;

	FunctionActor->OutDoubleValueFunction(OutDoubleValue);

	TestCoreSubsystem->TestEqual("CSharpOutSetDoubleFunction", OutDoubleValue, 3.21);
}
