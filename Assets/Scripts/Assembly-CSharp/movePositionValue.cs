using UnityEngine;

public enum movePositionValue
{
	RangeValue = 0,
	FixedValues = 1
}
public class MovePositionValue
{
	public Vector3 FixedValue;

	public Vector3 MinRangeValue;

	public Vector3 MaxRangeValue;

	public MovePositionValue()
	{
	}

	public MovePositionValue(Vector3 _fixedValue)
	{
	}

	public MovePositionValue(Vector3 _minRangeValue, Vector3 _maxRangeValue)
	{
	}
}
