using UnityEngine;

public class UI_Equip_Handle_Model : MonoBehaviour
{
	private UI_Equip_Handle uiEquipHandle;

	public UITexture modelTexture;

	private UIModelKind uiModelKind;

	private UIModelParam _uiModelParam;

	public UI_Downloading_Tips uiDownloadingTips;

	private bool hasInit;

	private bool buttonEnable;

	private void Awake()
	{
	}

	private void Init()
	{
	}

	public void Show(UI_Equip_Handle _uiEquipHandle, UIModelParam uiModelParam)
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
