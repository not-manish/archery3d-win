using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCStatisticData : GeneratedMessageLite<CCStatisticData, CCStatisticData.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCStatisticData, Builder>
		{
			private bool resultIsReadOnly;

			private CCStatisticData result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCStatisticData MessageBeingBuilt => null;

			public override CCStatisticData DefaultInstanceForType => null;

			public bool HasShootTimesExceptBingo => false;

			public int ShootTimesExceptBingo
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasAverageRounds => false;

			public float AverageRounds
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public Builder()
			{
			}

			internal Builder(CCStatisticData cloneFrom)
			{
			}

			private CCStatisticData PrepareBuilder()
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

			public override CCStatisticData BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCStatisticData other)
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

			public Builder SetShootTimesExceptBingo(int value)
			{
				return null;
			}

			public Builder ClearShootTimesExceptBingo()
			{
				return null;
			}

			public Builder SetAverageRounds(float value)
			{
				return null;
			}

			public Builder ClearAverageRounds()
			{
				return null;
			}
		}

		private static readonly CCStatisticData defaultInstance;

		private static readonly string[] _cCStatisticDataFieldNames;

		private static readonly uint[] _cCStatisticDataFieldTags;

		public const int ShootTimesExceptBingoFieldNumber = 1;

		private bool hasShootTimesExceptBingo;

		private int shootTimesExceptBingo_;

		public const int AverageRoundsFieldNumber = 2;

		private bool hasAverageRounds;

		private float averageRounds_;

		private int memoizedSerializedSize;

		public static CCStatisticData DefaultInstance => null;

		public override CCStatisticData DefaultInstanceForType => null;

		protected override CCStatisticData ThisMessage => null;

		public bool HasShootTimesExceptBingo => false;

		public int ShootTimesExceptBingo => 0;

		public bool HasAverageRounds => false;

		public float AverageRounds => 0f;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCStatisticData()
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

		public static CCStatisticData ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCStatisticData ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCStatisticData ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCStatisticData ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCStatisticData ParseFrom(Stream input)
		{
			return null;
		}

		public static CCStatisticData ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCStatisticData ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCStatisticData ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCStatisticData ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCStatisticData ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCStatisticData MakeReadOnly()
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

		public static Builder CreateBuilder(CCStatisticData prototype)
		{
			return null;
		}

		static CCStatisticData()
		{
		}
	}
}
