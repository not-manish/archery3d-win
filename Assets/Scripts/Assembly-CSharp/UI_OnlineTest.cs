using UnityEngine;

public class UI_OnlineTest : MonoInstance<UI_OnlineTest>, UIBase
{
	public UISprite sWindAngle;

	public UILabel lWindSpeed;

	public UIButton bPause;

	public UILabel lScore1;

	public UILabel lScore2;

	public UILabel lCurScore;

	public UI_AnimationCtrl aniCruScore;

	public UILabel lTurnHints;

	public UI_AnimationCtrl aniTurnHints;

	private bool hasSetScale;

	private bool buttonEnable;

	private void Start()
	{
	}

	public void Show(object param)
	{
	}

	public void Hide(object param)
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	public void KeyEscapeClicked()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void OnPressScreen(bool press)
	{
	}

	public void OnTouchScreen(Vector2 pos)
	{
	}

	public void UpdateWind()
	{
	}

	public void SetPlayer1Score(int Score)
	{
	}

	public void SetPlayer2Score(int Score)
	{
	}

	public void ShowCurScore(int score)
	{
	}

	public void ShowTurnHints(bool isMyTurn)
	{
	}

	public void ShowWinHints(GameResultType result)
	{
	}

	public void UpdateScore()
	{
	}
}
