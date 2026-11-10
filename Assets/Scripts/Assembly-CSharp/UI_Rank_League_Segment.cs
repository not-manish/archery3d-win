using System.Collections.Generic;
using UnityEngine;

public class UI_Rank_League_Segment : MonoBehaviour
{
	public UIButton btBack;

	public UIWidget sForTopPlayer;

	public List<Transform> tDivisionList;

	public List<UI_Rank_League_Segment_Item> uiList;

	public UIPanel uiScrollPanel;

	private bool hasSetScale;

	private UI_Rank_League uiLeague;

	private bool buttonEnable;

	private float AllItemLength;

	private float Ystart;

	private float StartForSPlayer;

	private float ItemHeight;

	private float ArrowHeight;

	private void Start()
	{
	}

	public void Show(UI_Rank_League _uiLeague)
	{
	}

	private void Awake()
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
