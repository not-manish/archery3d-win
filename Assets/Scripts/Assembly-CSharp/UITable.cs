using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Table")]
public class UITable : UIWidgetContainer
{
	public delegate void OnReposition();

	public enum Direction
	{
		Down = 0,
		Up = 1
	}

	public enum Sorting
	{
		None = 0,
		Alphabetic = 1,
		Horizontal = 2,
		Vertical = 3,
		Custom = 4
	}

	public int columns;

	public Direction direction;

	public Sorting sorting;

	public bool hideInactive;

	public bool keepWithinPanel;

	public Vector2 padding;

	public OnReposition onReposition;

	protected UIPanel mPanel;

	protected bool mInitDone;

	protected bool mReposition;

	protected List<Transform> mChildren;

	[HideInInspector]
	[SerializeField]
	private bool sorted;

	public bool repositionNow
	{
		set
		{
		}
	}

	public List<Transform> children => null;

	protected virtual void Sort(List<Transform> list)
	{
	}

	protected void RepositionVariableSize(List<Transform> children)
	{
	}

	[ContextMenu("Execute")]
	public virtual void Reposition()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void Init()
	{
	}

	protected virtual void LateUpdate()
	{
	}
}
