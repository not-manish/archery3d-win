using System;

public class EquipValueUpgrade
{
	public UISprite sCardProgress;

	public float startfillAmount;

	public float endfillAmount;

	public UILabel lUpgradeText;

	public int UpgradeBefore;

	public int UpgradeAfter;

	public int UpgradeNeedCard;

	public bool isPrcent;

	public bool isUpGrade;

	public UI_Equip_Upgrade.UpgradeState upgradeState;

	public float UpgradeTime;

	public Action<int> PlayerValueUpgradeFinish;

	public EquipValueUpgrade(UILabel _lUpgradeText, UISprite _sCardProgress, float _startfillAmount, float _endfillAmount, int _UpgradeBefore, int _UpgradeAfter, int _UpgradeNeedCard, bool _isPrecent, bool _isUpGrade, float _UpgradeTime = 1f, UI_Equip_Upgrade.UpgradeState _upgradeState = UI_Equip_Upgrade.UpgradeState.Null, Action<int> _PlayerValueUpgradeFinish = null)
	{
	}
}
