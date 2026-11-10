using UnityEngine;

public class UI_Equip_IconTips : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIPanel uipanel;

	public UISprite sLableBg;

	public UILabel liconTips;

	public Transform tTipsObj;

	public UIIconTipsParam uiIconTipsParam;

	private float showTime;

	[HideInInspector]
	public UI_Equip uiEquip;

	public FlexibleRealTimeRegulator m_tWaitTime;

	private bool buttonEnable;

	public void Show(UI_Equip _uiEquip, object param)
	{
	}

	public void UpdateState()
	{
	}

	private void Update()
	{
	}

	public void AnimFinishHide()
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
}
