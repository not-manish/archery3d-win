using System.Collections.Generic;
using UnityEngine;

public class UI_PanDian_Trophy : MonoBehaviour
{
	public UISprite[] player1Trophys;

	public UISprite[] player2Trophys;

	public UISprite[] player1EmptyTrophys;

	public UISprite[] player2EmptyTrophys;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	private List<TrophyState> leftTrophy;

	private List<TrophyState> rightTrophy;

	public void ShowEmptyStar(bool isMyLeft)
	{
	}

	private void Update()
	{
	}

	public void PlayStarAnim(UIStarParam PandianStar)
	{
	}

	public void UpdateTrophy(PvpType gameType, PlayerStandPart myStandPart, bool isShowStartAnim = false)
	{
	}

	public Vector3 MoveAnimPosition(Vector3 position)
	{
		return default;
	}

	public void ShowRealStar(List<TrophyState> _leftTrophy, List<TrophyState> _rightTrophy)
	{
	}
}
