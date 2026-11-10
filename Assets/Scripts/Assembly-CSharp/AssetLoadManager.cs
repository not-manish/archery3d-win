using System.Collections.Generic;
using UnityEngine;

public class AssetLoadManager
{
	private static Dictionary<string, Object> localAssetRef;

	private static Dictionary<string, AssetBundle> assetbundleNameRef;

	private static Dictionary<string, Dictionary<string, Object>> objectNameRef;

	private static Dictionary<string, UIAtlas> uiAtlasRef;

	private static Dictionary<string, Texture2D> uiTexRef;

	private static Dictionary<string, Material> uiMaterialRef;

	public static void ClearObjectRef()
	{
	}

	public static Object GetLocalAssetObject(string pathFullName)
	{
		return null;
	}

	public static GameObject GetLocalAssetGameObject(string pathFullName)
	{
		return null;
	}

	public static void UnLoadLocalAsset(string path, string name, bool isForce = false)
	{
	}

	public static Object GetDlAssetObject(string abFullName, string abName, string objectName)
	{
		return null;
	}

	public static bool LoadSceneAssetbundle(string abFullName, string Scene_Name, string abName)
	{
		return false;
	}

	public static bool isSceneExisting(string abName)
	{
		return false;
	}

	public static void ResetShader(Object obj)
	{
	}

	public static void ResetShader(AssetBundle obj)
	{
	}

	public static GameObject GetGameObjectCommon(string objName, string localPathFullName, string abFullName, string abName)
	{
		return null;
	}

	public static UIAtlas GetUiAtlas(string objName, string localPathFullName, string abFullName, string abName)
	{
		return null;
	}

	public static Texture2D GetTexture(string objName, string localPathFullName, string abFullName, string abName)
	{
		return null;
	}

	public static Material GetMaterial(string objName, string localPathFullName, string abFullName, string abName)
	{
		return null;
	}
}
