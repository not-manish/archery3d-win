using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCGamePlayingStatesResponsePanDian : GeneratedMessageLite<CCGamePlayingStatesResponsePanDian, CCGamePlayingStatesResponsePanDian.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCGamePlayingStatesResponsePanDian, Builder>
		{
			private bool resultIsReadOnly;

			private CCGamePlayingStatesResponsePanDian result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCGamePlayingStatesResponsePanDian MessageBeingBuilt => null;

			public override CCGamePlayingStatesResponsePanDian DefaultInstanceForType => null;

			public IPopsicleList<int> ScoreMyList => null;

			public int ScoreMyCount => 0;

			public IPopsicleList<int> ScoreOppList => null;

			public int ScoreOppCount => 0;

			public Builder()
			{
			}

			internal Builder(CCGamePlayingStatesResponsePanDian cloneFrom)
			{
			}

			private CCGamePlayingStatesResponsePanDian PrepareBuilder()
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

			public override CCGamePlayingStatesResponsePanDian BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCGamePlayingStatesResponsePanDian other)
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

		private static readonly CCGamePlayingStatesResponsePanDian defaultInstance;

		private static readonly string[] _cCGamePlayingStatesResponsePanDianFieldNames;

		private static readonly uint[] _cCGamePlayingStatesResponsePanDianFieldTags;

		public const int ScoreMyFieldNumber = 2;

		private PopsicleList<int> scoreMy_;

		public const int ScoreOppFieldNumber = 3;

		private PopsicleList<int> scoreOpp_;

		private int memoizedSerializedSize;

		public static CCGamePlayingStatesResponsePanDian DefaultInstance => null;

		public override CCGamePlayingStatesResponsePanDian DefaultInstanceForType => null;

		protected override CCGamePlayingStatesResponsePanDian ThisMessage => null;

		public IList<int> ScoreMyList => null;

		public int ScoreMyCount => 0;

		public IList<int> ScoreOppList => null;

		public int ScoreOppCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCGamePlayingStatesResponsePanDian()
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

		public static CCGamePlayingStatesResponsePanDian ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCGamePlayingStatesResponsePanDian ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponsePanDian ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCGamePlayingStatesResponsePanDian ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponsePanDian ParseFrom(Stream input)
		{
			return null;
		}

		public static CCGamePlayingStatesResponsePanDian ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponsePanDian ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCGamePlayingStatesResponsePanDian ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponsePanDian ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCGamePlayingStatesResponsePanDian ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCGamePlayingStatesResponsePanDian MakeReadOnly()
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

		public static Builder CreateBuilder(CCGamePlayingStatesResponsePanDian prototype)
		{
			return null;
		}

		static CCGamePlayingStatesResponsePanDian()
		{
		}
	}
}
