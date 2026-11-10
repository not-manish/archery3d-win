public class Telegram
{
	public int sender;

	public int receiver;

	public FSMMessageType msg;

	public float dispatchTime;

	public object extraInfo;

	public const float smallestDelay = 0.25f;

	public Telegram()
	{
	}

	public Telegram(float time, int sender, int receiver, FSMMessageType msg)
	{
	}

	public Telegram(float time, int sender, int receiver, FSMMessageType msg, object extraInfo)
	{
	}

	public static bool operator ==(Telegram t1, Telegram t2)
	{
		return false;
	}

	public static bool operator !=(Telegram t1, Telegram t2)
	{
		return false;
	}

	public override bool Equals(object t)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator <(Telegram t1, Telegram t2)
	{
		return false;
	}

	public static bool operator >(Telegram t1, Telegram t2)
	{
		return false;
	}
}
