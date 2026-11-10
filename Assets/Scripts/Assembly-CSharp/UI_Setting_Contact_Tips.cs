using UnityEngine;

public class UI_Setting_Contact_Tips : MonoBehaviour
{
	public UI_AnimationCtrl uiAnimationCtrl;

	public UIButton btClose;

	public UIButton btnItemDetail;

	public UIButton btnContactUs;

	private UI_Setting_Others uiSettingOthers;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(UI_Setting_Others UISettingOthers, object param)
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

	public void ClearAllEscape()
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
