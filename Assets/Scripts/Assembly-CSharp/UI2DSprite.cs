using UnityEngine;

[AddComponentMenu("NGUI/UI/NGUI Unity2D Sprite")]
[ExecuteInEditMode]
public class UI2DSprite : UIWidget
{
	[SerializeField]
	[HideInInspector]
	private Sprite mSprite;

	[SerializeField]
	[HideInInspector]
	private Material mMat;

	[HideInInspector]
	[SerializeField]
	private Shader mShader;

	public Sprite nextSprite;

	private int mPMA;

	public Sprite sprite2D
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

	public override Texture mainTexture => null;

	public bool premultipliedAlpha => false;

	public override Vector4 drawingDimensions => default;

	public Rect uvRect => default;

	protected override void OnUpdate()
	{
	}

	public override void MakePixelPerfect()
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
