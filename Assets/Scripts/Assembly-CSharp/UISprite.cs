using System;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Sprite")]
public class UISprite : UIWidget
{
	public enum Type
	{
		Simple = 0,
		Sliced = 1,
		Tiled = 2,
		Filled = 3,
		Advanced = 4
	}

	public enum FillDirection
	{
		Horizontal = 0,
		Vertical = 1,
		Radial90 = 2,
		Radial180 = 3,
		Radial360 = 4
	}

	public enum AdvancedType
	{
		Invisible = 0,
		Sliced = 1,
		Tiled = 2
	}

	public enum Flip
	{
		Nothing = 0,
		Horizontally = 1,
		Vertically = 2,
		Both = 3
	}

	[SerializeField]
	[HideInInspector]
	private UIAtlas mAtlas;

	[HideInInspector]
	[SerializeField]
	private string mSpriteName;

	[HideInInspector]
	[SerializeField]
	private Type mType;

	[SerializeField]
	[HideInInspector]
	private FillDirection mFillDirection;

	[Range(0f, 1f)]
	[SerializeField]
	[HideInInspector]
	private float mFillAmount;

	[SerializeField]
	[HideInInspector]
	private bool mInvert;

	[HideInInspector]
	[SerializeField]
	private Flip mFlip;

	[HideInInspector]
	[SerializeField]
	private bool mFillCenter;

	[NonSerialized]
	protected UISpriteData mSprite;

	protected Rect mInnerUV;

	protected Rect mOuterUV;

	private bool mSpriteSet;

	public AdvancedType centerType;

	public AdvancedType leftType;

	public AdvancedType rightType;

	public AdvancedType bottomType;

	public AdvancedType topType;

	private static Vector2[] mTempPos;

	private static Vector2[] mTempUVs;

	public virtual Type type
	{
		get
		{
			return Type.Simple;
		}
		set
		{
		}
	}

	public Flip flip
	{
		get
		{
			return Flip.Nothing;
		}
		set
		{
		}
	}

	public override Material material => null;

	public UIAtlas atlas
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string spriteName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool isValid => false;

	[Obsolete("Use 'centerType' instead")]
	public bool fillCenter
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public FillDirection fillDirection
	{
		get
		{
			return FillDirection.Horizontal;
		}
		set
		{
		}
	}

	public float fillAmount
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool invert
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override Vector4 border => default;

	public override int minWidth => 0;

	public override int minHeight => 0;

	public override Vector4 drawingDimensions => default;

	protected virtual Vector4 drawingUVs => default;

	public UISpriteData GetAtlasSprite()
	{
		return null;
	}

	protected void SetAtlasSprite(UISpriteData sp)
	{
	}

	public override void MakePixelPerfect()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	protected void SimpleFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	protected void SlicedFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	protected void TiledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	protected void FilledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	private static bool RadialCut(Vector2[] xy, Vector2[] uv, float fill, bool invert, int corner)
	{
		return false;
	}

	private static void RadialCut(Vector2[] xy, float cos, float sin, bool invert, int corner)
	{
	}

	protected void AdvancedFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	private void FillBuffers(float v0x, float v1x, float v0y, float v1y, float u0x, float u1x, float u0y, float u1y, Color col, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
