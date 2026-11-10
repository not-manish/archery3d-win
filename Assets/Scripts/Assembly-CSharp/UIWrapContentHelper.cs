using System.Collections.Generic;
using UnityEngine;

public class UIWrapContentHelper
{
	public delegate void UIWrapContentRenderDelegate(GameObject obj, int index);

	public UIWrapContentRenderDelegate OnRenderEvent;

	private int _count;

	private bool _hasRefresh;

	private UIWrapContentEx _wrapContent;

	private UIPanel _panel;

	private UIScrollView _scrollView;

	private Vector2 _initPanelClipOffset;

	private Vector3 _initPanelLocalPos;

	private Dictionary<GameObject, int> CacheObject2Index;

	private UIWrapContentHelper()
	{
	}

	private UIWrapContentHelper(UIWrapContentEx uiWrapContent)
	{
	}

	public void ResetScroll()
	{
	}

	private void SetCount(int count, bool invertOrder = false)
	{
	}

	private void OnInitItem(GameObject go, int wrapindex, int realindex)
	{
	}

	private bool CheckActive(GameObject go, int index)
	{
		return false;
	}

	private void DoRender(GameObject go, int index)
	{
	}

	public void Refresh(int count, bool invertOrder = false)
	{
	}

	public void CanDragScrollview(bool canDrag)
	{
	}

	public static UIWrapContentHelper Create(UIWrapContentEx uiWrapContent)
	{
		return null;
	}

	public static List<GameObject> GetActiveChilds(Transform parent)
	{
		return null;
	}
}
