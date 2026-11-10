using System.Collections.Generic;
using UnityEngine;

public class ChestOpen_CoinGemMoveAnim : MonoBehaviour
{
	public ChestRewardType openType;

	public List<GameObject> AllEquipCard;

	public List<Vector3> MoveAnimPosition;

	public List<Vector3> MoveAnimScale;

	public List<Vector3> MoveAnimRotate;

	private Vector3 MoveStartBackPosition;

	private Vector3 MoveEndBackPosition;

	private Vector3 MoveEndStartPosition;

	public ParticleSystem particleStar;

	public bool IsPlayStar;

	private float AnimOneTimes;

	public int MoveCount;

	private float time;

	private float MoveEndTime1;

	public int movecount;

	public int Index;

	private Vector3 oldPosition;

	private Vector3 oldScale;

	private Quaternion oldRotation;

	public bool isStartaAnim;

	private CoinGemMoveAnimType coinGemMoveAnimType;

	public bool isPlayMusic;

	public void Show(object Param)
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	public void Hide()
	{
	}

	public void ScaleAnim(float ChangeTime, float TotalTime, Vector3 oldScale = default(Vector3), Vector3 newScale = default(Vector3))
	{
	}

	public void MoveAnim(Vector3 moveAnimPodition = default(Vector3), Vector3 moveAnimEnd = default(Vector3))
	{
	}

	public float LastmoveTime()
	{
		return 0f;
	}

	public Vector3 MoveAnim1(float time, Vector3 moveAnimPosition, Vector3 MoveBackPosition, Vector3 moveAnimEnd)
	{
		return default;
	}

	public void TranslateAnim(Quaternion oldRotation = default(Quaternion), Quaternion newRotation = default(Quaternion))
	{
	}
}
