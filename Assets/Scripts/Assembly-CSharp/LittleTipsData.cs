using UnityEngine;

public class LittleTipsData
{
	public string Tipstring;

	public bool IsTouchHide;

	public Transform TipParent;

	public int Fontsize;

	public Vector3 TipsArrowsPosition;

	public float Width;

	public float Height;

	public bool IsShowOther;

	public LittleTipsData(string tipstring, Transform tipParent, bool _isTouchHide = true, bool _isShowOther = false, Vector3 tipsArrowsPosition = default(Vector3), int Fontsize = 40, float width = 382f, float height = 110f)
	{
	}
}
