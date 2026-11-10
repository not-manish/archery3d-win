using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCAiData : GeneratedMessageLite<CCAiData, CCAiData.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCAiData, Builder>
		{
			private bool resultIsReadOnly;

			private CCAiData result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCAiData MessageBeingBuilt => null;

			public override CCAiData DefaultInstanceForType => null;

			public bool HasGameTypeLevelId => false;

			public int GameTypeLevelId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasIndex => false;

			public int Index
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

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

			public bool HasGetTrophy => false;

			public string GetTrophy
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public IPopsicleList<CCShootItem> ShootItemsList => null;

			public int ShootItemsCount => 0;

			public bool HasArmId => false;

			public int ArmId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasBowId => false;

			public int BowId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasArrowId => false;

			public int ArrowId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasSightId => false;

			public int SightId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasStabilizerId => false;

			public int StabilizerId
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

			internal Builder(CCAiData cloneFrom)
			{
			}

			private CCAiData PrepareBuilder()
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

			public override CCAiData BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCAiData other)
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

			public Builder SetGameTypeLevelId(int value)
			{
				return null;
			}

			public Builder ClearGameTypeLevelId()
			{
				return null;
			}

			public Builder SetIndex(int value)
			{
				return null;
			}

			public Builder ClearIndex()
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

			public Builder SetGetTrophy(string value)
			{
				return null;
			}

			public Builder ClearGetTrophy()
			{
				return null;
			}

			public CCShootItem GetShootItems(int index)
			{
				return null;
			}

			public Builder SetShootItems(int index, CCShootItem value)
			{
				return null;
			}

			public Builder SetShootItems(int index, CCShootItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddShootItems(CCShootItem value)
			{
				return null;
			}

			public Builder AddShootItems(CCShootItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeShootItems(IEnumerable<CCShootItem> values)
			{
				return null;
			}

			public Builder ClearShootItems()
			{
				return null;
			}

			public Builder SetArmId(int value)
			{
				return null;
			}

			public Builder ClearArmId()
			{
				return null;
			}

			public Builder SetBowId(int value)
			{
				return null;
			}

			public Builder ClearBowId()
			{
				return null;
			}

			public Builder SetArrowId(int value)
			{
				return null;
			}

			public Builder ClearArrowId()
			{
				return null;
			}

			public Builder SetSightId(int value)
			{
				return null;
			}

			public Builder ClearSightId()
			{
				return null;
			}

			public Builder SetStabilizerId(int value)
			{
				return null;
			}

			public Builder ClearStabilizerId()
			{
				return null;
			}
		}

		private static readonly CCAiData defaultInstance;

		private static readonly string[] _cCAiDataFieldNames;

		private static readonly uint[] _cCAiDataFieldTags;

		public const int GameTypeLevelIdFieldNumber = 1;

		private bool hasGameTypeLevelId;

		private int gameTypeLevelId_;

		public const int IndexFieldNumber = 2;

		private bool hasIndex;

		private int index_;

		public const int UidFieldNumber = 3;

		private bool hasUid;

		private string uid_;

		public const int GetTrophyFieldNumber = 4;

		private bool hasGetTrophy;

		private string getTrophy_;

		public const int ShootItemsFieldNumber = 5;

		private PopsicleList<CCShootItem> shootItems_;

		public const int ArmIdFieldNumber = 6;

		private bool hasArmId;

		private int armId_;

		public const int BowIdFieldNumber = 7;

		private bool hasBowId;

		private int bowId_;

		public const int ArrowIdFieldNumber = 8;

		private bool hasArrowId;

		private int arrowId_;

		public const int SightIdFieldNumber = 9;

		private bool hasSightId;

		private int sightId_;

		public const int StabilizerIdFieldNumber = 10;

		private bool hasStabilizerId;

		private int stabilizerId_;

		private int memoizedSerializedSize;

		public static CCAiData DefaultInstance => null;

		public override CCAiData DefaultInstanceForType => null;

		protected override CCAiData ThisMessage => null;

		public bool HasGameTypeLevelId => false;

		public int GameTypeLevelId => 0;

		public bool HasIndex => false;

		public int Index => 0;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasGetTrophy => false;

		public string GetTrophy => null;

		public IList<CCShootItem> ShootItemsList => null;

		public int ShootItemsCount => 0;

		public bool HasArmId => false;

		public int ArmId => 0;

		public bool HasBowId => false;

		public int BowId => 0;

		public bool HasArrowId => false;

		public int ArrowId => 0;

		public bool HasSightId => false;

		public int SightId => 0;

		public bool HasStabilizerId => false;

		public int StabilizerId => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCAiData()
		{
		}

		public CCShootItem GetShootItems(int index)
		{
			return null;
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

		public static CCAiData ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCAiData ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAiData ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCAiData ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAiData ParseFrom(Stream input)
		{
			return null;
		}

		public static CCAiData ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAiData ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCAiData ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAiData ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCAiData ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCAiData MakeReadOnly()
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

		public static Builder CreateBuilder(CCAiData prototype)
		{
			return null;
		}

		static CCAiData()
		{
		}
	}
}
