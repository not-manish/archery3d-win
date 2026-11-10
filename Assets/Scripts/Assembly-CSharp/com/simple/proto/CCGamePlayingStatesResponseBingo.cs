using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCGamePlayingStatesResponseBingo : GeneratedMessageLite<CCGamePlayingStatesResponseBingo, CCGamePlayingStatesResponseBingo.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCGamePlayingStatesResponseBingo, Builder>
		{
			private bool resultIsReadOnly;

			private CCGamePlayingStatesResponseBingo result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCGamePlayingStatesResponseBingo MessageBeingBuilt => null;

			public override CCGamePlayingStatesResponseBingo DefaultInstanceForType => null;

			public IPopsicleList<int> ScoreMyList => null;

			public int ScoreMyCount => 0;

			public IPopsicleList<int> ScoreOppList => null;

			public int ScoreOppCount => 0;

			public IPopsicleList<int> BingoMy5X5List => null;

			public int BingoMy5X5Count => 0;

			public IPopsicleList<int> BingoOpp5X5List => null;

			public int BingoOpp5X5Count => 0;

			public Builder()
			{
			}

			internal Builder(CCGamePlayingStatesResponseBingo cloneFrom)
			{
			}

			private CCGamePlayingStatesResponseBingo PrepareBuilder()
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

			public override CCGamePlayingStatesResponseBingo BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCGamePlayingStatesResponseBingo other)
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

			public int GetScoreMy(int index)
			{
				return 0;
			}

			public Builder SetScoreMy(int index, int value)
			{
				return null;
			}

			public Builder AddScoreMy(int value)
			{
				return null;
			}

			public Builder AddRangeScoreMy(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearScoreMy()
			{
				return null;
			}

			public int GetScoreOpp(int index)
			{
				return 0;
			}

			public Builder SetScoreOpp(int index, int value)
			{
				return null;
			}

			public Builder AddScoreOpp(int value)
			{
				return null;
			}

			public Builder AddRangeScoreOpp(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearScoreOpp()
			{
				return null;
			}

			public int GetBingoMy5X5(int index)
			{
				return 0;
			}

			public Builder SetBingoMy5X5(int index, int value)
			{
				return null;
			}

			public Builder AddBingoMy5X5(int value)
			{
				return null;
			}

			public Builder AddRangeBingoMy5X5(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearBingoMy5X5()
			{
				return null;
			}

			public int GetBingoOpp5X5(int index)
			{
				return 0;
			}

			public Builder SetBingoOpp5X5(int index, int value)
			{
				return null;
			}

			public Builder AddBingoOpp5X5(int value)
			{
				return null;
			}

			public Builder AddRangeBingoOpp5X5(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearBingoOpp5X5()
			{
				return null;
			}
		}

		private static readonly CCGamePlayingStatesResponseBingo defaultInstance;

		private static readonly string[] _cCGamePlayingStatesResponseBingoFieldNames;

		private static readonly uint[] _cCGamePlayingStatesResponseBingoFieldTags;

		public const int ScoreMyFieldNumber = 2;

		private PopsicleList<int> scoreMy_;

		public const int ScoreOppFieldNumber = 3;

		private PopsicleList<int> scoreOpp_;

		public const int BingoMy5X5FieldNumber = 4;

		private PopsicleList<int> bingoMy5X5_;

		public const int BingoOpp5X5FieldNumber = 5;

		private PopsicleList<int> bingoOpp5X5_;

		private int memoizedSerializedSize;

		public static CCGamePlayingStatesResponseBingo DefaultInstance => null;

		public override CCGamePlayingStatesResponseBingo DefaultInstanceForType => null;

		protected override CCGamePlayingStatesResponseBingo ThisMessage => null;

		public IList<int> ScoreMyList => null;

		public int ScoreMyCount => 0;

		public IList<int> ScoreOppList => null;

		public int ScoreOppCount => 0;

		public IList<int> BingoMy5X5List => null;

		public int BingoMy5X5Count => 0;

		public IList<int> BingoOpp5X5List => null;

		public int BingoOpp5X5Count => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCGamePlayingStatesResponseBingo()
		{
		}

		public int GetScoreMy(int index)
		{
			return 0;
		}

		public int GetScoreOpp(int index)
		{
			return 0;
		}

		public int GetBingoMy5X5(int index)
		{
			return 0;
		}

		public int GetBingoOpp5X5(int index)
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

		public static CCGamePlayingStatesResponseBingo ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseBingo ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseBingo ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseBingo ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseBingo ParseFrom(Stream input)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseBingo ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseBingo ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseBingo ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseBingo ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseBingo ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCGamePlayingStatesResponseBingo MakeReadOnly()
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

		public static Builder CreateBuilder(CCGamePlayingStatesResponseBingo prototype)
		{
			return null;
		}

		static CCGamePlayingStatesResponseBingo()
		{
		}
	}
}
