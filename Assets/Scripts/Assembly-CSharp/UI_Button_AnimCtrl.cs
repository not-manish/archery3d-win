using System.Collections.Generic;
using UnityEngine;

public class UI_Button_AnimCtrl : MonoBehaviour
{
	public List<TweenScale> PressAnims;

	private Dictionary<ButtonAnimType, TweenScale> AnimsAllType;

	public List<AnimationCurve> AnimCurve;

	public bool isActivePlayAnim;

	public ButtonAnimType buttonAnimType;

	public BtnChangeColor btnChangeColor;

	private int TweenGroup;

	private void Awake()
	{
	}

	public void GetPressAnimsAnim()
	{
	}

	private void ButtonOnPress(GameObject go, bool isUP)
	{
	}

	private void ButtonOnClick(GameObject go)
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}
}
