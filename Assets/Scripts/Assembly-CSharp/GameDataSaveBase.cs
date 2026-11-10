using UnityEngine;

public class GameDataSaveBase
{
	protected static int ReadInt(string name, int value)
	{
		return 0;
	}

	protected static void SaveInt(string name, int value)
	{
	}

	protected static float ReadFloat(string name, float value)
	{
		return 0f;
	}

	protected static void SaveFloat(string name, float value)
	{
	}

	protected static string ReadString(string name, string value)
	{
		return null;
	}

	protected static void SaveString(string name, string value)
	{
	}

	protected static bool ReadBool(string name, bool value)
	{
		return false;
	}

	protected static void SaveBool(string name, bool value)
	{
	}

	protected static Vector3 ReadVector3(string name, Vector3 value)
	{
		return default;
	}

	protected static void SaveVector3(string name, Vector3 value)
	{
	}

	public static void RefreshData()
	{
	}
}
