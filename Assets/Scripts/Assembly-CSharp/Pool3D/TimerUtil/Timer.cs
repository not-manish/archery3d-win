namespace Pool3D.TimerUtil
{
	public struct Timer
	{
		public int Id;

		public static Timer Invalid;

		public bool IsActive => false;

		public Timer(int id)
		{
			Id = 0;
		}

		public static Timer Start(float timeSeconds, TimerScheduler.Callback callback, bool loop = false)
		{
			return default;
		}

		public static Timer StartNextFrame(TimerScheduler.Callback callback)
		{
			return default;
		}

		public void Stop()
		{
		}
	}
}
