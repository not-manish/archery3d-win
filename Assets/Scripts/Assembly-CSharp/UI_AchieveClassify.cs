using System.Collections.Generic;
using UnityEngine;

public class UI_AchieveClassify : MonoBehaviour
{
	public List<UI_PlayerInfo_AchievementItem> achievement;

	public Dictionary<AchievementType, AchievementItem> listAchievementInfo;

	public Dictionary<AchievementType, int> AllAcievementItemNewCount;

	public List<UIButton> SelectShowachieve;

	public List<UIButton> SelectShowachieveBig;

	public Transform tAchievementItemParent;

	public List<UI_AchievementItem> AchievementItemList;

	private int BigButton;

	public UIWrapContentEx uiWrapContentEx;

	public Color32 PointWhiteColor;

	public Color SelectColor;

	public Vector3 BigScale;

	public Color32 IconGrayColor;

	public Color32 PointGrayColor;

	public Color32 NameGrayColor;

	private List<AchieveItem> ShowAchieveItems;

	public AchievementType SelectAchievementType;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void UpdateAchieveInfo(bool isShow = false)
	{
	}

	public void SetSelectBtnBig(int mingindex)
	{
	}

	public void OnInitializeItem(GameObject go, int wrapIndex, int realIndex)
	{
	}

	public void RefreshAchievementItem(AchievementType achievementType)
	{
	}

	public void RefreshGetAchievementItem(AchieveItem AchievementItem = null)
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}
}
