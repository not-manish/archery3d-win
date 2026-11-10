using UnityEngine;

public class CameraMove : MonoBehaviour
{
	private enum MoveDirection
	{
		Null = 0,
		MoveToX = 1,
		MoveToY = 2
	}

	private enum MoveValue
	{
		Null = 0,
		MoveToAddX = 1,
		MoveToDelX = 2,
		MoveToAddY = 3,
		MoveToDelY = 4
	}

	public UI_Equip_Model_AnimCtrl uiEquipModelAnimCtrl;

	public Transform ShowEquipMoveY;

	public Transform ShowEquipParentAll;

	public Transform ShowEquipParentSingle;

	private float scaleFactor;

	public float FieldOfView;

	public float maxFieldOfView;

	private float minFieldOfView;

	public float maxDistance;

	public float minDistance;

	private Vector2 oldPosition1;

	private Vector2 oldPosition2;

	private Vector2 lastSingleTouchPosition;

	private Vector3 m_CameraOffset;

	private Camera m_Camera;

	public bool useMouse;

	public float xMin;

	public float xMax;

	public float zMin;

	public float zMax;

	private bool m_IsSingleFinger;

	private CameraMoveCtrlType cameraMoveCtrlType;

	private MoveDirection moveDirection;

	private float xSpeed;

	private float ySpeed;

	private int yMinLimit;

	private int yMaxLimit;

	private float x;

	private float y;

	private Transform MoveParent;

	private UI_Equip_Handle uiEquipHandle;

	public static bool isFingerMover;

	private bool isCtrlDown;

	private bool isCtrling;

	private Vector3 RotateSpeedX;

	private Vector3 RotateSpeedY;

	public void Show(UI_Equip_Handle _uiEquipHandle, object Param)
	{
	}

	private void Update()
	{
	}

	private void ScaleCamera()
	{
	}

	private MoveValue GetMoveDirection(Vector3 scenePos)
	{
		return MoveValue.Null;
	}

	private void MoveCamera(Vector3 scenePos)
	{
	}

	private static float ClampAngle(float angle, float min, float max)
	{
		return 0f;
	}
}
