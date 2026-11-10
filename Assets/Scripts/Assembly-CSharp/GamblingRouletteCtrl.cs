public class GamblingRouletteCtrl
{
	public enum RouletteType
	{
		FreeRoulette = 0,
		PayRoulette = 1,
		FreeGemRoulette = 2
	}

	public const int RoulettePerCount = 12;

	public const float OneRewardAngle = 30f;

	public const string FreeRouletteTime = "FreeRoulette time not end!Please wait next chance.";

	public const string BuyRouletteNot = "Roulette spin not enough!Please buy some spin.";
}
