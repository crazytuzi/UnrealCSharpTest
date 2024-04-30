#include "UnitTest/Core/FRawTestStruct.h"
#include "Binding/Class/TBindingClassBuilder.inl"
#include "Binding/Enum/TBindingEnumBuilder.inl"
#include "Macro/BindingMacro.h"
#include "Macro/NamespaceMacro.h"
#include "UnitTest/Core/ERawTestEnum.h"
#include "UnitTest/Core/ERawTestEnumClass.h"

struct FRegisterRawTestEnum
{
	FRegisterRawTestEnum()
	{
		TBindingEnumBuilder<ERawTestEnum>()
			.Enumerator("RawTestEnumZero", ERawTestEnum::RawTestEnumZero)
			.Enumerator("RawTestEnumOne", ERawTestEnum::RawTestEnumOne)
			.Enumerator("RawTestEnumTwo", ERawTestEnum::RawTestEnumTwo);
	}
};

static FRegisterRawTestEnum RegisterRawTestEnum;

struct FRegisterRawTestEnumClass
{
	FRegisterRawTestEnumClass()
	{
		TBindingEnumBuilder<ERawTestEnumClass>()
			.Enumerator("RawTestEnumClassZero", ERawTestEnumClass::RawTestEnumClassZero)
			.Enumerator("RawTestEnumClassOne", ERawTestEnumClass::RawTestEnumClassOne)
			.Enumerator("RawTestEnumClassTwo", ERawTestEnumClass::RawTestEnumClassTwo);
	}
};

static FRegisterRawTestEnumClass RegisterRawTestEnumClass;

struct FRegisterRawTestStruct
{
	FRegisterRawTestStruct()
	{
		TBindingClassBuilder<FRawTestStruct>(NAMESPACE_BINDING)
			.EqualTo()
			.NotEqualTo()
			.Property("Value", BINDING_PROPERTY(&FRawTestStruct::Value));
	}
};

static FRegisterRawTestStruct RegisterRawTestStruct;
