using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCHandleMailsResponse : GeneratedMessageLite<CCHandleMailsResponse, CCHandleMailsResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCHandleMailsResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCHandleMailsResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCHandleMailsResponse MessageBeingBuilt => null;

			public override CCHandleMailsResponse DefaultInstanceForType => null;

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

			public bool HasHandleType => false;

			public int HandleType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public IPopsicleList<long> MailIdsList => null;

			public int MailIdsCount => 0;

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

			internal Builder(CCHandleMailsResponse cloneFrom)
			{
			}

			private CCHandleMailsResponse PrepareBuilder()
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

			public override CCHandleMailsResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCHandleMailsResponse other)
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

			public Builder SetHandleType(int value)
			{
				return null;
			}

			public Builder ClearHandleType()
			{
				return null;
			}

			public long GetMailIds(int index)
			{
				return 0L;
			}

			public Builder SetMailIds(int index, long value)
			{
				return null;
			}

			public Builder AddMailIds(long value)
			{
				return null;
			}

			public Builder AddRangeMailIds(IEnumerable<long> values)
			{
				return null;
			}

			public Builder ClearMailIds()
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

		private static readonly CCHandleMailsResponse defaultInstance;

		private static readonly string[] _cCHandleMailsResponseFieldNames;

		private static readonly uint[] _cCHandleMailsResponseFieldTags;

		public const int ResultFieldNumber = 1;

		private bool hasResult;

		private int result_;

		public const int HandleTypeFieldNumber = 2;

		private bool hasHandleType;

		private int handleType_;

		public const int MailIdsFieldNumber = 3;

		private PopsicleList<long> mailIds_;

		public const int PlayerFieldNumber = 4;

		private bool hasPlayer;

		private CCPlayer player_;

		public const int ChestRewardFieldNumber = 5;

		private bool hasChestReward;

		private CCChestReward chestReward_;

		private int memoizedSerializedSize;

		public static CCHandleMailsResponse DefaultInstance => null;

		public override CCHandleMailsResponse DefaultInstanceForType => null;

		protected override CCHandleMailsResponse ThisMessage => null;

		public bool HasResult => false;

		public int Result => 0;

		public bool HasHandleType => false;

		public int HandleType => 0;

		public IList<long> MailIdsList => null;

		public int MailIdsCount => 0;

		public bool HasPlayer => false;

		public CCPlayer Player => null;

		public bool HasChestReward => false;

		public CCChestReward ChestReward => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCHandleMailsResponse()
		{
		}

		public long GetMailIds(int index)
		{
			return 0L;
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

		public static CCHandleMailsResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCHandleMailsResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCHandleMailsResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCHandleMailsResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCHandleMailsResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCHandleMailsResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCHandleMailsResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCHandleMailsResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCHandleMailsResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCHandleMailsResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCHandleMailsResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCHandleMailsResponse prototype)
		{
			return null;
		}

		static CCHandleMailsResponse()
		{
		}
	}
}
