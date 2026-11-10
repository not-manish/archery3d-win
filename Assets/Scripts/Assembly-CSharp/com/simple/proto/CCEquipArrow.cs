using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCEquipArrow : GeneratedMessageLite<CCEquipArrow, CCEquipArrow.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCEquipArrow, Builder>
		{
			private bool resultIsReadOnly;

			private CCEquipArrow result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCEquipArrow MessageBeingBuilt => null;

			public override CCEquipArrow DefaultInstanceForType => null;

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

			public bool HasNumber => false;

			public int Number
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

			internal Builder(CCEquipArrow cloneFrom)
			{
			}

			private CCEquipArrow PrepareBuilder()
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

			public override CCEquipArrow BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCEquipArrow other)
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

			public Builder SetNumber(int value)
			{
				return null;
			}

			public Builder ClearNumber()
			{
				return null;
			}
		}

		private static readonly CCEquipArrow defaultInstance;

		private static readonly string[] _cCEquipArrowFieldNames;

		private static readonly uint[] _cCEquipArrowFieldTags;

		public const int TypeFieldNumber = 1;

		private bool hasType;

		private int type_;

		public const int NumberFieldNumber = 2;

		private bool hasNumber;

		private int number_;

		private int memoizedSerializedSize;

		public static CCEquipArrow DefaultInstance => null;

		public override CCEquipArrow DefaultInstanceForType => null;

		protected override CCEquipArrow ThisMessage => null;

		public bool HasType => false;

		public int Type => 0;

		public bool HasNumber => false;

		public int Number => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCEquipArrow()
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

		public static CCEquipArrow ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCEquipArrow ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEquipArrow ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCEquipArrow ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEquipArrow ParseFrom(Stream input)
		{
			return null;
		}

		public static CCEquipArrow ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEquipArrow ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCEquipArrow ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEquipArrow ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCEquipArrow ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCEquipArrow MakeReadOnly()
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

		public static Builder CreateBuilder(CCEquipArrow prototype)
		{
			return null;
		}

		static CCEquipArrow()
		{
		}
	}
}
