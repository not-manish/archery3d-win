using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCLoginRequest : GeneratedMessageLite<CCLoginRequest, CCLoginRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCLoginRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCLoginRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCLoginRequest MessageBeingBuilt => null;

			public override CCLoginRequest DefaultInstanceForType => null;

			public bool HasUserId => false;

			public string UserId
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasClientVersion => false;

			public string ClientVersion
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasToken => false;

			public string Token
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasAbTest => false;

			public int AbTest
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasCountry => false;

			public string Country
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasDeviceId => false;

			public string DeviceId
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasApiRequest => false;

			public int ApiRequest
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasVideoExtraChestReq => false;

			public CCVideoExtraRequest VideoExtraChestReq
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public Builder()
			{
			}

			internal Builder(CCLoginRequest cloneFrom)
			{
			}

			private CCLoginRequest PrepareBuilder()
			{
				return null;
			}

			public override Builder Clear()
			{
				return null;
			}

			public override Builder Clone()
			{
				return null;
			}

			public override CCLoginRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCLoginRequest other)
			{
				return null;
			}

			public override Builder MergeFrom(ICodedInputStream input)
			{
				return null;
			}

			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				return null;
			}

			public Builder SetUserId(string value)
			{
				return null;
			}

			public Builder ClearUserId()
			{
				return null;
			}

			public Builder SetClientVersion(string value)
			{
				return null;
			}

			public Builder ClearClientVersion()
			{
				return null;
			}

			public Builder SetToken(string value)
			{
				return null;
			}

			public Builder ClearToken()
			{
				return null;
			}

			public Builder SetAbTest(int value)
			{
				return null;
			}

			public Builder ClearAbTest()
			{
				return null;
			}

			public Builder SetCountry(string value)
			{
				return null;
			}

			public Builder ClearCountry()
			{
				return null;
			}

			public Builder SetDeviceId(string value)
			{
				return null;
			}

			public Builder ClearDeviceId()
			{
				return null;
			}

			public Builder SetApiRequest(int value)
			{
				return null;
			}

			public Builder ClearApiRequest()
			{
				return null;
			}

			public Builder SetVideoExtraChestReq(CCVideoExtraRequest value)
			{
				return null;
			}

			public Builder SetVideoExtraChestReq(CCVideoExtraRequest.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeVideoExtraChestReq(CCVideoExtraRequest value)
			{
				return null;
			}

			public Builder ClearVideoExtraChestReq()
			{
				return null;
			}
		}

		private static readonly CCLoginRequest defaultInstance;

		private static readonly string[] _cCLoginRequestFieldNames;

		private static readonly uint[] _cCLoginRequestFieldTags;

		public const int UserIdFieldNumber = 1;

		private bool hasUserId;

		private string userId_;

		public const int ClientVersionFieldNumber = 2;

		private bool hasClientVersion;

		private string clientVersion_;

		public const int TokenFieldNumber = 3;

		private bool hasToken;

		private string token_;

		public const int AbTestFieldNumber = 4;

		private bool hasAbTest;

		private int abTest_;

		public const int CountryFieldNumber = 5;

		private bool hasCountry;

		private string country_;

		public const int DeviceIdFieldNumber = 6;

		private bool hasDeviceId;

		private string deviceId_;

		public const int ApiRequestFieldNumber = 7;

		private bool hasApiRequest;

		private int apiRequest_;

		public const int VideoExtraChestReqFieldNumber = 8;

		private bool hasVideoExtraChestReq;

		private CCVideoExtraRequest videoExtraChestReq_;

		private int memoizedSerializedSize;

		public static CCLoginRequest DefaultInstance => null;

		public override CCLoginRequest DefaultInstanceForType => null;

		protected override CCLoginRequest ThisMessage => null;

		public bool HasUserId => false;

		public string UserId => null;

		public bool HasClientVersion => false;

		public string ClientVersion => null;

		public bool HasToken => false;

		public string Token => null;

		public bool HasAbTest => false;

		public int AbTest => 0;

		public bool HasCountry => false;

		public string Country => null;

		public bool HasDeviceId => false;

		public string DeviceId => null;

		public bool HasApiRequest => false;

		public int ApiRequest => 0;

		public bool HasVideoExtraChestReq => false;

		public CCVideoExtraRequest VideoExtraChestReq => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCLoginRequest()
		{
		}

		public override void WriteTo(ICodedOutputStream output)
		{
		}

		private int CalcSerializedSize()
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override void PrintTo(TextWriter writer)
		{
		}

		public static CCLoginRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCLoginRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLoginRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCLoginRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLoginRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCLoginRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLoginRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCLoginRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLoginRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCLoginRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCLoginRequest MakeReadOnly()
		{
			return null;
		}

		public static Builder CreateBuilder()
		{
			return null;
		}

		public override Builder ToBuilder()
		{
			return null;
		}

		public override Builder CreateBuilderForType()
		{
			return null;
		}

		public static Builder CreateBuilder(CCLoginRequest prototype)
		{
			return null;
		}

		static CCLoginRequest()
		{
		}
	}
}
