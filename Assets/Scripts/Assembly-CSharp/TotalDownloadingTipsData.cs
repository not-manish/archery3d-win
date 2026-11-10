using System;
using System.Collections.Generic;

public class TotalDownloadingTipsData
{
	public List<DownloadingTipsData> DownloadingTipsDatas;

	public Action<SingleFileState> action;

	public TotalDownloadingTipsData(List<DownloadingTipsData> _downloadingTipsDatas, Action<SingleFileState> _action = null)
	{
	}
}
