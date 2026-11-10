using UnityEngine;

public class UI_Loading_Reconnect : MonoInstance<UI_Loading_Reconnect>, UIBase
{
	public GameObject oHideParent;

	public UIButton btCancel;

	private FlexibleTimeRegulator m_tHideRegulator;

	private FlexibleTimeRegulator m_tShowRegulator;

	private FlexibleTimeRegulator m_tTimeRegulator;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void Hide(object param)
	{
	}

	public void KeyEscapeClicked()
	{
	}

	private void Update()
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
