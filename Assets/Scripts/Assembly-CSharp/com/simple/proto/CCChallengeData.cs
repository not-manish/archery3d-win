using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCChallengeData : GeneratedMessageLite<CCChallengeData, CCChallengeData.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCChallengeData, Builder>
		{
			private bool resultIsReadOnly;

			private CCChallengeData result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCChallengeData MessageBeingBuilt => null;

			public override CCChallengeData DefaultInstanceForType => null;

			public bool HasLastSeasonHasReward => false;

			public bool LastSeasonHasReward
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasLastSeasonChallengeId => false;

			public int LastSeasonChallengeId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasLastSeasonChallengeGroup => false;

			public int LastSeasonChallengeGroup
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasLastSeasonChallengeRewardChestId => false;

			public int LastSeasonChallengeRewardChestId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasLastSeasonChallengeRank => false;

			public int LastSeasonChallengeRank
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasLastSeasonChallengeRankEstimate => false;

			public int LastSeasonChallengeRankEstimate
			{
				get
				{
					return 0;
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

			public bool HasHasJoin => false;

			public bool HasJoin
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasJoinChallengeGroup => false;

			public int JoinChallengeGroup
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasThisSeasonHasUnlocked => false;

			public bool ThisSeasonHasUnlocked
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasThisSeasonStartTime => false;

			public long ThisSeasonStartTime
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasThisSeasonEndTime => false;

			public long ThisSeasonEndTime
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasSumScore => false;

			public int SumScore
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasSumTime => false;

			public int SumTime
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public IPopsicleList<CCChallengeLevel> PassLevelInfoList => null;

			public int PassLevelInfoCount => 0;

			public bool HasHasBestRank => false;

			public bool HasBestRank
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasBestChallengeGroup => false;

			public int BestChallengeGroup
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasBestChallengeRank => false;

			public int BestChallengeRank
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasShouldShowChalRank => false;

			public bool ShouldShowChalRank
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasUnlockedLevel1 => false;

			public bool UnlockedLevel1
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasUnlockedLevel2 => false;

			public bool UnlockedLevel2
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasUnlockedLevel3 => false;

			public bool UnlockedLevel3
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasUnlockedLevel4 => false;

			public bool UnlockedLevel4
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

			internal Builder(CCChallengeData cloneFrom)
			{
			}

			private CCChallengeData PrepareBuilder()
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

			public override CCChallengeData BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCChallengeData other)
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

			public Builder SetLastSeasonHasReward(bool value)
			{
				return null;
			}

			public Builder ClearLastSeasonHasReward()
			{
				return null;
			}

			public Builder SetLastSeasonChallengeId(int value)
			{
				return null;
			}

			public Builder ClearLastSeasonChallengeId()
			{
				return null;
			}

			public Builder SetLastSeasonChallengeGroup(int value)
			{
				return null;
			}

			public Builder ClearLastSeasonChallengeGroup()
			{
				return null;
			}

			public Builder SetLastSeasonChallengeRewardChestId(int value)
			{
				return null;
			}

			public Builder ClearLastSeasonChallengeRewardChestId()
			{
				return null;
			}

			public Builder SetLastSeasonChallengeRank(int value)
			{
				return null;
			}

			public Builder ClearLastSeasonChallengeRank()
			{
				return null;
			}

			public Builder SetLastSeasonChallengeRankEstimate(int value)
			{
				return null;
			}

			public Builder ClearLastSeasonChallengeRankEstimate()
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

			public Builder SetHasJoin(bool value)
			{
				return null;
			}

			public Builder ClearHasJoin()
			{
				return null;
			}

			public Builder SetJoinChallengeGroup(int value)
			{
				return null;
			}

			public Builder ClearJoinChallengeGroup()
			{
				return null;
			}

			public Builder SetThisSeasonHasUnlocked(bool value)
			{
				return null;
			}

			public Builder ClearThisSeasonHasUnlocked()
			{
				return null;
			}

			public Builder SetThisSeasonStartTime(long value)
			{
				return null;
			}

			public Builder ClearThisSeasonStartTime()
			{
				return null;
			}

			public Builder SetThisSeasonEndTime(long value)
			{
				return null;
			}

			public Builder ClearThisSeasonEndTime()
			{
				return null;
			}

			public Builder SetSumScore(int value)
			{
				return null;
			}

			public Builder ClearSumScore()
			{
				return null;
			}

			public Builder SetSumTime(int value)
			{
				return null;
			}

			public Builder ClearSumTime()
			{
				return null;
			}

			public CCChallengeLevel GetPassLevelInfo(int index)
			{
				return null;
			}

			public Builder SetPassLevelInfo(int index, CCChallengeLevel value)
			{
				return null;
			}

			public Builder SetPassLevelInfo(int index, CCChallengeLevel.Builder builderForValue)
			{
				return null;
			}

			public Builder AddPassLevelInfo(CCChallengeLevel value)
			{
				return null;
			}

			public Builder AddPassLevelInfo(CCChallengeLevel.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangePassLevelInfo(IEnumerable<CCChallengeLevel> values)
			{
				return null;
			}

			public Builder ClearPassLevelInfo()
			{
				return null;
			}

			public Builder SetHasBestRank(bool value)
			{
				return null;
			}

			public Builder ClearHasBestRank()
			{
				return null;
			}

			public Builder SetBestChallengeGroup(int value)
			{
				return null;
			}

			public Builder ClearBestChallengeGroup()
			{
				return null;
			}

			public Builder SetBestChallengeRank(int value)
			{
				return null;
			}

			public Builder ClearBestChallengeRank()
			{
				return null;
			}

			public Builder SetShouldShowChalRank(bool value)
			{
				return null;
			}

			public Builder ClearShouldShowChalRank()
			{
				return null;
			}

			public Builder SetUnlockedLevel1(bool value)
			{
				return null;
			}

			public Builder ClearUnlockedLevel1()
			{
				return null;
			}

			public Builder SetUnlockedLevel2(bool value)
			{
				return null;
			}

			public Builder ClearUnlockedLevel2()
			{
				return null;
			}

			public Builder SetUnlockedLevel3(bool value)
			{
				return null;
			}

			public Builder ClearUnlockedLevel3()
			{
				return null;
			}

			public Builder SetUnlockedLevel4(bool value)
			{
				return null;
			}

			public Builder ClearUnlockedLevel4()
			{
				return null;
			}
		}

		private static readonly CCChallengeData defaultInstance;

		private static readonly string[] _cCChallengeDataFieldNames;

		private static readonly uint[] _cCChallengeDataFieldTags;

		public const int LastSeasonHasRewardFieldNumber = 1;

		private bool hasLastSeasonHasReward;

		private bool lastSeasonHasReward_;

		public const int LastSeasonChallengeIdFieldNumber = 2;

		private bool hasLastSeasonChallengeId;

		private int lastSeasonChallengeId_;

		public const int LastSeasonChallengeGroupFieldNumber = 3;

		private bool hasLastSeasonChallengeGroup;

		private int lastSeasonChallengeGroup_;

		public const int LastSeasonChallengeRewardChestIdFieldNumber = 4;

		private bool hasLastSeasonChallengeRewardChestId;

		private int lastSeasonChallengeRewardChestId_;

		public const int LastSeasonChallengeRankFieldNumber = 5;

		private bool hasLastSeasonChallengeRank;

		private int lastSeasonChallengeRank_;

		public const int LastSeasonChallengeRankEstimateFieldNumber = 6;

		private bool hasLastSeasonChallengeRankEstimate;

		private int lastSeasonChallengeRankEstimate_;

		public const int ChallengeIdFieldNumber = 7;

		private bool hasChallengeId;

		private int challengeId_;

		public const int HasJoinFieldNumber = 8;

		private bool hasHasJoin;

		private bool hasJoin_;

		public const int JoinChallengeGroupFieldNumber = 9;

		private bool hasJoinChallengeGroup;

		private int joinChallengeGroup_;

		public const int ThisSeasonHasUnlockedFieldNumber = 10;

		private bool hasThisSeasonHasUnlocked;

		private bool thisSeasonHasUnlocked_;

		public const int ThisSeasonStartTimeFieldNumber = 11;

		private bool hasThisSeasonStartTime;

		private long thisSeasonStartTime_;

		public const int ThisSeasonEndTimeFieldNumber = 12;

		private bool hasThisSeasonEndTime;

		private long thisSeasonEndTime_;

		public const int SumScoreFieldNumber = 13;

		private bool hasSumScore;

		private int sumScore_;

		public const int SumTimeFieldNumber = 14;

		private bool hasSumTime;

		private int sumTime_;

		public const int PassLevelInfoFieldNumber = 15;

		private PopsicleList<CCChallengeLevel> passLevelInfo_;

		public const int HasBestRankFieldNumber = 16;

		private bool hasHasBestRank;

		private bool hasBestRank_;

		public const int BestChallengeGroupFieldNumber = 17;

		private bool hasBestChallengeGroup;

		private int bestChallengeGroup_;

		public const int BestChallengeRankFieldNumber = 18;

		private bool hasBestChallengeRank;

		private int bestChallengeRank_;

		public const int ShouldShowChalRankFieldNumber = 19;

		private bool hasShouldShowChalRank;

		private bool shouldShowChalRank_;

		public const int UnlockedLevel1FieldNumber = 20;

		private bool hasUnlockedLevel1;

		private bool unlockedLevel1_;

		public const int UnlockedLevel2FieldNumber = 21;

		private bool hasUnlockedLevel2;

		private bool unlockedLevel2_;

		public const int UnlockedLevel3FieldNumber = 22;

		private bool hasUnlockedLevel3;

		private bool unlockedLevel3_;

		public const int UnlockedLevel4FieldNumber = 23;

		private bool hasUnlockedLevel4;

		private bool unlockedLevel4_;

		private int memoizedSerializedSize;

		public static CCChallengeData DefaultInstance => null;

		public override CCChallengeData DefaultInstanceForType => null;

		protected override CCChallengeData ThisMessage => null;

		public bool HasLastSeasonHasReward => false;

		public bool LastSeasonHasReward => false;

		public bool HasLastSeasonChallengeId => false;

		public int LastSeasonChallengeId => 0;

		public bool HasLastSeasonChallengeGroup => false;

		public int LastSeasonChallengeGroup => 0;

		public bool HasLastSeasonChallengeRewardChestId => false;

		public int LastSeasonChallengeRewardChestId => 0;

		public bool HasLastSeasonChallengeRank => false;

		public int LastSeasonChallengeRank => 0;

		public bool HasLastSeasonChallengeRankEstimate => false;

		public int LastSeasonChallengeRankEstimate => 0;

		public bool HasChallengeId => false;

		public int ChallengeId => 0;

		public bool HasHasJoin => false;

		public bool HasJoin => false;

		public bool HasJoinChallengeGroup => false;

		public int JoinChallengeGroup => 0;

		public bool HasThisSeasonHasUnlocked => false;

		public bool ThisSeasonHasUnlocked => false;

		public bool HasThisSeasonStartTime => false;

		public long ThisSeasonStartTime => 0L;

		public bool HasThisSeasonEndTime => false;

		public long ThisSeasonEndTime => 0L;

		public bool HasSumScore => false;

		public int SumScore => 0;

		public bool HasSumTime => false;

		public int SumTime => 0;

		public IList<CCChallengeLevel> PassLevelInfoList => null;

		public int PassLevelInfoCount => 0;

		public bool HasHasBestRank => false;

		public bool HasBestRank => false;

		public bool HasBestChallengeGroup => false;

		public int BestChallengeGroup => 0;

		public bool HasBestChallengeRank => false;

		public int BestChallengeRank => 0;

		public bool HasShouldShowChalRank => false;

		public bool ShouldShowChalRank => false;

		public bool HasUnlockedLevel1 => false;

		public bool UnlockedLevel1 => false;

		public bool HasUnlockedLevel2 => false;

		public bool UnlockedLevel2 => false;

		public bool HasUnlockedLevel3 => false;

		public bool UnlockedLevel3 => false;

		public bool HasUnlockedLevel4 => false;

		public bool UnlockedLevel4 => false;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCChallengeData()
		{
		}

		public CCChallengeLevel GetPassLevelInfo(int index)
		{
			return null;
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

		public static CCChallengeData ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCChallengeData ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeData ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCChallengeData ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeData ParseFrom(Stream input)
		{
			return null;
		}

		public static CCChallengeData ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeData ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCChallengeData ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeData ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCChallengeData ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCChallengeData MakeReadOnly()
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

		public static Builder CreateBuilder(CCChallengeData prototype)
		{
			return null;
		}

		static CCChallengeData()
		{
		}
	}
}
