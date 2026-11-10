using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCChestUnlockResponse : GeneratedMessageLite<CCChestUnlockResponse, CCChestUnlockResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCChestUnlockResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCChestUnlockResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCChestUnlockResponse MessageBeingBuilt => null;

			public override CCChestUnlockResponse DefaultInstanceForType => null;

			public bool HasIsSuccess => false;

			public bool IsSuccess
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasReason => false;

			public int Reason
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

			public bool HasChestKind => false;

			public int ChestKind
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasChestId => false;

			public int ChestId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasChestClassicIndex => false;

			public int ChestClassicIndex
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

			internal Builder(CCChestUnlockResponse cloneFrom)
			{
			}

			private CCChestUnlockResponse PrepareBuilder()
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

			public override CCChestUnlockResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCChestUnlockResponse other)
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

			public Builder SetIsSuccess(bool value)
			{
				return null;
			}

			public Builder ClearIsSuccess()
			{
				return null;
			}

			public Builder SetReason(int value)
			{
				return null;
			}

			public Builder ClearReason()
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

			public Builder SetChestKind(int value)
			{
				return null;
			}

			public Builder ClearChestKind()
			{
				return null;
			}

			public Builder SetChestId(int value)
			{
				return null;
			}

			public Builder ClearChestId()
			{
				return null;
			}

			public Builder SetChestClassicIndex(int value)
			{
				return null;
			}

			public Builder ClearChestClassicIndex()
			{
				return null;
			}
		}

		private static readonly CCChestUnlockResponse defaultInstance;

		private static readonly string[] _cCChestUnlockResponseFieldNames;

		private static readonly uint[] _cCChestUnlockResponseFieldTags;

		public const int IsSuccessFieldNumber = 1;

		private bool hasIsSuccess;

		private bool isSuccess_;

		public const int ReasonFieldNumber = 2;

		private bool hasReason;

		private int reason_;

		public const int PlayerFieldNumber = 3;

		private bool hasPlayer;

		private CCPlayer player_;

		public const int ChestKindFieldNumber = 4;

		private bool hasChestKind;

		private int chestKind_;

		public const int ChestIdFieldNumber = 5;

		private bool hasChestId;

		private int chestId_;

		public const int ChestClassicIndexFieldNumber = 6;

		private bool hasChestClassicIndex;

		private int chestClassicIndex_;

		private int memoizedSerializedSize;

		public static CCChestUnlockResponse DefaultInstance => null;

		public override CCChestUnlockResponse DefaultInstanceForType => null;

		protected override CCChestUnlockResponse ThisMessage => null;

		public bool HasIsSuccess => false;

		public bool IsSuccess => false;

		public bool HasReason => false;

		public int Reason => 0;

		public bool HasPlayer => false;

		public CCPlayer Player => null;

		public bool HasChestKind => false;

		public int ChestKind => 0;

		public bool HasChestId => false;

		public int ChestId => 0;

		public bool HasChestClassicIndex => false;

		public int ChestClassicIndex => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCChestUnlockResponse()
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

		public static CCChestUnlockResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCChestUnlockResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestUnlockResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCChestUnlockResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestUnlockResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCChestUnlockResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestUnlockResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCChestUnlockResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestUnlockResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCChestUnlockResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCChestUnlockResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCChestUnlockResponse prototype)
		{
			return null;
		}

		static CCChestUnlockResponse()
		{
		}
	}
}
