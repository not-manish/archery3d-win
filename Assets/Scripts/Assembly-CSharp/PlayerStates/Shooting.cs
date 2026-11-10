namespace PlayerStates
{
	internal class Shooting : State<PlayerEntity>
	{
		private float PullBowRatio;

		private static Shooting instance;

		public static Shooting Instance => null;

		private Shooting()
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
