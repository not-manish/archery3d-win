using System.Collections.Generic;
using UnityEngine;

public class CoinGemAnimCtr : MonoInstance<CoinGemAnimCtr>
{
	public UI_CoinGemAnim_Pool_Ctrl uiCoinGemAnimPoolCtrl;

	public UI_CoinGem_Pool_Ctrl uiCoinGemPoolCtrl;

	public Camera CoinGem3DCamera;

	public Camera RendtexTrueCamera;

	public RenderToTexture renderToTexture;

	public GameObject CoinGem;

	public Transform CoinGemParent;

	public GameObject CoinGem3D;

	public UITexture OpenChestShow3DMode;

	public int height;

	public int width;

	private bool hasSetScale;

	public void Show(object param)
	{
	}

	public void Hide(object param)
	{
	}

	public void Hide()
	{
	}

	public void DestroyTexture()
	{
	}

	private new void OnDestroy()
	{
	}

	public List<ChestOpen_CoinGemMoveAnim> GetShowAnimList(CoinGem coinGemparm)
	{
		return null;
	}

	public void GetDiamond(CoinGem coinGemparm, List<ChestOpen_CoinGemMoveAnim> ShowAnimList)
	{
	}

	public bool IsShow()
	{
		return false;
	}

	public Camera GetCoinGem3DCamera()
	{
		return null;
	}

	public Camera GetRendtexTrueCamera()
	{
		return null;
	}

	public void EndRecoverTimeMultiplier()
	{
	}
}
