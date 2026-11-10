using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCChallengeRankRequest : GeneratedMessageLite<CCChallengeRankRequest, CCChallengeRankRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCChallengeRankRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCChallengeRankRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCChallengeRankRequest MessageBeingBuilt => null;

			public override CCChallengeRankRequest DefaultInstanceForType => null;

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

			public bool HasChallengeId => false;

			public int ChallengeId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasChallengeGroup => false;

			public int ChallengeGroup
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasClearPlayerDataChalShow => false;

			public bool ClearPlayerDataChalShow
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public Builder()
			{
			}

			internal Builder(CCChallengeRankRequest cloneFrom)
			{
			}

			private CCChallengeRankRequest PrepareBuilder()
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

			public override CCChallengeRankRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCChallengeRankRequest other)
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

			public Builder SetChallengeId(int value)
			{
				return null;
			}

			public Builder ClearChallengeId()
			{
				return null;
			}

			public Builder SetChallengeGroup(int value)
			{
				return null;
			}

			public Builder ClearChallengeGroup()
			{
				return null;
			}

			public Builder SetClearPlayerDataChalShow(bool value)
			{
				return null;
			}

			public Builder ClearClearPlayerDataChalShow()
			{
				return null;
			}
		}

		private static readonly CCChallengeRankRequest defaultInstance;

		private static readonly string[] _cCChallengeRankRequestFieldNames;

		private static readonly uint[] _cCChallengeRankRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		public const int ChallengeIdFieldNumber = 2;

		private bool hasChallengeId;

		private int challengeId_;

		public const int ChallengeGroupFieldNumber = 3;

		private bool hasChallengeGroup;

		private int challengeGroup_;

		public const int ClearPlayerDataChalShowFieldNumber = 4;

		private bool hasClearPlayerDataChalShow;

		private bool clearPlayerDataChalShow_;

		private int memoizedSerializedSize;

		public static CCChallengeRankRequest DefaultInstance => null;

		public override CCChallengeRankRequest DefaultInstanceForType => null;

		protected override CCChallengeRankRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasChallengeId => false;

		public int ChallengeId => 0;

		public bool HasChallengeGroup => false;

		public int ChallengeGroup => 0;

		public bool HasClearPlayerDataChalShow => false;

		public bool ClearPlayerDataChalShow => false;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCChallengeRankRequest()
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

		public static CCChallengeRankRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCChallengeRankRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeRankRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCChallengeRankRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeRankRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCChallengeRankRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeRankRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCChallengeRankRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeRankRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCChallengeRankRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCChallengeRankRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCChallengeRankRequest prototype)
		{
			return null;
		}

		static CCChallengeRankRequest()
		{
		}
	}
}
