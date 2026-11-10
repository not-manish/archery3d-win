using System.Collections.Generic;
using UnityEngine;

public class UI_TargetPoint : MonoBehaviour
{
	public List<GameObject> MyShootUI;

	public List<GameObject> OppShootUI;

	public Transform CenterTrans;

	public Transform edgeTrans;

	private float length;

	private UITargetPointParam uiTargetParam;

	public void Show(object param)
	{
	}

	public void UpdateTarget(UITargetPointParam _uiParam)
	{
	}

	private void SetPosition(GameObject target, Vector2 relaPos)
	{
	}

	public void Hide()
	{
	}
}
