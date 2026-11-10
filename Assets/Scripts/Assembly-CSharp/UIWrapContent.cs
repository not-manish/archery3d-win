using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Wrap Content")]
public class UIWrapContent : MonoBehaviour
{
	public int itemSize;

	public bool cullContent;

	private Transform mTrans;

	private UIPanel mPanel;

	private UIScrollView mScroll;

	private bool mHorizontal;

	private BetterList<Transform> mChildren;

	protected virtual void Start()
	{
	}

	protected virtual void OnMove(UIPanel panel)
	{
	}

	[ContextMenu("Sort Based on Scroll Movement")]
	public void SortBasedOnScrollMovement()
	{
	}

	[ContextMenu("Sort Alphabetically")]
	public void SortAlphabetically()
	{
	}

	protected bool CacheScrollView()
	{
		return false;
	}

	private void ResetChildPositions()
	{
	}

	public void WrapContent()
	{
	}

	protected virtual void UpdateItem(Transform item, int index)
	{
	}
}
