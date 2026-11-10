using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCPlayerActionStats : GeneratedMessageLite<CCPlayerActionStats, CCPlayerActionStats.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCPlayerActionStats, Builder>
		{
			private bool resultIsReadOnly;

			private CCPlayerActionStats result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCPlayerActionStats MessageBeingBuilt => null;

			public override CCPlayerActionStats DefaultInstanceForType => null;

			public bool HasInstallTimeMil => false;

			public long InstallTimeMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasLastPayTimeMil => false;

			public long LastPayTimeMil
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public Builder()
			{
			}

			internal Builder(CCPlayerActionStats cloneFrom)
			{
			}

			private CCPlayerActionStats PrepareBuilder()
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

			public override CCPlayerActionStats BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCPlayerActionStats other)
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

			public Builder SetInstallTimeMil(long value)
			{
				return null;
			}

			public Builder ClearInstallTimeMil()
			{
				return null;
			}

			public Builder SetLastPayTimeMil(long value)
			{
				return null;
			}

			public Builder ClearLastPayTimeMil()
			{
				return null;
			}
		}

		private static readonly CCPlayerActionStats defaultInstance;

		private static readonly string[] _cCPlayerActionStatsFieldNames;

		private static readonly uint[] _cCPlayerActionStatsFieldTags;

		public const int InstallTimeMilFieldNumber = 1;

		private bool hasInstallTimeMil;

		private long installTimeMil_;

		public const int LastPayTimeMilFieldNumber = 2;

		private bool hasLastPayTimeMil;

		private long lastPayTimeMil_;

		private int memoizedSerializedSize;

		public static CCPlayerActionStats DefaultInstance => null;

		public override CCPlayerActionStats DefaultInstanceForType => null;

		protected override CCPlayerActionStats ThisMessage => null;

		public bool HasInstallTimeMil => false;

		public long InstallTimeMil => 0L;

		public bool HasLastPayTimeMil => false;

		public long LastPayTimeMil => 0L;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCPlayerActionStats()
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

		public static CCPlayerActionStats ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCPlayerActionStats ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayerActionStats ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCPlayerActionStats ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayerActionStats ParseFrom(Stream input)
		{
			return null;
		}

		public static CCPlayerActionStats ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayerActionStats ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCPlayerActionStats ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPlayerActionStats ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCPlayerActionStats ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCPlayerActionStats MakeReadOnly()
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

		public static Builder CreateBuilder(CCPlayerActionStats prototype)
		{
			return null;
		}

		static CCPlayerActionStats()
		{
		}
	}
}
