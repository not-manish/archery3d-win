using UnityEngine;

public class UIScoreParam
{
	public UIScoreStates uiScoreState;

	public int intScore;

	public string floatScore;

	public bool ShouldMove;

	public Vector3 MovePosition;

	public PlayerType playerType;

	public UIScoreParam(int _intScore)
	{
	}

	public UIScoreParam(UIScoreStates _uiScoreState, int _intScore = 0, string _floatScore = "", PlayerType _playerType = PlayerType.Myself)
	{
	}

	public void SetMovePosition(Vector3 _MovePosition)
	{
	}
}
