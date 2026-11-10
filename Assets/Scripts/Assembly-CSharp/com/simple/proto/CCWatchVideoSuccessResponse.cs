using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCWatchVideoSuccessResponse : GeneratedMessageLite<CCWatchVideoSuccessResponse, CCWatchVideoSuccessResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCWatchVideoSuccessResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCWatchVideoSuccessResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCWatchVideoSuccessResponse MessageBeingBuilt => null;

			public override CCWatchVideoSuccessResponse DefaultInstanceForType => null;

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

			public Builder()
			{
			}

			internal Builder(CCWatchVideoSuccessResponse cloneFrom)
			{
			}

			private CCWatchVideoSuccessResponse PrepareBuilder()
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

			public override CCWatchVideoSuccessResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCWatchVideoSuccessResponse other)
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
		}

		private static readonly CCWatchVideoSuccessResponse defaultInstance;

		private static readonly string[] _cCWatchVideoSuccessResponseFieldNames;

		private static readonly uint[] _cCWatchVideoSuccessResponseFieldTags;

		public const int ResultFieldNumber = 1;

		private bool hasResult;

		private int result_;

		public const int PlayerFieldNumber = 2;

		private bool hasPlayer;

		private CCPlayer player_;

		public const int ChestRewardFieldNumber = 3;

		private bool hasChestReward;

		private CCChestReward chestReward_;

		private int memoizedSerializedSize;

		public static CCWatchVideoSuccessResponse DefaultInstance => null;

		public override CCWatchVideoSuccessResponse DefaultInstanceForType => null;

		protected override CCWatchVideoSuccessResponse ThisMessage => null;

		public bool HasResult => false;

		public int Result => 0;

		public bool HasPlayer => false;

		public CCPlayer Player => null;

		public bool HasChestReward => false;

		public CCChestReward ChestReward => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCWatchVideoSuccessResponse()
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

		public static CCWatchVideoSuccessResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCWatchVideoSuccessResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCWatchVideoSuccessResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCWatchVideoSuccessResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCWatchVideoSuccessResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCWatchVideoSuccessResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCWatchVideoSuccessResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCWatchVideoSuccessResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCWatchVideoSuccessResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCWatchVideoSuccessResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCWatchVideoSuccessResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCWatchVideoSuccessResponse prototype)
		{
			return null;
		}

		static CCWatchVideoSuccessResponse()
		{
		}
	}
}
