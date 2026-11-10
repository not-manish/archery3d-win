namespace PlayerStates
{
	internal class BeforeShoot : State<PlayerEntity>
	{
		private static BeforeShoot instance;

		public static BeforeShoot Instance => null;

		private BeforeShoot()
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
