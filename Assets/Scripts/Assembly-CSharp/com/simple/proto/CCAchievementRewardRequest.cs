using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCAchievementRewardRequest : GeneratedMessageLite<CCAchievementRewardRequest, CCAchievementRewardRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCAchievementRewardRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCAchievementRewardRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCAchievementRewardRequest MessageBeingBuilt => null;

			public override CCAchievementRewardRequest DefaultInstanceForType => null;

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

			public bool HasAchievementType => false;

			public int AchievementType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasAchievementSubType => false;

			public int AchievementSubType
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

			internal Builder(CCAchievementRewardRequest cloneFrom)
			{
			}

			private CCAchievementRewardRequest PrepareBuilder()
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

			public override CCAchievementRewardRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCAchievementRewardRequest other)
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

			public Builder SetAchievementType(int value)
			{
				return null;
			}

			public Builder ClearAchievementType()
			{
				return null;
			}

			public Builder SetAchievementSubType(int value)
			{
				return null;
			}

			public Builder ClearAchievementSubType()
			{
				return null;
			}
		}

		private static readonly CCAchievementRewardRequest defaultInstance;

		private static readonly string[] _cCAchievementRewardRequestFieldNames;

		private static readonly uint[] _cCAchievementRewardRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		public const int AchievementTypeFieldNumber = 2;

		private bool hasAchievementType;

		private int achievementType_;

		public const int AchievementSubTypeFieldNumber = 3;

		private bool hasAchievementSubType;

		private int achievementSubType_;

		private int memoizedSerializedSize;

		public static CCAchievementRewardRequest DefaultInstance => null;

		public override CCAchievementRewardRequest DefaultInstanceForType => null;

		protected override CCAchievementRewardRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasAchievementType => false;

		public int AchievementType => 0;

		public bool HasAchievementSubType => false;

		public int AchievementSubType => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCAchievementRewardRequest()
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

		public static CCAchievementRewardRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCAchievementRewardRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAchievementRewardRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCAchievementRewardRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAchievementRewardRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCAchievementRewardRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAchievementRewardRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCAchievementRewardRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAchievementRewardRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCAchievementRewardRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCAchievementRewardRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCAchievementRewardRequest prototype)
		{
			return null;
		}

		static CCAchievementRewardRequest()
		{
		}
	}
}
