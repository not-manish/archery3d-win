using System.Collections.Generic;
using AssetUpdate;

public class ClientRsInfoCfgData
{
	public int m_Count;

	public int m_Type;

	public string m_Name;

	public string m_Url;

	public string m_Md5;

	public long m_Size;

	public int m_DlPriority;

	private static int NUM;

	public static ClientRsInfoCfgData[] datas;

	private static Dictionary<FileType, List<ConfigFileInfo>> AllFileInfos;

	public static void Clear()
	{
	}

	public static void LoadData(string fileName)
	{
	}

	public static void ProcessData(ClientRsInfoCfgData data)
	{
	}

	public static ConfigFileInfo GetConfigFileInfo(ClientRsInfoCfgData data)
	{
		return null;
	}

	public static AtlasFileInfo GetAtlasFileInfo(ClientRsInfoCfgData data)
	{
		return null;
	}

	public static TextureFileInfo GetTextureFileInfo(ClientRsInfoCfgData data)
	{
		return null;
	}

	public static ModelFileInfo GetModelFileInfo(ClientRsInfoCfgData data)
	{
		return null;
	}

	public static SceneFileInfo GetSceneFileInfo(ClientRsInfoCfgData data)
	{
		return null;
	}

	public static AudioFileInfo GetAudioFileInfo(ClientRsInfoCfgData data)
	{
		return null;
	}

	public static PrefabFileInfo GetPrefabFileInfo(ClientRsInfoCfgData data)
	{
		return null;
	}

	public static MaterialFileInfo GetMaterialFileInfo(ClientRsInfoCfgData data)
	{
		return null;
	}

	public static List<ConfigFileInfo> GetConfigDlPriority(int dlPriority)
	{
		return null;
	}

	public static void GetConfigDlPriority(ref Dictionary<DlPriority, List<ConfigFileInfo>> downloadListProDic)
	{
	}

	public static List<ConfigFileInfo> GetAllConfigDl()
	{
		return null;
	}
}
