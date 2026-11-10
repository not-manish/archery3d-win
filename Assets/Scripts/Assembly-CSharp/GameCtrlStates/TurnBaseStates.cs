namespace GameCtrlStates
{
	public enum TurnBaseStates
	{
		Init = 0,
		ShowGameMode = 1,
		PlayingEntranceAni = 2,
		JudgeTurn = 3,
		WaitingBegin_WaitingOpp = 4,
		ShowingTurnBase = 5,
		MyAiming = 6,
		MyShooting = 7,
		MyWaitingShowScore = 8,
		MyAfterShoot = 9,
		OppAiming = 10,
		OppShooting = 11,
		OppWaitingShowScore = 12,
		OppAfterShoot = 13,
		ShowSetsResult = 14,
		WaitingGameOver = 15,
		GameOver = 16,
		GameOverImmediately = 17
	}
}
