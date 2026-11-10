using System.Collections.Generic;
using UnityEngine;

public class UI_ChestOpen_Equip : MonoBehaviour
{
	public UI_ChestOpen_Equip_Level uiLevel;

	public UI_ChestOpen_Equip_Common uiCommon;

	public GameObject oEquip;

	public GameObject oUnlock;

	public UILabel lUnlock1;

	public UILabel lUnlock2;

	public GameObject oBonus;

	public UILabel lAddCardNum;

	public Transform tCard;

	public TweenPosition cardPositionAnim;

	public UI_AnimationCtrl InfoAnimationCtrl;

	private List<UITweener> UITweenList;

	public List<GameObject> HasUITween;

	public UI_ChestOpen_MoveCard uiChestOpenMoveCard;

	private Vector3 Positon;

	private bool hasSetScale;

	private ChestOpenEquipParam uiparam;

	public bool isStartAnim;

	public CardQuality cardQuality;

	private bool buttonEnable;

	private void Awake()
	{
	}

	public void Show(object param, ChestOpenShowType _openShowType = ChestOpenShowType.OpenChest)
	{
	}

	public void UpdateUnlock(ChestRewardType _chestRewardType, int EquipKindId, int Number, ChestOpenShowType _openShowType = ChestOpenShowType.OpenChest)
	{
	}

	private static string GetCardExtraAdd()
	{
		return null;
	}

	public void StartAnim()
	{
	}

	public void ShowEffect()
	{
	}

	public bool isAnimEnd()
	{
		return false;
	}

	public void SetAnimEnd()
	{
	}

	public void GetAllUITween()
	{
	}

	public void SetAllAnimEnd()
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
}
