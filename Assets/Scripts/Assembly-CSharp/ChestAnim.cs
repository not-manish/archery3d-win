using System.Collections.Generic;
using UnityEngine;

public class ChestAnim : MonoBehaviour
{
	public FlexibleTimeRegulator m_tTimeRegulator;

	[HideInInspector]
	public UI_ChestOpen uiChestOpen;

	public Animation chestAnimation;

	public List<AnimationState> chestAnimState;

	public ChestState currentState;

	private ChestEffect chestEffect;

	public void Show(ChestEffect _chestEffect)
	{
	}

	private void Update()
	{
	}

	public void setCurrChestState()
	{
	}
}
