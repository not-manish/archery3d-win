using UnityEngine;

public class UI_LittleTips : MonoBehaviour
{
	public UILabel lTips;

	public UISprite sTopIcon;

	private Transform oDistTips;

	public UI_AnimationCtrl uiAnimationCtrl;

	private LittleTipsData littleTipsData;

	public GameObject oShowTroy;

	public int showCount;

	private bool hasSetScale;

	private bool buttonEnable;

	public void Show(object Param)
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

	private void ButtonOnClicked(GameObject button)
	{
	}

	private void Update()
	{
	}

	public bool isShowing()
	{
		return false;
	}
}
