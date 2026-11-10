using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCGamePlayingStatesResponseChongCi : GeneratedMessageLite<CCGamePlayingStatesResponseChongCi, CCGamePlayingStatesResponseChongCi.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCGamePlayingStatesResponseChongCi, Builder>
		{
			private bool resultIsReadOnly;

			private CCGamePlayingStatesResponseChongCi result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCGamePlayingStatesResponseChongCi MessageBeingBuilt => null;

			public override CCGamePlayingStatesResponseChongCi DefaultInstanceForType => null;

			public bool HasIsFinals => false;

			public int IsFinals
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public IPopsicleList<int> RoundCountMyList => null;

			public int RoundCountMyCount => 0;

			public IPopsicleList<int> RoundCountOppList => null;

			public int RoundCountOppCount => 0;

			public IPopsicleList<int> ScoreMyList => null;

			public int ScoreMyCount => 0;

			public IPopsicleList<int> ScoreOppList => null;

			public int ScoreOppCount => 0;

			public Builder()
			{
			}

			internal Builder(CCGamePlayingStatesResponseChongCi cloneFrom)
			{
			}

			private CCGamePlayingStatesResponseChongCi PrepareBuilder()
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

			public override CCGamePlayingStatesResponseChongCi BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCGamePlayingStatesResponseChongCi other)
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

			public Builder SetIsFinals(int value)
			{
				return null;
			}

			public Builder ClearIsFinals()
			{
				return null;
			}

			public int GetRoundCountMy(int index)
			{
				return 0;
			}

			public Builder SetRoundCountMy(int index, int value)
			{
				return null;
			}

			public Builder AddRoundCountMy(int value)
			{
				return null;
			}

			public Builder AddRangeRoundCountMy(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearRoundCountMy()
			{
				return null;
			}

			public int GetRoundCountOpp(int index)
			{
				return 0;
			}

			public Builder SetRoundCountOpp(int index, int value)
			{
				return null;
			}

			public Builder AddRoundCountOpp(int value)
			{
				return null;
			}

			public Builder AddRangeRoundCountOpp(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearRoundCountOpp()
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
		}

		private static readonly CCGamePlayingStatesResponseChongCi defaultInstance;

		private static readonly string[] _cCGamePlayingStatesResponseChongCiFieldNames;

		private static readonly uint[] _cCGamePlayingStatesResponseChongCiFieldTags;

		public const int IsFinalsFieldNumber = 1;

		private bool hasIsFinals;

		private int isFinals_;

		public const int RoundCountMyFieldNumber = 2;

		private PopsicleList<int> roundCountMy_;

		public const int RoundCountOppFieldNumber = 3;

		private PopsicleList<int> roundCountOpp_;

		public const int ScoreMyFieldNumber = 4;

		private PopsicleList<int> scoreMy_;

		public const int ScoreOppFieldNumber = 5;

		private PopsicleList<int> scoreOpp_;

		private int memoizedSerializedSize;

		public static CCGamePlayingStatesResponseChongCi DefaultInstance => null;

		public override CCGamePlayingStatesResponseChongCi DefaultInstanceForType => null;

		protected override CCGamePlayingStatesResponseChongCi ThisMessage => null;

		public bool HasIsFinals => false;

		public int IsFinals => 0;

		public IList<int> RoundCountMyList => null;

		public int RoundCountMyCount => 0;

		public IList<int> RoundCountOppList => null;

		public int RoundCountOppCount => 0;

		public IList<int> ScoreMyList => null;

		public int ScoreMyCount => 0;

		public IList<int> ScoreOppList => null;

		public int ScoreOppCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCGamePlayingStatesResponseChongCi()
		{
		}

		public int GetRoundCountMy(int index)
		{
			return 0;
		}

		public int GetRoundCountOpp(int index)
		{
			return 0;
		}

		public int GetScoreMy(int index)
		{
			return 0;
		}

		public int GetScoreOpp(int index)
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

		public static CCGamePlayingStatesResponseChongCi ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseChongCi ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseChongCi ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseChongCi ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseChongCi ParseFrom(Stream input)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseChongCi ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseChongCi ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseChongCi ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseChongCi ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseChongCi ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCGamePlayingStatesResponseChongCi MakeReadOnly()
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

		public static Builder CreateBuilder(CCGamePlayingStatesResponseChongCi prototype)
		{
			return null;
		}

		static CCGamePlayingStatesResponseChongCi()
		{
		}
	}
}
