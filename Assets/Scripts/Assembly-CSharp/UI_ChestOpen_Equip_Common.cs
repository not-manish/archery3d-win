using UnityEngine;

public class UI_ChestOpen_Equip_Common : MonoBehaviour
{
	public GameObject oQualityBlueName;

	public GameObject oQualityPurpleName;

	public GameObject oQualityOrangeName;

	public UILabel lEquipBigName;

	public UILabel lEquipNum;

	public UISprite lEquipSprite;

	public UILabel lEquipSmallName;

	public UILabel lEquipKindName;

	public UISprite sEquipKindBack;

	public UISprite sEquipBack;

	public UISprite sEquipName;

	public void Show(UI_ChestOpen_Equip uiChestOpenEquip, ChestRewardType _chestRewardType, int EquipKindId, int Number, ChestOpenEquipParam chestOpenEquipParam = null)
	{
	}

	public void Hide()
	{
	}
}
