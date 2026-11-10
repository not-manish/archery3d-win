using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCChallengeLevel : GeneratedMessageLite<CCChallengeLevel, CCChallengeLevel.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCChallengeLevel, Builder>
		{
			private bool resultIsReadOnly;

			private CCChallengeLevel result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCChallengeLevel MessageBeingBuilt => null;

			public override CCChallengeLevel DefaultInstanceForType => null;

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

			public bool HasGetScore => false;

			public int GetScore
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasCostTime => false;

			public int CostTime
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

			internal Builder(CCChallengeLevel cloneFrom)
			{
			}

			private CCChallengeLevel PrepareBuilder()
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

			public override CCChallengeLevel BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCChallengeLevel other)
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

			public Builder SetGetScore(int value)
			{
				return null;
			}

			public Builder ClearGetScore()
			{
				return null;
			}

			public Builder SetCostTime(int value)
			{
				return null;
			}

			public Builder ClearCostTime()
			{
				return null;
			}
		}

		private static readonly CCChallengeLevel defaultInstance;

		private static readonly string[] _cCChallengeLevelFieldNames;

		private static readonly uint[] _cCChallengeLevelFieldTags;

		public const int IdFieldNumber = 1;

		private bool hasId;

		private int id_;

		public const int GetScoreFieldNumber = 2;

		private bool hasGetScore;

		private int getScore_;

		public const int CostTimeFieldNumber = 3;

		private bool hasCostTime;

		private int costTime_;

		private int memoizedSerializedSize;

		public static CCChallengeLevel DefaultInstance => null;

		public override CCChallengeLevel DefaultInstanceForType => null;

		protected override CCChallengeLevel ThisMessage => null;

		public bool HasId => false;

		public int Id => 0;

		public bool HasGetScore => false;

		public int GetScore => 0;

		public bool HasCostTime => false;

		public int CostTime => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCChallengeLevel()
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

		public static CCChallengeLevel ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCChallengeLevel ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeLevel ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCChallengeLevel ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeLevel ParseFrom(Stream input)
		{
			return null;
		}

		public static CCChallengeLevel ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeLevel ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCChallengeLevel ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeLevel ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCChallengeLevel ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCChallengeLevel MakeReadOnly()
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

		public static Builder CreateBuilder(CCChallengeLevel prototype)
		{
			return null;
		}

		static CCChallengeLevel()
		{
		}
	}
}
