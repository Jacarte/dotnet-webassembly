﻿namespace WebAssembly
{
	enum HelperMethod
	{
		RangeCheck8,
		RangeCheck16,
		RangeCheck32,
		RangeCheck64,
		SelectFloat32,
		SelectFloat64,
		SelectInt32,
		SelectInt64,
		GetFunctionPointer,
		Float32ReinterpretInt32,
		Float64ReinterpretInt64,
		Int32ReinterpretFloat32,
		Int64ReinterpretFloat64,
		StoreInt8FromInt32,
		StoreInt16FromInt32,
		StoreInt32FromInt32,
		StoreInt8FromInt64,
		StoreInt16FromInt64,
		StoreInt32FromInt64,
		StoreInt64FromInt64,
		StoreFloat32,
		StoreFloat64,
	}
}