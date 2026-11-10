namespace GameCtrlStates
{
	internal class InitialState : State<GameCtrlEntity>
	{
		private static InitialState instance;

		public static InitialState Instance => null;

		private InitialState()
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
