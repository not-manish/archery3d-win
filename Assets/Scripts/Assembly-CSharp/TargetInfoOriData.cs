public class TargetInfoOriData
{
	public int id;

	public int target_kind;

	public string target_kind_name;

	public int target_sub_type;

	public string target_sub_type_name;

	public string res_name;

	public float center_x;

	public float center_y;

	public float center_z;

	public float size_x;

	public float size_y;

	public float size_z;

	public int has_brok_effect;

	public string brok_res_name;

	public bool HasBrokenEffect()
	{
		return false;
	}
}
