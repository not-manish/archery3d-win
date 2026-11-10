using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCEquipData : GeneratedMessageLite<CCEquipData, CCEquipData.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCEquipData, Builder>
		{
			private bool resultIsReadOnly;

			private CCEquipData result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCEquipData MessageBeingBuilt => null;

			public override CCEquipData DefaultInstanceForType => null;

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

			public IPopsicleList<CCEquipArrow> EquipArrowList => null;

			public int EquipArrowCount => 0;

			public IPopsicleList<CCEquipOthers> EquipArmList => null;

			public int EquipArmCount => 0;

			public IPopsicleList<CCEquipOthers> EquipBowList => null;

			public int EquipBowCount => 0;

			public IPopsicleList<CCEquipOthers> EquipSightList => null;

			public int EquipSightCount => 0;

			public IPopsicleList<CCEquipOthers> EquipStabilizerList => null;

			public int EquipStabilizerCount => 0;

			public Builder()
			{
			}

			internal Builder(CCEquipData cloneFrom)
			{
			}

			private CCEquipData PrepareBuilder()
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

			public override CCEquipData BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCEquipData other)
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

			public Builder SetArmId(int value)
			{
				return null;
			}

			public Builder ClearArmId()
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

			public CCEquipArrow GetEquipArrow(int index)
			{
				return null;
			}

			public Builder SetEquipArrow(int index, CCEquipArrow value)
			{
				return null;
			}

			public Builder SetEquipArrow(int index, CCEquipArrow.Builder builderForValue)
			{
				return null;
			}

			public Builder AddEquipArrow(CCEquipArrow value)
			{
				return null;
			}

			public Builder AddEquipArrow(CCEquipArrow.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeEquipArrow(IEnumerable<CCEquipArrow> values)
			{
				return null;
			}

			public Builder ClearEquipArrow()
			{
				return null;
			}

			public CCEquipOthers GetEquipArm(int index)
			{
				return null;
			}

			public Builder SetEquipArm(int index, CCEquipOthers value)
			{
				return null;
			}

			public Builder SetEquipArm(int index, CCEquipOthers.Builder builderForValue)
			{
				return null;
			}

			public Builder AddEquipArm(CCEquipOthers value)
			{
				return null;
			}

			public Builder AddEquipArm(CCEquipOthers.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeEquipArm(IEnumerable<CCEquipOthers> values)
			{
				return null;
			}

			public Builder ClearEquipArm()
			{
				return null;
			}

			public CCEquipOthers GetEquipBow(int index)
			{
				return null;
			}

			public Builder SetEquipBow(int index, CCEquipOthers value)
			{
				return null;
			}

			public Builder SetEquipBow(int index, CCEquipOthers.Builder builderForValue)
			{
				return null;
			}

			public Builder AddEquipBow(CCEquipOthers value)
			{
				return null;
			}

			public Builder AddEquipBow(CCEquipOthers.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeEquipBow(IEnumerable<CCEquipOthers> values)
			{
				return null;
			}

			public Builder ClearEquipBow()
			{
				return null;
			}

			public CCEquipOthers GetEquipSight(int index)
			{
				return null;
			}

			public Builder SetEquipSight(int index, CCEquipOthers value)
			{
				return null;
			}

			public Builder SetEquipSight(int index, CCEquipOthers.Builder builderForValue)
			{
				return null;
			}

			public Builder AddEquipSight(CCEquipOthers value)
			{
				return null;
			}

			public Builder AddEquipSight(CCEquipOthers.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeEquipSight(IEnumerable<CCEquipOthers> values)
			{
				return null;
			}

			public Builder ClearEquipSight()
			{
				return null;
			}

			public CCEquipOthers GetEquipStabilizer(int index)
			{
				return null;
			}

			public Builder SetEquipStabilizer(int index, CCEquipOthers value)
			{
				return null;
			}

			public Builder SetEquipStabilizer(int index, CCEquipOthers.Builder builderForValue)
			{
				return null;
			}

			public Builder AddEquipStabilizer(CCEquipOthers value)
			{
				return null;
			}

			public Builder AddEquipStabilizer(CCEquipOthers.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeEquipStabilizer(IEnumerable<CCEquipOthers> values)
			{
				return null;
			}

			public Builder ClearEquipStabilizer()
			{
				return null;
			}
		}

		private static readonly CCEquipData defaultInstance;

		private static readonly string[] _cCEquipDataFieldNames;

		private static readonly uint[] _cCEquipDataFieldTags;

		public const int BowIdFieldNumber = 1;

		private bool hasBowId;

		private int bowId_;

		public const int ArrowIdFieldNumber = 2;

		private bool hasArrowId;

		private int arrowId_;

		public const int ArmIdFieldNumber = 3;

		private bool hasArmId;

		private int armId_;

		public const int SightIdFieldNumber = 4;

		private bool hasSightId;

		private int sightId_;

		public const int StabilizerIdFieldNumber = 5;

		private bool hasStabilizerId;

		private int stabilizerId_;

		public const int EquipArrowFieldNumber = 8;

		private PopsicleList<CCEquipArrow> equipArrow_;

		public const int EquipArmFieldNumber = 6;

		private PopsicleList<CCEquipOthers> equipArm_;

		public const int EquipBowFieldNumber = 7;

		private PopsicleList<CCEquipOthers> equipBow_;

		public const int EquipSightFieldNumber = 9;

		private PopsicleList<CCEquipOthers> equipSight_;

		public const int EquipStabilizerFieldNumber = 10;

		private PopsicleList<CCEquipOthers> equipStabilizer_;

		private int memoizedSerializedSize;

		public static CCEquipData DefaultInstance => null;

		public override CCEquipData DefaultInstanceForType => null;

		protected override CCEquipData ThisMessage => null;

		public bool HasBowId => false;

		public int BowId => 0;

		public bool HasArrowId => false;

		public int ArrowId => 0;

		public bool HasArmId => false;

		public int ArmId => 0;

		public bool HasSightId => false;

		public int SightId => 0;

		public bool HasStabilizerId => false;

		public int StabilizerId => 0;

		public IList<CCEquipArrow> EquipArrowList => null;

		public int EquipArrowCount => 0;

		public IList<CCEquipOthers> EquipArmList => null;

		public int EquipArmCount => 0;

		public IList<CCEquipOthers> EquipBowList => null;

		public int EquipBowCount => 0;

		public IList<CCEquipOthers> EquipSightList => null;

		public int EquipSightCount => 0;

		public IList<CCEquipOthers> EquipStabilizerList => null;

		public int EquipStabilizerCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCEquipData()
		{
		}

		public CCEquipArrow GetEquipArrow(int index)
		{
			return null;
		}

		public CCEquipOthers GetEquipArm(int index)
		{
			return null;
		}

		public CCEquipOthers GetEquipBow(int index)
		{
			return null;
		}

		public CCEquipOthers GetEquipSight(int index)
		{
			return null;
		}

		public CCEquipOthers GetEquipStabilizer(int index)
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

		public static CCEquipData ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCEquipData ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEquipData ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCEquipData ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEquipData ParseFrom(Stream input)
		{
			return null;
		}

		public static CCEquipData ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEquipData ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCEquipData ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEquipData ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCEquipData ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCEquipData MakeReadOnly()
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

		public static Builder CreateBuilder(CCEquipData prototype)
		{
			return null;
		}

		static CCEquipData()
		{
		}
	}
}
