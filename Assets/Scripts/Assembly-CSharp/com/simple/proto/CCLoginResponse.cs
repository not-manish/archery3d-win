using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCLoginResponse : GeneratedMessageLite<CCLoginResponse, CCLoginResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCLoginResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCLoginResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCLoginResponse MessageBeingBuilt => null;

			public override CCLoginResponse DefaultInstanceForType => null;

			public bool HasResult => false;

			public int Result
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasPlayer => false;

			public CCPlayer Player
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasCurrTimestamp => false;

			public long CurrTimestamp
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasRsInfoCfgItem => false;

			public CCFileItem RsInfoCfgItem
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasVersionInf => false;

			public CCVersionInf VersionInf
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasApiResponse => false;

			public int ApiResponse
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasVideoExtraChestRes => false;

			public CCVideoExtraResponse VideoExtraChestRes
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

			internal Builder(CCLoginResponse cloneFrom)
			{
			}

			private CCLoginResponse PrepareBuilder()
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

			public override CCLoginResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCLoginResponse other)
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

			public Builder SetResult(int value)
			{
				return null;
			}

			public Builder ClearResult()
			{
				return null;
			}

			public Builder SetPlayer(CCPlayer value)
			{
				return null;
			}

			public Builder SetPlayer(CCPlayer.Builder builderForValue)
			{
				return null;
			}

			public Builder MergePlayer(CCPlayer value)
			{
				return null;
			}

			public Builder ClearPlayer()
			{
				return null;
			}

			public Builder SetCurrTimestamp(long value)
			{
				return null;
			}

			public Builder ClearCurrTimestamp()
			{
				return null;
			}

			public Builder SetRsInfoCfgItem(CCFileItem value)
			{
				return null;
			}

			public Builder SetRsInfoCfgItem(CCFileItem.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeRsInfoCfgItem(CCFileItem value)
			{
				return null;
			}

			public Builder ClearRsInfoCfgItem()
			{
				return null;
			}

			public Builder SetVersionInf(CCVersionInf value)
			{
				return null;
			}

			public Builder SetVersionInf(CCVersionInf.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeVersionInf(CCVersionInf value)
			{
				return null;
			}

			public Builder ClearVersionInf()
			{
				return null;
			}

			public Builder SetApiResponse(int value)
			{
				return null;
			}

			public Builder ClearApiResponse()
			{
				return null;
			}

			public Builder SetVideoExtraChestRes(CCVideoExtraResponse value)
			{
				return null;
			}

			public Builder SetVideoExtraChestRes(CCVideoExtraResponse.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeVideoExtraChestRes(CCVideoExtraResponse value)
			{
				return null;
			}

			public Builder ClearVideoExtraChestRes()
			{
				return null;
			}
		}

		private static readonly CCLoginResponse defaultInstance;

		private static readonly string[] _cCLoginResponseFieldNames;

		private static readonly uint[] _cCLoginResponseFieldTags;

		public const int ResultFieldNumber = 1;

		private bool hasResult;

		private int result_;

		public const int PlayerFieldNumber = 2;

		private bool hasPlayer;

		private CCPlayer player_;

		public const int CurrTimestampFieldNumber = 3;

		private bool hasCurrTimestamp;

		private long currTimestamp_;

		public const int RsInfoCfgItemFieldNumber = 4;

		private bool hasRsInfoCfgItem;

		private CCFileItem rsInfoCfgItem_;

		public const int VersionInfFieldNumber = 5;

		private bool hasVersionInf;

		private CCVersionInf versionInf_;

		public const int ApiResponseFieldNumber = 6;

		private bool hasApiResponse;

		private int apiResponse_;

		public const int VideoExtraChestResFieldNumber = 7;

		private bool hasVideoExtraChestRes;

		private CCVideoExtraResponse videoExtraChestRes_;

		private int memoizedSerializedSize;

		public static CCLoginResponse DefaultInstance => null;

		public override CCLoginResponse DefaultInstanceForType => null;

		protected override CCLoginResponse ThisMessage => null;

		public bool HasResult => false;

		public int Result => 0;

		public bool HasPlayer => false;

		public CCPlayer Player => null;

		public bool HasCurrTimestamp => false;

		public long CurrTimestamp => 0L;

		public bool HasRsInfoCfgItem => false;

		public CCFileItem RsInfoCfgItem => null;

		public bool HasVersionInf => false;

		public CCVersionInf VersionInf => null;

		public bool HasApiResponse => false;

		public int ApiResponse => 0;

		public bool HasVideoExtraChestRes => false;

		public CCVideoExtraResponse VideoExtraChestRes => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCLoginResponse()
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

		public static CCLoginResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCLoginResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLoginResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCLoginResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLoginResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCLoginResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLoginResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCLoginResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLoginResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCLoginResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCLoginResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCLoginResponse prototype)
		{
			return null;
		}

		static CCLoginResponse()
		{
		}
	}
}
