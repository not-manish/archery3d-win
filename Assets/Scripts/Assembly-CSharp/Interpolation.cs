using UnityEngine;

public class Interpolation
{
	public class Linear : Interpolation
	{
		public float apply(float a)
		{
			return 0f;
		}
	}

	public class Pow : Interpolation
	{
		private int power;

		public Pow(int power)
		{
		}

		public float apply(float a)
		{
			return 0f;
		}
	}

	public class PowIn
	{
		private int power;

		public PowIn(int power)
		{
		}

		public float apply(float a)
		{
			return 0f;
		}
	}

	public class PowOut
	{
		private int power;

		public PowOut(int power)
		{
		}

		public float apply(float a)
		{
			return 0f;
		}
	}

	public class Sine
	{
		public float apply(float a)
		{
			return 0f;
		}
	}

	public class SineIn
	{
		public float apply(float a)
		{
			return 0f;
		}
	}

	public class SineOut
	{
		public float apply(float a)
		{
			return 0f;
		}
	}

	public class Exp
	{
		private float value;

		private float power;

		private float min;

		private float scale;

		public Exp(float value, float power)
		{
		}

		public float apply(float a)
		{
			return 0f;
		}
	}

	public class ExpIn
	{
		private float value;

		private float power;

		private float min;

		private float scale;

		public ExpIn(float value, float power)
		{
		}

		public float apply(float a)
		{
			return 0f;
		}
	}

	public class ExpOut
	{
		private float value;

		private float power;

		private float min;

		private float scale;

		public ExpOut(float value, float power)
		{
		}

		public float apply(float a)
		{
			return 0f;
		}
	}

	public class Circle
	{
		public float apply(float a)
		{
			return 0f;
		}
	}

	public class CircleIn
	{
		public float apply(float a)
		{
			return 0f;
		}
	}

	public class CircleOut
	{
		public float apply(float a)
		{
			return 0f;
		}
	}

	public static Linear linear;

	public static Pow pow2;

	public static PowIn power2In;

	public static PowOut power2Out;

	public static Pow pow3;

	public static PowIn power3In;

	public static PowOut power3Out;

	public static Pow pow4;

	public static PowIn power4In;

	public static PowOut power4Out;

	public static Pow pow5;

	public static PowIn power5In;

	public static PowOut powew5Out;

	public static Sine sine;

	public static SineIn sineIn;

	public static SineOut sineOut;

	public static Exp exp5;

	public static ExpIn exp5In;

	public static ExpOut exp5Out;

	public static ExpIn exp10In;

	public static ExpOut exp10Out;

	public static Circle circle;

	public static CircleIn circleIn;

	public static CircleOut circleOut;

	public static Vector3 CalculateCubicBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2)
	{
		return default;
	}

	public static Vector3[] GetBeizerList(Vector3 startPoint, Vector3 controlPoint, Vector3 endPoint, int segmentNum)
	{
		return null;
	}
}
