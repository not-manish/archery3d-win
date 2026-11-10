using UnityEngine;

public class UI_TurnTips : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimation;

	public GameObject objBg;

	public GameObject objRivalsTurn;

	public GameObject objYourTurn;

	public GameObject objResultTurn;

	public GameObject objResultDraw;

	public GameObject objResultLose;

	public GameObject objResultWin;

	public PlayerHeadShow SelfPlayerHead;

	public PlayerHeadShow OtherPlayerHead;

	public UISprite sMyResultBg;

	public UISprite sOtherResultBg;

	public UILabel lScoreSelf;

	public UILabel lScoreSelfbg;

	public UILabel lScoreother;

	public UILabel lScoreotherbg;

	public UILabel lSetName;

	public UILabel lSetNamebg;

	private UITurnParam uiParam;

	public void Show(object param)
	{
	}

	public void UpdateDate(object param)
	{
	}

	private void UpdateState()
	{
	}

	public void ShowScore()
	{
	}

	public void Hide()
	{
	}

	private void AnimationFinished()
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
