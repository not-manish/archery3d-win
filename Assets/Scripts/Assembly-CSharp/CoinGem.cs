using System.Collections.Generic;
using UnityEngine;

public class CoinGem
{
	private int CoinGemCount;

	public List<int> MoveTime;

	public List<Dictionary<movePositionValue, MovePositionValue>> MovePosition;

	public List<Dictionary<movePositionValue, MovePositionValue>> MoveScale;

	public List<Dictionary<movePositionValue, MovePositionValue>> MoveRotation;

	public ChestRewardType showAnimType;

	public CallCoinGemMoveAnimFrom callCoinGemMoveAnimFrom;

	public int MoveCount;

	public int quality;

	public Vector3 RangePositionCenter;

	public CoinGem()
	{
	}

	public void SetCoinGemNum(int ShowObjCount)
	{
	}

	public int GetCoinGemNum()
	{
		return 0;
	}

	public CoinGem(int _CoinGemCount, List<Dictionary<movePositionValue, MovePositionValue>> _movePosition, List<Dictionary<movePositionValue, MovePositionValue>> _moveScale, List<Dictionary<movePositionValue, MovePositionValue>> _moveRotation, ChestRewardType _showAnimType, CallCoinGemMoveAnimFrom _callCoinGemMoveAnimFrom = CallCoinGemMoveAnimFrom.OtherUIParam, int _moveCount = 1)
	{
	}

	public List<ChestOpen_CoinGemMoveAnim> GetShowAnimList()
	{
		return null;
	}

	public Dictionary<movePositionValue, MovePositionValue> SetCoinGemValue(movePositionValue _movePositionvalue, MovePositionValue _MovePositionValue)
	{
		return null;
	}

	public static Vector3 GetUIPosByScreen(Transform EndIcon)
	{
		return default;
	}

	public Vector3 GetWorldPosByUI3DCamera(Vector3 StartPosition)
	{
		return default;
	}

	public Vector3 GetWorldPosByUI3DCamera(Transform EndIcon, Camera camera)
	{
		return default;
	}
}
