using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCSingleLevelUpdateResponse : GeneratedMessageLite<CCSingleLevelUpdateResponse, CCSingleLevelUpdateResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCSingleLevelUpdateResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCSingleLevelUpdateResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCSingleLevelUpdateResponse MessageBeingBuilt => null;

			public override CCSingleLevelUpdateResponse DefaultInstanceForType => null;

			public bool HasPlayer => false;

			public CCPlayer Player
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public Builder()
			{
			}

			internal Builder(CCSingleLevelUpdateResponse cloneFrom)
			{
			}

			private CCSingleLevelUpdateResponse PrepareBuilder()
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

			public override CCSingleLevelUpdateResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCSingleLevelUpdateResponse other)
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

			public Builder SetPlayer(CCPlayer value)
			{
				return null;
			}

			public Builder SetPlayer(CCPlayer.Builder builderForValue)
			{
				return null;
			}

			public Builder MergePlayer(CCPlayer value)
			{
				return null;
			}

			public Builder ClearPlayer()
			{
				return null;
			}
		}

		private static readonly CCSingleLevelUpdateResponse defaultInstance;

		private static readonly string[] _cCSingleLevelUpdateResponseFieldNames;

		private static readonly uint[] _cCSingleLevelUpdateResponseFieldTags;

		public const int PlayerFieldNumber = 1;

		private bool hasPlayer;

		private CCPlayer player_;

		private int memoizedSerializedSize;

		public static CCSingleLevelUpdateResponse DefaultInstance => null;

		public override CCSingleLevelUpdateResponse DefaultInstanceForType => null;

		protected override CCSingleLevelUpdateResponse ThisMessage => null;

		public bool HasPlayer => false;

		public CCPlayer Player => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCSingleLevelUpdateResponse()
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

		public static CCSingleLevelUpdateResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCSingleLevelUpdateResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleLevelUpdateResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCSingleLevelUpdateResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleLevelUpdateResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCSingleLevelUpdateResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleLevelUpdateResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCSingleLevelUpdateResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleLevelUpdateResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCSingleLevelUpdateResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCSingleLevelUpdateResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCSingleLevelUpdateResponse prototype)
		{
			return null;
		}

		static CCSingleLevelUpdateResponse()
		{
		}
	}
}
