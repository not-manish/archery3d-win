using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCQuestData : GeneratedMessageLite<CCQuestData, CCQuestData.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCQuestData, Builder>
		{
			private bool resultIsReadOnly;

			private CCQuestData result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCQuestData MessageBeingBuilt => null;

			public override CCQuestData DefaultInstanceForType => null;

			public bool HasSysQuestStartTimeMil => false;

			public long SysQuestStartTimeMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasScoresCount => false;

			public int ScoresCount
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasScoresRewardRound => false;

			public int ScoresRewardRound
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasScoresRewardIndex => false;

			public int ScoresRewardIndex
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasTodayHasChangedQuest => false;

			public bool TodayHasChangedQuest
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasQuestItem1 => false;

			public CCQuestItem QuestItem1
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasQuestItem2 => false;

			public CCQuestItem QuestItem2
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasQuestItem3 => false;

			public CCQuestItem QuestItem3
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasGiftsLastRewardTimeMil => false;

			public long GiftsLastRewardTimeMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasGiftsRewardRound => false;

			public int GiftsRewardRound
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasGiftsRewardedIndex => false;

			public int GiftsRewardedIndex
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

			internal Builder(CCQuestData cloneFrom)
			{
			}

			private CCQuestData PrepareBuilder()
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

			public override CCQuestData BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCQuestData other)
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

			public Builder SetSysQuestStartTimeMil(long value)
			{
				return null;
			}

			public Builder ClearSysQuestStartTimeMil()
			{
				return null;
			}

			public Builder SetScoresCount(int value)
			{
				return null;
			}

			public Builder ClearScoresCount()
			{
				return null;
			}

			public Builder SetScoresRewardRound(int value)
			{
				return null;
			}

			public Builder ClearScoresRewardRound()
			{
				return null;
			}

			public Builder SetScoresRewardIndex(int value)
			{
				return null;
			}

			public Builder ClearScoresRewardIndex()
			{
				return null;
			}

			public Builder SetTodayHasChangedQuest(bool value)
			{
				return null;
			}

			public Builder ClearTodayHasChangedQuest()
			{
				return null;
			}

			public Builder SetQuestItem1(CCQuestItem value)
			{
				return null;
			}

			public Builder SetQuestItem1(CCQuestItem.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeQuestItem1(CCQuestItem value)
			{
				return null;
			}

			public Builder ClearQuestItem1()
			{
				return null;
			}

			public Builder SetQuestItem2(CCQuestItem value)
			{
				return null;
			}

			public Builder SetQuestItem2(CCQuestItem.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeQuestItem2(CCQuestItem value)
			{
				return null;
			}

			public Builder ClearQuestItem2()
			{
				return null;
			}

			public Builder SetQuestItem3(CCQuestItem value)
			{
				return null;
			}

			public Builder SetQuestItem3(CCQuestItem.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeQuestItem3(CCQuestItem value)
			{
				return null;
			}

			public Builder ClearQuestItem3()
			{
				return null;
			}

			public Builder SetGiftsLastRewardTimeMil(long value)
			{
				return null;
			}

			public Builder ClearGiftsLastRewardTimeMil()
			{
				return null;
			}

			public Builder SetGiftsRewardRound(int value)
			{
				return null;
			}

			public Builder ClearGiftsRewardRound()
			{
				return null;
			}

			public Builder SetGiftsRewardedIndex(int value)
			{
				return null;
			}

			public Builder ClearGiftsRewardedIndex()
			{
				return null;
			}
		}

		private static readonly CCQuestData defaultInstance;

		private static readonly string[] _cCQuestDataFieldNames;

		private static readonly uint[] _cCQuestDataFieldTags;

		public const int SysQuestStartTimeMilFieldNumber = 2;

		private bool hasSysQuestStartTimeMil;

		private long sysQuestStartTimeMil_;

		public const int ScoresCountFieldNumber = 3;

		private bool hasScoresCount;

		private int scoresCount_;

		public const int ScoresRewardRoundFieldNumber = 4;

		private bool hasScoresRewardRound;

		private int scoresRewardRound_;

		public const int ScoresRewardIndexFieldNumber = 5;

		private bool hasScoresRewardIndex;

		private int scoresRewardIndex_;

		public const int TodayHasChangedQuestFieldNumber = 6;

		private bool hasTodayHasChangedQuest;

		private bool todayHasChangedQuest_;

		public const int QuestItem1FieldNumber = 7;

		private bool hasQuestItem1;

		private CCQuestItem questItem1_;

		public const int QuestItem2FieldNumber = 8;

		private bool hasQuestItem2;

		private CCQuestItem questItem2_;

		public const int QuestItem3FieldNumber = 9;

		private bool hasQuestItem3;

		private CCQuestItem questItem3_;

		public const int GiftsLastRewardTimeMilFieldNumber = 10;

		private bool hasGiftsLastRewardTimeMil;

		private long giftsLastRewardTimeMil_;

		public const int GiftsRewardRoundFieldNumber = 11;

		private bool hasGiftsRewardRound;

		private int giftsRewardRound_;

		public const int GiftsRewardedIndexFieldNumber = 12;

		private bool hasGiftsRewardedIndex;

		private int giftsRewardedIndex_;

		private int memoizedSerializedSize;

		public static CCQuestData DefaultInstance => null;

		public override CCQuestData DefaultInstanceForType => null;

		protected override CCQuestData ThisMessage => null;

		public bool HasSysQuestStartTimeMil => false;

		public long SysQuestStartTimeMil => 0L;

		public bool HasScoresCount => false;

		public int ScoresCount => 0;

		public bool HasScoresRewardRound => false;

		public int ScoresRewardRound => 0;

		public bool HasScoresRewardIndex => false;

		public int ScoresRewardIndex => 0;

		public bool HasTodayHasChangedQuest => false;

		public bool TodayHasChangedQuest => false;

		public bool HasQuestItem1 => false;

		public CCQuestItem QuestItem1 => null;

		public bool HasQuestItem2 => false;

		public CCQuestItem QuestItem2 => null;

		public bool HasQuestItem3 => false;

		public CCQuestItem QuestItem3 => null;

		public bool HasGiftsLastRewardTimeMil => false;

		public long GiftsLastRewardTimeMil => 0L;

		public bool HasGiftsRewardRound => false;

		public int GiftsRewardRound => 0;

		public bool HasGiftsRewardedIndex => false;

		public int GiftsRewardedIndex => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCQuestData()
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

		public static CCQuestData ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCQuestData ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCQuestData ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCQuestData ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCQuestData ParseFrom(Stream input)
		{
			return null;
		}

		public static CCQuestData ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCQuestData ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCQuestData ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCQuestData ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCQuestData ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCQuestData MakeReadOnly()
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

		public static Builder CreateBuilder(CCQuestData prototype)
		{
			return null;
		}

		static CCQuestData()
		{
		}
	}
}
