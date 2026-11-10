using UnityEngine;

public class Target_NonFragile : TargetBase
{
	public override int CalculateScore(Vector3 worldHitPos, Vector3 worldTargetForward, Vector3 worldTargetTop, TargetCtrl targetCtrl)
	{
		return 0;
	}

	public override float GetTargetBarZ()
	{
		return 0f;
	}

	public override Vector3 GetTargetBarCenter()
	{
		return default;
	}

	public override float PlayAnimation(TargetAniType aniType)
	{
		return 0f;
	}
}
