using UnityEngine;

public class UI_LockModel2 : MonoBehaviour
{
	public RenderToTexture renderToTexture;

	public Camera cam;

	public Rigidbody lockRigidbody;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	private bool isAddForce;

	private float addLockVelocity;

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public RenderTexture GetModelTexture()
	{
		return null;
	}

	public void DestroyAllTexture()
	{
	}

	public void AddForce(Vector2 delta)
	{
	}

	private void FixedUpdate()
	{
	}
}
