using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCGamblingRouletteRequest : GeneratedMessageLite<CCGamblingRouletteRequest, CCGamblingRouletteRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCGamblingRouletteRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCGamblingRouletteRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCGamblingRouletteRequest MessageBeingBuilt => null;

			public override CCGamblingRouletteRequest DefaultInstanceForType => null;

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

			public bool HasRouletteType => false;

			public int RouletteType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasIsVideoFree => false;

			public bool IsVideoFree
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public Builder()
			{
			}

			internal Builder(CCGamblingRouletteRequest cloneFrom)
			{
			}

			private CCGamblingRouletteRequest PrepareBuilder()
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

			public override CCGamblingRouletteRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCGamblingRouletteRequest other)
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

			public Builder SetRouletteType(int value)
			{
				return null;
			}

			public Builder ClearRouletteType()
			{
				return null;
			}

			public Builder SetIsVideoFree(bool value)
			{
				return null;
			}

			public Builder ClearIsVideoFree()
			{
				return null;
			}
		}

		private static readonly CCGamblingRouletteRequest defaultInstance;

		private static readonly string[] _cCGamblingRouletteRequestFieldNames;

		private static readonly uint[] _cCGamblingRouletteRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		public const int RouletteTypeFieldNumber = 2;

		private bool hasRouletteType;

		private int rouletteType_;

		public const int IsVideoFreeFieldNumber = 3;

		private bool hasIsVideoFree;

		private bool isVideoFree_;

		private int memoizedSerializedSize;

		public static CCGamblingRouletteRequest DefaultInstance => null;

		public override CCGamblingRouletteRequest DefaultInstanceForType => null;

		protected override CCGamblingRouletteRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasRouletteType => false;

		public int RouletteType => 0;

		public bool HasIsVideoFree => false;

		public bool IsVideoFree => false;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCGamblingRouletteRequest()
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

		public static CCGamblingRouletteRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCGamblingRouletteRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamblingRouletteRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCGamblingRouletteRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamblingRouletteRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCGamblingRouletteRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamblingRouletteRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCGamblingRouletteRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGamblingRouletteRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCGamblingRouletteRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCGamblingRouletteRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCGamblingRouletteRequest prototype)
		{
			return null;
		}

		static CCGamblingRouletteRequest()
		{
		}
	}
}
