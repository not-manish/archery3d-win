using System;
using System.Collections.Generic;
using UnityEngine;

public class SpringContenSc : MonoBehaviour
{
	public enum OppPhotoType
	{
		DefaultAvatar = 0,
		AtlasAvatar = 1,
		FbIdAvatar = 2
	}

	private const float item_height = 136f;

	private float topLocalY;

	private const float max_speed = 800f;

	private float moveSpeed;

	private const float min_speed = 100f;

	private Transform targetTf;

	private Action finishSpringAction;

	private float targetInitDis;

	private int state;

	private const int state_none = 0;

	private const int state_finding = 1;

	private const int state_slowdown = 2;

	private Texture2D defaultPlayerTex;

	public List<Texture2D> DefaultTexList;

	public List<UITexture> oppPhotoUITex;

	private int nextPhotoIndex;

	private List<OppPhotoType> OppPhotoTypeList;

	private List<object> OppPhotoNameList;

	private const int MaxRealPhotoNum = 30;

	private const float DefaultToReal = 1.5f;

	private void Update()
	{
	}

	private void CheckFinishMove()
	{
	}

	private void ForceYToZero()
	{
	}

	private void SlowDownMoveSpeed()
	{
	}

	private void SetUITexture(UITexture oppUITex)
	{
	}

	public void Init(Action finishAction, Texture2D defaultPlayerTex)
	{
	}

	private void InitTexture()
	{
	}

	private void InitPosition()
	{
	}

	public void MoveItem()
	{
	}

	private void ClipItem()
	{
	}

	private float GetBottomY()
	{
		return 0f;
	}

	public void SetFindOpp()
	{
	}

	public void SetOppoTex(Texture2D targetTex)
	{
	}

	private void GenerateOppPhotos()
	{
	}
}
