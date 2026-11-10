using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCLeagueRankRequest : GeneratedMessageLite<CCLeagueRankRequest, CCLeagueRankRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCLeagueRankRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCLeagueRankRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCLeagueRankRequest MessageBeingBuilt => null;

			public override CCLeagueRankRequest DefaultInstanceForType => null;

			public bool HasUid => false;

			public string Uid
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasLeagueId => false;

			public int LeagueId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public Builder()
			{
			}

			internal Builder(CCLeagueRankRequest cloneFrom)
			{
			}

			private CCLeagueRankRequest PrepareBuilder()
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

			public override CCLeagueRankRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCLeagueRankRequest other)
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

			public Builder SetUid(string value)
			{
				return null;
			}

			public Builder ClearUid()
			{
				return null;
			}

			public Builder SetLeagueId(int value)
			{
				return null;
			}

			public Builder ClearLeagueId()
			{
				return null;
			}
		}

		private static readonly CCLeagueRankRequest defaultInstance;

		private static readonly string[] _cCLeagueRankRequestFieldNames;

		private static readonly uint[] _cCLeagueRankRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		public const int LeagueIdFieldNumber = 2;

		private bool hasLeagueId;

		private int leagueId_;

		private int memoizedSerializedSize;

		public static CCLeagueRankRequest DefaultInstance => null;

		public override CCLeagueRankRequest DefaultInstanceForType => null;

		protected override CCLeagueRankRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasLeagueId => false;

		public int LeagueId => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCLeagueRankRequest()
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

		public static CCLeagueRankRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCLeagueRankRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLeagueRankRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCLeagueRankRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLeagueRankRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCLeagueRankRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLeagueRankRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCLeagueRankRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLeagueRankRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCLeagueRankRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCLeagueRankRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCLeagueRankRequest prototype)
		{
			return null;
		}

		static CCLeagueRankRequest()
		{
		}
	}
}
