using UnityEngine;

public class UI_GO_Single_Failed : MonoBehaviour
{
	public UILabel lMyScore;

	public UILabel lPassScore;

	public UIButton btMenu;

	public UIButton btRetry;

	public GameObject btRetryOk;

	public GameObject btRetryGray;

	public GameObject oRetryCost;

	public GameObject oRetrying;

	public UILabel lRetryCostWhite;

	public UILabel lRetryCostRed;

	private FlexibleRealTimeRegulator m_tRealTimeRegulator;

	private bool hasSetScale;

	private UIGameOverParam uiParam;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	private void UpdateState()
	{
	}

	public void Hide(object param)
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

	public bool IsShowing()
	{
		return false;
	}

	public void RetryReponse()
	{
	}
}
