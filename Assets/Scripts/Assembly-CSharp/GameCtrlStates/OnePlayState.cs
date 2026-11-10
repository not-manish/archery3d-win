namespace GameCtrlStates
{
	internal class OnePlayState : State<GameCtrlEntity>
	{
		private static OnePlayState instance;

		public static OnePlayState Instance => null;

		private OnePlayState()
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
