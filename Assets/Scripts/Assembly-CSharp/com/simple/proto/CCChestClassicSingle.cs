using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCChestClassicSingle : GeneratedMessageLite<CCChestClassicSingle, CCChestClassicSingle.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCChestClassicSingle, Builder>
		{
			private bool resultIsReadOnly;

			private CCChestClassicSingle result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCChestClassicSingle MessageBeingBuilt => null;

			public override CCChestClassicSingle DefaultInstanceForType => null;

			public bool HasChestKind => false;

			public int ChestKind
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasChestId => false;

			public int ChestId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasHasUnlocked => false;

			public bool HasUnlocked
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasUnlockedTime => false;

			public long UnlockedTime
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasDurationTime => false;

			public long DurationTime
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasVideoSubTimes => false;

			public int VideoSubTimes
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

			internal Builder(CCChestClassicSingle cloneFrom)
			{
			}

			private CCChestClassicSingle PrepareBuilder()
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

			public override CCChestClassicSingle BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCChestClassicSingle other)
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

			public Builder SetChestKind(int value)
			{
				return null;
			}

			public Builder ClearChestKind()
			{
				return null;
			}

			public Builder SetChestId(int value)
			{
				return null;
			}

			public Builder ClearChestId()
			{
				return null;
			}

			public Builder SetHasUnlocked(bool value)
			{
				return null;
			}

			public Builder ClearHasUnlocked()
			{
				return null;
			}

			public Builder SetUnlockedTime(long value)
			{
				return null;
			}

			public Builder ClearUnlockedTime()
			{
				return null;
			}

			public Builder SetDurationTime(long value)
			{
				return null;
			}

			public Builder ClearDurationTime()
			{
				return null;
			}

			public Builder SetVideoSubTimes(int value)
			{
				return null;
			}

			public Builder ClearVideoSubTimes()
			{
				return null;
			}
		}

		private static readonly CCChestClassicSingle defaultInstance;

		private static readonly string[] _cCChestClassicSingleFieldNames;

		private static readonly uint[] _cCChestClassicSingleFieldTags;

		public const int ChestKindFieldNumber = 1;

		private bool hasChestKind;

		private int chestKind_;

		public const int ChestIdFieldNumber = 2;

		private bool hasChestId;

		private int chestId_;

		public const int HasUnlockedFieldNumber = 3;

		private bool hasHasUnlocked;

		private bool hasUnlocked_;

		public const int UnlockedTimeFieldNumber = 4;

		private bool hasUnlockedTime;

		private long unlockedTime_;

		public const int DurationTimeFieldNumber = 5;

		private bool hasDurationTime;

		private long durationTime_;

		public const int VideoSubTimesFieldNumber = 6;

		private bool hasVideoSubTimes;

		private int videoSubTimes_;

		private int memoizedSerializedSize;

		public static CCChestClassicSingle DefaultInstance => null;

		public override CCChestClassicSingle DefaultInstanceForType => null;

		protected override CCChestClassicSingle ThisMessage => null;

		public bool HasChestKind => false;

		public int ChestKind => 0;

		public bool HasChestId => false;

		public int ChestId => 0;

		public bool HasHasUnlocked => false;

		public bool HasUnlocked => false;

		public bool HasUnlockedTime => false;

		public long UnlockedTime => 0L;

		public bool HasDurationTime => false;

		public long DurationTime => 0L;

		public bool HasVideoSubTimes => false;

		public int VideoSubTimes => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCChestClassicSingle()
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

		public static CCChestClassicSingle ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCChestClassicSingle ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestClassicSingle ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCChestClassicSingle ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestClassicSingle ParseFrom(Stream input)
		{
			return null;
		}

		public static CCChestClassicSingle ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestClassicSingle ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCChestClassicSingle ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChestClassicSingle ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCChestClassicSingle ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCChestClassicSingle MakeReadOnly()
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

		public static Builder CreateBuilder(CCChestClassicSingle prototype)
		{
			return null;
		}

		static CCChestClassicSingle()
		{
		}
	}
}
