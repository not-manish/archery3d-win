namespace GameCtrlStates
{
	public class GlobalPlayerState : State<GameCtrlEntity>
	{
		private static GlobalPlayerState instance;

		public static GlobalPlayerState Instance => null;

		private GlobalPlayerState()
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
