using UnityEngine;

public class VelocityTracker
{
	private static int sampleSize;

	public float lastTime;

	private int numSamples;

	private float[] meanX;

	private float[] meanY;

	private float[] meanTime;

	public void Start(float timeStamp)
	{
	}

	public void Update(Vector2 delta, float timeStamp)
	{
	}

	public float GetVelocityX()
	{
		return 0f;
	}

	public float GetVelocityY()
	{
		return 0f;
	}

	private float GetAverage(float[] values, int numSamples)
	{
		return 0f;
	}
}
