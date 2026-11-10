using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCDeleteAccountRequest : GeneratedMessageLite<CCDeleteAccountRequest, CCDeleteAccountRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCDeleteAccountRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCDeleteAccountRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCDeleteAccountRequest MessageBeingBuilt => null;

			public override CCDeleteAccountRequest DefaultInstanceForType => null;

			public bool HasId => false;

			public string Id
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

			internal Builder(CCDeleteAccountRequest cloneFrom)
			{
			}

			private CCDeleteAccountRequest PrepareBuilder()
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

			public override CCDeleteAccountRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCDeleteAccountRequest other)
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

			public Builder SetId(string value)
			{
				return null;
			}

			public Builder ClearId()
			{
				return null;
			}
		}

		private static readonly CCDeleteAccountRequest defaultInstance;

		private static readonly string[] _cCDeleteAccountRequestFieldNames;

		private static readonly uint[] _cCDeleteAccountRequestFieldTags;

		public const int IdFieldNumber = 1;

		private bool hasId;

		private string id_;

		private int memoizedSerializedSize;

		public static CCDeleteAccountRequest DefaultInstance => null;

		public override CCDeleteAccountRequest DefaultInstanceForType => null;

		protected override CCDeleteAccountRequest ThisMessage => null;

		public bool HasId => false;

		public string Id => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCDeleteAccountRequest()
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

		public static CCDeleteAccountRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCDeleteAccountRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCDeleteAccountRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCDeleteAccountRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCDeleteAccountRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCDeleteAccountRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCDeleteAccountRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCDeleteAccountRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCDeleteAccountRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCDeleteAccountRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCDeleteAccountRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCDeleteAccountRequest prototype)
		{
			return null;
		}

		static CCDeleteAccountRequest()
		{
		}
	}
}
