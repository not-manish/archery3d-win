using System.Collections.Generic;
using com.simple.proto;

public class LimitedTimeBuyItem
{
	public int pack_state;

	public List<int> pack_unloc_ids;

	public bool pack_unloc_has_show;

	public long pack_unlock_start_time_mil;

	public long pack_unlock_duration_time_mil;

	public long pack_cooldown_start_time_mil;

	public long pack_cooldown_duration_time_mil;

	public LimitedTimeBuyItem()
	{
	}

	public LimitedTimeBuyItem(int _pack_state, List<int> _pack_unloc_ids, bool _pack_unloc_has_show, long _pack_unlock_start_time_mil, long _pack_unlock_duration_time_mil, long _pack_cooldown_start_time_mil, long _pack_cooldown_duration_time_mil)
	{
	}

	public void Update(CCLimitedTimeBuyItem data)
	{
	}

	public bool HasUnshowPackage()
	{
		return false;
	}

	public void SetHasShown()
	{
	}

	public bool HasPackage()
	{
		return false;
	}
}
