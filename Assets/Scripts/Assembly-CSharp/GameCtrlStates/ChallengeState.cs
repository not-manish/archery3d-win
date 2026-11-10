namespace GameCtrlStates
{
	internal class ChallengeState : State<GameCtrlEntity>
	{
		private static ChallengeState instance;

		public static ChallengeState Instance => null;

		private ChallengeState()
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
