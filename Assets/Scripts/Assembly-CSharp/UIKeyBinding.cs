using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Key Binding")]
public class UIKeyBinding : MonoBehaviour
{
	public enum Action
	{
		PressAndClick = 0,
		Select = 1
	}

	public enum Modifier
	{
		None = 0,
		Shift = 1,
		Control = 2,
		Alt = 3
	}

	public KeyCode keyCode;

	public Modifier modifier;

	public Action action;

	private bool mIgnoreUp;

	private bool mIsInput;

	private void Start()
	{
	}

	private void OnSubmit()
	{
	}

	private bool IsModifierActive()
	{
		return false;
	}

	private void Update()
	{
	}
}
