using System;
using System.Collections.Generic;
using AssetUpdate;
using com.simple.proto;

public class ResourcesCtr
{
	private static ResourcesCtr _instance;

	private static CCFileItem ccFileItem;

	private static RsInfoCfgFileInfo rsInfoCfgFileInfo;

	private static Dictionary<DlPriority, List<ConfigFileInfo>> allDownloadListProDic;

	private static Dictionary<DlPriority, List<ConfigFileInfo>> needDownloadListProDic;

	private static Action<bool> CheckFinishNeedDlRs;

	private static bool hasDownloadCalled;

	private static Dictionary<string, SingleFileState> tempSingleFileState;

	public static ResourcesCtr Instance => null;

	public static void CheckClientRsIndex(CCLoginResponse ccLoginResponse, Action<bool> _checkRsIndexAction)
	{
	}

	private static void CheckLocalRsInfoCfgFile()
	{
	}

	private static void OnUpdateRsInfoCfgFileOver()
	{
	}

	private static bool NeedDLFile(string localPath, string md5, string remoteUrl)
	{
		return false;
	}

	private static List<ConfigFileInfo> DeleteLocalUnusedResources(List<ConfigFileInfo> allConfigFile, List<string> ignoreFileNames)
	{
		return null;
	}

	public static void DownloadAssetPriority(DlPriority priority, Action _DownloadFinishedAction = null)
	{
	}

	public static void DownloadAssetSingle(string filename, FileType fileType, Action _DownloadFinishedAction = null)
	{
	}

	public static void GetDownloadingProgress(ref float sumProgress, ref long sumSize, DlPriority priority)
	{
	}

	public static void GetDownloadingProgress(ref float sumProgress, ref long sumSize, string fileName, FileType fileType)
	{
	}

	public static SingleFileState GetSingleFileState(string filename, FileType fileType)
	{
		return SingleFileState.None;
	}

	private static SingleFileState GetSingleFileState2(string filename)
	{
		return SingleFileState.None;
	}
}
