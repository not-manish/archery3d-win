using System;
using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Alpha")]
public class TweenAlpha : UITweener
{
	[Range(0f, 1f)]
	public float from;

	[Range(0f, 1f)]
	public float to;

	private UIRect mRect;

	public UIRect cachedRect => null;

	[Obsolete("Use 'value' instead")]
	public float alpha
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float value
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenAlpha Begin(GameObject go, float duration, float alpha)
	{
		return null;
	}

	public override void SetStartToCurrentValue()
	{
	}

	public override void SetEndToCurrentValue()
	{
	}
}
