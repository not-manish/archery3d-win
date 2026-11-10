using UnityEngine;

public class RenderToTexture : MonoBehaviour
{
	private RenderTexture renderTexture;

	public int textureSizeWidth;

	public int textureSizeHeight;

	public Camera mRenderCamera;

	public bool enableSquare;

	public void Init()
	{
	}

	public void Init(int _height, int _width, bool enforce = false)
	{
	}

	public void SetTextureSize(int height, int width)
	{
	}

	private void EnableSquare()
	{
	}

	public RenderTexture GetRenderTexture()
	{
		return null;
	}

	public void DestroyTexture()
	{
	}
}
