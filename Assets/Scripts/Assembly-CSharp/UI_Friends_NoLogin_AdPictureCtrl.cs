using System.Collections.Generic;
using UnityEngine;

public class UI_Friends_NoLogin_AdPictureCtrl : MonoBehaviour
{
	public enum MoveDirection
	{
		Right = 0,
		Left = 1
	}

	public enum MoveState
	{
		Null = 0,
		OnPress = 1,
		OnDrap = 2,
		AutoMove = 3
	}

	public UIScrollView ScrollViewParent;

	private int MaxChildCount;

	public List<GameObject> AdPictures;

	public List<UISprite> allDots;

	public UICenterOnChild uiCenterOnChild;

	public MoveState moveState;

	public MoveDirection moveDirecti;

	private float waitingAutoTime;

	public bool InputButton;

	private int NowCount;

	public float time;

	public void Start()
	{
	}

	public void Hide()
	{
	}

	private void Update()
	{
	}
}
