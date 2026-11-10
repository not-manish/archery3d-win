using UnityEngine;

public class UI_ChongCi_SumTimeLeft : MonoBehaviour
{
	public UILabel lTimeLeft;

	private bool isShootTimeEnable;

	private float shootDuration;

	private FlexibleRealTimeRegulator m_tShootTimeRegulator;

	private void Update()
	{
	}

	public void ResetSumTimeLeft(float duration, float timeLeft)
	{
	}

	public void CloseSumTimeLeft(bool isClearProgress, float duration, float timeLeft)
	{
	}
}
