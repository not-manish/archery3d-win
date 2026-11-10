using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCEquipOthers : GeneratedMessageLite<CCEquipOthers, CCEquipOthers.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCEquipOthers, Builder>
		{
			private bool resultIsReadOnly;

			private CCEquipOthers result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCEquipOthers MessageBeingBuilt => null;

			public override CCEquipOthers DefaultInstanceForType => null;

			public bool HasType => false;

			public int Type
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasLevel => false;

			public int Level
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasOwnedCard => false;

			public int OwnedCard
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasIsNewEquip => false;

			public bool IsNewEquip
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasHasUpEquip => false;

			public bool HasUpEquip
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

			internal Builder(CCEquipOthers cloneFrom)
			{
			}

			private CCEquipOthers PrepareBuilder()
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

			public override CCEquipOthers BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCEquipOthers other)
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

			public Builder SetType(int value)
			{
				return null;
			}

			public Builder ClearType()
			{
				return null;
			}

			public Builder SetLevel(int value)
			{
				return null;
			}

			public Builder ClearLevel()
			{
				return null;
			}

			public Builder SetOwnedCard(int value)
			{
				return null;
			}

			public Builder ClearOwnedCard()
			{
				return null;
			}

			public Builder SetIsNewEquip(bool value)
			{
				return null;
			}

			public Builder ClearIsNewEquip()
			{
				return null;
			}

			public Builder SetHasUpEquip(bool value)
			{
				return null;
			}

			public Builder ClearHasUpEquip()
			{
				return null;
			}
		}

		private static readonly CCEquipOthers defaultInstance;

		private static readonly string[] _cCEquipOthersFieldNames;

		private static readonly uint[] _cCEquipOthersFieldTags;

		public const int TypeFieldNumber = 1;

		private bool hasType;

		private int type_;

		public const int LevelFieldNumber = 2;

		private bool hasLevel;

		private int level_;

		public const int OwnedCardFieldNumber = 3;

		private bool hasOwnedCard;

		private int ownedCard_;

		public const int IsNewEquipFieldNumber = 4;

		private bool hasIsNewEquip;

		private bool isNewEquip_;

		public const int HasUpEquipFieldNumber = 5;

		private bool hasHasUpEquip;

		private bool hasUpEquip_;

		private int memoizedSerializedSize;

		public static CCEquipOthers DefaultInstance => null;

		public override CCEquipOthers DefaultInstanceForType => null;

		protected override CCEquipOthers ThisMessage => null;

		public bool HasType => false;

		public int Type => 0;

		public bool HasLevel => false;

		public int Level => 0;

		public bool HasOwnedCard => false;

		public int OwnedCard => 0;

		public bool HasIsNewEquip => false;

		public bool IsNewEquip => false;

		public bool HasHasUpEquip => false;

		public bool HasUpEquip => false;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCEquipOthers()
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

		public static CCEquipOthers ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCEquipOthers ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEquipOthers ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCEquipOthers ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEquipOthers ParseFrom(Stream input)
		{
			return null;
		}

		public static CCEquipOthers ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEquipOthers ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCEquipOthers ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEquipOthers ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCEquipOthers ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCEquipOthers MakeReadOnly()
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

		public static Builder CreateBuilder(CCEquipOthers prototype)
		{
			return null;
		}

		static CCEquipOthers()
		{
		}
	}
}
