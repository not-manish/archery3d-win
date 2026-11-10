using UnityEngine;

public class UI_AimCircleCtrl : MonoBehaviour
{
	public Camera uiCamera;

	public UISprite sFront;

	public UISprite sBack;

	private float FovMin;

	private float BackMin;

	private float FovMax;

	private float BackMax;

	private Vector3 BlueColor;

	private Vector3 YellowColor;

	private Vector3 RedColor;

	private UIAimCircleCtrlParam uiParam;

	private Transform targetTran;

	private Vector3 targetColor;

	private float realTimeStartTime;

	public void Show(object _uiParam)
	{
	}

	public void Hide()
	{
	}

	private void Update()
	{
	}
}
