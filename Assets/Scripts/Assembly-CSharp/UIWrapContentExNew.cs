using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Wrap Content Ex New")]
public class UIWrapContentExNew : MonoBehaviour
{
	public delegate void OnInitializeItem(GameObject go, int wrapIndex, int realIndex);

	public bool cullContent;

	public int minIndex;

	public int maxIndex;

	public Dictionary<int, Vector2> AllChildItemArea;

	public Dictionary<float, int> ChildRealIndex;

	public List<float> ChildRealPosition;

	private List<int> ScrollItemView;

	private int TotalScrollView;

	public bool wrapInCircle;

	public OnInitializeItem onInitializeItem;

	protected Transform mTrans;

	protected UIPanel mPanel;

	protected UIScrollView mScroll;

	protected bool mHorizontal;

	protected bool mFirstTime;

	protected List<Transform> mChildren;

	private Vector2 _initPanelClipOffset;

	private Vector3 _initPanelLocalPos;

	private Vector2 GetPanelClipOffset;

	private Vector3 GetPanelLocalPos;

	private Dictionary<GameObject, int> CacheObject2Index;

	private bool isStart;

	private bool isFirstInit;

	private int GetTotalScrollView(bool isDown = true)
	{
		return 0;
	}

	public float itemSize(int index)
	{
		return 0f;
	}

	public int itemRealIndex(float Position)
	{
		return 0;
	}

	public float GetItemRealPosition(int index)
	{
		return 0f;
	}

	protected virtual void Start()
	{
	}

	public void Init(int minIndex, int maxIndex)
	{
	}

	public void ResetScroll()
	{
	}

	protected virtual void OnMove(UIPanel panel)
	{
	}

	public virtual void SortBasedOnScrollMovement()
	{
	}

	[ContextMenu("Sort Based on Scroll Movement")]
	public virtual void SortBasedOnScrollMovementEdit()
	{
	}

	public virtual void SortAlphabetically()
	{
	}

	protected bool CacheScrollView()
	{
		return false;
	}

	protected virtual void ResetChildPositions()
	{
	}

	protected virtual void ResetChildPositions(int Count)
	{
	}

	private void UpdateContent()
	{
	}

	public virtual void WrapContent()
	{
	}

	private void OnValidate()
	{
	}

	protected virtual void UpdateItem(Transform item, int index)
	{
	}

	public int GetCount()
	{
		return 0;
	}

	public Transform GetItemTf(int index)
	{
		return null;
	}

	[ContextMenu("adjustWrapPos")]
	public void adjustWrapPos()
	{
	}
}
