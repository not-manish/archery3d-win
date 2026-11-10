using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCArenaLevel : GeneratedMessageLite<CCArenaLevel, CCArenaLevel.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCArenaLevel, Builder>
		{
			private bool resultIsReadOnly;

			private CCArenaLevel result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCArenaLevel MessageBeingBuilt => null;

			public override CCArenaLevel DefaultInstanceForType => null;

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

			public bool HasAveSumCount => false;

			public int AveSumCount
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasAveRing => false;

			public float AveRing
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public bool HasAveWinCount => false;

			public int AveWinCount
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasIsContinueWin => false;

			public bool IsContinueWin
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasContinueCount => false;

			public int ContinueCount
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

			internal Builder(CCArenaLevel cloneFrom)
			{
			}

			private CCArenaLevel PrepareBuilder()
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

			public override CCArenaLevel BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCArenaLevel other)
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

			public Builder SetAveSumCount(int value)
			{
				return null;
			}

			public Builder ClearAveSumCount()
			{
				return null;
			}

			public Builder SetAveRing(float value)
			{
				return null;
			}

			public Builder ClearAveRing()
			{
				return null;
			}

			public Builder SetAveWinCount(int value)
			{
				return null;
			}

			public Builder ClearAveWinCount()
			{
				return null;
			}

			public Builder SetIsContinueWin(bool value)
			{
				return null;
			}

			public Builder ClearIsContinueWin()
			{
				return null;
			}

			public Builder SetContinueCount(int value)
			{
				return null;
			}

			public Builder ClearContinueCount()
			{
				return null;
			}
		}

		private static readonly CCArenaLevel defaultInstance;

		private static readonly string[] _cCArenaLevelFieldNames;

		private static readonly uint[] _cCArenaLevelFieldTags;

		public const int IdFieldNumber = 1;

		private bool hasId;

		private int id_;

		public const int AveSumCountFieldNumber = 2;

		private bool hasAveSumCount;

		private int aveSumCount_;

		public const int AveRingFieldNumber = 3;

		private bool hasAveRing;

		private float aveRing_;

		public const int AveWinCountFieldNumber = 6;

		private bool hasAveWinCount;

		private int aveWinCount_;

		public const int IsContinueWinFieldNumber = 4;

		private bool hasIsContinueWin;

		private bool isContinueWin_;

		public const int ContinueCountFieldNumber = 5;

		private bool hasContinueCount;

		private int continueCount_;

		private int memoizedSerializedSize;

		public static CCArenaLevel DefaultInstance => null;

		public override CCArenaLevel DefaultInstanceForType => null;

		protected override CCArenaLevel ThisMessage => null;

		public bool HasId => false;

		public int Id => 0;

		public bool HasAveSumCount => false;

		public int AveSumCount => 0;

		public bool HasAveRing => false;

		public float AveRing => 0f;

		public bool HasAveWinCount => false;

		public int AveWinCount => 0;

		public bool HasIsContinueWin => false;

		public bool IsContinueWin => false;

		public bool HasContinueCount => false;

		public int ContinueCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCArenaLevel()
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

		public static CCArenaLevel ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCArenaLevel ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCArenaLevel ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCArenaLevel ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCArenaLevel ParseFrom(Stream input)
		{
			return null;
		}

		public static CCArenaLevel ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCArenaLevel ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCArenaLevel ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCArenaLevel ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCArenaLevel ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCArenaLevel MakeReadOnly()
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

		public static Builder CreateBuilder(CCArenaLevel prototype)
		{
			return null;
		}

		static CCArenaLevel()
		{
		}
	}
}
