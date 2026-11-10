using UnityEngine;

public class UI_Equip_Display_Model : MonoBehaviour
{
	private UI_Equip_Display uiDisplay;

	public UITexture modelTexture;

	private UIModelKind uiModelKind;

	private UIModelParam _uiModelParam;

	public Transform tProgress;

	public UI_Downloading_Tips uiDownloadingTips;

	private bool buttonEnable;

	public void Show(UI_Equip_Display _uiDisplay, UIModelParam uiModelParam)
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

	public void UpdateState()
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	public void SetProgressPosition(bool isMoveLeft)
	{
	}
}
