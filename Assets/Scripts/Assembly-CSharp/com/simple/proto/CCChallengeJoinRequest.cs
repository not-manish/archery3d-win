using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCChallengeJoinRequest : GeneratedMessageLite<CCChallengeJoinRequest, CCChallengeJoinRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCChallengeJoinRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCChallengeJoinRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCChallengeJoinRequest MessageBeingBuilt => null;

			public override CCChallengeJoinRequest DefaultInstanceForType => null;

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

			public bool HasGroup => false;

			public int Group
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

			internal Builder(CCChallengeJoinRequest cloneFrom)
			{
			}

			private CCChallengeJoinRequest PrepareBuilder()
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

			public override CCChallengeJoinRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCChallengeJoinRequest other)
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

			public Builder SetGroup(int value)
			{
				return null;
			}

			public Builder ClearGroup()
			{
				return null;
			}
		}

		private static readonly CCChallengeJoinRequest defaultInstance;

		private static readonly string[] _cCChallengeJoinRequestFieldNames;

		private static readonly uint[] _cCChallengeJoinRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		public const int GroupFieldNumber = 2;

		private bool hasGroup;

		private int group_;

		private int memoizedSerializedSize;

		public static CCChallengeJoinRequest DefaultInstance => null;

		public override CCChallengeJoinRequest DefaultInstanceForType => null;

		protected override CCChallengeJoinRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasGroup => false;

		public int Group => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCChallengeJoinRequest()
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

		public static CCChallengeJoinRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCChallengeJoinRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeJoinRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCChallengeJoinRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeJoinRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCChallengeJoinRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeJoinRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCChallengeJoinRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeJoinRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCChallengeJoinRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCChallengeJoinRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCChallengeJoinRequest prototype)
		{
			return null;
		}

		static CCChallengeJoinRequest()
		{
		}
	}
}
