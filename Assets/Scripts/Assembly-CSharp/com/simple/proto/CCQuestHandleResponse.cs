using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCQuestHandleResponse : GeneratedMessageLite<CCQuestHandleResponse, CCQuestHandleResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCQuestHandleResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCQuestHandleResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCQuestHandleResponse MessageBeingBuilt => null;

			public override CCQuestHandleResponse DefaultInstanceForType => null;

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

			public bool HasQuestHandleType => false;

			public int QuestHandleType
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

			public bool HasChestReward => false;

			public CCChestReward ChestReward
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasQuestData => false;

			public CCQuestData QuestData
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

			internal Builder(CCQuestHandleResponse cloneFrom)
			{
			}

			private CCQuestHandleResponse PrepareBuilder()
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

			public override CCQuestHandleResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCQuestHandleResponse other)
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

			public Builder SetQuestHandleType(int value)
			{
				return null;
			}

			public Builder ClearQuestHandleType()
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

			public Builder SetChestReward(CCChestReward value)
			{
				return null;
			}

			public Builder SetChestReward(CCChestReward.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeChestReward(CCChestReward value)
			{
				return null;
			}

			public Builder ClearChestReward()
			{
				return null;
			}

			public Builder SetQuestData(CCQuestData value)
			{
				return null;
			}

			public Builder SetQuestData(CCQuestData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeQuestData(CCQuestData value)
			{
				return null;
			}

			public Builder ClearQuestData()
			{
				return null;
			}
		}

		private static readonly CCQuestHandleResponse defaultInstance;

		private static readonly string[] _cCQuestHandleResponseFieldNames;

		private static readonly uint[] _cCQuestHandleResponseFieldTags;

		public const int ResultFieldNumber = 1;

		private bool hasResult;

		private int result_;

		public const int QuestHandleTypeFieldNumber = 2;

		private bool hasQuestHandleType;

		private int questHandleType_;

		public const int PlayerFieldNumber = 3;

		private bool hasPlayer;

		private CCPlayer player_;

		public const int ChestRewardFieldNumber = 4;

		private bool hasChestReward;

		private CCChestReward chestReward_;

		public const int QuestDataFieldNumber = 5;

		private bool hasQuestData;

		private CCQuestData questData_;

		private int memoizedSerializedSize;

		public static CCQuestHandleResponse DefaultInstance => null;

		public override CCQuestHandleResponse DefaultInstanceForType => null;

		protected override CCQuestHandleResponse ThisMessage => null;

		public bool HasResult => false;

		public int Result => 0;

		public bool HasQuestHandleType => false;

		public int QuestHandleType => 0;

		public bool HasPlayer => false;

		public CCPlayer Player => null;

		public bool HasChestReward => false;

		public CCChestReward ChestReward => null;

		public bool HasQuestData => false;

		public CCQuestData QuestData => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCQuestHandleResponse()
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

		public static CCQuestHandleResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCQuestHandleResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCQuestHandleResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCQuestHandleResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCQuestHandleResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCQuestHandleResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCQuestHandleResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCQuestHandleResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCQuestHandleResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCQuestHandleResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCQuestHandleResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCQuestHandleResponse prototype)
		{
			return null;
		}

		static CCQuestHandleResponse()
		{
		}
	}
}
