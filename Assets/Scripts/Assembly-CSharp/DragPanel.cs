using UnityEngine;

public class DragPanel : MonoBehaviour
{
	private VelocityTracker m_VT;

	private bool m_QuickTap;

	private float m_MaxTapDelay;

	private float m_TouchDownTime;

	private float m_MaxFlingDelay;

	private Vector2 m_FlingVec;

	private bool m_Fling;

	public bool IsConsiderFling;

	public float flingStartThresholdVx;

	public float flingStartThresholdVy;

	public float flingEndThresholdVx;

	public float flingEndThresholdVy;

	public float flingAttenuation;

	public Vector2 M_FlingVec => default;

	public bool M_Fling => false;

	private void Update()
	{
	}

	public void OnDrag(Vector2 delta)
	{
	}

	public void OnPress(bool state)
	{
	}

	private void OnFling(float velocityX, float velocityY)
	{
	}

	public void OnTouchUp()
	{
	}

	public void OnTouchDown()
	{
	}

	public void OnQuickTap()
	{
	}

	private void Fling()
	{
	}

	public virtual void _TouchDown()
	{
	}

	public virtual void _TouchUp()
	{
	}

	public virtual void _QuickTap()
	{
	}

	public virtual void _FlingStart()
	{
	}

	public virtual void _Fling()
	{
	}

	public virtual void _FlingEnd()
	{
	}

	public virtual void _Drag(Vector2 delta)
	{
	}
}
