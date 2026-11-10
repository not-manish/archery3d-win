using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCAchievementSubData : GeneratedMessageLite<CCAchievementSubData, CCAchievementSubData.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCAchievementSubData, Builder>
		{
			private bool resultIsReadOnly;

			private CCAchievementSubData result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCAchievementSubData MessageBeingBuilt => null;

			public override CCAchievementSubData DefaultInstanceForType => null;

			public bool HasPointsCount => false;

			public int PointsCount
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public IPopsicleList<CCAchievementSubItem> AchSubItemsList => null;

			public int AchSubItemsCount => 0;

			public Builder()
			{
			}

			internal Builder(CCAchievementSubData cloneFrom)
			{
			}

			private CCAchievementSubData PrepareBuilder()
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

			public override CCAchievementSubData BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCAchievementSubData other)
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

			public Builder SetPointsCount(int value)
			{
				return null;
			}

			public Builder ClearPointsCount()
			{
				return null;
			}

			public CCAchievementSubItem GetAchSubItems(int index)
			{
				return null;
			}

			public Builder SetAchSubItems(int index, CCAchievementSubItem value)
			{
				return null;
			}

			public Builder SetAchSubItems(int index, CCAchievementSubItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddAchSubItems(CCAchievementSubItem value)
			{
				return null;
			}

			public Builder AddAchSubItems(CCAchievementSubItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeAchSubItems(IEnumerable<CCAchievementSubItem> values)
			{
				return null;
			}

			public Builder ClearAchSubItems()
			{
				return null;
			}
		}

		private static readonly CCAchievementSubData defaultInstance;

		private static readonly string[] _cCAchievementSubDataFieldNames;

		private static readonly uint[] _cCAchievementSubDataFieldTags;

		public const int PointsCountFieldNumber = 1;

		private bool hasPointsCount;

		private int pointsCount_;

		public const int AchSubItemsFieldNumber = 2;

		private PopsicleList<CCAchievementSubItem> achSubItems_;

		private int memoizedSerializedSize;

		public static CCAchievementSubData DefaultInstance => null;

		public override CCAchievementSubData DefaultInstanceForType => null;

		protected override CCAchievementSubData ThisMessage => null;

		public bool HasPointsCount => false;

		public int PointsCount => 0;

		public IList<CCAchievementSubItem> AchSubItemsList => null;

		public int AchSubItemsCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCAchievementSubData()
		{
		}

		public CCAchievementSubItem GetAchSubItems(int index)
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

		public static CCAchievementSubData ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCAchievementSubData ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAchievementSubData ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCAchievementSubData ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAchievementSubData ParseFrom(Stream input)
		{
			return null;
		}

		public static CCAchievementSubData ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAchievementSubData ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCAchievementSubData ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCAchievementSubData ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCAchievementSubData ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCAchievementSubData MakeReadOnly()
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

		public static Builder CreateBuilder(CCAchievementSubData prototype)
		{
			return null;
		}

		static CCAchievementSubData()
		{
		}
	}
}
