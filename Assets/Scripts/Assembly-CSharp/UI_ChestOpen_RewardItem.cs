using UnityEngine;

public class UI_ChestOpen_RewardItem : MonoBehaviour
{
	public UILabel lEquipNum;

	public UISprite lEquipSprite;

	public UILabel lEquipSmallName;

	public UILabel lEquipKindName;

	public UISprite sEquipBack;

	public UISprite sEquipName;

	public ChestOpenRewardItemData param;

	public UI_AnimationCtrl uiAnimationCtrl;

	public ChestVideoType chestVideoType;

	public CardQuality cardQuality;

	public virtual void Show(object _param)
	{
	}

	public virtual void UpdateInfo()
	{
	}

	public virtual void UpdateNormalInfo()
	{
	}

	public virtual void UpdateMysteryInfo(bool isGet = false)
	{
	}

	public virtual void Hide()
	{
	}
}
