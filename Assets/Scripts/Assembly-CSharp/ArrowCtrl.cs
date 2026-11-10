using System.Collections.Generic;
using UnityEngine;

public class ArrowCtrl : MonoBehaviour
{
	private Dictionary<int, ArrowFly> ArrowPrefabs;

	private List<ArrowFly> ArrowList;

	private Dictionary<int, List<ArrowFly>> UnusedList;

	private List<ArrowFly> FlyingArrow;

	private void Awake()
	{
	}

	public void GenerateArrow(Vector3 startPos, Quaternion rotation, ref ArrowFly arrowFly, ArrowExtraParam extraPara)
	{
	}

	public void CollectAllArrows()
	{
	}

	public void CollectArrow(ArrowFly arrowFly)
	{
	}

	public void AddFlyingArrow(ArrowFly arrowFly)
	{
	}

	public bool IsArrowFlying(ArrowFly arrowFly)
	{
		return false;
	}

	public bool GetServeTargetIsArrowTarget(int serveID)
	{
		return false;
	}

	public void ArrowArriveDeleteTarget(ArrowFly arrowFly)
	{
	}

	public void ArrowArriveTarget(ArrowFly arrowFly)
	{
	}

	public static Vector3 GetArrowPosFromZ(float targetZ, Vector3 startPos, Vector3 camAimDir, float desZ, float effectiveZ, bool has_wind, float windSpeed, float windAngle, float arrowFlyParamA, float arrowFlyParamB)
	{
		return default;
	}

	public static Vector3 GetFlyingNextPositon(float MoveSpeed, float deltaTime, float targetZ, Vector3 startPos, Vector3 camAimDir, Vector3 curPos, float effectiveZ, bool hasWind, float windSpeed, float windAngle, float arrowFlyParamA, float arrowFlyParamB)
	{
		return default;
	}
}
