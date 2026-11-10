using System.Collections.Generic;
using UnityEngine;

public class UI_Equip_Upgrade : MonoBehaviour
{
	public enum UpgradeState
	{
		Null = 0,
		PlayCostCard = 1,
		EquipValueAdd = 2,
		EquipValueChange = 3,
		PlayLevelUp = 4,
		PlayingLevelUp = 5,
		PlayPropertiesAdd = 6,
		PlayingPropertiesAdd = 7,
		PlayTapToContinue = 8,
		PlayingToContinue = 9,
		Finished = 10
	}

	public UI_Equip_Upgrade_Model uiModel;

	public UIButton btClose;

	public UIButton btShouEquip;

	public GameObject oTapToContinue;

	public UISprite oWinnerBonus;

	public GameObject oWinUpgradeArrow;

	public UISprite oCheerupBonus;

	public GameObject oCheerupUpgradeArrow;

	public GameObject[] oEquipProperties;

	public GameObject[] oEquipPropertiesAddNum;

	public UILabel lEquipName;

	public UILabel lCurLevel;

	public UILabel lCardProgressNum;

	public UISprite sCardProgress;

	public UISprite sUpProgressArrows;

	public UILabel[] lPropName;

	public UILabel[] lPropCurNum;

	public UILabel[] lPropAddNum;

	public UISprite[] sPropCurProgress;

	public UISprite[] sPropNextProgress;

	public UISprite[] sPropFullProgress;

	public UILabel lWinnerLevel;

	public UILabel lCheerupLevel;

	public UILabel lWinnerUpgrade;

	public UILabel lCheerupUpgrade;

	public UIChangeWidgeColor colorWinner;

	public UIChangeWidgeColor colorCheerup;

	private int LevelBefore;

	private int LevelAfter;

	private int CardLeftBefore;

	private int CardLeftAfter;

	private int CardNeedBefore;

	private int CardNeedAfter;

	public List<EquipPropertiesType> ValueType;

	public List<bool> ValueIsPercent;

	public List<int> ValueBefore;

	public List<int> ValueAfter;

	public List<EquipPropertiesType> MaxValueType;

	public UI_Equip_Info_Color uiEquipInfoColor;

	public UI_AnimationCtrl levelNumAnimationCtrl;

	public List<UI_AnimationCtrl> CommonValueAnimationCtrl;

	public UI_AnimationCtrl winnerBonusAnimationCtrl;

	public UI_AnimationCtrl cheerUpBonusAnimationCtrl;

	public UI_AnimationCtrl tapToContinusAnimationCtrl;

	public UIPanel uiPanel;

	private EquipValueUpgrade equipValueUpgrade;

	private UIModelKind uiModelKind;

	private UpgradeState curState;

	private FlexibleRealTimeRegulator m_tTimeRegulator;

	public UIEquipUpgradeParam uiParam;

	[HideInInspector]
	public UI_Equip uiEquip;

	private bool buttonEnable;

	private float t;

	private int index;

	private int normalItemIndex;

	private int valueTypeindex;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Show(UI_Equip _uiEquip, object param)
	{
	}

	private void ShowModels(UIEquipUpgradeParam uiParam)
	{
	}

	private void UpdateState(bool isShowFillAccount = true)
	{
	}

	private float GetProgress(int CurNum, int MaxNum)
	{
		return 0f;
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

	public void PlayerValueUpgrade()
	{
	}

	public void PlayerCardUpgradeFinish(int value = 0)
	{
	}

	public void PlayerLevelUp()
	{
	}

	public void PlayerLevelUpFinish()
	{
	}

	public void PlayPropertiesAdd(int i)
	{
	}

	public void PlayPropertiesAddFinish()
	{
	}

	public void PlayWinOrLosePropertiesAddFinish()
	{
	}

	public void PlayTapToContinue()
	{
	}

	public void PlayTapToContinueFinish()
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void UpdatePlayerInfo()
	{
	}

	public void EquipOperateResponse()
	{
	}
}
