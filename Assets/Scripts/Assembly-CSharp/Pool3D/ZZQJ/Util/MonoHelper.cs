using System.Collections;
using System.Runtime.CompilerServices;

namespace Pool3D.ZZQJ.Util
{
	public class MonoHelper : MonoSingleton<MonoHelper>
	{
		[CompilerGenerated]
		private MonoUpdaterEvent m_UpdateEvent;

		[CompilerGenerated]
		private MonoUpdaterEvent m_FixedUpdateEvent;

		private event MonoUpdaterEvent UpdateEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private event MonoUpdaterEvent FixedUpdateEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static void AddUpdateListener(MonoUpdaterEvent listener)
		{
		}

		public static void RemoveUpdateListener(MonoUpdaterEvent listener)
		{
		}

		public static void AddFixedUpdateListener(MonoUpdaterEvent listener)
		{
		}

		public static void RemoveFixedUpdateListener(MonoUpdaterEvent listener)
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		public new static void StartCoroutine(IEnumerator routine)
		{
		}
	}
}
