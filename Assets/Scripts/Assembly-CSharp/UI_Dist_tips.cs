using UnityEngine;

public class UI_Dist_tips : MonoBehaviour
{
	public UILabel lTips;

	public UILabel lTipsbg;

	public UIButton btnClose;

	public UISprite sTopIcon;

	private Vector3 NormalTopPosition;

	private Vector3 LeftTopPosition;

	private Vector3 NormalPosition;

	private Vector3 LeftPosition;

	public Transform oDistTips;

	public UI_AnimationCtrl uiAnimationCtrl;

	private DistTipsParam distTipsParam;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

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

	public bool isShowing()
	{
		return false;
	}
}
