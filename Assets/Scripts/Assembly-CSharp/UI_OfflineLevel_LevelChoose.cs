using System;
using System.Collections.Generic;
using UnityEngine;

public class UI_OfflineLevel_LevelChoose : MonoBehaviour
{
	public UIScrollBar uiScrollBar;

	public UIButton btnBack;

	public GameObject oBack;

	public UIButton btBuyHeart;

	public UI_Offline_Heart_Recover uiHeartRecove;

	public UILabel lHeartNum;

	public UISlider sPassLevel;

	public UISprite sS_ProgressBlack;

	public UISprite sE_LevelLock;

	public UISprite sS_PlayerLocation;

	public UI_OfflineLevel_ReConnect offlineLevel_ReConnect;

	public List<Levellock> LevelLockDic;

	public Transform RewardParent;

	private float oneLevellength;

	private OfflineLevelCtrl offlineLevelCtrl;

	public bool isHeartAdd;

	public TimeSpan heattAddNeedTime;

	public bool buttonEnable;

	private bool isMoveProgressBlack;

	private float uiScrollBarValue;

	private float downY;

	private float UpY;

	private void Start()
	{
	}

	public void LoadLevelLock()
	{
	}

	public void Show()
	{
	}

	public void UpdateTimeAndHeart()
	{
	}

	public void UpdateState()
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	public void ButtonOnClicked(GameObject button)
	{
	}

	public void Hide()
	{
	}

	private void Update()
	{
	}

	public void UpdatePosition(OfflineLevelCtrl _offlineLevelCtrl, int _levelID, bool isFirstEnter = false)
	{
	}

	public void OnValueChange()
	{
	}

	public void OnBackLastOpenLevel()
	{
	}

	public bool isShow()
	{
		return false;
	}

	public void SetBackButtonActive(bool isActive, BackBtnType backBtnType)
	{
	}
}
