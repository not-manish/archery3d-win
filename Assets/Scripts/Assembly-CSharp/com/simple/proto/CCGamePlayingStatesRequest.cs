using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCGamePlayingStatesRequest : GeneratedMessageLite<CCGamePlayingStatesRequest, CCGamePlayingStatesRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCGamePlayingStatesRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCGamePlayingStatesRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCGamePlayingStatesRequest MessageBeingBuilt => null;

			public override CCGamePlayingStatesRequest DefaultInstanceForType => null;

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

			internal Builder(CCGamePlayingStatesRequest cloneFrom)
			{
			}

			private CCGamePlayingStatesRequest PrepareBuilder()
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

			public override CCGamePlayingStatesRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCGamePlayingStatesRequest other)
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

		private static readonly CCGamePlayingStatesRequest defaultInstance;

		private static readonly string[] _cCGamePlayingStatesRequestFieldNames;

		private static readonly uint[] _cCGamePlayingStatesRequestFieldTags;

		public const int UserIdFieldNumber = 1;

		private bool hasUserId;

		private string userId_;

		private int memoizedSerializedSize;

		public static CCGamePlayingStatesRequest DefaultInstance => null;

		public override CCGamePlayingStatesRequest DefaultInstanceForType => null;

		protected override CCGamePlayingStatesRequest ThisMessage => null;

		public bool HasUserId => false;

		public string UserId => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCGamePlayingStatesRequest()
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

		public static CCGamePlayingStatesRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCGamePlayingStatesRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCGamePlayingStatesRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCGamePlayingStatesRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCGamePlayingStatesRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCGamePlayingStatesRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCGamePlayingStatesRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCGamePlayingStatesRequest prototype)
		{
			return null;
		}

		static CCGamePlayingStatesRequest()
		{
		}
	}
}
