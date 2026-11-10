using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Play Sound")]
public class UIPlaySound : MonoBehaviour
{
	public enum Trigger
	{
		OnClick = 0,
		OnMouseOver = 1,
		OnMouseOut = 2,
		OnPress = 3,
		OnRelease = 4,
		Custom = 5
	}

	public AudioClip audioClip;

	public Trigger trigger;

	private bool mIsOver;

	[Range(0f, 1f)]
	public float volume;

	[Range(0f, 2f)]
	public float pitch;

	private bool canPlay => false;

	private void OnHover(bool isOver)
	{
	}

	private void OnPress(bool isPressed)
	{
	}

	private void OnClick()
	{
	}

	private void OnSelect(bool isSelected)
	{
	}

	public void Play()
	{
	}
}
