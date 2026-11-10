using UnityEngine;

public class UI_OfflineLevel : MonoInstance<UI_OfflineLevel>, UIBase
{
	public UIButton btBack;

	public UI_OfflineLevel_List uiLevelList;

	public UI_OfflineLevel_HeartStore uiOfflineHeartStore;

	public UI_OfflineLevel_LevelChoose uiOfflineLevelChoose;

	public UI_OfflineLevel_IsEnterLevel uiOfflineIsEnterLevel;

	public UI_Offline_AnimPlaying uiAnimPlaying;

	public OfflineLevelCtrl offlineLevelCtrl;

	public ShowOfflineLevelPanel showOfflineLevelPanel;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void CheckSingleDataWithConnect()
	{
	}

	public void Show(object param)
	{
	}

	private void SetUIOfflinePanel()
	{
	}

	public void Hide(object param)
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	public void KeyEscapeClicked()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	private void ButtonCommonClicked(ButtonType buttonType)
	{
	}

	public void SetAnimPlaying(bool isActive)
	{
	}

	public void ShowNext()
	{
	}

	private void CreateItems()
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void UpdatePlayerInfo()
	{
	}
}
