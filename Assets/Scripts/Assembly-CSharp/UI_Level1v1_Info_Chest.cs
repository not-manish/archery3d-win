using System.Collections.Generic;
using UnityEngine;

public class UI_Level1v1_Info_Chest : MonoBehaviour
{
	public List<GameObject> oChestParent;

	public List<UISprite> sChestLogoBig;

	public List<UILabel> lChestCard;

	public List<UIButton> btnChestInfo;

	private List<int> chestIds;

	private void Start()
	{
	}

	public void SetChestInfo(List<int> _chestIds)
	{
	}

	private void ButtonOnClick(GameObject button)
	{
	}

	public void OnDragItem(GameObject go, Vector2 delta)
	{
	}
}
