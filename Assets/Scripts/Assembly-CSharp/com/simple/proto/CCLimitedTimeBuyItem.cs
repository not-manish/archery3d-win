using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCLimitedTimeBuyItem : GeneratedMessageLite<CCLimitedTimeBuyItem, CCLimitedTimeBuyItem.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCLimitedTimeBuyItem, Builder>
		{
			private bool resultIsReadOnly;

			private CCLimitedTimeBuyItem result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCLimitedTimeBuyItem MessageBeingBuilt => null;

			public override CCLimitedTimeBuyItem DefaultInstanceForType => null;

			public bool HasPackState => false;

			public int PackState
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public IPopsicleList<int> PackUnlocIdsList => null;

			public int PackUnlocIdsCount => 0;

			public bool HasPackUnlocHasShow => false;

			public bool PackUnlocHasShow
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasPackUnlockStartTimeMil => false;

			public long PackUnlockStartTimeMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasPackUnlockDurationTimeMil => false;

			public long PackUnlockDurationTimeMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasPackCooldownStartTimeMil => false;

			public long PackCooldownStartTimeMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasPackCooldownDurationTimeMil => false;

			public long PackCooldownDurationTimeMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasShowTimes => false;

			public int ShowTimes
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

			internal Builder(CCLimitedTimeBuyItem cloneFrom)
			{
			}

			private CCLimitedTimeBuyItem PrepareBuilder()
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

			public override CCLimitedTimeBuyItem BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCLimitedTimeBuyItem other)
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

			public Builder SetPackState(int value)
			{
				return null;
			}

			public Builder ClearPackState()
			{
				return null;
			}

			public int GetPackUnlocIds(int index)
			{
				return 0;
			}

			public Builder SetPackUnlocIds(int index, int value)
			{
				return null;
			}

			public Builder AddPackUnlocIds(int value)
			{
				return null;
			}

			public Builder AddRangePackUnlocIds(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearPackUnlocIds()
			{
				return null;
			}

			public Builder SetPackUnlocHasShow(bool value)
			{
				return null;
			}

			public Builder ClearPackUnlocHasShow()
			{
				return null;
			}

			public Builder SetPackUnlockStartTimeMil(long value)
			{
				return null;
			}

			public Builder ClearPackUnlockStartTimeMil()
			{
				return null;
			}

			public Builder SetPackUnlockDurationTimeMil(long value)
			{
				return null;
			}

			public Builder ClearPackUnlockDurationTimeMil()
			{
				return null;
			}

			public Builder SetPackCooldownStartTimeMil(long value)
			{
				return null;
			}

			public Builder ClearPackCooldownStartTimeMil()
			{
				return null;
			}

			public Builder SetPackCooldownDurationTimeMil(long value)
			{
				return null;
			}

			public Builder ClearPackCooldownDurationTimeMil()
			{
				return null;
			}

			public Builder SetShowTimes(int value)
			{
				return null;
			}

			public Builder ClearShowTimes()
			{
				return null;
			}
		}

		private static readonly CCLimitedTimeBuyItem defaultInstance;

		private static readonly string[] _cCLimitedTimeBuyItemFieldNames;

		private static readonly uint[] _cCLimitedTimeBuyItemFieldTags;

		public const int PackStateFieldNumber = 1;

		private bool hasPackState;

		private int packState_;

		public const int PackUnlocIdsFieldNumber = 2;

		private PopsicleList<int> packUnlocIds_;

		public const int PackUnlocHasShowFieldNumber = 3;

		private bool hasPackUnlocHasShow;

		private bool packUnlocHasShow_;

		public const int PackUnlockStartTimeMilFieldNumber = 4;

		private bool hasPackUnlockStartTimeMil;

		private long packUnlockStartTimeMil_;

		public const int PackUnlockDurationTimeMilFieldNumber = 5;

		private bool hasPackUnlockDurationTimeMil;

		private long packUnlockDurationTimeMil_;

		public const int PackCooldownStartTimeMilFieldNumber = 6;

		private bool hasPackCooldownStartTimeMil;

		private long packCooldownStartTimeMil_;

		public const int PackCooldownDurationTimeMilFieldNumber = 7;

		private bool hasPackCooldownDurationTimeMil;

		private long packCooldownDurationTimeMil_;

		public const int ShowTimesFieldNumber = 8;

		private bool hasShowTimes;

		private int showTimes_;

		private int memoizedSerializedSize;

		public static CCLimitedTimeBuyItem DefaultInstance => null;

		public override CCLimitedTimeBuyItem DefaultInstanceForType => null;

		protected override CCLimitedTimeBuyItem ThisMessage => null;

		public bool HasPackState => false;

		public int PackState => 0;

		public IList<int> PackUnlocIdsList => null;

		public int PackUnlocIdsCount => 0;

		public bool HasPackUnlocHasShow => false;

		public bool PackUnlocHasShow => false;

		public bool HasPackUnlockStartTimeMil => false;

		public long PackUnlockStartTimeMil => 0L;

		public bool HasPackUnlockDurationTimeMil => false;

		public long PackUnlockDurationTimeMil => 0L;

		public bool HasPackCooldownStartTimeMil => false;

		public long PackCooldownStartTimeMil => 0L;

		public bool HasPackCooldownDurationTimeMil => false;

		public long PackCooldownDurationTimeMil => 0L;

		public bool HasShowTimes => false;

		public int ShowTimes => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCLimitedTimeBuyItem()
		{
		}

		public int GetPackUnlocIds(int index)
		{
			return 0;
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

		public static CCLimitedTimeBuyItem ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCLimitedTimeBuyItem ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLimitedTimeBuyItem ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCLimitedTimeBuyItem ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLimitedTimeBuyItem ParseFrom(Stream input)
		{
			return null;
		}

		public static CCLimitedTimeBuyItem ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLimitedTimeBuyItem ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCLimitedTimeBuyItem ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCLimitedTimeBuyItem ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCLimitedTimeBuyItem ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCLimitedTimeBuyItem MakeReadOnly()
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

		public static Builder CreateBuilder(CCLimitedTimeBuyItem prototype)
		{
			return null;
		}

		static CCLimitedTimeBuyItem()
		{
		}
	}
}
