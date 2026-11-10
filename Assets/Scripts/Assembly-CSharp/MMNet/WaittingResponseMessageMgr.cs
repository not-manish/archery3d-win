using System.Collections.Generic;

namespace MMNet
{
	public class WaittingResponseMessageMgr
	{
		private Dictionary<long, WaittingResponseMessage> manageMsgs;

		private List<WaittingResponseMessage> nomanageMsgs;

		public void Update()
		{
		}

		public void AddMsg(WaittingResponseMessage msg)
		{
		}

		public void RemoveMsg(WaittingResponseMessage msg)
		{
		}

		public float OnResponse(long transaction_id)
		{
			return 0f;
		}

		private void ClearAll()
		{
		}

		public void Init()
		{
		}

		private bool CheckValid()
		{
			return false;
		}
	}
}
