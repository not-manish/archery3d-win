using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCVideoNewResponse : GeneratedMessageLite<CCVideoNewResponse, CCVideoNewResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCVideoNewResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCVideoNewResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCVideoNewResponse MessageBeingBuilt => null;

			public override CCVideoNewResponse DefaultInstanceForType => null;

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

			public bool HasRequireType => false;

			public int RequireType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasVideoType => false;

			public int VideoType
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

			public bool HasHasRewarded => false;

			public bool HasRewarded
			{
				get
				{
					return false;
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

			public Builder()
			{
			}

			internal Builder(CCVideoNewResponse cloneFrom)
			{
			}

			private CCVideoNewResponse PrepareBuilder()
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

			public override CCVideoNewResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCVideoNewResponse other)
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

			public Builder SetRequireType(int value)
			{
				return null;
			}

			public Builder ClearRequireType()
			{
				return null;
			}

			public Builder SetVideoType(int value)
			{
				return null;
			}

			public Builder ClearVideoType()
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

			public Builder SetWatchedVideo(bool value)
			{
				return null;
			}

			public Builder ClearWatchedVideo()
			{
				return null;
			}

			public Builder SetHasRewarded(bool value)
			{
				return null;
			}

			public Builder ClearHasRewarded()
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
		}

		private static readonly CCVideoNewResponse defaultInstance;

		private static readonly string[] _cCVideoNewResponseFieldNames;

		private static readonly uint[] _cCVideoNewResponseFieldTags;

		public const int ResultFieldNumber = 1;

		private bool hasResult;

		private int result_;

		public const int RequireTypeFieldNumber = 2;

		private bool hasRequireType;

		private int requireType_;

		public const int VideoTypeFieldNumber = 3;

		private bool hasVideoType;

		private int videoType_;

		public const int PlayerFieldNumber = 4;

		private bool hasPlayer;

		private CCPlayer player_;

		public const int WatchedVideoFieldNumber = 5;

		private bool hasWatchedVideo;

		private bool watchedVideo_;

		public const int HasRewardedFieldNumber = 6;

		private bool hasHasRewarded;

		private bool hasRewarded_;

		public const int ChestRewardFieldNumber = 7;

		private bool hasChestReward;

		private CCChestReward chestReward_;

		public const int ChestReward2FieldNumber = 8;

		private bool hasChestReward2;

		private CCChestReward chestReward2_;

		private int memoizedSerializedSize;

		public static CCVideoNewResponse DefaultInstance => null;

		public override CCVideoNewResponse DefaultInstanceForType => null;

		protected override CCVideoNewResponse ThisMessage => null;

		public bool HasResult => false;

		public int Result => 0;

		public bool HasRequireType => false;

		public int RequireType => 0;

		public bool HasVideoType => false;

		public int VideoType => 0;

		public bool HasPlayer => false;

		public CCPlayer Player => null;

		public bool HasWatchedVideo => false;

		public bool WatchedVideo => false;

		public bool HasHasRewarded => false;

		public bool HasRewarded => false;

		public bool HasChestReward => false;

		public CCChestReward ChestReward => null;

		public bool HasChestReward2 => false;

		public CCChestReward ChestReward2 => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCVideoNewResponse()
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

		public static CCVideoNewResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCVideoNewResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoNewResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCVideoNewResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoNewResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCVideoNewResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoNewResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCVideoNewResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoNewResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCVideoNewResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCVideoNewResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCVideoNewResponse prototype)
		{
			return null;
		}

		static CCVideoNewResponse()
		{
		}
	}
}
