using UnityEngine;

public class UI_GameMode_Unlock : MonoBehaviour
{
	private UI_GameOver_ShowTip uiGameOverShowTip;

	public UILabel lTips;

	public UIButton btnClose;

	public UIButton btnplay;

	public GameObject oRushIcon;

	public GameObject oBingoIcon;

	public GameObject oArenaIcon;

	public GameObject oChallengeIcon;

	public UI_AnimationCtrl uiAnimationCtrl;

	private UnLockGameMode unLockGameMode;

	private bool hasSetScale;

	private GameType gameType;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
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

	public void CheskIsUnlockGameMode(bool isshow)
	{
	}

	public bool isShowing()
	{
		return false;
	}
}
