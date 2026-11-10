using DG.Tweening;
using UnityEngine;

public static class UiUtil
{
	private struct Circle
	{
		public int R { get; set; }

		public Vector2 Coord { get; set; }

		public float Dist2Center(int x, int y)
		{
			return 0f;
		}
	}

	private const string LOG_TAG = "UiUtil";

	public static void SetColor(this UIButton btn, Color color)
	{
	}

	public static void SetEnable(this UIButton btn, bool enable)
	{
	}

	public static void SetButtonText(this UIButton btn, string text)
	{
	}

	public static void SetSpriteText(this UISprite spt, string text)
	{
	}

	public static void ScaleSprite(this UISprite sprite, int maxSize)
	{
	}

	private static GameObject LoadUi(string path, string name, Transform parent, int layer)
	{
		return null;
	}

	public static GameObject LoadGo(string path, Transform parent = null)
	{
		return null;
	}

	public static GameObject[] LoadGos(string path, int num, Transform parent = null)
	{
		return null;
	}

	public static void SetActive(bool state, params GameObject[] objs)
	{
	}

	public static Texture2D ScaleTexture(Texture2D originalTexture, int size)
	{
		return null;
	}

	public static Texture2D CutTexture(Texture2D srcTex, int cutRadius)
	{
		return null;
	}

	public static void MirrorDepth(Transform t, int baseDepth, bool includeChildren = true)
	{
	}

	private static void MirrorWidgetDepthRecursively(Transform t, int baseDepth)
	{
	}

	public static void ChangeDepth(Transform t, int baseDepth, int depthToChange, bool includeChildren = true)
	{
	}

	private static void ChangeDepthRecursively(Transform t, int baseDepth, int depthToChange, int recursiveDepth)
	{
	}

	public static Tween TweenAlpha(this UIWidget wgt, float alpha, float duration, Ease ease = Ease.Unset)
	{
		return null;
	}

	public static Tween TweenLocalPos(this UIWidget wgt, Vector3 pos, float duration, Ease ease = Ease.Unset)
	{
		return null;
	}

	public static Tween TweenWorldPos(this UIWidget wgt, Vector3 pos, float duration, Ease ease = Ease.Unset)
	{
		return null;
	}

	public static Tween TweenScale(this UIWidget wgt, float scale, float duration, Ease ease = Ease.Unset)
	{
		return null;
	}

	public static Tween TweenNum(this UILabel label, long beginNum, long endNum, float duration, Ease ease = Ease.Unset)
	{
		return null;
	}

	public static Tween TweenNum(this UILabel label, int beginNum, int endNum, float duration, Ease ease = Ease.Unset)
	{
		return null;
	}
}
