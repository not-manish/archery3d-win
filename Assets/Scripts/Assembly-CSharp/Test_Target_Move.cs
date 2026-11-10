using UnityEngine;

public class Test_Target_Move : MonoBehaviour
{
	private MoveDir moveDir;

	public MoveObjType MoveObjType;

	public Transform MoveMaxObj;

	public Transform MoveMinObj;

	public Vector3 minPosition;

	public Vector3 maxPosition;

	public bool isBack;

	public Vector3 StartRotation;

	public Vector3 EndRotation;

	public float Speed;

	public bool isReset;

	public bool isStartMove;

	public bool isStop;

	private Vector3 OldPosition;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SelfMove()
	{
	}
}
