using System.Collections.Generic;
using UnityEngine;

public class ArrowExtraParam
{
	public int ArrowModelIndex;

	public float ArrowRealFlySpeed;

	public float ArrowFlySpeed;

	public PlayerType playerType;

	public bool hasWind;

	public float windSpeed;

	public float windAngle;

	public float bowEffRealZDis;

	public List<int> hitServeIDList;

	public List<Vector3> hitTargetCenterList;

	public List<Vector3> hitPointList;

	public List<Vector3> hitForwardList;

	public List<Vector3> hit_targets_top;

	public float target_z;

	public Vector3 camPosWhenAiming;

	public Vector3 camDirWhenAiming;

	public float ArrowFlyParamA;

	public float ArrowFlyParamB;
}
