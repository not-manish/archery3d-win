using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Wrap Content Ex")]
public class UIWrapContentEx : MonoBehaviour
{
	public delegate void OnInitializeItem(GameObject go, int wrapIndex, int realIndex);

	public int itemSize;

	public bool cullContent;

	public int minIndex;

	public int maxIndex;

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

	private bool isGetMaxSize;

	private Vector2 ViewSize;

	public float GetItemSize()
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

	public void ShowElementByIndex(int index)
	{
	}

	public void SetLocalPosition(GameObject obj, Vector3 NewLocalPosition, float Value, string direction = "x")
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

	public void UpdareData()
	{
	}

	public virtual void WrapContentNew()
	{
	}

	public virtual void WrapContent()
	{
	}

	public virtual void RestWrapContent(bool _allWithinRange)
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

	public Vector2 getMinSpringPos()
	{
		return default;
	}

	public Vector2 getMaxSpringPos()
	{
		return default;
	}

	public bool couldSpringBack()
	{
		return false;
	}

	public bool couldSpringForward()
	{
		return false;
	}

	public void RoundSpringLimit(ref Vector3 pos)
	{
	}

	public int getRealIndex(Vector3 localPos)
	{
		return 0;
	}

	[ContextMenu("adjustWrapPos")]
	public void adjustWrapPos()
	{
	}

	public int getIndexWithLocalPos(Vector3 localPos)
	{
		return 0;
	}

	public int getIndexWithRealIndex(int realIndex)
	{
		return 0;
	}

	public Vector3 getRealShouldPos(int realIndex)
	{
		return default;
	}

	public Vector3 getRealIndexShouldSpringPOS(int realIndex)
	{
		return default;
	}

	public void WrapChildPosWithRealIndex(int realIndex)
	{
	}

	public void RefreshChildData()
	{
	}

	public ItemShowType isMyItemInVisibleArea(int index, bool isInRank = false)
	{
		return ItemShowType.Top;
	}

	public void GetMyPanel(ref UIPanel movePanel, ref Vector2 InitPanelClipOffset, ref Vector3 InitPanelLocalPos)
	{
	}

	public Vector3 ScrollToMyItem(int index)
	{
		return default;
	}

	public Vector2 MaxViewSize()
	{
		return default;
	}
}
