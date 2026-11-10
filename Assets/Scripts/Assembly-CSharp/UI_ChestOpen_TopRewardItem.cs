using UnityEngine;

public class UI_ChestOpen_TopRewardItem : UI_ChestOpen_RewardItem
{
	public UIButton btnVideo;

	public UILabel lName;

	public UILabel lNameBg;

	public UISprite sEquipKindBack;

	public UISprite sMystery;

	public UILabel lMystery;

	public UISprite slight;

	private FlexibleRealTimeRegulator m_TimeRegulator;

	private FlexibleRealTimeRegulator m_tTimeAddRegulator;

	private FlexibleRealTimeRegulator m_tTimeStartRegulator;

	public UI_AnimationCtrl CardAnim;

	public GameObject GetRewardParticl;

	public UI_AnimationCtrl AddNumAnim;

	public UI_AnimationCtrl BtnAnimationCtrl;

	public Transform tCoin;

	public UI_ChestOpen_Equip_Level uiChestOpenEquipLevel;

	private bool buttonEnable;

	private float t;

	private void Start()
	{
	}

	public override void Show(object _param)
	{
	}

	public override void UpdateNormalInfo()
	{
	}

	public override void UpdateMysteryInfo(bool isGet = false)
	{
	}

	public void ShowTopItem(ChestVideoType _chestVideoType, bool isShowMystery)
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

	public void PlayerVideoFinish(bool isFinished)
	{
	}

	public bool IsShowing()
	{
		return false;
	}

	public void GetSuccess(ChestOpenRewardItemData chestOpenRewardItemData)
	{
	}

	private void RecoverAllAni()
	{
	}

	private void PlayerAllAniFinish()
	{
	}

	private void Update()
	{
	}

	public void PlayerValueUpgrade(long AddCard, long ownedCard, float oldcardProgressValue, float cardProgressValue, int unlockCostCard, float time)
	{
	}

	public override void Hide()
	{
	}
}
