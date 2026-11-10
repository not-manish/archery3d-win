using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UIModelCtrl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitingToPlayAnimation_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Player _player;

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
		public _003CWaitingToPlayAnimation_003Ed__60(int _003C_003E1__state)
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

	public UI_Equip_Model_AnimCtrl uiEquipAllAnimCtrl;

	public GameObject gameObjectEnableAll;

	public RenderToTexture renderToTextureAll;

	public Camera renderCamAll;

	public GameObject equipAllParent;

	public GameObject allBowParent;

	public GameObject allArrowParent;

	public GameObject allSightParent;

	public GameObject allStabilizerParent;

	public GameObject gameObjectEnableA;

	public RenderToTexture renderToTextureA;

	public Camera renderCamA;

	public GameObject equipSingleParentA;

	public GameObject singleBowParentA;

	public GameObject singleArrowParentA;

	public GameObject singleSightParentA;

	public GameObject singleStabilizerParentA;

	public GameObject singleArmParentA;

	public Transform tsingleArmParent;

	public GameObject gameObjectEnableB;

	public RenderToTexture renderToTextureB;

	public Camera renderCamB;

	public GameObject equipSingleParentB;

	public GameObject singleBowParentB;

	public GameObject singleArrowParentB;

	public GameObject singleSightParentB;

	public GameObject singleStabilizerParentB;

	public GameObject singleArmParentB;

	public GameObject gameObjectEnableHandle;

	public RenderToTexture renderToTextureHandle;

	public Camera renderCamHandle;

	public GameObject equipParentHandle;

	public GameObject equipAnimParentHandle;

	public GameObject equipAllParentHandle;

	public GameObject equipSingleParentHandle;

	public GameObject allBowParentHandle;

	public GameObject allArrowParentHandle;

	public GameObject allSightParentHandle;

	public GameObject allStabilizerParentHandle;

	public GameObject singleBowParentHandle;

	public GameObject singleArrowParentHandle;

	public GameObject singleSightParentHandle;

	public GameObject singleStabilizerParentHandle;

	public GameObject singleArmParentHandle;

	public CameraMove cameraMove;

	private Dictionary<EquipType, int> curEquipsIndexAll;

	private Dictionary<EquipType, int> curEquipsIndexA;

	private Dictionary<EquipType, int> curEquipsIndexB;

	private Dictionary<EquipType, int> curEquipsIndexHandle;

	public void Show(UIModelParam uiParam)
	{
	}

	private void SetActiveEquip(UIModelKind uiModelKind, EquipType equipType = EquipType.stabilizer, bool isShowAll = false)
	{
	}

	private void UpdateModel(UIModelParam uiModelParam)
	{
	}

	public void SetSightPosition(int bow_model_index, int sight_model_index, GameObject SightObj)
	{
	}

	public void UpdateSightPosition(int bow_model_index, UIModelKind uiModelKind, EquipType equipType)
	{
	}

	public void SetChildPosition(int model_index, UIModelKind uiModelKind, EquipType equipType)
	{
	}

	public void UpdateBowType(bool isShowEffectEquip, int modelIndex)
	{
	}

	private void AddModelToParent(GameObject childrenObject, UIModelKind uiModelKind, EquipType equipType, bool isshowAll = false)
	{
	}

	private void DestroyAllChildren(Transform tr)
	{
	}

	private void AddChildren(Transform parent, Transform children)
	{
	}

	private GameObject LoadResource(UIModelKind ModelKind, EquipType equipType, int modelIndex, bool isShowEffectEquip)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitingToPlayAnimation_003Ed__60))]
	private IEnumerator WaitingToPlayAnimation(Player _player)
	{
		return null;
	}

	public void Hide(UIModelKind uiModelKind)
	{
	}

	public void Hide()
	{
	}

	public RenderTexture GetModelTexture(UIModelKind uiModelKind)
	{
		return null;
	}

	public void DestroyAllTexture()
	{
	}

	public void SetCameraAlph(UIModelKind uiModelKind, int alph)
	{
	}

	public void SetPositionSingleArmParent(UIModelKind uiModelKind, EquipType equipType)
	{
	}

	public void SetShouTaoCameraPosition(UIModelKind uiModelKind, EquipType equipType)
	{
	}
}
