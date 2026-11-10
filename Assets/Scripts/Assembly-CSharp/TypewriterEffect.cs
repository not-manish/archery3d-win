using UnityEngine;

[RequireComponent(typeof(UILabel))]
[AddComponentMenu("NGUI/Examples/Typewriter Effect")]
public class TypewriterEffect : MonoBehaviour
{
	public int charsPerSecond;

	private UILabel mLabel;

	private string mText;

	private int mOffset;

	private float mNextChar;

	private bool mReset;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}
}
