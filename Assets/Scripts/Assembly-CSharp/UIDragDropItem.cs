using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Drag and Drop Item")]
public class UIDragDropItem : MonoBehaviour
{
	public enum Restriction
	{
		None = 0,
		Horizontal = 1,
		Vertical = 2,
		PressAndHold = 3
	}

	public Restriction restriction;

	public bool cloneOnDrag;

	[HideInInspector]
	public float pressAndHoldDelay;

	protected Transform mTrans;

	protected Transform mParent;

	protected Collider mCollider;

	protected UIButton mButton;

	protected UIRoot mRoot;

	protected UIGrid mGrid;

	protected UITable mTable;

	protected int mTouchID;

	protected float mPressTime;

	protected UIDragScrollView mDragScrollView;

	protected virtual void Start()
	{
	}

	private void OnPress(bool isPressed)
	{
	}

	private void OnDragStart()
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	private void OnDragEnd()
	{
	}

	protected virtual void OnDragDropStart()
	{
	}

	protected virtual void OnDragDropMove(Vector3 delta)
	{
	}

	protected virtual void OnDragDropRelease(GameObject surface)
	{
	}
}
