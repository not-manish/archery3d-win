namespace PlayerStates
{
	internal class OppShooting : State<PlayerEntity>
	{
		private static OppShooting instance;

		public static OppShooting Instance => null;

		private OppShooting()
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
