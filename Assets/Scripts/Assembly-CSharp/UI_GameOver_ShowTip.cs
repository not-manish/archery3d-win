using UnityEngine;

public class UI_GameOver_ShowTip : MonoBehaviour
{
	public UI_GameMode_Unlock uiGameModeUnlock;

	public UI_GameOver_Failure_EquipTips uiGameOverFailureEquipTips;

	public GameOverShowTip gameOverShowTip;

	private bool hasSetScale;

	public void Show(object param)
	{
	}

	public void Hide(object param)
	{
	}

	public bool isShowing()
	{
		return false;
	}
}
