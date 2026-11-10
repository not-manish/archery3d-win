using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCPlayerStateData : GeneratedMessageLite<CCPlayerStateData, CCPlayerStateData.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCPlayerStateData, Builder>
		{
			private bool resultIsReadOnly;

			private CCPlayerStateData result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCPlayerStateData MessageBeingBuilt => null;

			public override CCPlayerStateData DefaultInstanceForType => null;

			public bool HasNearestLoginTimeMil => false;

			public long NearestLoginTimeMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasNearestUnloginTimeMil => false;

			public long NearestUnloginTimeMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasCurOnlineState => false;

			public int CurOnlineState
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

			internal Builder(CCPlayerStateData cloneFrom)
			{
			}

			private CCPlayerStateData PrepareBuilder()
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

			public override CCPlayerStateData BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCPlayerStateData other)
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

			public Builder SetNearestLoginTimeMil(long value)
			{
				return null;
			}

			public Builder ClearNearestLoginTimeMil()
			{
				return null;
			}

			public Builder SetNearestUnloginTimeMil(long value)
			{
				return null;
			}

			public Builder ClearNearestUnloginTimeMil()
			{
				return null;
			}

			public Builder SetCurOnlineState(int value)
			{
				return null;
			}

			public Builder ClearCurOnlineState()
			{
				return null;
			}
		}

		private static readonly CCPlayerStateData defaultInstance;

		private static readonly string[] _cCPlayerStateDataFieldNames;

		private static readonly uint[] _cCPlayerStateDataFieldTags;

		public const int NearestLoginTimeMilFieldNumber = 1;

		private bool hasNearestLoginTimeMil;

		private long nearestLoginTimeMil_;

		public const int NearestUnloginTimeMilFieldNumber = 2;

		private bool hasNearestUnloginTimeMil;

		private long nearestUnloginTimeMil_;

		public const int CurOnlineStateFieldNumber = 3;

		private bool hasCurOnlineState;

		private int curOnlineState_;

		private int memoizedSerializedSize;

		public static CCPlayerStateData DefaultInstance => null;

		public override CCPlayerStateData DefaultInstanceForType => null;

		protected override CCPlayerStateData ThisMessage => null;

		public bool HasNearestLoginTimeMil => false;

		public long NearestLoginTimeMil => 0L;

		public bool HasNearestUnloginTimeMil => false;

		public long NearestUnloginTimeMil => 0L;

		public bool HasCurOnlineState => false;

		public int CurOnlineState => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCPlayerStateData()
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

		public static CCPlayerStateData ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCPlayerStateData ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayerStateData ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCPlayerStateData ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayerStateData ParseFrom(Stream input)
		{
			return null;
		}

		public static CCPlayerStateData ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayerStateData ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCPlayerStateData ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayerStateData ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCPlayerStateData ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCPlayerStateData MakeReadOnly()
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

		public static Builder CreateBuilder(CCPlayerStateData prototype)
		{
			return null;
		}

		static CCPlayerStateData()
		{
		}
	}
}
