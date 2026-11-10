using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Popup List")]
public class UIPopupList : UIWidgetContainer
{
	public enum Position
	{
		Auto = 0,
		Above = 1,
		Below = 2
	}

	public delegate void LegacyEvent(string val);

	public static UIPopupList current;

	private const float animSpeed = 0.15f;

	public UIAtlas atlas;

	public UIFont bitmapFont;

	public Font trueTypeFont;

	public int fontSize;

	public FontStyle fontStyle;

	public string backgroundSprite;

	public string highlightSprite;

	public Position position;

	public List<string> items;

	public Vector2 padding;

	public Color textColor;

	public Color backgroundColor;

	public Color highlightColor;

	public bool isAnimated;

	public bool isLocalized;

	public List<EventDelegate> onChange;

	[SerializeField]
	[HideInInspector]
	private string mSelectedItem;

	private UIPanel mPanel;

	private GameObject mChild;

	private UISprite mBackground;

	private UISprite mHighlight;

	private UILabel mHighlightedLabel;

	private List<UILabel> mLabelList;

	private float mBgBorder;

	[HideInInspector]
	[SerializeField]
	private GameObject eventReceiver;

	[SerializeField]
	[HideInInspector]
	private string functionName;

	[SerializeField]
	[HideInInspector]
	private float textScale;

	[HideInInspector]
	[SerializeField]
	private UIFont font;

	[HideInInspector]
	[SerializeField]
	private UILabel textLabel;

	private LegacyEvent mLegacyEvent;

	private bool mUseDynamicFont;

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

	[Obsolete("Use EventDelegate.Add(popup.onChange, YourCallback) instead, and UIPopupList.current.value to determine the state")]
	public LegacyEvent onSelectionChange
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool isOpen => false;

	public string value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Obsolete("Use 'value' instead")]
	public string selection
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private bool handleEvents
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool isValid => false;

	private int activeFontSize => 0;

	private float activeFontScale => 0f;

	protected void TriggerCallbacks()
	{
	}

	private void OnEnable()
	{
	}

	private void OnValidate()
	{
	}

	private void Start()
	{
	}

	private void OnLocalize()
	{
	}

	private void Highlight(UILabel lbl, bool instant)
	{
	}

	private void OnItemHover(GameObject go, bool isOver)
	{
	}

	private void Select(UILabel lbl, bool instant)
	{
	}

	private void OnItemPress(GameObject go, bool isPressed)
	{
	}

	private void OnKey(KeyCode key)
	{
	}

	private void OnSelect(bool isSelected)
	{
	}

	public void Close()
	{
	}

	private void AnimateColor(UIWidget widget)
	{
	}

	private void AnimatePosition(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	private void AnimateScale(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	private void Animate(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	private void OnClick()
	{
	}
}
