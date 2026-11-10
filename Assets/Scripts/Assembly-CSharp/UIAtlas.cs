using System;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/UI/Atlas")]
public class UIAtlas : MonoBehaviour
{
	[Serializable]
	private class Sprite
	{
		public string name;

		public Rect outer;

		public Rect inner;

		public bool rotated;

		public float paddingLeft;

		public float paddingRight;

		public float paddingTop;

		public float paddingBottom;

		public bool hasPadding => false;
	}

	private enum Coordinates
	{
		Pixels = 0,
		TexCoords = 1
	}

	[SerializeField]
	[HideInInspector]
	private Material material;

	[HideInInspector]
	[SerializeField]
	private List<UISpriteData> mSprites;

	[HideInInspector]
	[SerializeField]
	private float mPixelSize;

	[HideInInspector]
	[SerializeField]
	private UIAtlas mReplacement;

	[SerializeField]
	[HideInInspector]
	private Coordinates mCoordinates;

	[HideInInspector]
	[SerializeField]
	private List<Sprite> sprites;

	private int mPMA;

	public Material spriteMaterial
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool premultipliedAlpha => false;

	public List<UISpriteData> spriteList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Texture texture => null;

	public float pixelSize
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public UIAtlas replacement
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UISpriteData GetSprite(string name)
	{
		return null;
	}

	public void SortAlphabetically()
	{
	}

	public BetterList<string> GetListOfSprites()
	{
		return null;
	}

	public BetterList<string> GetListOfSprites(string match)
	{
		return null;
	}

	private bool References(UIAtlas atlas)
	{
		return false;
	}

	public static bool CheckIfRelated(UIAtlas a, UIAtlas b)
	{
		return false;
	}

	public void MarkAsChanged()
	{
	}

	private bool Upgrade()
	{
		return false;
	}
}
