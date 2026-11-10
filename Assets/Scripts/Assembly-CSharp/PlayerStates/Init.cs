namespace PlayerStates
{
	internal class Init : State<PlayerEntity>
	{
		private static Init instance;

		public static Init Instance => null;

		private Init()
		{
		}

		public override void Enter(PlayerEntity player)
		{
		}

		public override void Execute(PlayerEntity player)
		{
		}

		public override void Exit(PlayerEntity player)
		{
		}

		public override bool OnMessage(PlayerEntity player, Telegram telegram)
		{
			return false;
		}
	}
}
