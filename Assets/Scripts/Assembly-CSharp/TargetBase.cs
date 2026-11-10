using UnityEngine;

public abstract class TargetBase : MonoBehaviour
{
	public Transform targetBar;

	public Transform targetArrowTarget;

	public Animation targetAniCom;

	public abstract float GetTargetBarZ();

	public abstract Vector3 GetTargetBarCenter();

	public Transform GetTargetCenterTransform()
	{
		return null;
	}

	public Transform GetTargetArrowsParent()
	{
		return null;
	}

	public abstract int CalculateScore(Vector3 worldHitPos, Vector3 worldTargetForward, Vector3 worldTargetTop, TargetCtrl targetCtrl);

	public abstract float PlayAnimation(TargetAniType aniType);
}
