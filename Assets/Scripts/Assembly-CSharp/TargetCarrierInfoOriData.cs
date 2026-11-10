using System.Collections.Generic;

public class TargetCarrierInfoOriData
{
	public int ID;

	public string carrier_res_name;

	public int formu_pos_id;

	public int formu_rot_id;

	public float parent_pos_x;

	public float parent_pos_y;

	public float parent_pos_z;

	public int target_num;

	public List<float> targets_pos_x;

	public List<float> targets_pos_y;

	public List<float> targets_pos_z;

	public int sub_carrier_num;

	public List<int> sub_car_ids;
}
