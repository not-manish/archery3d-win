namespace GameCtrlStates
{
	internal class ChongCiState : State<GameCtrlEntity>
	{
		private float loadWaitingTime;

		private float loadReceiveTime;

		private bool loadAssetSuccess;

		private float gameTimeOverWaitingTime;

		private float gameTimeOverReceiveTime;

		private float loadShootOffTime;

		private static ChongCiState instance;

		public static ChongCiState Instance => null;

		private ChongCiState()
		{
		}

		public override void Enter(GameCtrlEntity entity)
		{
		}

		public override void Execute(GameCtrlEntity entity)
		{
		}

		public override void Exit(GameCtrlEntity entity)
		{
		}

		public override bool OnMessage(GameCtrlEntity entity, Telegram telegram)
		{
			return false;
		}

		public bool IsGameStateOvering(GameCtrlEntity entity)
		{
			return false;
		}
	}
}
