using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCGamePlayingStatesResponseSingle : GeneratedMessageLite<CCGamePlayingStatesResponseSingle, CCGamePlayingStatesResponseSingle.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCGamePlayingStatesResponseSingle, Builder>
		{
			private bool resultIsReadOnly;

			private CCGamePlayingStatesResponseSingle result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCGamePlayingStatesResponseSingle MessageBeingBuilt => null;

			public override CCGamePlayingStatesResponseSingle DefaultInstanceForType => null;

			public IPopsicleList<int> ScoreMyList => null;

			public int ScoreMyCount => 0;

			public Builder()
			{
			}

			internal Builder(CCGamePlayingStatesResponseSingle cloneFrom)
			{
			}

			private CCGamePlayingStatesResponseSingle PrepareBuilder()
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

			public override CCGamePlayingStatesResponseSingle BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCGamePlayingStatesResponseSingle other)
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
		}

		private static readonly CCGamePlayingStatesResponseSingle defaultInstance;

		private static readonly string[] _cCGamePlayingStatesResponseSingleFieldNames;

		private static readonly uint[] _cCGamePlayingStatesResponseSingleFieldTags;

		public const int ScoreMyFieldNumber = 2;

		private PopsicleList<int> scoreMy_;

		private int memoizedSerializedSize;

		public static CCGamePlayingStatesResponseSingle DefaultInstance => null;

		public override CCGamePlayingStatesResponseSingle DefaultInstanceForType => null;

		protected override CCGamePlayingStatesResponseSingle ThisMessage => null;

		public IList<int> ScoreMyList => null;

		public int ScoreMyCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCGamePlayingStatesResponseSingle()
		{
		}

		public int GetScoreMy(int index)
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

		public static CCGamePlayingStatesResponseSingle ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseSingle ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseSingle ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseSingle ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseSingle ParseFrom(Stream input)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseSingle ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseSingle ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseSingle ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseSingle ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCGamePlayingStatesResponseSingle ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCGamePlayingStatesResponseSingle MakeReadOnly()
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

		public static Builder CreateBuilder(CCGamePlayingStatesResponseSingle prototype)
		{
			return null;
		}

		static CCGamePlayingStatesResponseSingle()
		{
		}
	}
}
