using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCSingleLevelRewardRequest : GeneratedMessageLite<CCSingleLevelRewardRequest, CCSingleLevelRewardRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCSingleLevelRewardRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCSingleLevelRewardRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCSingleLevelRewardRequest MessageBeingBuilt => null;

			public override CCSingleLevelRewardRequest DefaultInstanceForType => null;

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

			public bool HasLevelId => false;

			public int LevelId
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

			internal Builder(CCSingleLevelRewardRequest cloneFrom)
			{
			}

			private CCSingleLevelRewardRequest PrepareBuilder()
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

			public override CCSingleLevelRewardRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCSingleLevelRewardRequest other)
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

			public Builder SetLevelId(int value)
			{
				return null;
			}

			public Builder ClearLevelId()
			{
				return null;
			}
		}

		private static readonly CCSingleLevelRewardRequest defaultInstance;

		private static readonly string[] _cCSingleLevelRewardRequestFieldNames;

		private static readonly uint[] _cCSingleLevelRewardRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		public const int LevelIdFieldNumber = 2;

		private bool hasLevelId;

		private int levelId_;

		private int memoizedSerializedSize;

		public static CCSingleLevelRewardRequest DefaultInstance => null;

		public override CCSingleLevelRewardRequest DefaultInstanceForType => null;

		protected override CCSingleLevelRewardRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasLevelId => false;

		public int LevelId => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCSingleLevelRewardRequest()
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

		public static CCSingleLevelRewardRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCSingleLevelRewardRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleLevelRewardRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCSingleLevelRewardRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleLevelRewardRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCSingleLevelRewardRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleLevelRewardRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCSingleLevelRewardRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleLevelRewardRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCSingleLevelRewardRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCSingleLevelRewardRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCSingleLevelRewardRequest prototype)
		{
			return null;
		}

		static CCSingleLevelRewardRequest()
		{
		}
	}
}
