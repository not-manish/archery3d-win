using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class UI_Rank_Challenge_Ranking : MonoBehaviour
{
	public UIButton btScore;

	public GameObject oScore;

	public GameObject oTime;

	public UI_Rank_MyItem_Panel uiRankMyItemPanel;

	public UI_ChallengeLevel_Rank_Ranking_Item uiChallengeRankRankingItem;

	public UI_ChallengeLevel_Rank_ScoreBoard uiChallengeLevelRankScoreBoard;

	public List<UI_ChallengeLevel_Rank_Ranking_Item> items;

	public UIScrollView uiScrollView;

	public UIWrapContentEx uiWrapContentEx;

	public List<UIChallengeRankingParam> uiRankChallengeItemsParam;

	private const int TopCountConst = 100;

	private const int MyBeforeConst = 25;

	private const int MyAfterConst = 25;

	private const int AllItermsNum = 101;

	private int MyCount;

	private Dictionary<ChallengeGroup, int> ShowPrizeIndex;

	private bool hasSetScale;

	private UI_Rank_Challenge uiRankChallenge;

	private int challengeId;

	private ChallengeGroup challengeGroup;

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

	public void Show(UI_Rank_Challenge _uiRankChallenge, ChallengeGroup myGroup)
	{
	}

	private void AskRank(int _challengeId, ChallengeGroup _challengeGroup)
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

	private void OnInitializeItem(GameObject go, int wrapIndex, int realIndex)
	{
	}

	private void ChangeShowScoreTime(bool _isShowScore)
	{
	}

	private void DealServeItems()
	{
	}

	private int GenerateRank(float RankNormalize, long playerCount)
	{
		return 0;
	}

	private float GetScoreRankNormalize(long MyScore, long MaxScore, long MinScore)
	{
		return 0f;
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

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void ClickedItem(bool isMe, UserHeadData userHeadData, string name, long oppValue)
	{
	}

	public void GroupButtonClicked(ChallengeGroup group)
	{
	}

	public void SetUpdateName()
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void ChallengeRankResponse()
	{
	}

	public void ReconnectLoginSuccess()
	{
	}

	private void SetMyRank(int topPrecent)
	{
	}
}
