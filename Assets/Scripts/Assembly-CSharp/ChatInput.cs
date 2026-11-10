using UnityEngine;

[AddComponentMenu("NGUI/Examples/Chat Input")]
[RequireComponent(typeof(UIInput))]
public class ChatInput : MonoBehaviour
{
	public UITextList textList;

	public bool fillWithDummyData;

	private UIInput mInput;

	private void Start()
	{
	}

	public void OnSubmit()
	{
	}
}
