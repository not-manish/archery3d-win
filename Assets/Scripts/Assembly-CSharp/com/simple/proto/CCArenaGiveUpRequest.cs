using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCArenaGiveUpRequest : GeneratedMessageLite<CCArenaGiveUpRequest, CCArenaGiveUpRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCArenaGiveUpRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCArenaGiveUpRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCArenaGiveUpRequest MessageBeingBuilt => null;

			public override CCArenaGiveUpRequest DefaultInstanceForType => null;

			public bool HasUid => false;

			public string Uid
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasArenaType => false;

			public int ArenaType
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

			internal Builder(CCArenaGiveUpRequest cloneFrom)
			{
			}

			private CCArenaGiveUpRequest PrepareBuilder()
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

			public override CCArenaGiveUpRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCArenaGiveUpRequest other)
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

			public Builder SetUid(string value)
			{
				return null;
			}

			public Builder ClearUid()
			{
				return null;
			}

			public Builder SetArenaType(int value)
			{
				return null;
			}

			public Builder ClearArenaType()
			{
				return null;
			}
		}

		private static readonly CCArenaGiveUpRequest defaultInstance;

		private static readonly string[] _cCArenaGiveUpRequestFieldNames;

		private static readonly uint[] _cCArenaGiveUpRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		public const int ArenaTypeFieldNumber = 2;

		private bool hasArenaType;

		private int arenaType_;

		private int memoizedSerializedSize;

		public static CCArenaGiveUpRequest DefaultInstance => null;

		public override CCArenaGiveUpRequest DefaultInstanceForType => null;

		protected override CCArenaGiveUpRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasArenaType => false;

		public int ArenaType => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCArenaGiveUpRequest()
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

		public static CCArenaGiveUpRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCArenaGiveUpRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCArenaGiveUpRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCArenaGiveUpRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCArenaGiveUpRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCArenaGiveUpRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCArenaGiveUpRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCArenaGiveUpRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCArenaGiveUpRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCArenaGiveUpRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCArenaGiveUpRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCArenaGiveUpRequest prototype)
		{
			return null;
		}

		static CCArenaGiveUpRequest()
		{
		}
	}
}
