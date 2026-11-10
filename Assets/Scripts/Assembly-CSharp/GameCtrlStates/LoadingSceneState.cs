namespace GameCtrlStates
{
	internal class LoadingSceneState : State<GameCtrlEntity>
	{
		private static LoadingSceneState instance;

		public static LoadingSceneState Instance => null;

		private LoadingSceneState()
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
