using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCGamePlayingStatesResponseHuiHe : GeneratedMessageLite<CCGamePlayingStatesResponseHuiHe, CCGamePlayingStatesResponseHuiHe.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCGamePlayingStatesResponseHuiHe, Builder>
		{
			private bool resultIsReadOnly;

			private CCGamePlayingStatesResponseHuiHe result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCGamePlayingStatesResponseHuiHe MessageBeingBuilt => null;

			public override CCGamePlayingStatesResponseHuiHe DefaultInstanceForType => null;

			public IPopsicleList<int> ScoreMyList => null;

			public int ScoreMyCount => 0;

			public IPopsicleList<int> ScoreOppList => null;

			public int ScoreOppCount => 0;

			public Builder()
			{
			}

			internal Builder(CCGamePlayingStatesResponseHuiHe cloneFrom)
			{
			}

			private CCGamePlayingStatesResponseHuiHe PrepareBuilder()
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

			public override CCGamePlayingStatesResponseHuiHe BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCGamePlayingStatesResponseHuiHe other)
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
		}

		private static readonly CCGamePlayingStatesResponseHuiHe defaultInstance;

		private static readonly string[] _cCGamePlayingStatesResponseHuiHeFieldNames;

		private static readonly uint[] _cCGamePlayingStatesResponseHuiHeFieldTags;

		public const int ScoreMyFieldNumber = 2;

		private PopsicleList<int> scoreMy_;

		public const int ScoreOppFieldNumber = 3;

		private PopsicleList<int> scoreOpp_;

		private int memoizedSerializedSize;

		public static CCGamePlayingStatesResponseHuiHe DefaultInstance => null;

		public override CCGamePlayingStatesResponseHuiHe DefaultInstanceForType => null;

		protected override CCGamePlayingStatesResponseHuiHe ThisMessage => null;

		public IList<int> ScoreMyList => null;

		public int ScoreMyCount => 0;

		public IList<int> ScoreOppList => null;

		public int ScoreOppCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCGamePlayingStatesResponseHuiHe()
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

		public static CCGamePlayingStatesResponseHuiHe ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseHuiHe ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseHuiHe ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseHuiHe ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseHuiHe ParseFrom(Stream input)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseHuiHe ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseHuiHe ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseHuiHe ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseHuiHe ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseHuiHe ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCGamePlayingStatesResponseHuiHe MakeReadOnly()
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

		public static Builder CreateBuilder(CCGamePlayingStatesResponseHuiHe prototype)
		{
			return null;
		}

		static CCGamePlayingStatesResponseHuiHe()
		{
		}
	}
}
