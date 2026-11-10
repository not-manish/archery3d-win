using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCLimitedTimeBuyResponse : GeneratedMessageLite<CCLimitedTimeBuyResponse, CCLimitedTimeBuyResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCLimitedTimeBuyResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCLimitedTimeBuyResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCLimitedTimeBuyResponse MessageBeingBuilt => null;

			public override CCLimitedTimeBuyResponse DefaultInstanceForType => null;

			public bool HasIsSuccess => false;

			public bool IsSuccess
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasReason => false;

			public int Reason
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasPlayer => false;

			public CCPlayer Player
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasChestReward => false;

			public CCChestReward ChestReward
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

			public Builder()
			{
			}

			internal Builder(CCLimitedTimeBuyResponse cloneFrom)
			{
			}

			private CCLimitedTimeBuyResponse PrepareBuilder()
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

			public override CCLimitedTimeBuyResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCLimitedTimeBuyResponse other)
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

			public Builder SetIsSuccess(bool value)
			{
				return null;
			}

			public Builder ClearIsSuccess()
			{
				return null;
			}

			public Builder SetReason(int value)
			{
				return null;
			}

			public Builder ClearReason()
			{
				return null;
			}

			public Builder SetPlayer(CCPlayer value)
			{
				return null;
			}

			public Builder SetPlayer(CCPlayer.Builder builderForValue)
			{
				return null;
			}

			public Builder MergePlayer(CCPlayer value)
			{
				return null;
			}

			public Builder ClearPlayer()
			{
				return null;
			}

			public Builder SetChestReward(CCChestReward value)
			{
				return null;
			}

			public Builder SetChestReward(CCChestReward.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeChestReward(CCChestReward value)
			{
				return null;
			}

			public Builder ClearChestReward()
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
		}

		private static readonly CCLimitedTimeBuyResponse defaultInstance;

		private static readonly string[] _cCLimitedTimeBuyResponseFieldNames;

		private static readonly uint[] _cCLimitedTimeBuyResponseFieldTags;

		public const int IsSuccessFieldNumber = 1;

		private bool hasIsSuccess;

		private bool isSuccess_;

		public const int ReasonFieldNumber = 2;

		private bool hasReason;

		private int reason_;

		public const int PlayerFieldNumber = 3;

		private bool hasPlayer;

		private CCPlayer player_;

		public const int ChestRewardFieldNumber = 4;

		private bool hasChestReward;

		private CCChestReward chestReward_;

		public const int HandleTypeFieldNumber = 5;

		private bool hasHandleType;

		private int handleType_;

		public const int PackageTypeFieldNumber = 6;

		private bool hasPackageType;

		private int packageType_;

		public const int PackageIdFieldNumber = 7;

		private bool hasPackageId;

		private int packageId_;

		public const int LevelGradeFieldNumber = 8;

		private bool hasLevelGrade;

		private int levelGrade_;

		private int memoizedSerializedSize;

		public static CCLimitedTimeBuyResponse DefaultInstance => null;

		public override CCLimitedTimeBuyResponse DefaultInstanceForType => null;

		protected override CCLimitedTimeBuyResponse ThisMessage => null;

		public bool HasIsSuccess => false;

		public bool IsSuccess => false;

		public bool HasReason => false;

		public int Reason => 0;

		public bool HasPlayer => false;

		public CCPlayer Player => null;

		public bool HasChestReward => false;

		public CCChestReward ChestReward => null;

		public bool HasHandleType => false;

		public int HandleType => 0;

		public bool HasPackageType => false;

		public int PackageType => 0;

		public bool HasPackageId => false;

		public int PackageId => 0;

		public bool HasLevelGrade => false;

		public int LevelGrade => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCLimitedTimeBuyResponse()
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

		public static CCLimitedTimeBuyResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCLimitedTimeBuyResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLimitedTimeBuyResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCLimitedTimeBuyResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLimitedTimeBuyResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCLimitedTimeBuyResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLimitedTimeBuyResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCLimitedTimeBuyResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLimitedTimeBuyResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCLimitedTimeBuyResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCLimitedTimeBuyResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCLimitedTimeBuyResponse prototype)
		{
			return null;
		}

		static CCLimitedTimeBuyResponse()
		{
		}
	}
}
