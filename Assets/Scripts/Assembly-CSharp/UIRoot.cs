using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Root")]
public class UIRoot : MonoBehaviour
{
	public enum Scaling
	{
		PixelPerfect = 0,
		FixedSize = 1,
		FixedSizeOnMobiles = 2
	}

	public static List<UIRoot> list;

	public Scaling scalingStyle;

	public int manualHeight;

	public int minimumHeight;

	public int maximumHeight;

	public bool adjustByDPI;

	public bool shrinkPortraitUI;

	private Transform mTrans;

	public int activeHeight => 0;

	public float pixelSizeAdjustment => 0f;

	public static float GetPixelSizeAdjustment(GameObject go)
	{
		return 0f;
	}

	public float GetPixelSizeAdjustment(int height)
	{
		return 0f;
	}

	protected virtual void Awake()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void Start()
	{
	}

	private void Update()
	{
	}

	public static void Broadcast(string funcName)
	{
	}

	public static void Broadcast(string funcName, object param)
	{
	}
}
