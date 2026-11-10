using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCUpdatePlayerNameRequest : GeneratedMessageLite<CCUpdatePlayerNameRequest, CCUpdatePlayerNameRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCUpdatePlayerNameRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCUpdatePlayerNameRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCUpdatePlayerNameRequest MessageBeingBuilt => null;

			public override CCUpdatePlayerNameRequest DefaultInstanceForType => null;

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

			public bool HasNewName => false;

			public string NewName
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

			internal Builder(CCUpdatePlayerNameRequest cloneFrom)
			{
			}

			private CCUpdatePlayerNameRequest PrepareBuilder()
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

			public override CCUpdatePlayerNameRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCUpdatePlayerNameRequest other)
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

			public Builder SetNewName(string value)
			{
				return null;
			}

			public Builder ClearNewName()
			{
				return null;
			}
		}

		private static readonly CCUpdatePlayerNameRequest defaultInstance;

		private static readonly string[] _cCUpdatePlayerNameRequestFieldNames;

		private static readonly uint[] _cCUpdatePlayerNameRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		public const int NewNameFieldNumber = 2;

		private bool hasNewName;

		private string newName_;

		private int memoizedSerializedSize;

		public static CCUpdatePlayerNameRequest DefaultInstance => null;

		public override CCUpdatePlayerNameRequest DefaultInstanceForType => null;

		protected override CCUpdatePlayerNameRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasNewName => false;

		public string NewName => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCUpdatePlayerNameRequest()
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

		public static CCUpdatePlayerNameRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCUpdatePlayerNameRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCUpdatePlayerNameRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCUpdatePlayerNameRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCUpdatePlayerNameRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCUpdatePlayerNameRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCUpdatePlayerNameRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCUpdatePlayerNameRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCUpdatePlayerNameRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCUpdatePlayerNameRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCUpdatePlayerNameRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCUpdatePlayerNameRequest prototype)
		{
			return null;
		}

		static CCUpdatePlayerNameRequest()
		{
		}
	}
}
