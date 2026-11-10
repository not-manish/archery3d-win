using UnityEngine;

[RequireComponent(typeof(UIWidget))]
[AddComponentMenu("NGUI/Examples/Envelop Content")]
public class EnvelopContent : MonoBehaviour
{
	public Transform targetRoot;

	public int padLeft;

	public int padRight;

	public int padBottom;

	public int padTop;

	private void Start()
	{
	}

	[ContextMenu("Execute")]
	public void Execute()
	{
	}
}
