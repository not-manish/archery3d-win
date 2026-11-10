using UnityEngine;

public class UI_HintsTips : MonoBehaviour
{
	public UI_AnimationCtrl uiReadyGo;

	public UI_AnimationCtrl uiGameMode;

	public UI_AnimationCtrl uiShootOff;

	public UI_AnimationCtrl uiAnimation;

	private FlexibleTimeRegulator m_tTimeRegulator;

	public GameObject oWaitingOppLoad;

	public GameObject objReady;

	public GameObject objGO;

	public GameObject objFinish;

	public GameObject objRush;

	public GameObject objBingo;

	public GameObject objCareer;

	public GameObject objChallenge;

	public UILabel lChallengeLevel;

	public GameObject objClassic;

	public GameObject objClassicBestof3;

	public GameObject objClassicCountUp;

	public GameObject objArena;

	public GameObject objArenaBestof3;

	public GameObject objArenaCountUp;

	public GameObject objShootOff;

	public GameObject objShootOff_15Second;

	public GameObject objShootOff_OneArrow;

	public GameObject objTimeOut;

	private UIHintsTipParam uiParam;

	public void Show(object param)
	{
	}

	private void UpdateState()
	{
	}

	private void Update()
	{
	}

	public void Hide()
	{
	}

	public void ShowWaitingOpp()
	{
	}

	public bool isShowing()
	{
		return false;
	}
}
