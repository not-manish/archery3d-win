using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCBillData : GeneratedMessageLite<CCBillData, CCBillData.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCBillData, Builder>
		{
			private bool resultIsReadOnly;

			private CCBillData result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCBillData MessageBeingBuilt => null;

			public override CCBillData DefaultInstanceForType => null;

			public bool HasPackageName => false;

			public string PackageName
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasProductId => false;

			public string ProductId
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasToken => false;

			public string Token
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasPayload => false;

			public string Payload
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

			internal Builder(CCBillData cloneFrom)
			{
			}

			private CCBillData PrepareBuilder()
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

			public override CCBillData BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCBillData other)
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

			public Builder SetPackageName(string value)
			{
				return null;
			}

			public Builder ClearPackageName()
			{
				return null;
			}

			public Builder SetProductId(string value)
			{
				return null;
			}

			public Builder ClearProductId()
			{
				return null;
			}

			public Builder SetToken(string value)
			{
				return null;
			}

			public Builder ClearToken()
			{
				return null;
			}

			public Builder SetPayload(string value)
			{
				return null;
			}

			public Builder ClearPayload()
			{
				return null;
			}
		}

		private static readonly CCBillData defaultInstance;

		private static readonly string[] _cCBillDataFieldNames;

		private static readonly uint[] _cCBillDataFieldTags;

		public const int PackageNameFieldNumber = 1;

		private bool hasPackageName;

		private string packageName_;

		public const int ProductIdFieldNumber = 2;

		private bool hasProductId;

		private string productId_;

		public const int TokenFieldNumber = 3;

		private bool hasToken;

		private string token_;

		public const int PayloadFieldNumber = 4;

		private bool hasPayload;

		private string payload_;

		private int memoizedSerializedSize;

		public static CCBillData DefaultInstance => null;

		public override CCBillData DefaultInstanceForType => null;

		protected override CCBillData ThisMessage => null;

		public bool HasPackageName => false;

		public string PackageName => null;

		public bool HasProductId => false;

		public string ProductId => null;

		public bool HasToken => false;

		public string Token => null;

		public bool HasPayload => false;

		public string Payload => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCBillData()
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

		public static CCBillData ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCBillData ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBillData ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCBillData ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBillData ParseFrom(Stream input)
		{
			return null;
		}

		public static CCBillData ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBillData ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCBillData ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCBillData ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCBillData ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCBillData MakeReadOnly()
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

		public static Builder CreateBuilder(CCBillData prototype)
		{
			return null;
		}

		static CCBillData()
		{
		}
	}
}
