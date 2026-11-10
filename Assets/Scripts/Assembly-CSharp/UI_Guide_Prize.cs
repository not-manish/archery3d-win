using UnityEngine;

public class UI_Guide_Prize : MonoBehaviour
{
	private enum State
	{
		WaitingShowTap = 0,
		TapToContinue = 1
	}

	public UIButton btTapContinue;

	public GameObject oTapToContnue;

	private FlexibleTimeRegulator m_tTimeRegulator;

	public UISprite sChestBig;

	private State state;

	private bool buttonEnable;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Show()
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

	private void ButtonOnPress(GameObject go, bool pressed)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
