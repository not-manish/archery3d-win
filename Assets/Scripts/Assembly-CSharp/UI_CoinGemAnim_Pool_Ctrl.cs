using System.Collections.Generic;
using UnityEngine;

public class UI_CoinGemAnim_Pool_Ctrl : MonoBehaviour
{
	public GoldParticleSc GoldAnimOne;

	public GoldParticleSc GemAnimOne;

	private List<GoldParticleSc> GoldAnimPoolList;

	private List<GoldParticleSc> GemAnimPoolList;

	private List<GoldParticleSc> AniCtrlList;

	private void Awake()
	{
	}

	public bool GenerateCoinGemAnimBroken(ChestRewardType chestRewardType, CoinGemAnimCtrData CoinGemAnimCtrData, CoinGemType coinGemType, bool havePlayEndAnim = false)
	{
		return false;
	}

	public void RecoveryGoldBalloon()
	{
	}

	public void RecoveryGemBalloon()
	{
	}
}
