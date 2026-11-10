using UnityEngine;

public class ChestEffect : MonoBehaviour
{
	public ParticleSystem FallEffect;

	public ParticleSystem notOpenEffect;

	public ParticleSystem OpenEffect;

	public ParticleSystem ShakeEffect;

	public ParticleSystem OpeningEffect;

	public ParticleSystem OpenLightEffect;

	private FlexibleRealTimeRegulator realTimeRegulatorIn;

	public void Show()
	{
	}

	public void Hide(bool isShow = false)
	{
	}

	public void PlayNotOpenEffect()
	{
	}

	public void PlayShakeEffect()
	{
	}

	public void PlayOpenEffect()
	{
	}

	private void Update()
	{
	}

	public void PlayOpenAgainEffect()
	{
	}
}
