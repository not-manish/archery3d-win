using System.Collections.Generic;
using UnityEngine;

public class UI_ChestOpen_CoinGem : MonoBehaviour
{
	public UISprite sMoneyNameBack;

	public UILabel lMoneyName;

	public UISprite sMoneyBack;

	public UISprite sMoneyFront;

	public UILabel lMoneyNameBig;

	public UILabel lMoneyAdd;

	public UISprite sMoneyHave;

	public UILabel lMoneyCurHave;

	public UISprite sEquipName;

	public UI_AnimationCtrl CoinAnimationCtrl;

	public TweenPosition cardPositionAnim;

	private List<UITweener> UITweenList;

	public List<GameObject> HasUITween;

	public Transform tCoin;

	public UI_ChestOpen_MoveCard uiChestOpenMoveCard;

	public FlexibleTimeRegulator m_tTimeRegulator;

	public FlexibleTimeRegulator m_tTimeAddRegulator;

	public UI_AnimationCtrl NumAddAnimCtrl;

	private bool hasSetScale;

	private ChestOpenCoinGemParam uiParam;

	private Vector3 Positon;

	private bool isStartAnim;

	private long myGoldGem;

	private float t;

	private bool isCardProGressAdd;

	private bool buttonEnable;

	private void Awake()
	{
	}

	public void GetAllUITween()
	{
	}

	public void EquipCardAdd()
	{
	}

	public bool isAnimEnd()
	{
		return false;
	}

	public void SetAnimEnd()
	{
	}

	public void SetAllAnimEnd()
	{
	}

	public void Show(object param)
	{
	}

	public void StartAnim()
	{
	}

	public void ShowEffect()
	{
	}

	private void Update()
	{
	}

	public void PlayerValueUpgrade(long MyHadGold, long goldCount, float time)
	{
	}

	public void UpdateState()
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
