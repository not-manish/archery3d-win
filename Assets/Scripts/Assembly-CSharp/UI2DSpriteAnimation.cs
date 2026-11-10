using UnityEngine;

public class UI2DSpriteAnimation : MonoBehaviour
{
	public int framerate;

	public bool ignoreTimeScale;

	public Sprite[] frames;

	private SpriteRenderer mUnitySprite;

	private UI2DSprite mNguiSprite;

	private int mIndex;

	private float mUpdate;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
