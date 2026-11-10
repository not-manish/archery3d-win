using UnityEngine;

public class UI_GO_Single_Success : MonoBehaviour
{
	public UILabel lMyScore;

	public UILabel lMyTime;

	public GameObject oNewRecord;

	public GameObject oPerfect;

	public UIButton btMenu;

	public UIButton btNext;

	public UIButton btRetry;

	public GameObject oRetryGray;

	public UILabel LWhiteCost;

	public UILabel LRedCost;

	public GameObject oRetry;

	public GameObject oRetrying;

	public UISprite sPassMedalIcon;

	public UI_AnimationCtrl NewRecordAnimationCtrl;

	public UI_AnimationCtrl PerfectAnimationCtrl;

	public ParticleSystem WinParticile;

	private bool hasSetScale;

	private UIGameOverParam uiParam;

	private int SumScore;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void ResetAnim()
	{
	}

	public void Hide(object param)
	{
	}

	private void UpdateState()
	{
	}

	public void ShowNewScore()
	{
	}

	public void ShowButton()
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

	public void PlayEffect()
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void showPassLevelIcon(int _sumScore)
	{
	}

	public void RetryReponse()
	{
	}
}
