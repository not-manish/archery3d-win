using UnityEngine;

[AddComponentMenu("NGUI/Examples/Lag Position")]
public class LagPosition : MonoBehaviour
{
	public int updateOrder;

	public Vector3 speed;

	public bool ignoreTimeScale;

	private Transform mTrans;

	private Vector3 mRelative;

	private Vector3 mAbsolute;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}
}
