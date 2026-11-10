using UnityEngine;

public class UI_Bingo_Rules : MonoBehaviour
{
	public GameObject oRule;

	public UIButton btnRule1;

	public UIButton btnRule2;

	public UI_AnimationCtrl uiRule1ShowAnim;

	public UI_AnimationCtrl uiRule1PlayAnim;

	public UI_AnimationCtrl uiRule1BtnAnim;

	public UI_AnimationCtrl uiRule2ShowAnim;

	public UI_AnimationCtrl uiRule2PlayAnim;

	public UI_AnimationCtrl uiRule2BtnAnim;

	public PlayerHeadShow playerHeadShow;

	private UnLockGameModeLevel unLockGameModeLevel;

	public FlexibleTimeRegulator m_tAnimPlayAgainTime1Regulator;

	public FlexibleTimeRegulator m_tAnimPlayAgainTime2Regulator;

	public UI1v1GameRulesData ui1v1GameRulesData;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object Param)
	{
	}

	public void uiRule1ShowAnimFinish()
	{
	}

	public void uiRule1ShowAnimAgainFinish()
	{
	}

	public void uiRule1PlayAnimFinish()
	{
	}

	public void uiRule2ShowAnimFinish()
	{
	}

	public void uiRule2ShowAnimAgainFinish()
	{
	}

	public void uiRule2PlayAnimFinish()
	{
	}

	private void Update()
	{
	}

	private void ButtonOnClicked(GameObject button)
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

	public void Hide(object param)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void ResetAnim()
	{
	}
}
