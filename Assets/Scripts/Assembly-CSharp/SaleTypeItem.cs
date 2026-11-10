public class SaleTypeItem
{
	public int pack_state;

	public int pack_unloc_id;

	public bool pack_unloc_has_show;

	public long pack_unlock_start_time_mil;

	public long pack_unlock_duration_time_mil;

	public long pack_cooldown_start_time_mil;

	public long pack_cooldown_duration_time_mil;

	public int SpecialEquipTypeID;

	public LimitedTimeBuyCtrl.PackageType PackageType;

	public SaleTypeItem(int index, LimitedTimeBuyItem limitedTimeBuyItem, LimitedTimeBuyCtrl.PackageType _PackageType)
	{
	}

	public SaleTypeItem(int _pack_state, int _pack_unloc_id, bool _pack_unloc_has_show, long _pack_unlock_start_time_mil, long _pack_unlock_duration_time_mil, long _pack_cooldown_start_time_mil, long _pack_cooldown_duration_time_mil, LimitedTimeBuyCtrl.PackageType _PackageType)
	{
	}
}
