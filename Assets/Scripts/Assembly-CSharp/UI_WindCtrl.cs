using UnityEngine;

public class UI_WindCtrl : MonoBehaviour
{
	public GameObject oWithResist;

	public GameObject oWithoutResist;

	public UISprite sWindAngle;

	public UILabel lWithoutResistSpeed;

	public UISprite sWindResistLevel;

	public UILabel lWithResistSpeed;

	public UILabel lWithResistSpeedbg;

	public UILabel lResistPercent;

	public TweenPosition tweenPositionWindAngle;

	private float radius;

	public UI_AnimationCtrl uiAnimationCtrl;

	public UI_AnimationCtrl uiAnimationEndCtrl;

	public void Hide()
	{
	}

	public void Show()
	{
	}

	public void SetActive(bool active)
	{
	}

	public void UpdateWind(bool hasWind, float windAngle, float windSpeed, bool isShowResist, int ResistPercent)
	{
	}

	public void UpdateEndAnim()
	{
	}

	public void UpdateWindNoAni(bool hasWind, float windAngle, float windSpeed, bool isShowResist, int ResistPercent)
	{
	}

	public void SetWindUI(bool hasWind, float windAngle, float windSpeed, bool isShowResist, int ResistPercent)
	{
	}
}
