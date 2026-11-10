using UnityEngine;

public class Target_Normal : TargetBase
{
	public override float PlayAnimation(TargetAniType aniType)
	{
		return 0f;
	}

	public override float GetTargetBarZ()
	{
		return 0f;
	}

	public override Vector3 GetTargetBarCenter()
	{
		return default;
	}

	public override int CalculateScore(Vector3 worldHitPos, Vector3 worldTargetForward, Vector3 worldTargetTop, TargetCtrl targetCtrl)
	{
		return 0;
	}
}
