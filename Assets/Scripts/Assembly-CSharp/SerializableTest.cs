using System;
using UnityEngine;

public class SerializableTest : MonoBehaviour
{
	[SerializeField]
	private int a;

	public test2 t1;

	[NonSerialized]
	public test2 t2;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
