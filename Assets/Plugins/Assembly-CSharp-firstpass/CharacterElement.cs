using System;
using UnityEngine;

[Serializable]
public class CharacterElement
{
	public string name;

	public string bundleName;

	public AssetBundleRequest gameObjectRequest;

	public AssetBundleRequest materialRequest;

	public AssetBundleRequest boneNameRequest;

	public UnityEngine.Object gameObjectAsset;

	public UnityEngine.Object materialAsset;

	public UnityEngine.Object boneNameAsset;

	public bool IsLoaded => false;

	public CharacterElement(string name)
	{
	}

	public SkinnedMeshRenderer GetSkinnedMeshRenderer()
	{
		return null;
	}

	public string[] GetBoneNames()
	{
		return null;
	}
}
