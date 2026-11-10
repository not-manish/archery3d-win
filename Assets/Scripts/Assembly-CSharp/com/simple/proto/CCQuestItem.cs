using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCQuestItem : GeneratedMessageLite<CCQuestItem, CCQuestItem.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCQuestItem, Builder>
		{
			private bool resultIsReadOnly;

			private CCQuestItem result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCQuestItem MessageBeingBuilt => null;

			public override CCQuestItem DefaultInstanceForType => null;

			public bool HasQuestBigType => false;

			public int QuestBigType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasQuestSubType => false;

			public int QuestSubType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasQuestValue => false;

			public int QuestValue
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasHasReward => false;

			public bool HasReward
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasQuestId => false;

			public int QuestId
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

			internal Builder(CCQuestItem cloneFrom)
			{
			}

			private CCQuestItem PrepareBuilder()
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

			public override CCQuestItem BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCQuestItem other)
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

			public Builder SetQuestBigType(int value)
			{
				return null;
			}

			public Builder ClearQuestBigType()
			{
				return null;
			}

			public Builder SetQuestSubType(int value)
			{
				return null;
			}

			public Builder ClearQuestSubType()
			{
				return null;
			}

			public Builder SetQuestValue(int value)
			{
				return null;
			}

			public Builder ClearQuestValue()
			{
				return null;
			}

			public Builder SetHasReward(bool value)
			{
				return null;
			}

			public Builder ClearHasReward()
			{
				return null;
			}

			public Builder SetQuestId(int value)
			{
				return null;
			}

			public Builder ClearQuestId()
			{
				return null;
			}
		}

		private static readonly CCQuestItem defaultInstance;

		private static readonly string[] _cCQuestItemFieldNames;

		private static readonly uint[] _cCQuestItemFieldTags;

		public const int QuestBigTypeFieldNumber = 1;

		private bool hasQuestBigType;

		private int questBigType_;

		public const int QuestSubTypeFieldNumber = 2;

		private bool hasQuestSubType;

		private int questSubType_;

		public const int QuestValueFieldNumber = 3;

		private bool hasQuestValue;

		private int questValue_;

		public const int HasRewardFieldNumber = 4;

		private bool hasHasReward;

		private bool hasReward_;

		public const int QuestIdFieldNumber = 5;

		private bool hasQuestId;

		private int questId_;

		private int memoizedSerializedSize;

		public static CCQuestItem DefaultInstance => null;

		public override CCQuestItem DefaultInstanceForType => null;

		protected override CCQuestItem ThisMessage => null;

		public bool HasQuestBigType => false;

		public int QuestBigType => 0;

		public bool HasQuestSubType => false;

		public int QuestSubType => 0;

		public bool HasQuestValue => false;

		public int QuestValue => 0;

		public bool HasHasReward => false;

		public bool HasReward => false;

		public bool HasQuestId => false;

		public int QuestId => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCQuestItem()
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

		public static CCQuestItem ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCQuestItem ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCQuestItem ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCQuestItem ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCQuestItem ParseFrom(Stream input)
		{
			return null;
		}

		public static CCQuestItem ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCQuestItem ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCQuestItem ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCQuestItem ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCQuestItem ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCQuestItem MakeReadOnly()
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

		public static Builder CreateBuilder(CCQuestItem prototype)
		{
			return null;
		}

		static CCQuestItem()
		{
		}
	}
}
