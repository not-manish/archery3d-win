using System;
using System.Collections.Generic;
using UnityEngine;

public class UI_Downloading_Tips : MonoBehaviour
{
	public UILabel lPercent;

	public UI_Progress_Scroll uiProgress;

	public GameObject oDownLoadingTips;

	public TotalDownloadingTipsData downloadingTipsData;

	private List<DownloadingTipsData> DownloadingTipsDatas;

	public FlexibleRealTimeRegulator m_tDownloadTime;

	private NewAssestDownloadState newAssestDownloadState;

	private Action<SingleFileState> action;

	private float sumSize;

	public void Show(object Param)
	{
	}

	public void updateState()
	{
	}

	private void Update()
	{
	}

	public void Hide()
	{
	}

	public void SetAction(SingleFileState singleFileState)
	{
	}

	public void StartDownload(DownloadingTipsData downloadingData)
	{
	}

	public void SetDownloadState(NewAssestDownloadState NewState)
	{
	}

	public void ShowDownloadingTips()
	{
	}

	public void ShowDownloadingTips(float totalDownloadSize)
	{
	}

	private float totalDownloadSize()
	{
		return 0f;
	}

	private float GetDownloadMaxSize(string _downloadName, FileType fileType)
	{
		return 0f;
	}
}
