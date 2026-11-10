using System.Collections.Generic;
using UnityEngine;

public class AssetbundlesManage
{
	private static Dictionary<string, WWW> wwwCEs;

	private static Dictionary<string, CharacterElement> characterElements;

	private static Dictionary<string, bool> isExitResourceFolder;

	private static Dictionary<string, WWW> gameObjectWWWs;

	private static Dictionary<string, Object> gameObjectObject;

	public static bool CharacterElementsExist(string bundleName)
	{
		return false;
	}

	public static void CharacterElementsAdd(string bundleName, CharacterElement ce)
	{
	}

	public static bool WwwCEContains(string bundleName)
	{
		return false;
	}

	public static void WwwCEAdd(string bundleName)
	{
	}

	public static bool WwwCEIsDown(string bundleName)
	{
		return false;
	}

	public static WWW GetWwwCE(string bundleName)
	{
		return null;
	}

	public static void RemoveWwwCE(string bundleName)
	{
	}

	public static bool CharacterElementGenerate(string bundleName)
	{
		return false;
	}

	public static CharacterElement CharacterElementsGet(string bundleName)
	{
		return null;
	}

	private static bool GameObjectObjectExist(string character)
	{
		return false;
	}

	private static bool WwwGOContains(string character)
	{
		return false;
	}

	private static void WwwGOAdd(string character, AssetbundlesURL urlType)
	{
	}

	private static WWW GetWwwGO(string character)
	{
		return null;
	}

	private static void GameObjectAdd(string character, WWW www)
	{
	}

	private static void RemoveWwwGO(string character)
	{
	}

	public static bool GameObjectGenerate(string currentCharacter, AssetbundlesURL urlType)
	{
		return false;
	}

	public static GameObject GetGameObject(string character)
	{
		return null;
	}
}
