#include "UnitTest/Binding/FTestBindingProperty.h"
#include "Binding/Class/TBindingClassBuilder.inl"
#include "Macro/NamespaceMacro.h"

BINDING_CLASS(FTestBindingProperty)

struct FRegisterTestBindingProperty
{
	FRegisterTestBindingProperty()
	{
		TBindingClassBuilder<FTestBindingProperty>(NAMESPACE_BINDING)
			.Property("BoolValue", BINDING_PROPERTY(&FTestBindingProperty::BoolValue))
			.Property("Int8Value", BINDING_PROPERTY(&FTestBindingProperty::Int8Value))
			.Property("Int16Value", BINDING_PROPERTY(&FTestBindingProperty::Int16Value))
			.Property("Int32Value", BINDING_PROPERTY(&FTestBindingProperty::Int32Value))
			.Property("Int64Value", BINDING_PROPERTY(&FTestBindingProperty::Int64Value))
			.Property("UInt8Value", BINDING_PROPERTY(&FTestBindingProperty::UInt8Value))
			.Property("UInt16Value", BINDING_PROPERTY(&FTestBindingProperty::UInt16Value))
			.Property("UInt32Value", BINDING_PROPERTY(&FTestBindingProperty::UInt32Value))
			.Property("UInt64Value", BINDING_PROPERTY(&FTestBindingProperty::UInt64Value))
			.Property("FloatValue", BINDING_PROPERTY(&FTestBindingProperty::FloatValue))
			.Property("DoubleValue", BINDING_PROPERTY(&FTestBindingProperty::DoubleValue))
			.Property("NameValue", BINDING_PROPERTY(&FTestBindingProperty::NameValue))
			.Property("TextValue", BINDING_PROPERTY(&FTestBindingProperty::TextValue))
			.Property("StringValue", BINDING_PROPERTY(&FTestBindingProperty::StringValue))
			.Property("EnumValue", BINDING_PROPERTY(&FTestBindingProperty::EnumValue))
			.Property("EnumAsByteValue", BINDING_PROPERTY(&FTestBindingProperty::EnumAsByteValue))
			.Property("EnumClassValue", BINDING_PROPERTY(&FTestBindingProperty::EnumClassValue))
			.Property("RawEnumValue", BINDING_PROPERTY(&FTestBindingProperty::RawEnumValue))
			.Property("RawEnumClassValue", BINDING_PROPERTY(&FTestBindingProperty::RawEnumClassValue))
			.Property("StructValue", BINDING_PROPERTY(&FTestBindingProperty::StructValue))
			.Property("RawStructValue", BINDING_PROPERTY(&FTestBindingProperty::RawStructValue))
			.Property("ObjectValue", BINDING_PROPERTY(&FTestBindingProperty::ObjectValue))
			.Property("ClassValue", BINDING_PROPERTY(&FTestBindingProperty::ClassValue))
			.Property("InterfaceValue", BINDING_PROPERTY(&FTestBindingProperty::InterfaceValue))
			.Property("SubclassOfValue", BINDING_PROPERTY(&FTestBindingProperty::SubclassOfValue))
			.Property("WeakObjectPtrValue", BINDING_PROPERTY(&FTestBindingProperty::WeakObjectPtrValue))
			.Property("LazyObjectPtrValue", BINDING_PROPERTY(&FTestBindingProperty::LazyObjectPtrValue))
			.Property("SoftObjectPtrValue", BINDING_PROPERTY(&FTestBindingProperty::SoftObjectPtrValue))
			.Property("SoftClassPtrValue", BINDING_PROPERTY(&FTestBindingProperty::SoftClassPtrValue))
			.Property("ArrayValue", BINDING_PROPERTY(&FTestBindingProperty::ArrayValue))
			.Property("SetValue", BINDING_PROPERTY(&FTestBindingProperty::SetValue))
			.Property("MapValue", BINDING_PROPERTY(&FTestBindingProperty::MapValue))
			.Register();
	}
};

static FRegisterTestBindingProperty RegisterTestBindingProperty;

FTestBindingProperty::FTestBindingProperty():
	BoolValue(true),
	Int8Value(12),
	Int16Value(12),
	Int32Value(12),
	Int64Value(12),
	UInt8Value(12),
	UInt16Value(12),
	UInt32Value(12),
	UInt64Value(12),
	FloatValue(12.3f),
	DoubleValue(12.3),
	NameValue(TEXT("Name12")),
	TextValue(FText::FromString(TEXT("Text12"))),
	StringValue(TEXT("String12")),
	EnumValue(ETestEnum::TestEnumOne),
	EnumAsByteValue(ETestEnum::TestEnumOne),
	EnumClassValue(ETestEnumClass::TestEnumClassOne),
	RawEnumValue(ERawTestEnum::RawTestEnumOne),
	RawEnumClassValue(ERawTestEnumClass::RawTestEnumClassOne),
	StructValue({1}),
	RawStructValue({1}),
	ObjectValue(GWorld->GetWorld()),
	ClassValue(GWorld->GetWorld()->GetClass()),
	SubclassOfValue(GWorld->GetWorld()->GetClass()),
	WeakObjectPtrValue(GWorld->GetWorld()),
	LazyObjectPtrValue(GWorld->GetWorld()),
	SoftObjectPtrValue(GWorld->GetWorld()),
	SoftClassPtrValue(GWorld->GetWorld()->GetClass()),
	ArrayValue({1, 2}),
	SetValue({1, 2}),
	MapValue({{1, 1}, {2, 2}})
{
}
