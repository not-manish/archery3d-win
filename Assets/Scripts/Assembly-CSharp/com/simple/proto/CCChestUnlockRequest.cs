using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCChestUnlockRequest : GeneratedMessageLite<CCChestUnlockRequest, CCChestUnlockRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCChestUnlockRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCChestUnlockRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCChestUnlockRequest MessageBeingBuilt => null;

			public override CCChestUnlockRequest DefaultInstanceForType => null;

			public bool HasUid => false;

			public string Uid
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

			internal Builder(CCChestUnlockRequest cloneFrom)
			{
			}

			private CCChestUnlockRequest PrepareBuilder()
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

			public override CCChestUnlockRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCChestUnlockRequest other)
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

			public Builder SetUid(string value)
			{
				return null;
			}

			public Builder ClearUid()
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

		private static readonly CCChestUnlockRequest defaultInstance;

		private static readonly string[] _cCChestUnlockRequestFieldNames;

		private static readonly uint[] _cCChestUnlockRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		public const int ChestKindFieldNumber = 2;

		private bool hasChestKind;

		private int chestKind_;

		public const int ChestIdFieldNumber = 3;

		private bool hasChestId;

		private int chestId_;

		public const int ChestClassicIndexFieldNumber = 4;

		private bool hasChestClassicIndex;

		private int chestClassicIndex_;

		private int memoizedSerializedSize;

		public static CCChestUnlockRequest DefaultInstance => null;

		public override CCChestUnlockRequest DefaultInstanceForType => null;

		protected override CCChestUnlockRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasChestKind => false;

		public int ChestKind => 0;

		public bool HasChestId => false;

		public int ChestId => 0;

		public bool HasChestClassicIndex => false;

		public int ChestClassicIndex => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCChestUnlockRequest()
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

		public static CCChestUnlockRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCChestUnlockRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestUnlockRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCChestUnlockRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestUnlockRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCChestUnlockRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestUnlockRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCChestUnlockRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestUnlockRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCChestUnlockRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCChestUnlockRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCChestUnlockRequest prototype)
		{
			return null;
		}

		static CCChestUnlockRequest()
		{
		}
	}
}
