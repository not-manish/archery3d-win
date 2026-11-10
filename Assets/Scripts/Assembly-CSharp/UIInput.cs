using System;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/UI/Input Field")]
public class UIInput : MonoBehaviour
{
	public enum InputType
	{
		Standard = 0,
		AutoCorrect = 1,
		Password = 2
	}

	public enum Validation
	{
		None = 0,
		Integer = 1,
		Float = 2,
		Alphanumeric = 3,
		Username = 4,
		Name = 5
	}

	public enum KeyboardType
	{
		Default = 0,
		ASCIICapable = 1,
		NumbersAndPunctuation = 2,
		URL = 3,
		NumberPad = 4,
		PhonePad = 5,
		NamePhonePad = 6,
		EmailAddress = 7
	}

	public enum OnReturnKey
	{
		Default = 0,
		Submit = 1,
		NewLine = 2
	}

	public delegate char OnValidate(string text, int charIndex, char addedChar);

	public static UIInput current;

	public static UIInput selection;

	public UILabel label;

	public InputType inputType;

	public OnReturnKey onReturnKey;

	public KeyboardType keyboardType;

	public Validation validation;

	public int characterLimit;

	public string savedAs;

	public GameObject selectOnTab;

	public Color activeTextColor;

	public Color caretColor;

	public Color selectionColor;

	public List<EventDelegate> onSubmit;

	public List<EventDelegate> onChange;

	public OnValidate onValidate;

	[HideInInspector]
	[SerializeField]
	protected string mValue;

	protected string mDefaultText;

	protected Color mDefaultColor;

	protected float mPosition;

	protected bool mDoInit;

	protected UIWidget.Pivot mPivot;

	protected bool mLoadSavedValue;

	protected static int mDrawStart;

	protected static TouchScreenKeyboard mKeyboard;

	private string mCached;

	public string defaultText
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Obsolete("Use UIInput.value instead")]
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

	[Obsolete("Use UIInput.isSelected instead")]
	public bool selected
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isSelected
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int cursorPosition
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int selectionStart
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int selectionEnd
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public UITexture caret => null;

	public string Validate(string val)
	{
		return null;
	}

	private void Start()
	{
	}

	protected void Init()
	{
	}

	protected void SaveToPlayerPrefs(string val)
	{
	}

	protected virtual void OnSelect(bool isSelected)
	{
	}

	protected void OnSelectEvent()
	{
	}

	protected void OnDeselectEvent()
	{
	}

	private void Update()
	{
	}

	public void Submit()
	{
	}

	public void UpdateLabel()
	{
	}

	protected void SetPivotToLeft()
	{
	}

	protected void SetPivotToRight()
	{
	}

	protected void RestoreLabelPivot()
	{
	}

	protected char Validate(string text, int pos, char ch)
	{
		return '\0';
	}

	protected void ExecuteOnChange()
	{
	}

	public void RemoveFocus()
	{
	}

	public void SaveValue()
	{
	}

	public void LoadValue()
	{
	}
}
