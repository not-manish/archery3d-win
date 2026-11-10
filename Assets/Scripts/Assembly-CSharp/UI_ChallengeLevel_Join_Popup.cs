using UnityEngine;

public class UI_ChallengeLevel_Join_Popup : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btSelect;

	public UIButton btExit;

	public UISprite sGroupLogo;

	public UILabel lGroupName1;

	public UILabel lGroupName2;

	public UILabel lTimeLeft;

	private int EntryFee;

	public UILabel lEntryFee;

	private bool hasSetScale;

	private ChallengeGroup group;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(ChallengeGroup _group)
	{
	}

	private void UpdateState()
	{
	}

	private string GetTimeLeft()
	{
		return null;
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

	public bool IsShowing()
	{
		return false;
	}

	public void GoToShopBuyGold()
	{
	}
}
