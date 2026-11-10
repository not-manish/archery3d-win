namespace GameCtrlStates
{
	internal class TurnBaseState : State<GameCtrlEntity>
	{
		private float showTurnTime;

		private float camMoveTime;

		private float loadShootOffTime;

		private static TurnBaseState instance;

		public static TurnBaseState Instance => null;

		private TurnBaseState()
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
