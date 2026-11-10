using System.Collections.Generic;
using UnityEngine;

public class TargetManage : MonoBehaviour
{
	private bool IsShareTarget;

	public static bool HasUnnormalTarget;

	public static int TargetDistance;

	private int MyTargetId;

	[HideInInspector]
	public List<TargetCarrier> targetMy;

	[HideInInspector]
	public List<TargetCarrier> targetOpp;

	public void LoadTarget(GameType gameType, int levelID, int levelIndex, PlayerStandPart playerStandPart)
	{
	}

	public void LoadTargets(PlayerStandPart playerStandPart, bool shareTarget, int leftTargetId, int rightTargetId)
	{
	}

	public TargetCarrier LoadTargetCarrier(int carrierID, int severStartId, int scene_pos_type, bool isLoadNotShoot = false)
	{
		return null;
	}

	public void RecoverAllTarget()
	{
	}

	public void SynchroServeTarget(List<int> myServeIDs, List<int> oppServeIDs)
	{
	}

	public void DeleteTargetFromServeId(List<int> targetServeIDs)
	{
	}

	public bool IsPlayerTarget(bool isMyself, TargetCtrl targetCtrl)
	{
		return false;
	}

	public void GetNotShootTarget(bool isMyself)
	{
	}

	public void DestroyTarget(TargetCtrl targetCtrl)
	{
	}

	public void HideTarget(TargetCtrl targetCtrl)
	{
	}

	public void ShowTarget(TargetCtrl targetCtrl)
	{
	}

	public List<TargetCtrl> GetAllTargets(bool isMyself)
	{
		return null;
	}

	public float GetTargetMaxZ(bool isMyself)
	{
		return 0f;
	}

	public List<TargetCtrl> GetSortedTargets(bool isMyself)
	{
		return null;
	}

	public TargetCtrl GetTargetCtrlByServeID(int serveID)
	{
		return null;
	}

	public bool ShootTargetIsRight(int serveID, PlayerType isMyself)
	{
		return false;
	}

	public void ShowShouldShootTarget(List<int> ShowLightCount, bool isShowOrHide)
	{
	}

	public void ResetMove()
	{
	}

	public void ResumeMove()
	{
	}

	public void PauseMove()
	{
	}

	public void SetAllTargetsPos(float targetTime)
	{
	}

	private void GetAppearDisapperTargetCarrier(ref List<TargetCarrier> appearCarriers, ref List<TargetCarrier> disappearCarriers, List<int> ScoreList, Dictionary<int, int> targetIdScores, bool isMySelf)
	{
	}

	public void UpdateTargetCarrierActive(TargetCarrierActiveType activeType, List<int> ScoreList, Dictionary<int, int> targetIdScores, bool isMySelf)
	{
	}

	public void UpdateTargetDistance()
	{
	}

	public void UpdateUIDistance(PvpType pvpType, string TargetDistance)
	{
	}

	private void DebugDictionary(Dictionary<int, int> Dic)
	{
	}

	private int GetCarrierIdFromTargetId(int targetId)
	{
		return 0;
	}
}
