using System;
using UnityEngine;

public class UI_TutorialPanel : MonoBehaviour
{
	public static int TutorialPanelLevel;

	public GameObject oTutorialRoot;

	public UIButton btnCloseTips;

	public UIPanel uiPanel;

	public GameObject oFullscreen;

	public GameObject oTopDown;

	public GameObject oFingerTouch;

	public GameObject oFingerClick;

	public GameObject oFinger;

	public GameObject oTutoriaTips;

	public GameObject oNewChestTips;

	public GameObject oEquipFinish;

	public GameObject oClickEquip;

	public GameObject oClickHandPosition;

	public ParticleSystem ClickParticle1;

	public ParticleSystem ClickParticle2;

	public UI_AnimationCtrl uiAnimationCtrlTips;

	public UITutorialPanelParam uiParam;

	private TutorialTipsType tipsType;

	public UIPanel uiFingerPanel;

	public UI_AnimationCtrl uiAnimationCtrl;

	public UIPanel uiFingerClickPanel;

	public UI_AnimationCtrl uiClickAnimationCtrl;

	private bool buttonEnable;

	private Action BtMiddleAction;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void Hide(object param)
	{
	}

	public void ShowFingerTouch(Vector3 position, int PanelDepth)
	{
	}

	public void ShowTuTorialTips(TutorialTipsType TipsType, int PanelDepth)
	{
	}

	public void ShowFingerClick(Vector3 position, int PanelDepth)
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

	public void HideFingerTouch()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void SetButtonMiddleAction(Action action)
	{
	}

	public bool isShowing()
	{
		return false;
	}
}
