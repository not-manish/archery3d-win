namespace PlayerStates
{
	public class GlobalPlayerState : State<PlayerEntity>
	{
		private static GlobalPlayerState instance;

		public static GlobalPlayerState Instance => null;

		private GlobalPlayerState()
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
