using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class UI_RankChallengePopup_WeekResult : MonoBehaviour
{
	public UIButton btCollectReward;

	public UIButton btContinue;

	public UIButton btScore;

	public GameObject oScore;

	public GameObject oTime;

	public UILabel lChallegeGroup1;

	public UILabel lChallegeGroup2;

	public UISprite sChallengeGroup;

	public GameObject oDownFinishTip;

	public UILabel lRankString;

	public UILabel lRankStringBg;

	public GameObject oDownUnFinishTip;

	public UI_WaitLoading uiWaitLoading;

	public UI_Rank_MyItem_Panel uiRankMyItemPanel;

	public UI_ChallengeLevel_Rank_Ranking_Item uiChallengeRankRankingItem;

	public List<UI_ChallengeLevel_Rank_Ranking_Item> items;

	public UIScrollView uiScrollView;

	public UIWrapContentEx uiWrapContentEx;

	public List<UIChallengeRankingParam> uiRankChallengeItemsParam;

	private const int TopCountConst = 100;

	private const int MyBeforeConst = 25;

	private const int MyAfterConst = 25;

	private const int AllItermsNum = 101;

	private int MyCount;

	private bool hasSetScale;

	private UI_RankChallengePopup uiPopup;

	private bool isShowScore;

	private HashSet<string> containUids;

	private List<CCRankItem> Top100Items;

	private List<CCRankItem> Last25Items;

	private List<CCRankItem> ItemsAdjacent;

	private List<CCRankItem> TopUnfinshedItems;

	private int AdjacentStartRank;

	private int MyRankIndex;

	private int TopPercent;

	private int Last25StartRank;

	private SelfChallengeState MyState;

	private bool buttonEnable;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Show(UI_RankChallengePopup _uiPopup)
	{
	}

	private void UpdateState()
	{
	}

	private void UpdateState(bool _isShowScore)
	{
	}

	public void IsShowMyItem(PlayerData playerdate, int _myCount)
	{
	}

	public void ScrollBackAction()
	{
	}

	public void ShowDownTips(bool isFinish, int topPrecent)
	{
	}

	public string getRank(int RankNum)
	{
		return null;
	}

	private void OnInitializeItem(GameObject go, int wrapIndex, int realIndex)
	{
	}

	private void ChangeShowScoreTime(bool _isShowScore)
	{
	}

	private void DealServeItems()
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

	public bool IsShowing()
	{
		return false;
	}

	public void ChallengeRankResponse()
	{
	}
}
