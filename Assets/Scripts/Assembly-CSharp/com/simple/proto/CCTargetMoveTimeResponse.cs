using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCTargetMoveTimeResponse : GeneratedMessageLite<CCTargetMoveTimeResponse, CCTargetMoveTimeResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCTargetMoveTimeResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCTargetMoveTimeResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCTargetMoveTimeResponse MessageBeingBuilt => null;

			public override CCTargetMoveTimeResponse DefaultInstanceForType => null;

			public bool HasTargetMoveTime => false;

			public int TargetMoveTime
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

			internal Builder(CCTargetMoveTimeResponse cloneFrom)
			{
			}

			private CCTargetMoveTimeResponse PrepareBuilder()
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

			public override CCTargetMoveTimeResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCTargetMoveTimeResponse other)
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

			public Builder SetTargetMoveTime(int value)
			{
				return null;
			}

			public Builder ClearTargetMoveTime()
			{
				return null;
			}
		}

		private static readonly CCTargetMoveTimeResponse defaultInstance;

		private static readonly string[] _cCTargetMoveTimeResponseFieldNames;

		private static readonly uint[] _cCTargetMoveTimeResponseFieldTags;

		public const int TargetMoveTimeFieldNumber = 1;

		private bool hasTargetMoveTime;

		private int targetMoveTime_;

		private int memoizedSerializedSize;

		public static CCTargetMoveTimeResponse DefaultInstance => null;

		public override CCTargetMoveTimeResponse DefaultInstanceForType => null;

		protected override CCTargetMoveTimeResponse ThisMessage => null;

		public bool HasTargetMoveTime => false;

		public int TargetMoveTime => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCTargetMoveTimeResponse()
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

		public static CCTargetMoveTimeResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCTargetMoveTimeResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTargetMoveTimeResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCTargetMoveTimeResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTargetMoveTimeResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCTargetMoveTimeResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTargetMoveTimeResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCTargetMoveTimeResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTargetMoveTimeResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCTargetMoveTimeResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCTargetMoveTimeResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCTargetMoveTimeResponse prototype)
		{
			return null;
		}

		static CCTargetMoveTimeResponse()
		{
		}
	}
}
