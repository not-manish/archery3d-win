using UnityEngine;

public class UI_Fighting_Playerinfo : MonoBehaviour
{
	public PlayerHeadShow PlayerHeadSelf;

	public UILabel lNamePlayerSelf;

	public UI_AnimationCtrl uiAnimationCtrlSelf;

	public UISprite oMyTrophy;

	public UILabel lTrophyMy;

	public UI_TimeProgress MyTimeProgress;

	private UI_TimeProgress MyTimeProgressValue;

	public UISprite PlayerHeadSelfBg;

	public PlayerHeadShow PlayerHeadOther;

	public UILabel lNamePlayerOther;

	public UI_AnimationCtrl uiAnimationCtrlOther;

	public UISprite oOtherTrophy;

	public UILabel lTrophyOpp;

	public UI_TimeProgress OtherTimeProgress;

	private UI_TimeProgress OtherTimeProgressValue;

	public UISprite PlayerHeadOtherBg;

	public UI_FightingCommon UI_FightingCommon;

	public TurnType turntype;

	private bool hasSetScale;

	public void Show(object param)
	{
	}

	public void UpdateState(object param)
	{
	}

	public void UpdateTurn(TurnType _turntype)
	{
	}

	private void Update()
	{
	}

	public void ResetShootingTime(float duration, float timeLeft, OnlineNormalState PlayerState)
	{
	}

	public void CloseShootingTime(bool isClearProgress, OnlineNormalState PlayerState)
	{
	}

	public void CloseShootingTime(bool isClearProgress, float duration, float timeLeft, OnlineNormalState PlayerState)
	{
	}

	public void Hide(object param)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
