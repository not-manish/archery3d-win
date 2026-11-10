using UnityEngine;

public class UI_LogoScroll : MonoBehaviour
{
	private enum ScrollState
	{
		Waitting = 0,
		Scrolling = 1
	}

	public Material LogoScroll;

	public UITexture uiTexture;

	public Texture uiFlowTexture;

	private string flashTexName;

	private string MainTexTexName;

	private string FlowColorName;

	public Color FlowColor;

	private Vector2 offset;

	private Vector2 speed;

	private float LeftFloat;

	private float RightFloat;

	private ScrollState curState;

	private float WaitTime;

	private void Awake()
	{
	}

	public void ShowFlow()
	{
	}

	public void Hide()
	{
	}

	private void Update()
	{
	}

	public void ResetScrolling()
	{
	}
}
