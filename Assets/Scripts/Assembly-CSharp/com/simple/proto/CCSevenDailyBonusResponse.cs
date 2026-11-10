using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCSevenDailyBonusResponse : GeneratedMessageLite<CCSevenDailyBonusResponse, CCSevenDailyBonusResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCSevenDailyBonusResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCSevenDailyBonusResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCSevenDailyBonusResponse MessageBeingBuilt => null;

			public override CCSevenDailyBonusResponse DefaultInstanceForType => null;

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

			public bool HasChestReward2 => false;

			public CCChestReward ChestReward2
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasWatchedVideo => false;

			public bool WatchedVideo
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

			internal Builder(CCSevenDailyBonusResponse cloneFrom)
			{
			}

			private CCSevenDailyBonusResponse PrepareBuilder()
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

			public override CCSevenDailyBonusResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCSevenDailyBonusResponse other)
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

			public Builder SetChestReward2(CCChestReward value)
			{
				return null;
			}

			public Builder SetChestReward2(CCChestReward.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeChestReward2(CCChestReward value)
			{
				return null;
			}

			public Builder ClearChestReward2()
			{
				return null;
			}

			public Builder SetWatchedVideo(bool value)
			{
				return null;
			}

			public Builder ClearWatchedVideo()
			{
				return null;
			}
		}

		private static readonly CCSevenDailyBonusResponse defaultInstance;

		private static readonly string[] _cCSevenDailyBonusResponseFieldNames;

		private static readonly uint[] _cCSevenDailyBonusResponseFieldTags;

		public const int ResultFieldNumber = 1;

		private bool hasResult;

		private int result_;

		public const int PlayerFieldNumber = 2;

		private bool hasPlayer;

		private CCPlayer player_;

		public const int ChestRewardFieldNumber = 3;

		private bool hasChestReward;

		private CCChestReward chestReward_;

		public const int ChestReward2FieldNumber = 4;

		private bool hasChestReward2;

		private CCChestReward chestReward2_;

		public const int WatchedVideoFieldNumber = 5;

		private bool hasWatchedVideo;

		private bool watchedVideo_;

		private int memoizedSerializedSize;

		public static CCSevenDailyBonusResponse DefaultInstance => null;

		public override CCSevenDailyBonusResponse DefaultInstanceForType => null;

		protected override CCSevenDailyBonusResponse ThisMessage => null;

		public bool HasResult => false;

		public int Result => 0;

		public bool HasPlayer => false;

		public CCPlayer Player => null;

		public bool HasChestReward => false;

		public CCChestReward ChestReward => null;

		public bool HasChestReward2 => false;

		public CCChestReward ChestReward2 => null;

		public bool HasWatchedVideo => false;

		public bool WatchedVideo => false;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCSevenDailyBonusResponse()
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

		public static CCSevenDailyBonusResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCSevenDailyBonusResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSevenDailyBonusResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCSevenDailyBonusResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSevenDailyBonusResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCSevenDailyBonusResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSevenDailyBonusResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCSevenDailyBonusResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSevenDailyBonusResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCSevenDailyBonusResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCSevenDailyBonusResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCSevenDailyBonusResponse prototype)
		{
			return null;
		}

		static CCSevenDailyBonusResponse()
		{
		}
	}
}
