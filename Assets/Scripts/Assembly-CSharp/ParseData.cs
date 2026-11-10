using System;
using System.Collections.Generic;

public class ParseData
{
	private static IDictionary<Type, ObjectMetadata> object_metadata;

	public static object[] ParseObjects(Type type, string[] values, int startRow, int num)
	{
		return null;
	}

	private static void AddObjectMetadata(Type type)
	{
	}

	private static object GetValue(string v, Type type)
	{
		return null;
	}

	private static object ParseIntList(string str, Type type)
	{
		return null;
	}

	private static object ParseFloatList(string str, Type type)
	{
		return null;
	}

	private static object ParseStringList(string str, Type type)
	{
		return null;
	}

	public static D MapperToModel<D, S>(D d, S s)
	{
		return default;
	}
}
