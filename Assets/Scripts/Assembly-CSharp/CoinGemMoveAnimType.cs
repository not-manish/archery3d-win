using UnityEngine;

public class CoinGemMoveAnimType
{
	public delegate void IsAnimPlayEnd(ChestOpen_CoinGemMoveAnim chestOpen_CoinGemMoveAnim);

	public CallCoinGemMoveAnimFrom callCoinGemMoveAnimFrom;

	public Vector3 rangePositionCenter;

	public int index;

	public int moveAllCount;

	public int quality;

	public IsAnimPlayEnd isAnimPlayEnd;

	public CoinGemMoveAnimType(CallCoinGemMoveAnimFrom _callCoinGemMoveAnimFrom, int _moveAllCount, int _index, Vector3 _rangePositionCenter, IsAnimPlayEnd _IsAnimPlayEnd = null, int _quality = 0)
	{
	}
}
