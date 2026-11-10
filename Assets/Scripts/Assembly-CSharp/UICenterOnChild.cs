using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Center Scroll View on Child")]
public class UICenterOnChild : MonoBehaviour
{
	public float springStrength;

	public float nextPageThreshold;

	public SpringPanel.OnFinished onFinished;

	private UIScrollView mScrollView;

	private GameObject mCenteredObject;

	public GameObject centeredObject => null;

	private void OnEnable()
	{
	}

	private void OnDragFinished()
	{
	}

	private void OnValidate()
	{
	}

	public void Recenter()
	{
	}

	private void CenterOn(Transform target, Vector3 panelCenter)
	{
	}

	public void CenterOn(Transform target)
	{
	}
}
