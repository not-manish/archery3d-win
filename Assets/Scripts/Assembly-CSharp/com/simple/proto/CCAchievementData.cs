using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCAchievementData : GeneratedMessageLite<CCAchievementData, CCAchievementData.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCAchievementData, Builder>
		{
			private bool resultIsReadOnly;

			private CCAchievementData result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCAchievementData MessageBeingBuilt => null;

			public override CCAchievementData DefaultInstanceForType => null;

			public bool HasPointsCount => false;

			public int PointsCount
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasRewardPoints => false;

			public int RewardPoints
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasMatchData => false;

			public CCAchievementSubData MatchData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasCupData => false;

			public CCAchievementSubData CupData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasRichData => false;

			public CCAchievementSubData RichData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasChallengeData => false;

			public CCAchievementSubData ChallengeData
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

			internal Builder(CCAchievementData cloneFrom)
			{
			}

			private CCAchievementData PrepareBuilder()
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

			public override CCAchievementData BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCAchievementData other)
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

			public Builder SetPointsCount(int value)
			{
				return null;
			}

			public Builder ClearPointsCount()
			{
				return null;
			}

			public Builder SetRewardPoints(int value)
			{
				return null;
			}

			public Builder ClearRewardPoints()
			{
				return null;
			}

			public Builder SetMatchData(CCAchievementSubData value)
			{
				return null;
			}

			public Builder SetMatchData(CCAchievementSubData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeMatchData(CCAchievementSubData value)
			{
				return null;
			}

			public Builder ClearMatchData()
			{
				return null;
			}

			public Builder SetCupData(CCAchievementSubData value)
			{
				return null;
			}

			public Builder SetCupData(CCAchievementSubData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeCupData(CCAchievementSubData value)
			{
				return null;
			}

			public Builder ClearCupData()
			{
				return null;
			}

			public Builder SetRichData(CCAchievementSubData value)
			{
				return null;
			}

			public Builder SetRichData(CCAchievementSubData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeRichData(CCAchievementSubData value)
			{
				return null;
			}

			public Builder ClearRichData()
			{
				return null;
			}

			public Builder SetChallengeData(CCAchievementSubData value)
			{
				return null;
			}

			public Builder SetChallengeData(CCAchievementSubData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeChallengeData(CCAchievementSubData value)
			{
				return null;
			}

			public Builder ClearChallengeData()
			{
				return null;
			}
		}

		private static readonly CCAchievementData defaultInstance;

		private static readonly string[] _cCAchievementDataFieldNames;

		private static readonly uint[] _cCAchievementDataFieldTags;

		public const int PointsCountFieldNumber = 1;

		private bool hasPointsCount;

		private int pointsCount_;

		public const int RewardPointsFieldNumber = 2;

		private bool hasRewardPoints;

		private int rewardPoints_;

		public const int MatchDataFieldNumber = 3;

		private bool hasMatchData;

		private CCAchievementSubData matchData_;

		public const int CupDataFieldNumber = 4;

		private bool hasCupData;

		private CCAchievementSubData cupData_;

		public const int RichDataFieldNumber = 5;

		private bool hasRichData;

		private CCAchievementSubData richData_;

		public const int ChallengeDataFieldNumber = 6;

		private bool hasChallengeData;

		private CCAchievementSubData challengeData_;

		private int memoizedSerializedSize;

		public static CCAchievementData DefaultInstance => null;

		public override CCAchievementData DefaultInstanceForType => null;

		protected override CCAchievementData ThisMessage => null;

		public bool HasPointsCount => false;

		public int PointsCount => 0;

		public bool HasRewardPoints => false;

		public int RewardPoints => 0;

		public bool HasMatchData => false;

		public CCAchievementSubData MatchData => null;

		public bool HasCupData => false;

		public CCAchievementSubData CupData => null;

		public bool HasRichData => false;

		public CCAchievementSubData RichData => null;

		public bool HasChallengeData => false;

		public CCAchievementSubData ChallengeData => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCAchievementData()
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

		public static CCAchievementData ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCAchievementData ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAchievementData ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCAchievementData ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAchievementData ParseFrom(Stream input)
		{
			return null;
		}

		public static CCAchievementData ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAchievementData ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCAchievementData ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAchievementData ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCAchievementData ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCAchievementData MakeReadOnly()
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

		public static Builder CreateBuilder(CCAchievementData prototype)
		{
			return null;
		}

		static CCAchievementData()
		{
		}
	}
}
