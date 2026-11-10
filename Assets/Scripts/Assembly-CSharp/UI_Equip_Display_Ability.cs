using UnityEngine;

public class UI_Equip_Display_Ability : MonoInstance<UI_Equip_Display_Ability>, UIBase
{
	public UIButton btInfo;

	public UISprite sRange;

	public UILabel lRange;

	public UISprite sAccuracy;

	public UILabel lAccuracy;

	public UISprite sZoomIn;

	public UILabel lZoomIn;

	public UISprite sStamina;

	public UILabel lStamina;

	public UISprite sStability;

	public UILabel lStability;

	public UISprite sArrowSpeed;

	public UILabel lArrowSpeed;

	public UISprite sAimingSpeed;

	public UILabel lAimingSpeed;

	public UISprite oResistWind;

	public UILabel lResistWindLevel;

	public UISprite oWinnerBonus;

	public UILabel lWinnerBonusLevel;

	public UISprite oCheerUp;

	public UILabel lCheerUpLevel;

	public UIButton btnWind;

	public UIButton btnWinner;

	public UIButton btnCheerUp;

	private int RangeCur;

	private int RangeTarget;

	private int AccuracyCur;

	private int AccuracyTarget;

	private int ZoomInCur;

	private int ZoomInTarget;

	private int StaminaCur;

	private int StaminaTarget;

	private int StabilityCur;

	private int StabilityTarget;

	private int ArrowSpeedCur;

	private int ArrowSpeedTarget;

	private int AimingSpeedCur;

	private int AimingSpeedTarget;

	private EquipProperties equipProperties;

	private bool hasSetScale;

	private UI_Equip uiEquip;

	private bool buttonEnable;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Show(object param)
	{
	}

	public void UpdateState(bool force)
	{
	}

	private float GetProgress(int CurNum, int MaxNum)
	{
		return 0f;
	}

	public void Hide(bool enfoce)
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
