public class DelayEvent : IPoolable
{
	public delegate void Delegate_DelayHandle();

	private static DelayEvent g_Instance;

	public ObjectPool<DelayEvent> pools;

	public Delegate_DelayHandle OnDelay;

	private float time;

	public float delayTime;

	public bool ignoreTimeScale;

	public static DelayEvent Instance()
	{
		return null;
	}

	public DelayEvent()
	{
	}

	public void InitPools()
	{
	}

	private DelayEvent NewDelayEvent()
	{
		return null;
	}

	private DelayEvent(float delayTime)
	{
	}

	public bool Update()
	{
		return false;
	}

	public void IDestory()
	{
	}

	public void IReset()
	{
	}
}
