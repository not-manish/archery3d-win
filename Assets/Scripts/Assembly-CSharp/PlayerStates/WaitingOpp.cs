namespace PlayerStates
{
	internal class WaitingOpp : State<PlayerEntity>
	{
		private static WaitingOpp instance;

		public static WaitingOpp Instance => null;

		private WaitingOpp()
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
