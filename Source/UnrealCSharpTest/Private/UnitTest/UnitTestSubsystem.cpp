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

	// FName
	TestCoreSubsystem->TestEqual("CSharpGetNameFunction", FunctionActor->GetNameValueFunction(), FName(TEXT("Name12")));

	FunctionActor->SetNameValueFunction(FName(TEXT("21emaN")));

	TestCoreSubsystem->TestEqual("CSharpSetNameFunction", FunctionActor->GetNameValueFunction(), FName(TEXT("21emaN")));

	auto OutNameValue = FName(TEXT("Name12"));

	FunctionActor->OutNameValueFunction(OutNameValue);

	TestCoreSubsystem->TestEqual("CSharpOutSetNameFunction", OutNameValue, FName(TEXT("21emaN")));

	// FText
	TestCoreSubsystem->TestEqual("CSharpGetTextFunction", FunctionActor->GetTextValueFunction(),
	                             FText::FromString(TEXT("Text12")));

	FunctionActor->SetTextValueFunction(FText::FromString(TEXT("21txeT")));

	TestCoreSubsystem->TestEqual("CSharpSetTextFunction", FunctionActor->GetTextValueFunction(),
	                             FText::FromString(TEXT("21txeT")));

	auto OutTextValue = FText::FromString(TEXT("Text12"));

	FunctionActor->OutTextValueFunction(OutTextValue);

	TestCoreSubsystem->TestEqual("CSharpOutSetTextFunction", OutTextValue, FText::FromString(TEXT("21txeT")));

	// FString
	TestCoreSubsystem->TestEqual("CSharpGetStringFunction", FunctionActor->GetStringValueFunction(),
	                             FString(TEXT("String12")));

	FunctionActor->SetStringValueFunction(FString(TEXT("21gnirtS")));

	TestCoreSubsystem->TestEqual("CSharpSetStringFunction", FunctionActor->GetStringValueFunction(),
	                             FString(TEXT("21gnirtS")));

	auto OutStringValue = FString(TEXT("String12"));

	FunctionActor->OutStringValueFunction(OutStringValue);

	TestCoreSubsystem->TestEqual("CSharpOutSetStringFunction", OutStringValue, FString(TEXT("21gnirtS")));

	// Enum
	TestCoreSubsystem->TestEqual("CSharpGetEnumFunction", FunctionActor->GetEnumValueFunction(),
	                             ETestEnum::TestEnumOne);

	FunctionActor->SetEnumValueFunction(ETestEnum::TestEnumTwo);

	TestCoreSubsystem->TestEqual("CSharpSetEnumFunction", FunctionActor->GetEnumValueFunction(),
	                             ETestEnum::TestEnumTwo);

	auto OutEnumValue = TEnumAsByte<ETestEnum>(ETestEnum::TestEnumOne);

	FunctionActor->OutEnumValueFunction(OutEnumValue);

	TestCoreSubsystem->TestEqual("CSharpOutSetEnumFunction", OutEnumValue.GetValue(), ETestEnum::TestEnumTwo);

	// EnumClass
	TestCoreSubsystem->TestEqual("CSharpGetEnumClassFunction", FunctionActor->GetEnumClassValueFunction(),
	                             ETestEnumClass::TestEnumClassOne);

	FunctionActor->SetEnumClassValueFunction(ETestEnumClass::TestEnumClassTwo);

	TestCoreSubsystem->TestEqual("CSharpSetEnumClassFunction", FunctionActor->GetEnumClassValueFunction(),
	                             ETestEnumClass::TestEnumClassTwo);

	auto OutEnumClassValue = ETestEnumClass::TestEnumClassOne;

	FunctionActor->OutEnumClassValueFunction(OutEnumClassValue);

	TestCoreSubsystem->TestEqual("CSharpOutSetEnumClassFunction", OutEnumClassValue,
	                             ETestEnumClass::TestEnumClassTwo);

	// UStruct
	TestCoreSubsystem->TestEqual("CSharpGetStructFunction", FunctionActor->GetStructValueFunction(), FTestStruct{1});

	FunctionActor->SetStructValueFunction(FTestStruct{2});

	TestCoreSubsystem->TestEqual("CSharpSetStructFunction", FunctionActor->GetStructValueFunction(), FTestStruct{2});

	auto OutStructValue = FTestStruct{1};

	FunctionActor->OutStructValueFunction(OutStructValue);

	TestCoreSubsystem->TestEqual("CSharpOutSetStructFunction", OutStructValue, FTestStruct{2});

	// UObject
	TestCoreSubsystem->TestEqual("CSharpGetObjectFunction", FunctionActor->GetObjectValueFunction(),
	                             Cast<UObject>(FunctionActor));

	FunctionActor->SetObjectValueFunction(this);

	TestCoreSubsystem->TestEqual("CSharpSetObjectFunction", FunctionActor->GetObjectValueFunction(),
	                             Cast<UObject>(this));

	UObject* OutObjectValue = FunctionActor;

	FunctionActor->OutObjectValueFunction(OutObjectValue);

	TestCoreSubsystem->TestEqual("CSharpOutSetObjectFunction", OutObjectValue, Cast<UObject>(this));

	// UClass
	TestCoreSubsystem->TestEqual("CSharpGetClassFunction", FunctionActor->GetClassValueFunction(),
	                             FunctionActor->GetClass());

	FunctionActor->SetClassValueFunction(GetClass());

	TestCoreSubsystem->TestEqual("CSharpSetClassFunction", FunctionActor->GetClassValueFunction(), GetClass());

	UClass* OutClassValue = FunctionActor->GetClass();

	FunctionActor->OutClassValueFunction(OutClassValue);

	TestCoreSubsystem->TestEqual("CSharpOutSetClassFunction", OutClassValue, GetClass());

	// UInterface
	TestCoreSubsystem->TestEqual("CSharpGetInterfaceFunction", FunctionActor->GetInterfaceValueFunction(),
	                             FunctionActor->InterfaceValue);

	FunctionActor->SetInterfaceValueFunction(FunctionActor->InterfaceValue);

	TestCoreSubsystem->TestEqual("CSharpSetInterfaceFunction", FunctionActor->GetInterfaceValueFunction(),
	                             FunctionActor->InterfaceValue);

	auto OutInterfaceValue = FunctionActor->InterfaceValue;

	FunctionActor->OutInterfaceValueFunction(OutInterfaceValue);

	TestCoreSubsystem->TestEqual("CSharpOutSetInterfaceFunction", OutInterfaceValue, FunctionActor->InterfaceValue);

	// TSubclassOf
	TestCoreSubsystem->TestEqual("CSharpGetSubclassOfFunction", FunctionActor->GetSubclassOfValueFunction(),
	                             TSubclassOf<UObject>(FunctionActor->GetClass()));

	FunctionActor->SetSubclassOfValueFunction(GetClass());

	TestCoreSubsystem->TestEqual("CSharpSetSubclassOfFunction", FunctionActor->GetSubclassOfValueFunction(),
	                             TSubclassOf<UObject>(GetClass()));

	auto OutSubclassOfValue = TSubclassOf<UObject>(FunctionActor->GetClass());

	FunctionActor->OutSubclassOfValueFunction(OutSubclassOfValue);

	TestCoreSubsystem->TestEqual("CSharpOutSetSubclassOfFunction", OutSubclassOfValue,
	                             TSubclassOf<UObject>(GetClass()));

	// TSoftObjectPtr
	TestCoreSubsystem->TestEqual("CSharpGetSoftObjectPtrFunction", FunctionActor->GetSoftObjectPtrValueFunction(),
	                             TSoftObjectPtr<UObject>(FunctionActor));

	FunctionActor->SetSoftObjectPtrValueFunction(this);

	TestCoreSubsystem->TestEqual("CSharpSetSoftObjectPtrFunction", FunctionActor->GetSoftObjectPtrValueFunction(),
	                             TSoftObjectPtr<UObject>(this));

	auto OutSoftObjectPtrValue = TSoftObjectPtr<UObject>(FunctionActor);

	FunctionActor->OutSoftObjectPtrValueFunction(OutSoftObjectPtrValue);

	TestCoreSubsystem->TestEqual("CSharpOutSetSoftObjectPtrFunction", OutSoftObjectPtrValue,
	                             TSoftObjectPtr<UObject>(this));

	// TSoftClassPtr
	TestCoreSubsystem->TestEqual("CSharpGetSoftClassPtrFunction", FunctionActor->GetSoftClassPtrValueFunction(),
	                             TSoftClassPtr<UObject>(FunctionActor->GetClass()));

	FunctionActor->SetSoftClassPtrValueFunction(GetClass());

	TestCoreSubsystem->TestEqual("CSharpSetSoftClassPtrFunction", FunctionActor->GetSoftClassPtrValueFunction(),
	                             TSoftClassPtr<UObject>(GetClass()));

	auto OutSoftClassPtrValue = TSoftClassPtr<UObject>(FunctionActor->GetClass());

	FunctionActor->OutSoftClassPtrValueFunction(OutSoftClassPtrValue);

	TestCoreSubsystem->TestEqual("CSharpOutSetSoftClassPtrFunction", OutSoftClassPtrValue,
	                             TSoftClassPtr<UObject>(GetClass()));
}
