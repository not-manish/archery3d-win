public class FlexibleTimeRegulator
{
	private float m_dWaitTime;

	private float m_dStartTime;

	private bool enable;

	public FlexibleTimeRegulator()
	{
	}

	public FlexibleTimeRegulator(FlexibleTimeRegulator copy)
	{
	}

	public bool IsTimeEnd()
	{
		return false;
	}

	public void ReEnableRegulator()
	{
	}

	public void ResetPeriodTime(float waitTime)
	{
	}

	public void DisableRegulator()
	{
	}

	public float GetDuaringTime()
	{
		return 0f;
	}

	public float GetLeftTime()
	{
		return 0f;
	}

	public bool IsTimeEnable()
	{
		return false;
	}
}
