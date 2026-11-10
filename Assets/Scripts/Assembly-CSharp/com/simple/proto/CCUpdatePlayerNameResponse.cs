using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCUpdatePlayerNameResponse : GeneratedMessageLite<CCUpdatePlayerNameResponse, CCUpdatePlayerNameResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCUpdatePlayerNameResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCUpdatePlayerNameResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCUpdatePlayerNameResponse MessageBeingBuilt => null;

			public override CCUpdatePlayerNameResponse DefaultInstanceForType => null;

			public bool HasIsSuccess => false;

			public bool IsSuccess
			{
				get
				{
					return false;
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

			public bool HasUpdateTime => false;

			public long UpdateTime
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasReason => false;

			public int Reason
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

			internal Builder(CCUpdatePlayerNameResponse cloneFrom)
			{
			}

			private CCUpdatePlayerNameResponse PrepareBuilder()
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

			public override CCUpdatePlayerNameResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCUpdatePlayerNameResponse other)
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

			public Builder SetIsSuccess(bool value)
			{
				return null;
			}

			public Builder ClearIsSuccess()
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

			public Builder SetUpdateTime(long value)
			{
				return null;
			}

			public Builder ClearUpdateTime()
			{
				return null;
			}

			public Builder SetReason(int value)
			{
				return null;
			}

			public Builder ClearReason()
			{
				return null;
			}
		}

		private static readonly CCUpdatePlayerNameResponse defaultInstance;

		private static readonly string[] _cCUpdatePlayerNameResponseFieldNames;

		private static readonly uint[] _cCUpdatePlayerNameResponseFieldTags;

		public const int IsSuccessFieldNumber = 1;

		private bool hasIsSuccess;

		private bool isSuccess_;

		public const int NewNameFieldNumber = 2;

		private bool hasNewName;

		private string newName_;

		public const int UpdateTimeFieldNumber = 4;

		private bool hasUpdateTime;

		private long updateTime_;

		public const int ReasonFieldNumber = 3;

		private bool hasReason;

		private int reason_;

		private int memoizedSerializedSize;

		public static CCUpdatePlayerNameResponse DefaultInstance => null;

		public override CCUpdatePlayerNameResponse DefaultInstanceForType => null;

		protected override CCUpdatePlayerNameResponse ThisMessage => null;

		public bool HasIsSuccess => false;

		public bool IsSuccess => false;

		public bool HasNewName => false;

		public string NewName => null;

		public bool HasUpdateTime => false;

		public long UpdateTime => 0L;

		public bool HasReason => false;

		public int Reason => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCUpdatePlayerNameResponse()
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

		public static CCUpdatePlayerNameResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCUpdatePlayerNameResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCUpdatePlayerNameResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCUpdatePlayerNameResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCUpdatePlayerNameResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCUpdatePlayerNameResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCUpdatePlayerNameResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCUpdatePlayerNameResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCUpdatePlayerNameResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCUpdatePlayerNameResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCUpdatePlayerNameResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCUpdatePlayerNameResponse prototype)
		{
			return null;
		}

		static CCUpdatePlayerNameResponse()
		{
		}
	}
}
