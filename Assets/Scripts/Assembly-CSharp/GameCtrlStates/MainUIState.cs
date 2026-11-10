namespace GameCtrlStates
{
	internal class MainUIState : State<GameCtrlEntity>
	{
		private static MainUIState instance;

		public static MainUIState Instance => null;

		private MainUIState()
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
	}
}
