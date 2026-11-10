using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCVideoFreeNew : GeneratedMessageLite<CCVideoFreeNew, CCVideoFreeNew.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCVideoFreeNew, Builder>
		{
			private bool resultIsReadOnly;

			private CCVideoFreeNew result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCVideoFreeNew MessageBeingBuilt => null;

			public override CCVideoFreeNew DefaultInstanceForType => null;

			public bool HasUpdateDayStartTimeMil => false;

			public long UpdateDayStartTimeMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasLoopUpdStartTimeMil => false;

			public long LoopUpdStartTimeMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasLoopRewardNextId => false;

			public int LoopRewardNextId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasOrderRewardIndex => false;

			public int OrderRewardIndex
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasOrderRewardNextId1 => false;

			public int OrderRewardNextId1
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasOrderRewardNextId2 => false;

			public int OrderRewardNextId2
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasOrderRewardNextId3 => false;

			public int OrderRewardNextId3
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasCountWatchedVideoCount => false;

			public int CountWatchedVideoCount
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasCountRewardNextId => false;

			public int CountRewardNextId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasCountHasRewarded => false;

			public bool CountHasRewarded
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

			internal Builder(CCVideoFreeNew cloneFrom)
			{
			}

			private CCVideoFreeNew PrepareBuilder()
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

			public override CCVideoFreeNew BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCVideoFreeNew other)
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

			public Builder SetUpdateDayStartTimeMil(long value)
			{
				return null;
			}

			public Builder ClearUpdateDayStartTimeMil()
			{
				return null;
			}

			public Builder SetLoopUpdStartTimeMil(long value)
			{
				return null;
			}

			public Builder ClearLoopUpdStartTimeMil()
			{
				return null;
			}

			public Builder SetLoopRewardNextId(int value)
			{
				return null;
			}

			public Builder ClearLoopRewardNextId()
			{
				return null;
			}

			public Builder SetOrderRewardIndex(int value)
			{
				return null;
			}

			public Builder ClearOrderRewardIndex()
			{
				return null;
			}

			public Builder SetOrderRewardNextId1(int value)
			{
				return null;
			}

			public Builder ClearOrderRewardNextId1()
			{
				return null;
			}

			public Builder SetOrderRewardNextId2(int value)
			{
				return null;
			}

			public Builder ClearOrderRewardNextId2()
			{
				return null;
			}

			public Builder SetOrderRewardNextId3(int value)
			{
				return null;
			}

			public Builder ClearOrderRewardNextId3()
			{
				return null;
			}

			public Builder SetCountWatchedVideoCount(int value)
			{
				return null;
			}

			public Builder ClearCountWatchedVideoCount()
			{
				return null;
			}

			public Builder SetCountRewardNextId(int value)
			{
				return null;
			}

			public Builder ClearCountRewardNextId()
			{
				return null;
			}

			public Builder SetCountHasRewarded(bool value)
			{
				return null;
			}

			public Builder ClearCountHasRewarded()
			{
				return null;
			}
		}

		private static readonly CCVideoFreeNew defaultInstance;

		private static readonly string[] _cCVideoFreeNewFieldNames;

		private static readonly uint[] _cCVideoFreeNewFieldTags;

		public const int UpdateDayStartTimeMilFieldNumber = 1;

		private bool hasUpdateDayStartTimeMil;

		private long updateDayStartTimeMil_;

		public const int LoopUpdStartTimeMilFieldNumber = 2;

		private bool hasLoopUpdStartTimeMil;

		private long loopUpdStartTimeMil_;

		public const int LoopRewardNextIdFieldNumber = 3;

		private bool hasLoopRewardNextId;

		private int loopRewardNextId_;

		public const int OrderRewardIndexFieldNumber = 4;

		private bool hasOrderRewardIndex;

		private int orderRewardIndex_;

		public const int OrderRewardNextId1FieldNumber = 5;

		private bool hasOrderRewardNextId1;

		private int orderRewardNextId1_;

		public const int OrderRewardNextId2FieldNumber = 6;

		private bool hasOrderRewardNextId2;

		private int orderRewardNextId2_;

		public const int OrderRewardNextId3FieldNumber = 7;

		private bool hasOrderRewardNextId3;

		private int orderRewardNextId3_;

		public const int CountWatchedVideoCountFieldNumber = 8;

		private bool hasCountWatchedVideoCount;

		private int countWatchedVideoCount_;

		public const int CountRewardNextIdFieldNumber = 9;

		private bool hasCountRewardNextId;

		private int countRewardNextId_;

		public const int CountHasRewardedFieldNumber = 10;

		private bool hasCountHasRewarded;

		private bool countHasRewarded_;

		private int memoizedSerializedSize;

		public static CCVideoFreeNew DefaultInstance => null;

		public override CCVideoFreeNew DefaultInstanceForType => null;

		protected override CCVideoFreeNew ThisMessage => null;

		public bool HasUpdateDayStartTimeMil => false;

		public long UpdateDayStartTimeMil => 0L;

		public bool HasLoopUpdStartTimeMil => false;

		public long LoopUpdStartTimeMil => 0L;

		public bool HasLoopRewardNextId => false;

		public int LoopRewardNextId => 0;

		public bool HasOrderRewardIndex => false;

		public int OrderRewardIndex => 0;

		public bool HasOrderRewardNextId1 => false;

		public int OrderRewardNextId1 => 0;

		public bool HasOrderRewardNextId2 => false;

		public int OrderRewardNextId2 => 0;

		public bool HasOrderRewardNextId3 => false;

		public int OrderRewardNextId3 => 0;

		public bool HasCountWatchedVideoCount => false;

		public int CountWatchedVideoCount => 0;

		public bool HasCountRewardNextId => false;

		public int CountRewardNextId => 0;

		public bool HasCountHasRewarded => false;

		public bool CountHasRewarded => false;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCVideoFreeNew()
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

		public static CCVideoFreeNew ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCVideoFreeNew ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoFreeNew ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCVideoFreeNew ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoFreeNew ParseFrom(Stream input)
		{
			return null;
		}

		public static CCVideoFreeNew ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoFreeNew ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCVideoFreeNew ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoFreeNew ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCVideoFreeNew ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCVideoFreeNew MakeReadOnly()
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

		public static Builder CreateBuilder(CCVideoFreeNew prototype)
		{
			return null;
		}

		static CCVideoFreeNew()
		{
		}
	}
}
