using UnityEngine;

public class UI_Equip_Compare_Model : MonoBehaviour
{
	private UI_Equip_Compare uiCompare;

	public UITexture modelTexture;

	public UIModelKind uiModelKind;

	private UIModelParam _uiModelParam;

	public UI_Downloading_Tips uiDownloadingTips;

	private bool buttonEnable;

	public void Show(UI_Equip_Compare _uiCompare, UIModelParam uiModelParam)
	{
	}

	public bool Check_IsNeedDownload_equip()
	{
		return false;
	}

	public void ShowUnlock(SingleFileState singleFileState)
	{
	}

	public void ShowModel()
	{
	}

	public void Hide()
	{
	}

	public void UpdateState()
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}
}
