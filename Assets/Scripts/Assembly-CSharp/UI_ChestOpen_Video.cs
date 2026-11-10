using System.Collections.Generic;
using UnityEngine;

public class UI_ChestOpen_Video : MonoBehaviour
{
	public GameObject oEquip;

	public UIButton btnMysteryReward;

	public UILabel lName;

	public UILabel lAddCardNum;

	public UISprite lEquipSprite;

	public UILabel lEquipSmallName;

	public UILabel lEquipKindName;

	public UISprite sEquipKindBack;

	public UISprite sEquipBack;

	public UISprite sEquipName;

	public UISprite slight;

	public Transform tCoin;

	public UI_ChestOpen_Equip_Level uiChestOpenEquipLevel;

	public TweenPosition cardPositionAnim;

	public UI_AnimationCtrl InfoAnimationCtrl;

	private List<UITweener> UITweenList;

	public List<GameObject> HasUITween;

	public bool isPlayVideo;

	public bool HasPlayVideo;

	private bool HasPlayAddAnim;

	public UILabel lMystery;

	private FlexibleRealTimeRegulator m_TimeRegulator;

	public UI_AnimationCtrl CardAnim;

	public GameObject GetRewardParticl;

	public CardQuality cardQuality;

	private Vector3 Positon;

	private bool hasSetScale;

	private ChestOpenRewardItemData chestReward;

	public bool isStartAnim;

	private bool buttonEnable;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Show(object param, ChestOpenShowType _openShowType = ChestOpenShowType.OpenChest)
	{
	}

	private static string GetCardExtraAdd()
	{
		return null;
	}

	public void StartAnim()
	{
	}

	public bool isAnimEnd()
	{
		return false;
	}

	public void SetAnimEnd()
	{
	}

	public void AnimEnd()
	{
	}

	public bool NeedSkip()
	{
		return false;
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

	public void PlayerVideoFinish(bool isFinished)
	{
	}

	public void ShowInfo(bool isGet = false)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void GetSuccess(ChestOpenRewardItemData chestOpenRewardItemData)
	{
	}

	private void RecoverAllAni()
	{
	}

	private void PlayerAllAniFinish()
	{
	}

	private void Update()
	{
	}
}
