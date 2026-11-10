using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class LoadOtherAssets
{
	private static Dictionary<string, WWW> otherAssetsWWWs;

	private static Dictionary<string, AssetBundleRequest> otherAssetsRequest;

	public static void DownAssets(string bundleName)
	{
	}

	public static bool IsAssetsWWWDone(string bundleName)
	{
		return false;
	}

	public static bool IsAllOtherAssetsWWWDone()
	{
		return false;
	}

	public static void LoadAsset(string bundleName, string objectName, Type type)
	{
	}

	public static bool IsAssetLoaded(string bundleName, ref UnityEngine.Object obj)
	{
		return false;
	}

	public static void ClearCache(string bundleName)
	{
	}

	public static void ClearCache()
	{
	}
}
