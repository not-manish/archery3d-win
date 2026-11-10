using UnityEngine;

public class RealTime : MonoBehaviour
{
	private static RealTime mInst;

	private float mRealTime;

	private float mRealDelta;

	public static float time => 0f;

	public static float deltaTime => 0f;

	private static void Spawn()
	{
	}

	private void Update()
	{
	}
}
