namespace GameCtrlStates
{
	internal class GuideState : State<GameCtrlEntity>
	{
		private int HasShootCount;

		private int lastScore;

		private static GuideState instance;

		public static GuideState Instance => null;

		private GuideState()
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
