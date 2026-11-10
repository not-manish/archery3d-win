using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Grid")]
public class UIGrid : UIWidgetContainer
{
	public delegate void OnReposition();

	public enum Arrangement
	{
		Horizontal = 0,
		Vertical = 1
	}

	public enum Sorting
	{
		None = 0,
		Alphabetic = 1,
		Horizontal = 2,
		Vertical = 3,
		Custom = 4
	}

	public Arrangement arrangement;

	public Sorting sorting;

	public UIWidget.Pivot pivot;

	public int maxPerLine;

	public float cellWidth;

	public float cellHeight;

	public bool animateSmoothly;

	public bool hideInactive;

	public bool keepWithinPanel;

	public OnReposition onReposition;

	public BetterList<Transform>.CompareFunc onCustomSort;

	[SerializeField]
	[HideInInspector]
	private bool sorted;

	protected bool mReposition;

	protected UIPanel mPanel;

	protected bool mInitDone;

	public bool repositionNow
	{
		set
		{
		}
	}

	public BetterList<Transform> GetChildList()
	{
		return null;
	}

	public Transform GetChild(int index)
	{
		return null;
	}

	public int GetIndex(Transform trans)
	{
		return 0;
	}

	public void AddChild(Transform trans)
	{
	}

	public void AddChild(Transform trans, bool sort)
	{
	}

	public void AddChild(Transform trans, int index)
	{
	}

	public Transform RemoveChild(int index)
	{
		return null;
	}

	public bool RemoveChild(Transform t)
	{
		return false;
	}

	protected virtual void Init()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void Update()
	{
	}

	public static int SortByName(Transform a, Transform b)
	{
		return 0;
	}

	public static int SortHorizontal(Transform a, Transform b)
	{
		return 0;
	}

	public static int SortVertical(Transform a, Transform b)
	{
		return 0;
	}

	protected virtual void Sort(BetterList<Transform> list)
	{
	}

	[ContextMenu("Execute")]
	public virtual void Reposition()
	{
	}

	public void ConstrainWithinPanel()
	{
	}

	protected void ResetPosition(BetterList<Transform> list)
	{
	}
}
