using System.Collections.Generic;
using UnityEngine;

public class AnimatorTest : MonoBehaviour
{
	private enum TestStates
	{
		Idle = 0,
		PlayingLaGong = 1,
		SheJianing = 2
	}

	public Animator animator;

	private int LaGong;

	private int FangJian;

	private int IdlePose;

	private TestStates States;

	private float time;

	public Dictionary<int, bool> recoverValue;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}
}
