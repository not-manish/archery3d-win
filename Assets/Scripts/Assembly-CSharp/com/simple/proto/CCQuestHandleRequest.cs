using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCQuestHandleRequest : GeneratedMessageLite<CCQuestHandleRequest, CCQuestHandleRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCQuestHandleRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCQuestHandleRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCQuestHandleRequest MessageBeingBuilt => null;

			public override CCQuestHandleRequest DefaultInstanceForType => null;

			public bool HasQuestHandleType => false;

			public int QuestHandleType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasQuestIndex => false;

			public int QuestIndex
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

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

			public Builder()
			{
			}

			internal Builder(CCQuestHandleRequest cloneFrom)
			{
			}

			private CCQuestHandleRequest PrepareBuilder()
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

			public override CCQuestHandleRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCQuestHandleRequest other)
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

			public Builder SetQuestHandleType(int value)
			{
				return null;
			}

			public Builder ClearQuestHandleType()
			{
				return null;
			}

			public Builder SetQuestIndex(int value)
			{
				return null;
			}

			public Builder ClearQuestIndex()
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
		}

		private static readonly CCQuestHandleRequest defaultInstance;

		private static readonly string[] _cCQuestHandleRequestFieldNames;

		private static readonly uint[] _cCQuestHandleRequestFieldTags;

		public const int QuestHandleTypeFieldNumber = 1;

		private bool hasQuestHandleType;

		private int questHandleType_;

		public const int QuestIndexFieldNumber = 2;

		private bool hasQuestIndex;

		private int questIndex_;

		public const int UidFieldNumber = 3;

		private bool hasUid;

		private string uid_;

		private int memoizedSerializedSize;

		public static CCQuestHandleRequest DefaultInstance => null;

		public override CCQuestHandleRequest DefaultInstanceForType => null;

		protected override CCQuestHandleRequest ThisMessage => null;

		public bool HasQuestHandleType => false;

		public int QuestHandleType => 0;

		public bool HasQuestIndex => false;

		public int QuestIndex => 0;

		public bool HasUid => false;

		public string Uid => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCQuestHandleRequest()
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

		public static CCQuestHandleRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCQuestHandleRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCQuestHandleRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCQuestHandleRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCQuestHandleRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCQuestHandleRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCQuestHandleRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCQuestHandleRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCQuestHandleRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCQuestHandleRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCQuestHandleRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCQuestHandleRequest prototype)
		{
			return null;
		}

		static CCQuestHandleRequest()
		{
		}
	}
}
