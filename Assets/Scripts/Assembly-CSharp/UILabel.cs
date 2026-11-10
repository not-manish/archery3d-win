using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Label")]
public class UILabel : UIWidget
{
	public enum Effect
	{
		None = 0,
		Shadow = 1,
		Outline = 2
	}

	public enum Overflow
	{
		ShrinkContent = 0,
		ClampContent = 1,
		ResizeFreely = 2,
		ResizeHeight = 3
	}

	public enum Crispness
	{
		Never = 0,
		OnDesktop = 1,
		Always = 2
	}

	public Crispness keepCrispWhenShrunk;

	[HideInInspector]
	[SerializeField]
	private Font mTrueTypeFont;

	[SerializeField]
	[HideInInspector]
	private UIFont mFont;

	[HideInInspector]
	[SerializeField]
	[Multiline(6)]
	private string mText;

	[SerializeField]
	[HideInInspector]
	private int mFontSize;

	[SerializeField]
	[HideInInspector]
	private FontStyle mFontStyle;

	[SerializeField]
	[HideInInspector]
	private NGUIText.Alignment mAlignment;

	[HideInInspector]
	[SerializeField]
	private bool mEncoding;

	[HideInInspector]
	[SerializeField]
	private int mMaxLineCount;

	[HideInInspector]
	[SerializeField]
	private Effect mEffectStyle;

	[SerializeField]
	[HideInInspector]
	private Color mEffectColor;

	[HideInInspector]
	[SerializeField]
	private NGUIText.SymbolStyle mSymbols;

	[HideInInspector]
	[SerializeField]
	private Vector2 mEffectDistance;

	[SerializeField]
	[HideInInspector]
	private Overflow mOverflow;

	[HideInInspector]
	[SerializeField]
	private Material mMaterial;

	[SerializeField]
	[HideInInspector]
	private bool mApplyGradient;

	[HideInInspector]
	[SerializeField]
	private Color mGradientTop;

	[HideInInspector]
	[SerializeField]
	private Color mGradientBottom;

	[HideInInspector]
	[SerializeField]
	private int mSpacingX;

	[HideInInspector]
	[SerializeField]
	private int mSpacingY;

	[SerializeField]
	[HideInInspector]
	private bool mShrinkToFit;

	[SerializeField]
	[HideInInspector]
	private int mMaxLineWidth;

	[SerializeField]
	[HideInInspector]
	private int mMaxLineHeight;

	[HideInInspector]
	[SerializeField]
	private float mLineWidth;

	[SerializeField]
	[HideInInspector]
	private bool mMultiline;

	[NonSerialized]
	private Font mActiveTTF;

	private float mDensity;

	private bool mShouldBeProcessed;

	private string mProcessedText;

	private bool mPremultiply;

	private Vector2 mCalculatedSize;

	private float mScale;

	private int mPrintedSize;

	private int mLastWidth;

	private int mLastHeight;

	private static BetterList<UILabel> mList;

	private static Dictionary<Font, int> mFontUsage;

	private static BetterList<Vector3> mTempVerts;

	private static BetterList<int> mTempIndices;

	private bool shouldBeProcessed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override bool isAnchoredHorizontally => false;

	public override bool isAnchoredVertically => false;

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

	[Obsolete("Use UILabel.bitmapFont instead")]
	public UIFont font
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UIFont bitmapFont
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Font trueTypeFont
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UnityEngine.Object ambigiousFont
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int defaultFontSize => 0;

	public int fontSize
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public FontStyle fontStyle
	{
		get
		{
			return FontStyle.Normal;
		}
		set
		{
		}
	}

	public NGUIText.Alignment alignment
	{
		get
		{
			return NGUIText.Alignment.Automatic;
		}
		set
		{
		}
	}

	public bool applyGradient
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Color gradientTop
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Color gradientBottom
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public int spacingX
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int spacingY
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private bool keepCrisp => false;

	public bool supportEncoding
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public NGUIText.SymbolStyle symbolStyle
	{
		get
		{
			return NGUIText.SymbolStyle.None;
		}
		set
		{
		}
	}

	public Overflow overflowMethod
	{
		get
		{
			return Overflow.ShrinkContent;
		}
		set
		{
		}
	}

	[Obsolete("Use 'width' instead")]
	public int lineWidth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[Obsolete("Use 'height' instead")]
	public int lineHeight
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool multiLine
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override Vector3[] localCorners => null;

	public override Vector3[] worldCorners => null;

	public override Vector4 drawingDimensions => default;

	public int maxLineCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Effect effectStyle
	{
		get
		{
			return Effect.None;
		}
		set
		{
		}
	}

	public Color effectColor
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Vector2 effectDistance
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	[Obsolete("Use 'overflowMethod == UILabel.Overflow.ShrinkContent' instead")]
	public bool shrinkToFit
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string processedText => null;

	public Vector2 printedSize => default;

	public override Vector2 localSize => default;

	private bool isValid => false;

	protected override void OnInit()
	{
	}

	protected override void OnDisable()
	{
	}

	protected void SetActiveFont(Font fnt)
	{
	}

	private static void OnFontTextureChanged()
	{
	}

	public override Vector3[] GetSides(Transform relativeTo)
	{
		return null;
	}

	protected override void UpgradeFrom265()
	{
	}

	protected override void OnAnchor()
	{
	}

	private void ProcessAndRequest()
	{
	}

	protected override void OnStart()
	{
	}

	public override void MarkAsChanged()
	{
	}

	private void ProcessText()
	{
	}

	private void ProcessText(bool legacyMode, bool full)
	{
	}

	public override void MakePixelPerfect()
	{
	}

	public void AssumeNaturalSize()
	{
	}

	[Obsolete("Use UILabel.GetCharacterAtPosition instead")]
	public int GetCharacterIndex(Vector3 worldPos)
	{
		return 0;
	}

	[Obsolete("Use UILabel.GetCharacterAtPosition instead")]
	public int GetCharacterIndex(Vector2 localPos)
	{
		return 0;
	}

	public int GetCharacterIndexAtPosition(Vector3 worldPos)
	{
		return 0;
	}

	public int GetCharacterIndexAtPosition(Vector2 localPos)
	{
		return 0;
	}

	public string GetWordAtPosition(Vector3 worldPos)
	{
		return null;
	}

	public string GetWordAtPosition(Vector2 localPos)
	{
		return null;
	}

	public string GetWordAtCharacterIndex(int characterIndex)
	{
		return null;
	}

	public string GetUrlAtPosition(Vector3 worldPos)
	{
		return null;
	}

	public string GetUrlAtPosition(Vector2 localPos)
	{
		return null;
	}

	public string GetUrlAtCharacterIndex(int characterIndex)
	{
		return null;
	}

	public int GetCharacterIndex(int currentIndex, KeyCode key)
	{
		return 0;
	}

	public void PrintOverlay(int start, int end, UIGeometry caret, UIGeometry highlight, Color caretColor, Color highlightColor)
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	protected Vector2 ApplyOffset(BetterList<Vector3> verts, int start)
	{
		return default;
	}

	private void ApplyShadow(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, int start, int end, float x, float y)
	{
	}

	public int CalculateOffsetToFit(string text)
	{
		return 0;
	}

	public void SetCurrentProgress()
	{
	}

	public void SetCurrentPercent()
	{
	}

	public void SetCurrentSelection()
	{
	}

	public bool Wrap(string text, out string final)
	{
		final = null;
		return false;
	}

	public bool Wrap(string text, out string final, int height)
	{
		final = null;
		return false;
	}

	public void UpdateNGUIText()
	{
	}
}
