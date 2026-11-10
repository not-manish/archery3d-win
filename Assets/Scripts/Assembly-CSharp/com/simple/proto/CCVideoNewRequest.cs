using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCVideoNewRequest : GeneratedMessageLite<CCVideoNewRequest, CCVideoNewRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCVideoNewRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCVideoNewRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCVideoNewRequest MessageBeingBuilt => null;

			public override CCVideoNewRequest DefaultInstanceForType => null;

			public bool HasRequireType => false;

			public int RequireType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasVideoType => false;

			public int VideoType
			{
				get
				{
					return 0;
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

			internal Builder(CCVideoNewRequest cloneFrom)
			{
			}

			private CCVideoNewRequest PrepareBuilder()
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

			public override CCVideoNewRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCVideoNewRequest other)
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

			public Builder SetRequireType(int value)
			{
				return null;
			}

			public Builder ClearRequireType()
			{
				return null;
			}

			public Builder SetVideoType(int value)
			{
				return null;
			}

			public Builder ClearVideoType()
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

		private static readonly CCVideoNewRequest defaultInstance;

		private static readonly string[] _cCVideoNewRequestFieldNames;

		private static readonly uint[] _cCVideoNewRequestFieldTags;

		public const int RequireTypeFieldNumber = 1;

		private bool hasRequireType;

		private int requireType_;

		public const int VideoTypeFieldNumber = 2;

		private bool hasVideoType;

		private int videoType_;

		public const int WatchedVideoFieldNumber = 3;

		private bool hasWatchedVideo;

		private bool watchedVideo_;

		private int memoizedSerializedSize;

		public static CCVideoNewRequest DefaultInstance => null;

		public override CCVideoNewRequest DefaultInstanceForType => null;

		protected override CCVideoNewRequest ThisMessage => null;

		public bool HasRequireType => false;

		public int RequireType => 0;

		public bool HasVideoType => false;

		public int VideoType => 0;

		public bool HasWatchedVideo => false;

		public bool WatchedVideo => false;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCVideoNewRequest()
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

		public static CCVideoNewRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCVideoNewRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoNewRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCVideoNewRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoNewRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCVideoNewRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoNewRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCVideoNewRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVideoNewRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCVideoNewRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCVideoNewRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCVideoNewRequest prototype)
		{
			return null;
		}

		static CCVideoNewRequest()
		{
		}
	}
}
