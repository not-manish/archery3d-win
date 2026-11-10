using System;
using System.Diagnostics;
using UnityEngine;

[AddComponentMenu("NGUI/UI/NGUI Widget")]
[ExecuteInEditMode]
public class UIWidget : UIRect
{
	public enum Pivot
	{
		TopLeft = 0,
		Top = 1,
		TopRight = 2,
		Left = 3,
		Center = 4,
		Right = 5,
		BottomLeft = 6,
		Bottom = 7,
		BottomRight = 8
	}

	public delegate void OnDimensionsChanged();

	public enum AspectRatioSource
	{
		Free = 0,
		BasedOnWidth = 1,
		BasedOnHeight = 2
	}

	public delegate bool HitCheck(Vector3 worldPos);

	[SerializeField]
	[HideInInspector]
	protected Color mColor;

	[HideInInspector]
	[SerializeField]
	protected Pivot mPivot;

	[SerializeField]
	[HideInInspector]
	protected int mWidth;

	[HideInInspector]
	[SerializeField]
	protected int mHeight;

	[SerializeField]
	[HideInInspector]
	protected int mDepth;

	public OnDimensionsChanged onChange;

	public bool autoResizeBoxCollider;

	public bool hideIfOffScreen;

	public AspectRatioSource keepAspectRatio;

	public float aspectRatio;

	public HitCheck hitCheck;

	[NonSerialized]
	public UIPanel panel;

	[NonSerialized]
	public UIGeometry geometry;

	[NonSerialized]
	public bool fillGeometry;

	protected bool mPlayMode;

	protected Vector4 mDrawRegion;

	private Matrix4x4 mLocalToPanel;

	private bool mIsVisibleByAlpha;

	private bool mIsVisibleByPanel;

	private bool mIsInFront;

	private float mLastAlpha;

	private bool mMoved;

	[NonSerialized]
	[HideInInspector]
	public UIDrawCall drawCall;

	protected Vector3[] mCorners;

	private int mAlphaFrameID;

	private int mMatrixFrame;

	private Vector3 mOldV0;

	private Vector3 mOldV1;

	public Vector4 drawRegion
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Vector2 pivotOffset => default;

	public int width
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int height
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Color color
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public override float alpha
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool isVisible => false;

	public bool hasVertices => false;

	public Pivot rawPivot
	{
		get
		{
			return Pivot.TopLeft;
		}
		set
		{
		}
	}

	public Pivot pivot
	{
		get
		{
			return Pivot.TopLeft;
		}
		set
		{
		}
	}

	public int depth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int raycastDepth => 0;

	public override Vector3[] localCorners => null;

	public virtual Vector2 localSize => default;

	public override Vector3[] worldCorners => null;

	public virtual Vector4 drawingDimensions => default;

	public virtual Material material
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual Texture mainTexture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual Shader shader
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Obsolete("There is no relative scale anymore. Widgets now have width and height instead")]
	public Vector2 relativeSize => default;

	public bool hasBoxCollider => false;

	public virtual int minWidth => 0;

	public virtual int minHeight => 0;

	public virtual Vector4 border => default;

	public void SetDimensions(int w, int h)
	{
	}

	public override Vector3[] GetSides(Transform relativeTo)
	{
		return null;
	}

	public override float CalculateFinalAlpha(int frameID)
	{
		return 0f;
	}

	protected void UpdateFinalAlpha(int frameID)
	{
	}

	public override void Invalidate(bool includeChildren)
	{
	}

	public float CalculateCumulativeAlpha(int frameID)
	{
		return 0f;
	}

	public override void SetRect(float x, float y, float width, float height)
	{
	}

	public void ResizeCollider()
	{
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public static int FullCompareFunc(UIWidget left, UIWidget right)
	{
		return 0;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static int PanelCompareFunc(UIWidget left, UIWidget right)
	{
		return 0;
	}

	public Bounds CalculateBounds()
	{
		return default;
	}

	public Bounds CalculateBounds(Transform relativeParent)
	{
		return default;
	}

	public void SetDirty()
	{
	}

	protected void RemoveFromPanel()
	{
	}

	public virtual void MarkAsChanged()
	{
	}

	public UIPanel CreatePanel()
	{
		return null;
	}

	public void CheckLayer()
	{
	}

	public override void ParentHasChanged()
	{
	}

	protected virtual void Awake()
	{
	}

	protected override void OnInit()
	{
	}

	protected virtual void UpgradeFrom265()
	{
	}

	protected override void OnStart()
	{
	}

	protected override void OnAnchor()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}

	protected override void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public bool UpdateVisibility(bool visibleByAlpha, bool visibleByPanel)
	{
		return false;
	}

	public bool UpdateTransform(int frame)
	{
		return false;
	}

	public bool UpdateGeometry(int frame)
	{
		return false;
	}

	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t)
	{
	}

	public virtual void MakePixelPerfect()
	{
	}

	public virtual void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
