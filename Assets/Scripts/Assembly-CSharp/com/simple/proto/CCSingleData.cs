using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCSingleData : GeneratedMessageLite<CCSingleData, CCSingleData.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCSingleData, Builder>
		{
			private bool resultIsReadOnly;

			private CCSingleData result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCSingleData MessageBeingBuilt => null;

			public override CCSingleData DefaultInstanceForType => null;

			public IPopsicleList<CCSingleLevel> LevelInfosList => null;

			public int LevelInfosCount => 0;

			public Builder()
			{
			}

			internal Builder(CCSingleData cloneFrom)
			{
			}

			private CCSingleData PrepareBuilder()
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

			public override CCSingleData BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCSingleData other)
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

			public CCSingleLevel GetLevelInfos(int index)
			{
				return null;
			}

			public Builder SetLevelInfos(int index, CCSingleLevel value)
			{
				return null;
			}

			public Builder SetLevelInfos(int index, CCSingleLevel.Builder builderForValue)
			{
				return null;
			}

			public Builder AddLevelInfos(CCSingleLevel value)
			{
				return null;
			}

			public Builder AddLevelInfos(CCSingleLevel.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeLevelInfos(IEnumerable<CCSingleLevel> values)
			{
				return null;
			}

			public Builder ClearLevelInfos()
			{
				return null;
			}
		}

		private static readonly CCSingleData defaultInstance;

		private static readonly string[] _cCSingleDataFieldNames;

		private static readonly uint[] _cCSingleDataFieldTags;

		public const int LevelInfosFieldNumber = 1;

		private PopsicleList<CCSingleLevel> levelInfos_;

		private int memoizedSerializedSize;

		public static CCSingleData DefaultInstance => null;

		public override CCSingleData DefaultInstanceForType => null;

		protected override CCSingleData ThisMessage => null;

		public IList<CCSingleLevel> LevelInfosList => null;

		public int LevelInfosCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCSingleData()
		{
		}

		public CCSingleLevel GetLevelInfos(int index)
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

		public static CCSingleData ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCSingleData ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleData ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCSingleData ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleData ParseFrom(Stream input)
		{
			return null;
		}

		public static CCSingleData ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleData ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCSingleData ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleData ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCSingleData ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCSingleData MakeReadOnly()
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

		public static Builder CreateBuilder(CCSingleData prototype)
		{
			return null;
		}

		static CCSingleData()
		{
		}
	}
}
