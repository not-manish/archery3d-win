using System.Collections.Generic;
using UnityEngine;

public class UI_RankLeaguePopup_Segment : MonoBehaviour
{
	public UIButton btCollected;

	public UIButton btContinue;

	public GameObject oWordsPromoted;

	public GameObject oWordsStay;

	public GameObject oWordsDemoted;

	public UIWidget sForTopPlayer;

	public List<Transform> tDivisionList;

	public List<UI_Rank_League_Segment_Item> uiList;

	public UIPanel uiScrollPanel;

	private UI_RankLeaguePopup uiRankPopup;

	private bool hasUpdate;

	private bool hasSetScale;

	private bool buttonEnable;

	private float Ystart;

	private float StartForSPlayer;

	private float ItemHeight;

	private float ArrowHeight;

	private void Start()
	{
	}

	public void Show(UI_RankLeaguePopup _uiRankPopup, object param)
	{
	}

	private void UpdateState()
	{
	}

	private void CreateItems()
	{
	}

	public void GetMoveToTarget(int x)
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

	private void SetPositon(bool IsSplayerTop)
	{
	}
}
