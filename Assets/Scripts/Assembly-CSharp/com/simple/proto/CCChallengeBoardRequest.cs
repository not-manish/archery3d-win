using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCChallengeBoardRequest : GeneratedMessageLite<CCChallengeBoardRequest, CCChallengeBoardRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCChallengeBoardRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCChallengeBoardRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCChallengeBoardRequest MessageBeingBuilt => null;

			public override CCChallengeBoardRequest DefaultInstanceForType => null;

			public bool HasUidMy => false;

			public string UidMy
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasUidOpp => false;

			public string UidOpp
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

			internal Builder(CCChallengeBoardRequest cloneFrom)
			{
			}

			private CCChallengeBoardRequest PrepareBuilder()
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

			public override CCChallengeBoardRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCChallengeBoardRequest other)
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

			public Builder SetUidMy(string value)
			{
				return null;
			}

			public Builder ClearUidMy()
			{
				return null;
			}

			public Builder SetUidOpp(string value)
			{
				return null;
			}

			public Builder ClearUidOpp()
			{
				return null;
			}
		}

		private static readonly CCChallengeBoardRequest defaultInstance;

		private static readonly string[] _cCChallengeBoardRequestFieldNames;

		private static readonly uint[] _cCChallengeBoardRequestFieldTags;

		public const int UidMyFieldNumber = 1;

		private bool hasUidMy;

		private string uidMy_;

		public const int UidOppFieldNumber = 2;

		private bool hasUidOpp;

		private string uidOpp_;

		private int memoizedSerializedSize;

		public static CCChallengeBoardRequest DefaultInstance => null;

		public override CCChallengeBoardRequest DefaultInstanceForType => null;

		protected override CCChallengeBoardRequest ThisMessage => null;

		public bool HasUidMy => false;

		public string UidMy => null;

		public bool HasUidOpp => false;

		public string UidOpp => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCChallengeBoardRequest()
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

		public static CCChallengeBoardRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCChallengeBoardRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeBoardRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCChallengeBoardRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeBoardRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCChallengeBoardRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeBoardRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCChallengeBoardRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeBoardRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCChallengeBoardRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCChallengeBoardRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCChallengeBoardRequest prototype)
		{
			return null;
		}

		static CCChallengeBoardRequest()
		{
		}
	}
}
