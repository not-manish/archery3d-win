using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UI_CoinGem_Pool_Ctrl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayAnim_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<ChestOpen_CoinGemMoveAnim> ShowAnimList;

		public CoinGem coinGemparm;

		public UI_CoinGem_Pool_Ctrl _003C_003E4__this;

		private int _003CStarCount_003E5__2;

		private int _003CmoveCount_003E5__3;

		private WaitForSeconds _003Csecond_003E5__4;

		private int _003Cx_003E5__5;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CPlayAnim_003Ed__13(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CPlayAnimFun_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<ChestOpen_CoinGemMoveAnim> ShowAnimList;

		public CoinGem coinGemparm;

		public UI_CoinGem_Pool_Ctrl _003C_003E4__this;

		private FlexibleRealTimeRegulator _003Cm_tTimeRegulator_003E5__2;

		private List<CoinGemMoveAnimType> _003CMoveItemAnimList_003E5__3;

		private int _003CmoveCount_003E5__4;

		private int _003Cindex_003E5__5;

		private float _003Ctime_003E5__6;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CPlayAnimFun_003Ed__14(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public ChestOpen_CoinGemMoveAnim GoldAnimOne;

	public ChestOpen_CoinGemMoveAnim GemAnimOne;

	public ChestOpen_CoinGemMoveAnim EquipCardAnimOne;

	public ChestOpen_CoinGemMoveAnim TrophyAnimOne;

	public Transform GemAnimParent;

	private List<ChestOpen_CoinGemMoveAnim> GoldAnimPoolList;

	private List<ChestOpen_CoinGemMoveAnim> GemAnimPoolList;

	private List<ChestOpen_CoinGemMoveAnim> EquipCardPoolList;

	private List<ChestOpen_CoinGemMoveAnim> TrophyPoolList;

	private List<ChestOpen_CoinGemMoveAnim> AniCtrlList;

	private int[] StarNum;

	private void Awake()
	{
	}

	public void ShowCoinAnim(CoinGem coinGemparm, List<ChestOpen_CoinGemMoveAnim> ShowAnimList)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayAnim_003Ed__13))]
	public IEnumerator PlayAnim(CoinGem coinGemparm, List<ChestOpen_CoinGemMoveAnim> ShowAnimList)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayAnimFun_003Ed__14))]
	public IEnumerator PlayAnimFun(CoinGem coinGemparm, List<ChestOpen_CoinGemMoveAnim> ShowAnimList)
	{
		return null;
	}

	public List<ChestOpen_CoinGemMoveAnim> GenerateCoinGemAnimBroken(CoinGem coinGemparm)
	{
		return null;
	}

	public Vector3 GetRangePosition(Vector3 minPosition, Vector3 MaxPosition)
	{
		return default;
	}

	public void SetMoveAnimValue(ChestOpen_CoinGemMoveAnim coinGem_MoveAnim, Dictionary<movePositionValue, MovePositionValue> Values, SetMoveAnimTypeValue type, int z)
	{
	}

	public Vector3 GetPosition(movePositionValue Key, MovePositionValue Value)
	{
		return default;
	}

	public void RecoveryGoldBalloon(ChestOpen_CoinGemMoveAnim chestOpen_CoinGemMoveAnim)
	{
	}

	public void RecoveryCardBalloon(ChestOpen_CoinGemMoveAnim chestOpen_CoinGemMoveAnim)
	{
	}

	public void RecoveryGemBalloon(ChestOpen_CoinGemMoveAnim chestOpen_CoinGemMoveAnim)
	{
	}

	public void RecoveryTrophyBalloon(ChestOpen_CoinGemMoveAnim chestOpen_CoinGemMoveAnim)
	{
	}

	public void RecoveryPrefabBalloon(ChestOpen_CoinGemMoveAnim chestOpen_CoinGemMoveAnim)
	{
	}
}
