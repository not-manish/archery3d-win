using System.Collections.Generic;
using UnityEngine;

public class UI_Level1V1_Rule : MonoBehaviour
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

	public UIButton btnLeft;

	public UIButton btnRight;

	public GameObject lRangeTitle1;

	public UILabel lPvpTitle1;

	public UILabel lPvpTitle1bg;

	public UILabel lPvpInfo1;

	public GameObject lRangeTitle2;

	public UILabel lPvpTitle2;

	public UILabel lPvpTitle2bg;

	public UILabel lPvpInfo2;

	private float RangeRulePositionX;

	private float oneRulePositionX;

	public MoveState moveState;

	public MoveDirection moveDirecti;

	private float waitingAutoTime;

	public bool InputButton;

	private int NowCount;

	public float time;

	private void Start()
	{
	}

	public void Show(List<PvpType> gameRuleCount)
	{
	}

	public void SetPvpInfo(PvpType pvpType, int ShowRuleCount)
	{
	}

	public void Hide()
	{
	}

	private void Update()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}
}
