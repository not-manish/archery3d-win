using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCLimitedTimeBuyRequest : GeneratedMessageLite<CCLimitedTimeBuyRequest, CCLimitedTimeBuyRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCLimitedTimeBuyRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCLimitedTimeBuyRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCLimitedTimeBuyRequest MessageBeingBuilt => null;

			public override CCLimitedTimeBuyRequest DefaultInstanceForType => null;

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

			public bool HasHandleType => false;

			public int HandleType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasPackageType => false;

			public int PackageType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasPackageId => false;

			public int PackageId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasLevelGrade => false;

			public int LevelGrade
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasApplyAllPacks => false;

			public bool ApplyAllPacks
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public Builder()
			{
			}

			internal Builder(CCLimitedTimeBuyRequest cloneFrom)
			{
			}

			private CCLimitedTimeBuyRequest PrepareBuilder()
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

			public override CCLimitedTimeBuyRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCLimitedTimeBuyRequest other)
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

			public Builder SetHandleType(int value)
			{
				return null;
			}

			public Builder ClearHandleType()
			{
				return null;
			}

			public Builder SetPackageType(int value)
			{
				return null;
			}

			public Builder ClearPackageType()
			{
				return null;
			}

			public Builder SetPackageId(int value)
			{
				return null;
			}

			public Builder ClearPackageId()
			{
				return null;
			}

			public Builder SetLevelGrade(int value)
			{
				return null;
			}

			public Builder ClearLevelGrade()
			{
				return null;
			}

			public Builder SetApplyAllPacks(bool value)
			{
				return null;
			}

			public Builder ClearApplyAllPacks()
			{
				return null;
			}
		}

		private static readonly CCLimitedTimeBuyRequest defaultInstance;

		private static readonly string[] _cCLimitedTimeBuyRequestFieldNames;

		private static readonly uint[] _cCLimitedTimeBuyRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		public const int HandleTypeFieldNumber = 2;

		private bool hasHandleType;

		private int handleType_;

		public const int PackageTypeFieldNumber = 3;

		private bool hasPackageType;

		private int packageType_;

		public const int PackageIdFieldNumber = 4;

		private bool hasPackageId;

		private int packageId_;

		public const int LevelGradeFieldNumber = 5;

		private bool hasLevelGrade;

		private int levelGrade_;

		public const int ApplyAllPacksFieldNumber = 6;

		private bool hasApplyAllPacks;

		private bool applyAllPacks_;

		private int memoizedSerializedSize;

		public static CCLimitedTimeBuyRequest DefaultInstance => null;

		public override CCLimitedTimeBuyRequest DefaultInstanceForType => null;

		protected override CCLimitedTimeBuyRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasHandleType => false;

		public int HandleType => 0;

		public bool HasPackageType => false;

		public int PackageType => 0;

		public bool HasPackageId => false;

		public int PackageId => 0;

		public bool HasLevelGrade => false;

		public int LevelGrade => 0;

		public bool HasApplyAllPacks => false;

		public bool ApplyAllPacks => false;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCLimitedTimeBuyRequest()
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

		public static CCLimitedTimeBuyRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCLimitedTimeBuyRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLimitedTimeBuyRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCLimitedTimeBuyRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLimitedTimeBuyRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCLimitedTimeBuyRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLimitedTimeBuyRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCLimitedTimeBuyRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLimitedTimeBuyRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCLimitedTimeBuyRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCLimitedTimeBuyRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCLimitedTimeBuyRequest prototype)
		{
			return null;
		}

		static CCLimitedTimeBuyRequest()
		{
		}
	}
}
