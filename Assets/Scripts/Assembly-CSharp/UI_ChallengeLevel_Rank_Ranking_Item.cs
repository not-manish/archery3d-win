using System;
using UnityEngine;

public class UI_ChallengeLevel_Rank_Ranking_Item : MonoBehaviour
{
	public GameObject oNormalRank;

	public GameObject oMiddlePos;

	public GameObject oTopPercent;

	public GameObject oUnFinsihPercent;

	public UIButton btItem;

	public UISprite sBacground;

	public PlayerHeadShow playerHeadShow;

	public UILabel lRank;

	public UILabel lRankbg;

	public UILabel lPlayerName;

	public UILabel lValue;

	public UILabel lMiddlePlayerNum;

	public UILabel lTopPercent;

	public UILabel lUnFinsihPercent;

	private Action<bool, UserHeadData, string, long> action;

	private UIChallengeRankingParam uiParam;

	private bool isMe;

	private ChallengeRankType rankType;

	private bool isOnBoard;

	private string uid;

	private long value;

	private bool isShowScore;

	private bool buttonEnable;

	public void Show(Action<bool, UserHeadData, string, long> _action, bool _isShowScore, UIChallengeRankingParam _uiParam)
	{
	}

	private void UpdateState()
	{
	}

	private void UpdateState_Rank()
	{
	}

	public void ChangeShowScoreTime(bool showScore)
	{
	}

	public static string ValueToScore(bool isValid, long value)
	{
		return null;
	}

	public static string ValueToTime(bool isValid, long value)
	{
		return null;
	}

	public void UpdatePhoto()
	{
	}

	private void Start()
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}
}
