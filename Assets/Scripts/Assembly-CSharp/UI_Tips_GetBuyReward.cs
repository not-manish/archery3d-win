using System;
using System.Collections.Generic;
using UnityEngine;

public class UI_Tips_GetBuyReward : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btCollect;

	public UISprite sBoard;

	public UISprite sAllItemBg;

	public Transform tTopTitle;

	public Transform tBtn;

	public UILabel lTitle1;

	public UILabel lTitle2;

	public UILabel lButton1;

	public UILabel lButton2;

	public List<UI_Tips_GetReward_Item> AllRewardItems;

	private int BoardMaxHeight;

	private int AllItemBgMaxHeight;

	private int tTopTitleMaxY;

	private int tBtnMinY;

	private int ItemHeight;

	private int ItemWight;

	public UI_AnimationCtrl ResultEffectAnimCtrl;

	public GameObject ResultEffect;

	public List<ParticleSystem> EffectGetSpinReward;

	private TipsGetBuyRewardData res;

	private bool hasSetScale;

	private UITipParam uiParam;

	private bool buttonEnable;

	private Action BtCloseAction;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void ShowData(object param)
	{
	}

	public int LoadItem(LimitedTimeBuyOriData limitedTimeBuyOriData)
	{
		return 0;
	}

	private void UpdateState(UITipParam uiParam)
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

	private void PurchaseLTBFinished()
	{
	}

	public void SetPosition(int _rewardCount)
	{
	}

	public void OpenCoinGemAnim(ChestRewardType rewardType, int ShowObjCount)
	{
	}

	public void SetButtonCloseAction(Action action)
	{
	}

	public void GetRewardEffect(bool isShow)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public bool isShowShopBuy()
	{
		return false;
	}
}
