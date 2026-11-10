using UnityEngine;

public class UI_Equip_Upgrade_Model : MonoBehaviour
{
	private UI_Equip_Upgrade uiUpgrade;

	public UITexture modelTexture;

	private UIModelKind uiModelKind;

	private UIModelParam _uiModelParam;

	public UI_Downloading_Tips uiDownloadingTips;

	private bool buttonEnable;

	public void Show(UI_Equip_Upgrade _uiUpgrade, UIModelParam uiModelParam)
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
