using System.Collections.Generic;
using UnityEngine;

public class UI_Gameover_tenChest : MonoBehaviour
{
	public UIButton btnChest5;

	public UIButton btnChest8;

	public UIButton btnChest10;

	public UISprite sChest5;

	public UISprite sChest8;

	public UISprite sChest10;

	public UI_AnimationCtrl AnimChes5;

	public UI_AnimationCtrl AnimChes8;

	public UI_AnimationCtrl AnimChes10;

	public UISlider STenChestProcessFront;

	public UILabel lGamesCount0;

	public UILabel lGamesCount5;

	public UILabel lGamesCount8;

	public UILabel lGamesCount10;

	private bool isStartAnim;

	private float StartProgressValue;

	private float EndProgressValue;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	private List<UI_AnimationCtrl> PlayAnim;

	private GameoverTenChestData gameoverTenChestData;

	private bool hasSetScale;

	private UI_Setting uiSetting;

	private float t;

	private bool buttonEnable;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Show(object Param)
	{
	}

	public void ShowGamesTips(GameoverTenChestData param)
	{
	}

	public void PlayerAdd()
	{
	}

	public void EndAnim()
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

	private void ButtonOnClicked(GameObject button)
	{
	}

	public bool IsShowing()
	{
		return false;
	}
}
