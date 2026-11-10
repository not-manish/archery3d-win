using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCReMatchResponse : GeneratedMessageLite<CCReMatchResponse, CCReMatchResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCReMatchResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCReMatchResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCReMatchResponse MessageBeingBuilt => null;

			public override CCReMatchResponse DefaultInstanceForType => null;

			public bool HasStatus => false;

			public CCStatus Status
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasMyRematchState => false;

			public int MyRematchState
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasOppRematchState => false;

			public int OppRematchState
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

			internal Builder(CCReMatchResponse cloneFrom)
			{
			}

			private CCReMatchResponse PrepareBuilder()
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

			public override CCReMatchResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCReMatchResponse other)
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

			public Builder SetStatus(CCStatus value)
			{
				return null;
			}

			public Builder SetStatus(CCStatus.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeStatus(CCStatus value)
			{
				return null;
			}

			public Builder ClearStatus()
			{
				return null;
			}

			public Builder SetMyRematchState(int value)
			{
				return null;
			}

			public Builder ClearMyRematchState()
			{
				return null;
			}

			public Builder SetOppRematchState(int value)
			{
				return null;
			}

			public Builder ClearOppRematchState()
			{
				return null;
			}
		}

		private static readonly CCReMatchResponse defaultInstance;

		private static readonly string[] _cCReMatchResponseFieldNames;

		private static readonly uint[] _cCReMatchResponseFieldTags;

		public const int StatusFieldNumber = 1;

		private bool hasStatus;

		private CCStatus status_;

		public const int MyRematchStateFieldNumber = 2;

		private bool hasMyRematchState;

		private int myRematchState_;

		public const int OppRematchStateFieldNumber = 3;

		private bool hasOppRematchState;

		private int oppRematchState_;

		private int memoizedSerializedSize;

		public static CCReMatchResponse DefaultInstance => null;

		public override CCReMatchResponse DefaultInstanceForType => null;

		protected override CCReMatchResponse ThisMessage => null;

		public bool HasStatus => false;

		public CCStatus Status => null;

		public bool HasMyRematchState => false;

		public int MyRematchState => 0;

		public bool HasOppRematchState => false;

		public int OppRematchState => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCReMatchResponse()
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

		public static CCReMatchResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCReMatchResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCReMatchResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCReMatchResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCReMatchResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCReMatchResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCReMatchResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCReMatchResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCReMatchResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCReMatchResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCReMatchResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCReMatchResponse prototype)
		{
			return null;
		}

		static CCReMatchResponse()
		{
		}
	}
}
