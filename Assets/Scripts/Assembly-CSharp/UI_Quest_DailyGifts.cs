using System.Collections.Generic;
using UnityEngine;
using com.simple.proto;

public class UI_Quest_DailyGifts : MonoBehaviour
{
	public List<UI_QuestDetail_GiftItem> DailyQuestLists;

	public QuestData QuestData;

	public UILabel lTitle;

	public UILabel lTitlebg;

	public UILabel lNextTime;

	public UILabel lTimeTips;

	public List<UISprite> sArrows;

	public long QuestStartTime;

	public long LastDailyGetTime;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public int GetQuestItemIndex;

	public void Show(object param)
	{
	}

	public void UpdateState()
	{
	}

	public void Hide(object param)
	{
	}

	private void Update()
	{
	}

	public void GetRespones(CCChestReward ccchestReward)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public bool isQuestRefresh()
	{
		return false;
	}

	private void UpdateTimeLeft()
	{
	}
}
