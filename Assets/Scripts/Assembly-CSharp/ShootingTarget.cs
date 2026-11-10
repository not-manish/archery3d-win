using System.Collections.Generic;
using UnityEngine;

public class ShootingTarget
{
	public bool IsRobot;

	public bool hasShoot;

	public List<int> target_serve_ids;

	public List<Vector3> hit_targets_pos;

	public List<Vector3> targets_center_pos;

	public List<Vector3> hit_targets_forward;

	public List<Vector3> hit_targets_top;

	public Vector3 cam_start_pos;

	public Vector3 cam_start_dir;

	public float targetZ;

	public int arm_id;

	public int bow_id;

	public int arrow_id;

	public int sight_id;

	public int stabilizer_id;

	public bool has_wind;

	public float wind_speed;

	public float wind_angle;

	public float shoot_target_time;

	public static ShootingTarget GetShootTarget(bool _hasShoot, PlayerEntity player)
	{
		return null;
	}
}
