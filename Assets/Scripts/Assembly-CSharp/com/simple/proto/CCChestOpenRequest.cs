using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCChestOpenRequest : GeneratedMessageLite<CCChestOpenRequest, CCChestOpenRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCChestOpenRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCChestOpenRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCChestOpenRequest MessageBeingBuilt => null;

			public override CCChestOpenRequest DefaultInstanceForType => null;

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

			public bool HasOpenType => false;

			public int OpenType
			{
				get
				{
					return 0;
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

			internal Builder(CCChestOpenRequest cloneFrom)
			{
			}

			private CCChestOpenRequest PrepareBuilder()
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

			public override CCChestOpenRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCChestOpenRequest other)
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

			public Builder SetOpenType(int value)
			{
				return null;
			}

			public Builder ClearOpenType()
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

		private static readonly CCChestOpenRequest defaultInstance;

		private static readonly string[] _cCChestOpenRequestFieldNames;

		private static readonly uint[] _cCChestOpenRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		public const int OpenTypeFieldNumber = 5;

		private bool hasOpenType;

		private int openType_;

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

		public static CCChestOpenRequest DefaultInstance => null;

		public override CCChestOpenRequest DefaultInstanceForType => null;

		protected override CCChestOpenRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasOpenType => false;

		public int OpenType => 0;

		public bool HasChestKind => false;

		public int ChestKind => 0;

		public bool HasChestId => false;

		public int ChestId => 0;

		public bool HasChestClassicIndex => false;

		public int ChestClassicIndex => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCChestOpenRequest()
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

		public static CCChestOpenRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCChestOpenRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestOpenRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCChestOpenRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestOpenRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCChestOpenRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestOpenRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCChestOpenRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestOpenRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCChestOpenRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCChestOpenRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCChestOpenRequest prototype)
		{
			return null;
		}

		static CCChestOpenRequest()
		{
		}
	}
}
