using System.Collections.Generic;
using UnityEngine;

public class TargetCarrierContainers : MonoBehaviour
{
	public List<TargetCarrierContainers> subContains;

	public List<Transform> targetParents;

	private TargetMoveCtrl moveCtrl;

	public List<TargetCtrl> GenerateTargets(TargetCarrier targetCarrier, TargetCarrierOriData targetCarrierOriData, int carrier_sub_id, int ServerStartId, bool isLoadNotShoot)
	{
		return null;
	}

	public TargetLightShowCtrl LoadTargetLight(TargetNormalType targetNormalType, Transform target)
	{
		return null;
	}

	public GameObject LoadCanNotTarget(Transform Target)
	{
		return null;
	}

	public void ResetMove()
	{
	}

	public void ResumeMove()
	{
	}

	public void PauseMove()
	{
	}

	public void SetAllTargetsPos(float targetTime)
	{
	}
}
