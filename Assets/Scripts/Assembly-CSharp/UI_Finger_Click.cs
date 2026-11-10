using UnityEngine;

public class UI_Finger_Click : MonoBehaviour
{
	public GameObject oFingerClick;

	public GameObject oFinger;

	public ParticleSystem ClickParticle1;

	public ParticleSystem ClickParticle2;

	public UI_AnimationCtrl uiClickAnimationCtrl;

	public FingerClickData fingerClickData;

	public void Show(object param)
	{
	}

	public void Hide(object param)
	{
	}

	public void ShowFingerClick()
	{
	}

	public void ShowFingerClick(Vector3 position, int PanelDepth)
	{
	}

	public void SetEffectActive(bool isActive)
	{
	}

	public void HideFingerTouch()
	{
	}

	public bool isShowing()
	{
		return false;
	}
}
