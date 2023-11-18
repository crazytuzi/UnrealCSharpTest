#pragma once

#include "Macro/BindingMacro.h"

struct FRawTestStruct
{
	int32 Value;
};

static bool operator==(const FRawTestStruct& InA, const FRawTestStruct& InB)
{
	return InA.Value == InB.Value;
}

static bool operator!=(const FRawTestStruct& InA, const FRawTestStruct& InB)
{
	return InA.Value != InB.Value;
}

BINDING_CLASS(FRawTestStruct)
