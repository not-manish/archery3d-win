using UnityEngine;

namespace Pool3D.ZZQJ.Util
{
	public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
	{
		private static T ms_instance;

		public static T Instance => null;

		protected static T Instantiate()
		{
			return null;
		}

		protected virtual void InitSingleton()
		{
		}

		private void Awake()
		{
		}

		public void OnApplicationQuit()
		{
		}
	}
}
