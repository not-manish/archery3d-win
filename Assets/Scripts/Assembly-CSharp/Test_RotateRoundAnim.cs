using UnityEngine;

public class Test_RotateRoundAnim : MonoBehaviour
{
	public GameObject targetObj;

	public Vector3 targetPosition;

	public Vector3 MoveDirection;

	public float Speed;

	public bool isReset;

	public bool isStartMove;

	public float MaxAngle;

	private float MoveAngle;

	private Vector3 oldPosition;

	private Quaternion OldRotation;

	private Vector3 OldScale;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void RotateAround(Vector3 point, Vector3 axis, float angle)
	{
	}
}
