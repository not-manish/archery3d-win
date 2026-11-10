using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCSevenDailyBonusRequest : GeneratedMessageLite<CCSevenDailyBonusRequest, CCSevenDailyBonusRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCSevenDailyBonusRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCSevenDailyBonusRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCSevenDailyBonusRequest MessageBeingBuilt => null;

			public override CCSevenDailyBonusRequest DefaultInstanceForType => null;

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

			public bool HasWatchedVideo => false;

			public bool WatchedVideo
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

			internal Builder(CCSevenDailyBonusRequest cloneFrom)
			{
			}

			private CCSevenDailyBonusRequest PrepareBuilder()
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

			public override CCSevenDailyBonusRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCSevenDailyBonusRequest other)
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

			public Builder SetWatchedVideo(bool value)
			{
				return null;
			}

			public Builder ClearWatchedVideo()
			{
				return null;
			}
		}

		private static readonly CCSevenDailyBonusRequest defaultInstance;

		private static readonly string[] _cCSevenDailyBonusRequestFieldNames;

		private static readonly uint[] _cCSevenDailyBonusRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		public const int WatchedVideoFieldNumber = 2;

		private bool hasWatchedVideo;

		private bool watchedVideo_;

		private int memoizedSerializedSize;

		public static CCSevenDailyBonusRequest DefaultInstance => null;

		public override CCSevenDailyBonusRequest DefaultInstanceForType => null;

		protected override CCSevenDailyBonusRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasWatchedVideo => false;

		public bool WatchedVideo => false;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCSevenDailyBonusRequest()
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

		public static CCSevenDailyBonusRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCSevenDailyBonusRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSevenDailyBonusRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCSevenDailyBonusRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSevenDailyBonusRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCSevenDailyBonusRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSevenDailyBonusRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCSevenDailyBonusRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSevenDailyBonusRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCSevenDailyBonusRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCSevenDailyBonusRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCSevenDailyBonusRequest prototype)
		{
			return null;
		}

		static CCSevenDailyBonusRequest()
		{
		}
	}
}
