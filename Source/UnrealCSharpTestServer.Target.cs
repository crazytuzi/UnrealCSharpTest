// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class UnrealCSharpTestServerTarget : TargetRules
{
	public UnrealCSharpTestServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		ExtraModuleNames.Add("UnrealCSharpTest");
	}
}
