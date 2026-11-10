using System.Collections.Generic;

public class TargetCarrierOriData
{
	public int ID;

	public int carrier_info_id;

	public int target_kind;

	public int target_type;

	public int target_score;

	public int is_permanent;

	public List<int> appear_type_int;

	public List<TCAppearType> appear_type;

	public List<int> appear_param;

	public List<int> disappear_type_int;

	public List<TCDisappearType> disappear_type;

	public List<int> disappear_param;

	public bool IsPermanent()
	{
		return false;
	}
}
