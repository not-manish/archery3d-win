using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCFileItem : GeneratedMessageLite<CCFileItem, CCFileItem.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCFileItem, Builder>
		{
			private bool resultIsReadOnly;

			private CCFileItem result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCFileItem MessageBeingBuilt => null;

			public override CCFileItem DefaultInstanceForType => null;

			public bool HasName => false;

			public string Name
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasMd5 => false;

			public string Md5
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasUrl => false;

			public string Url
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasSize => false;

			public int Size
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

			internal Builder(CCFileItem cloneFrom)
			{
			}

			private CCFileItem PrepareBuilder()
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

			public override CCFileItem BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCFileItem other)
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

			public Builder SetName(string value)
			{
				return null;
			}

			public Builder ClearName()
			{
				return null;
			}

			public Builder SetMd5(string value)
			{
				return null;
			}

			public Builder ClearMd5()
			{
				return null;
			}

			public Builder SetUrl(string value)
			{
				return null;
			}

			public Builder ClearUrl()
			{
				return null;
			}

			public Builder SetSize(int value)
			{
				return null;
			}

			public Builder ClearSize()
			{
				return null;
			}
		}

		private static readonly CCFileItem defaultInstance;

		private static readonly string[] _cCFileItemFieldNames;

		private static readonly uint[] _cCFileItemFieldTags;

		public const int NameFieldNumber = 1;

		private bool hasName;

		private string name_;

		public const int Md5FieldNumber = 2;

		private bool hasMd5;

		private string md5_;

		public const int UrlFieldNumber = 3;

		private bool hasUrl;

		private string url_;

		public const int SizeFieldNumber = 4;

		private bool hasSize;

		private int size_;

		private int memoizedSerializedSize;

		public static CCFileItem DefaultInstance => null;

		public override CCFileItem DefaultInstanceForType => null;

		protected override CCFileItem ThisMessage => null;

		public bool HasName => false;

		public string Name => null;

		public bool HasMd5 => false;

		public string Md5 => null;

		public bool HasUrl => false;

		public string Url => null;

		public bool HasSize => false;

		public int Size => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCFileItem()
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

		public static CCFileItem ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCFileItem ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCFileItem ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCFileItem ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCFileItem ParseFrom(Stream input)
		{
			return null;
		}

		public static CCFileItem ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCFileItem ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCFileItem ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCFileItem ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCFileItem ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCFileItem MakeReadOnly()
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

		public static Builder CreateBuilder(CCFileItem prototype)
		{
			return null;
		}

		static CCFileItem()
		{
		}
	}
}
