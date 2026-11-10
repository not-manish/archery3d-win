using UnityEngine;

[AddComponentMenu("NGUI/Examples/Lag Rotation")]
public class LagRotation : MonoBehaviour
{
	public int updateOrder;

	public float speed;

	public bool ignoreTimeScale;

	private Transform mTrans;

	private Quaternion mRelative;

	private Quaternion mAbsolute;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}
}
