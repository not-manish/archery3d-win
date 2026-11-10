using UnityEngine;

public class UI_Lock_GameMode : MonoBehaviour
{
	public RenderToTexture GameModerenderToTexture;

	public Camera cam;

	public Rigidbody lockRigidbody;

	public FlexibleRealTimeRegulator m_tTimeRegulator;

	public bool isPlayerUnLockAnim;

	public float AnimShowtime;

	private float time;

	private float BackForce;

	public float xBacktimes;

	public float Xforce;

	public float Yforce;

	public float MaxZForce;

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public RenderTexture GetGameModeLockTexture()
	{
		return null;
	}

	public void DestroyAllTexture()
	{
	}

	public void PlayerUnLockAnim(bool isPlay)
	{
	}

	private void FixedUpdate()
	{
	}
}
