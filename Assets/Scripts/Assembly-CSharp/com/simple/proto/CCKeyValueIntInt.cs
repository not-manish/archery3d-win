using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCKeyValueIntInt : GeneratedMessageLite<CCKeyValueIntInt, CCKeyValueIntInt.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCKeyValueIntInt, Builder>
		{
			private bool resultIsReadOnly;

			private CCKeyValueIntInt result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCKeyValueIntInt MessageBeingBuilt => null;

			public override CCKeyValueIntInt DefaultInstanceForType => null;

			public bool HasKey => false;

			public int Key
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasValue => false;

			public int Value
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

			internal Builder(CCKeyValueIntInt cloneFrom)
			{
			}

			private CCKeyValueIntInt PrepareBuilder()
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

			public override CCKeyValueIntInt BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCKeyValueIntInt other)
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

			public Builder SetKey(int value)
			{
				return null;
			}

			public Builder ClearKey()
			{
				return null;
			}

			public Builder SetValue(int value)
			{
				return null;
			}

			public Builder ClearValue()
			{
				return null;
			}
		}

		private static readonly CCKeyValueIntInt defaultInstance;

		private static readonly string[] _cCKeyValueIntIntFieldNames;

		private static readonly uint[] _cCKeyValueIntIntFieldTags;

		public const int KeyFieldNumber = 1;

		private bool hasKey;

		private int key_;

		public const int ValueFieldNumber = 2;

		private bool hasValue;

		private int value_;

		private int memoizedSerializedSize;

		public static CCKeyValueIntInt DefaultInstance => null;

		public override CCKeyValueIntInt DefaultInstanceForType => null;

		protected override CCKeyValueIntInt ThisMessage => null;

		public bool HasKey => false;

		public int Key => 0;

		public bool HasValue => false;

		public int Value => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCKeyValueIntInt()
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

		public static CCKeyValueIntInt ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCKeyValueIntInt ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCKeyValueIntInt ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCKeyValueIntInt ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCKeyValueIntInt ParseFrom(Stream input)
		{
			return null;
		}

		public static CCKeyValueIntInt ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCKeyValueIntInt ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCKeyValueIntInt ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCKeyValueIntInt ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCKeyValueIntInt ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCKeyValueIntInt MakeReadOnly()
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

		public static Builder CreateBuilder(CCKeyValueIntInt prototype)
		{
			return null;
		}

		static CCKeyValueIntInt()
		{
		}
	}
}
