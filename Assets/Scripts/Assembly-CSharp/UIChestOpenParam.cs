using System;
using System.Collections.Generic;
using com.simple.proto;

public class UIChestOpenParam
{
	public ChestOpenShowType ChestShowType;

	public ChestOpenType openType;

	public bool NeedRequest;

	public int chest_kind;

	public int chest_id;

	public int chest_classic_index;

	public Action HidePlayAction;

	public List<CCChestReward> ListChestReward;

	public CCChestReward ccChestReward;

	public UIChestOpenParam(ChestOpenType _openType, int _chest_kind, int _chest_id, int _chest_classic_index, List<CCChestReward> _listChestReward = null, Action hidePlayAction = null)
	{
	}

	public UIChestOpenParam(ChestOpenShowType _ChestShowType, ChestOpenType _openType, CCChestReward _chestReward, int _chest_kind, int _chest_id = 0, List<CCChestReward> _listChestReward = null, Action hidePlayAction = null)
	{
	}
}
