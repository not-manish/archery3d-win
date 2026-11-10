using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCAchievementSubItem : GeneratedMessageLite<CCAchievementSubItem, CCAchievementSubItem.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCAchievementSubItem, Builder>
		{
			private bool resultIsReadOnly;

			private CCAchievementSubItem result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCAchievementSubItem MessageBeingBuilt => null;

			public override CCAchievementSubItem DefaultInstanceForType => null;

			public bool HasAchiSubType => false;

			public int AchiSubType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasAchiValue => false;

			public long AchiValue
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasAchiRewardLevel => false;

			public int AchiRewardLevel
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

			internal Builder(CCAchievementSubItem cloneFrom)
			{
			}

			private CCAchievementSubItem PrepareBuilder()
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

			public override CCAchievementSubItem BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCAchievementSubItem other)
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

			public Builder SetAchiSubType(int value)
			{
				return null;
			}

			public Builder ClearAchiSubType()
			{
				return null;
			}

			public Builder SetAchiValue(long value)
			{
				return null;
			}

			public Builder ClearAchiValue()
			{
				return null;
			}

			public Builder SetAchiRewardLevel(int value)
			{
				return null;
			}

			public Builder ClearAchiRewardLevel()
			{
				return null;
			}
		}

		private static readonly CCAchievementSubItem defaultInstance;

		private static readonly string[] _cCAchievementSubItemFieldNames;

		private static readonly uint[] _cCAchievementSubItemFieldTags;

		public const int AchiSubTypeFieldNumber = 1;

		private bool hasAchiSubType;

		private int achiSubType_;

		public const int AchiValueFieldNumber = 2;

		private bool hasAchiValue;

		private long achiValue_;

		public const int AchiRewardLevelFieldNumber = 3;

		private bool hasAchiRewardLevel;

		private int achiRewardLevel_;

		private int memoizedSerializedSize;

		public static CCAchievementSubItem DefaultInstance => null;

		public override CCAchievementSubItem DefaultInstanceForType => null;

		protected override CCAchievementSubItem ThisMessage => null;

		public bool HasAchiSubType => false;

		public int AchiSubType => 0;

		public bool HasAchiValue => false;

		public long AchiValue => 0L;

		public bool HasAchiRewardLevel => false;

		public int AchiRewardLevel => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCAchievementSubItem()
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

		public static CCAchievementSubItem ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCAchievementSubItem ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAchievementSubItem ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCAchievementSubItem ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAchievementSubItem ParseFrom(Stream input)
		{
			return null;
		}

		public static CCAchievementSubItem ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAchievementSubItem ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCAchievementSubItem ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAchievementSubItem ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCAchievementSubItem ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCAchievementSubItem MakeReadOnly()
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

		public static Builder CreateBuilder(CCAchievementSubItem prototype)
		{
			return null;
		}

		static CCAchievementSubItem()
		{
		}
	}
}
