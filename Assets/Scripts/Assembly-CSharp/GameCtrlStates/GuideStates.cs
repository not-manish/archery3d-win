namespace GameCtrlStates
{
	public enum GuideStates
	{
		Init = 0,
		Showing_Welcome = 1,
		Showing_HintPress_Init = 2,
		Showing_HintPress_Waiting = 3,
		Showing_HintPress_Aiming = 4,
		Showing_HintPress_Shooting = 5,
		Showing_HintPress_ShowingScore = 6,
		Showing_HintPress_Retry = 7,
		HitTarget_Init = 8,
		HitTarget_ShowingWind = 9,
		HitTarget_Shooting = 10,
		HitTarget_ShowingScore = 11,
		HitTarget_Shooting_ShowingHasShootNum = 12,
		HitTarget_Retry = 13,
		GreatJob_WaitingToShow = 14,
		GreatJob_Showing = 15,
		GameOver = 16
	}
}
