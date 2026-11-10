using UnityEngine;

public class UI_ChestOpen_MoveCardAnim : MonoBehaviour
{
	public GameObject oCoinGemInfo;

	public GameObject oCoinGemBackGroung;

	public GameObject oEquipInfo;

	public GameObject oEquipBackGroung;

	public UISprite sEquipBack;

	public UISprite sEquipKindBack;

	public ChestRewardType openType;

	public void UpdateInfo(CardQuality CardQuality)
	{
	}

	public void SetAnim(ChestRewardType _openType)
	{
	}

	public void SetAnimEnd(ChestRewardType _openType)
	{
	}

	public bool isAnimEnd(ChestRewardType _openType)
	{
		return false;
	}
}
