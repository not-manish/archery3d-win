using System.Collections.Generic;
using UnityEngine;

public class UI_OfflineLevel_Item : MonoBehaviour
{
	private GameObject btSelectLevel;

	public Camera OfflineCamera;

	public GameObject objLock;

	public List<MeshRenderer> mLevelNums;

	public MeshRenderer mLevelLine;

	public MeshRenderer mLeveDownObj;

	public List<MeshRenderer> mLevelStarts;

	private int levelID;

	private bool hasSetScale;

	public string OfflineLevelRewardInfo;

	private GameObject tempObject;

	private UI_OfflineLevel_List uiList;

	private bool HasGetMeshRenderer;

	private float MoveSpeed;

	private Transform tranLine;

	private float v;

	public bool PlayLineAnim;

	public bool ClickEnter;

	public void Show(UI_OfflineLevel_List _uiList, int _levelID)
	{
	}

	public void UpdateState(int _levelID)
	{
	}

	public void SetLevelMaterial(LevelPassStart levelPassStart)
	{
	}

	private void GetMeshRenderer()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void GetClick()
	{
	}

	private void OnClick()
	{
	}

	private void LateUpdate()
	{
	}

	public void Hide(object param)
	{
	}

	public void EnableButtons()
	{
	}

	public void DisableButtons()
	{
	}

	private void ButtonOnClicked(GameObject button)
	{
	}

	public void SetTestOpenChest()
	{
	}

	public void GetRewardResond()
	{
	}

	public void UpdatePlayerInfo()
	{
	}

	public void UpdateRewards()
	{
	}
}
