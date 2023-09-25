// Copyright Epic Games, Inc. All Rights Reserved.

#include "UnrealCSharpTestGameMode.h"
#include "UnrealCSharpTestCharacter.h"
#include "UObject/ConstructorHelpers.h"

AUnrealCSharpTestGameMode::AUnrealCSharpTestGameMode()
	: Super()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnClassFinder(TEXT("/Game/FirstPerson/Blueprints/BP_FirstPersonCharacter"));
	DefaultPawnClass = PlayerPawnClassFinder.Class;

}
