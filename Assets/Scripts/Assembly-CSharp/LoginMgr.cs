public class LoginMgr
{
	private LoginState loginState;

	private NetMgr m_NetMgr;

	private float m_TryTimes;

	private FlexibleTimeRegulator m_TimeRegular;

	public bool IsLoginSuccess => false;

	public LoginState GetLoginState()
	{
		return LoginState.SUCCESS;
	}

	public void SetLoginState(LoginState state)
	{
	}

	public LoginMgr(NetMgr netMgr)
	{
	}

	public void Update()
	{
	}

	public void ConnectSuccess()
	{
	}

	public void ConnectFailed()
	{
	}

	private void Login()
	{
	}
}
