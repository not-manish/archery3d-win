using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class UI_Rank_Global : MonoBehaviour
{
	public UIScrollView uiScrollView;

	public UIWrapContentEx uiWrapContentEx;

	public UI_Rank_MyItem_Panel uiRankMyItemPanel;

	public UI_Rank_Global_Item uiRankGlobalItem;

	public List<UIRankGlobalItemParam> uiRankGlobalItemsParam;

	private const int TopCountConst = 50;

	private const int MyBeforeConst = 25;

	private const int MyAfterConst = 25;

	private const int AllItermsNum = 101;

	private int MyCount;

	private bool hasSetScale;

	private UI_Rank uiRank;

	private HashSet<string> containUids;

	private List<CCRankItem> Top50Items;

	private List<CCRankItem> ItemsAdjacent;

	private int AdjacentStartRank;

	private bool buttonEnable;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Show(UI_Rank _uiRank)
	{
	}

	private void AskRank()
	{
	}

	private void UpdateState()
	{
	}

	public void IsShowMyItem(PlayerData playerdate, int _myCount)
	{
	}

	private void DealServeItems()
	{
	}

	private int GenerateRank(long Top50MinTrophy, long GlobalMinTrophy, long playerTrophy, long playerCount)
	{
		return 0;
	}

	private void OnInitializeItem(GameObject go, int wrapIndex, int realIndex)
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

	private void ButtonOnClicked(GameObject button)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void GlobalRankResponse()
	{
	}

	public void ReconnectLoginSuccess()
	{
	}

	public void SetUpdateName()
	{
	}

	public void ScrollBackAction()
	{
	}
}
