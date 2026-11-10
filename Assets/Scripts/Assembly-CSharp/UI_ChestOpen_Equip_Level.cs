using UnityEngine;

public class UI_ChestOpen_Equip_Level : MonoBehaviour
{
	public UISprite sCardProgress;

	public UILabel lCardProgressNum;

	public UILabel lLevel;

	public GameObject oCanUpgrade;

	public UISprite sIcon;

	public GameObject oEquipOther;

	public UISprite sLevelBg;

	public bool isCardProGressAdd;

	public float sCardProgressValue;

	public float oldsCardProgressValue;

	private int unlock_cost_card;

	private long AddCardNumber;

	private EquipOthers equipOthers;

	private EquipOthersBase equipOriDataCur;

	private UI_ChestOpen_Equip uiChestOpenEquip;

	private EquipArrow equipArrow;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public FlexibleRealTimeRegulator m_tTimeAddRegulator;

	private EquipStatistics equipStatistics;

	private ChestRewardType chestRewardType;

	public UI_AnimationCtrl NumAddAnimCtrl;

	private int AddNumber;

	private int DelNumber;

	private float t;

	public void Show(UI_ChestOpen_Equip _uiChestOpenEquip, ChestRewardType _chestRewardType, int EquipKindId, int Number, ChestOpenEquipParam chestOpenEquipParam = null)
	{
	}

	public void ShowVideoValue(ChestRewardType _chestRewardType, int EquipKindId, int Number)
	{
	}

	private float GetProgress(long CurNum, long MaxNum)
	{
		return 0f;
	}

	public void setEndAnim()
	{
	}

	public void SetTime()
	{
	}

	public void SetTime(float time)
	{
	}

	public void EquipCardAdd()
	{
	}

	private void Update()
	{
	}

	public void PlayerValueUpgrade(long AddCard, long ownedCard, float oldcardProgressValue, float cardProgressValue, int unlockCostCard, float time)
	{
	}

	public void SetColor(int quality)
	{
	}
}
