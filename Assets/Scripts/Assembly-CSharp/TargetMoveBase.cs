using UnityEngine;

public class TargetMoveBase : MonoBehaviour
{
	public virtual Vector3 GetTargetPos(float T)
	{
		return default;
	}

	public virtual Vector3 GetTargetRotation(float T)
	{
		return default;
	}
}
