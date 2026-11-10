using UnityEngine;

public class UI_TimeProgress : MonoBehaviour
{
	public UISprite sTimeProgress;

	private Color32 GreenColor;

	private Color32 YellowColor;

	private Color32 RedColor;

	private Color32 targetColor;

	private bool isShootTimeEnable;

	private float shootDuration;

	private FlexibleRealTimeRegulator m_tShootTimeRegulator;

	private void Update()
	{
	}

	public void ResetShootingTime(float duration, float timeLeft)
	{
	}

	public void CloseShootingTime(bool isClearProgress)
	{
	}

	public void CloseShootingTime(bool isClearProgress, float duration, float timeLeft)
	{
	}
}
