using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCHandleMailsRequest : GeneratedMessageLite<CCHandleMailsRequest, CCHandleMailsRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCHandleMailsRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCHandleMailsRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCHandleMailsRequest MessageBeingBuilt => null;

			public override CCHandleMailsRequest DefaultInstanceForType => null;

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

			public bool HasHandleType => false;

			public int HandleType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public IPopsicleList<long> MailIdsList => null;

			public int MailIdsCount => 0;

			public Builder()
			{
			}

			internal Builder(CCHandleMailsRequest cloneFrom)
			{
			}

			private CCHandleMailsRequest PrepareBuilder()
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

			public override CCHandleMailsRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCHandleMailsRequest other)
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

			public Builder SetHandleType(int value)
			{
				return null;
			}

			public Builder ClearHandleType()
			{
				return null;
			}

			public long GetMailIds(int index)
			{
				return 0L;
			}

			public Builder SetMailIds(int index, long value)
			{
				return null;
			}

			public Builder AddMailIds(long value)
			{
				return null;
			}

			public Builder AddRangeMailIds(IEnumerable<long> values)
			{
				return null;
			}

			public Builder ClearMailIds()
			{
				return null;
			}
		}

		private static readonly CCHandleMailsRequest defaultInstance;

		private static readonly string[] _cCHandleMailsRequestFieldNames;

		private static readonly uint[] _cCHandleMailsRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		public const int HandleTypeFieldNumber = 2;

		private bool hasHandleType;

		private int handleType_;

		public const int MailIdsFieldNumber = 3;

		private PopsicleList<long> mailIds_;

		private int memoizedSerializedSize;

		public static CCHandleMailsRequest DefaultInstance => null;

		public override CCHandleMailsRequest DefaultInstanceForType => null;

		protected override CCHandleMailsRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasHandleType => false;

		public int HandleType => 0;

		public IList<long> MailIdsList => null;

		public int MailIdsCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCHandleMailsRequest()
		{
		}

		public long GetMailIds(int index)
		{
			return 0L;
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

		public static CCHandleMailsRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCHandleMailsRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCHandleMailsRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCHandleMailsRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCHandleMailsRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCHandleMailsRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCHandleMailsRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCHandleMailsRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCHandleMailsRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCHandleMailsRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCHandleMailsRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCHandleMailsRequest prototype)
		{
			return null;
		}

		static CCHandleMailsRequest()
		{
		}
	}
}
