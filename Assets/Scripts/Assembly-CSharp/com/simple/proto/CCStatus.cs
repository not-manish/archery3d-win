using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCStatus : GeneratedMessageLite<CCStatus, CCStatus.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCStatus, Builder>
		{
			private bool resultIsReadOnly;

			private CCStatus result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCStatus MessageBeingBuilt => null;

			public override CCStatus DefaultInstanceForType => null;

			public bool HasStatus => false;

			public int Status
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasErrorReason => false;

			public int ErrorReason
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

			internal Builder(CCStatus cloneFrom)
			{
			}

			private CCStatus PrepareBuilder()
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

			public override CCStatus BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCStatus other)
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

			public Builder SetStatus(int value)
			{
				return null;
			}

			public Builder ClearStatus()
			{
				return null;
			}

			public Builder SetErrorReason(int value)
			{
				return null;
			}

			public Builder ClearErrorReason()
			{
				return null;
			}
		}

		private static readonly CCStatus defaultInstance;

		private static readonly string[] _cCStatusFieldNames;

		private static readonly uint[] _cCStatusFieldTags;

		public const int StatusFieldNumber = 1;

		private bool hasStatus;

		private int status_;

		public const int ErrorReasonFieldNumber = 2;

		private bool hasErrorReason;

		private int errorReason_;

		private int memoizedSerializedSize;

		public static CCStatus DefaultInstance => null;

		public override CCStatus DefaultInstanceForType => null;

		protected override CCStatus ThisMessage => null;

		public bool HasStatus => false;

		public int Status => 0;

		public bool HasErrorReason => false;

		public int ErrorReason => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCStatus()
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

		public static CCStatus ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCStatus ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCStatus ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCStatus ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCStatus ParseFrom(Stream input)
		{
			return null;
		}

		public static CCStatus ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCStatus ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCStatus ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCStatus ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCStatus ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCStatus MakeReadOnly()
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

		public static Builder CreateBuilder(CCStatus prototype)
		{
			return null;
		}

		static CCStatus()
		{
		}
	}
}
