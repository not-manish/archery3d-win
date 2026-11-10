using System.Collections.Generic;
using UnityEngine;

namespace Pool3D.TimerUtil
{
	public sealed class TimerScheduler : MonoBehaviour
	{
		private struct TimerData
		{
			public Callback Callback;

			public float Duration;

			public bool Loop;

			public int Id;

			public TimerData(float time, Callback callback, bool loop, int id)
			{
				Callback = null;
				Duration = 0f;
				Loop = false;
				Id = 0;
			}
		}

		private struct TimerIdPair
		{
			public int Id;

			public int KeyTime;
		}

		public delegate void Callback();

		private PriorityQueue<int, TimerData> timers;

		private List<TimerData> deferredTimers;

		private List<TimerIdPair> activeTimers;

		private int nextTimerId;

		private static TimerScheduler _instance;

		private float tmpTime;

		public static TimerScheduler Instance => null;

		private void Awake()
		{
		}

		private int GetKeyTime(float time)
		{
			return 0;
		}

		private bool HasKeyTimePassed(int key)
		{
			return false;
		}

		private int AddTimer(TimerData timer, bool deferred = false)
		{
			return 0;
		}

		private int GetActiveTimerIndex(int timerId)
		{
			return 0;
		}

		private bool RemoveActiveTimer(int timerId)
		{
			return false;
		}

		private int GetTimerDeferredIndex(int timerId)
		{
			return 0;
		}

		private void AddDeferredTimers()
		{
		}

		private void Update()
		{
		}

		public Timer StartTimer(float timeSeconds, Callback callback, bool loop = false, bool deferred = false)
		{
			return default;
		}

		public void StopTimer(Timer timerId)
		{
		}

		public bool IsTimerActive(Timer timerId)
		{
			return false;
		}

		private void OnDestroy()
		{
		}
	}
}
