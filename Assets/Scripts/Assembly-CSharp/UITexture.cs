using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Texture")]
public class UITexture : UIWidget
{
	public enum Flip
	{
		Nothing = 0,
		Horizontally = 1,
		Vertically = 2,
		Both = 3
	}

	[HideInInspector]
	[SerializeField]
	private Rect mRect;

	[HideInInspector]
	[SerializeField]
	private Texture mTexture;

	[HideInInspector]
	[SerializeField]
	private Material mMat;

	[HideInInspector]
	[SerializeField]
	private Shader mShader;

	[SerializeField]
	[HideInInspector]
	private Flip mFlip;

	private int mPMA;

	public override Texture mainTexture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override Material material
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override Shader shader
	{
		get
		{
			return null;
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

	public bool premultipliedAlpha => false;

	public Rect uvRect
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public override Vector4 drawingDimensions => default;

	public override void MakePixelPerfect()
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
