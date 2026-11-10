using UnityEngine;

public class UI_OfflineLevel_HeartStore : UI_Offline_BuyObjToContinue
{
	public UIButton[] btPayDiamonds;

	public UISprite[] sHeatIcon;

	public UILabel[] labGetObjNums;

	public UILabel[] labPayDiamondNums;

	public TweenTransform HeatAdd;

	public UI_AnimationCtrl uiHeatAddAnimationCtrl;

	public bool buttonEnable;

	public new void Start()
	{
	}

	public override void UpdateState()
	{
	}

	public override void EnableButtons()
	{
	}

	public override void DisableButtons()
	{
	}

	public override void KeyEscapeClicked()
	{
	}

	public override void ButtonOnClicked(GameObject button)
	{
	}

	public override void Hide(object parm)
	{
	}

	public override void PayDiamondButtonOnClicked(GameObject button)
	{
	}

	public override void BuyDiamondButtonOnClicked(GameObject button)
	{
	}

	public override void BuyObjsResponse()
	{
	}

	public void AnimFinish()
	{
	}
}
