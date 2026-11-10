using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCSingleLevel : GeneratedMessageLite<CCSingleLevel, CCSingleLevel.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCSingleLevel, Builder>
		{
			private bool resultIsReadOnly;

			private CCSingleLevel result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCSingleLevel MessageBeingBuilt => null;

			public override CCSingleLevel DefaultInstanceForType => null;

			public bool HasId => false;

			public int Id
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasSumScores => false;

			public int SumScores
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasHasGetReward => false;

			public bool HasGetReward
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

			internal Builder(CCSingleLevel cloneFrom)
			{
			}

			private CCSingleLevel PrepareBuilder()
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

			public override CCSingleLevel BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCSingleLevel other)
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

			public Builder SetId(int value)
			{
				return null;
			}

			public Builder ClearId()
			{
				return null;
			}

			public Builder SetSumScores(int value)
			{
				return null;
			}

			public Builder ClearSumScores()
			{
				return null;
			}

			public Builder SetHasGetReward(bool value)
			{
				return null;
			}

			public Builder ClearHasGetReward()
			{
				return null;
			}
		}

		private static readonly CCSingleLevel defaultInstance;

		private static readonly string[] _cCSingleLevelFieldNames;

		private static readonly uint[] _cCSingleLevelFieldTags;

		public const int IdFieldNumber = 1;

		private bool hasId;

		private int id_;

		public const int SumScoresFieldNumber = 2;

		private bool hasSumScores;

		private int sumScores_;

		public const int HasGetRewardFieldNumber = 3;

		private bool hasHasGetReward;

		private bool hasGetReward_;

		private int memoizedSerializedSize;

		public static CCSingleLevel DefaultInstance => null;

		public override CCSingleLevel DefaultInstanceForType => null;

		protected override CCSingleLevel ThisMessage => null;

		public bool HasId => false;

		public int Id => 0;

		public bool HasSumScores => false;

		public int SumScores => 0;

		public bool HasHasGetReward => false;

		public bool HasGetReward => false;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCSingleLevel()
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

		public static CCSingleLevel ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCSingleLevel ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleLevel ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCSingleLevel ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleLevel ParseFrom(Stream input)
		{
			return null;
		}

		public static CCSingleLevel ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleLevel ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCSingleLevel ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleLevel ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCSingleLevel ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCSingleLevel MakeReadOnly()
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

		public static Builder CreateBuilder(CCSingleLevel prototype)
		{
			return null;
		}

		static CCSingleLevel()
		{
		}
	}
}
