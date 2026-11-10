using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCTargetMoveTimeRequest : GeneratedMessageLite<CCTargetMoveTimeRequest, CCTargetMoveTimeRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCTargetMoveTimeRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCTargetMoveTimeRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCTargetMoveTimeRequest MessageBeingBuilt => null;

			public override CCTargetMoveTimeRequest DefaultInstanceForType => null;

			public bool HasUserId => false;

			public string UserId
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

			internal Builder(CCTargetMoveTimeRequest cloneFrom)
			{
			}

			private CCTargetMoveTimeRequest PrepareBuilder()
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

			public override CCTargetMoveTimeRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCTargetMoveTimeRequest other)
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

			public Builder SetUserId(string value)
			{
				return null;
			}

			public Builder ClearUserId()
			{
				return null;
			}
		}

		private static readonly CCTargetMoveTimeRequest defaultInstance;

		private static readonly string[] _cCTargetMoveTimeRequestFieldNames;

		private static readonly uint[] _cCTargetMoveTimeRequestFieldTags;

		public const int UserIdFieldNumber = 1;

		private bool hasUserId;

		private string userId_;

		private int memoizedSerializedSize;

		public static CCTargetMoveTimeRequest DefaultInstance => null;

		public override CCTargetMoveTimeRequest DefaultInstanceForType => null;

		protected override CCTargetMoveTimeRequest ThisMessage => null;

		public bool HasUserId => false;

		public string UserId => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCTargetMoveTimeRequest()
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

		public static CCTargetMoveTimeRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCTargetMoveTimeRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTargetMoveTimeRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCTargetMoveTimeRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTargetMoveTimeRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCTargetMoveTimeRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTargetMoveTimeRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCTargetMoveTimeRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCTargetMoveTimeRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCTargetMoveTimeRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCTargetMoveTimeRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCTargetMoveTimeRequest prototype)
		{
			return null;
		}

		static CCTargetMoveTimeRequest()
		{
		}
	}
}
