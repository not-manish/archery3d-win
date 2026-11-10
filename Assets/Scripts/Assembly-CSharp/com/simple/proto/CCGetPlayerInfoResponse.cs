using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCGetPlayerInfoResponse : GeneratedMessageLite<CCGetPlayerInfoResponse, CCGetPlayerInfoResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCGetPlayerInfoResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCGetPlayerInfoResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCGetPlayerInfoResponse MessageBeingBuilt => null;

			public override CCGetPlayerInfoResponse DefaultInstanceForType => null;

			public bool HasIsSuccess => false;

			public bool IsSuccess
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasReason => false;

			public int Reason
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

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

			internal Builder(CCGetPlayerInfoResponse cloneFrom)
			{
			}

			private CCGetPlayerInfoResponse PrepareBuilder()
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

			public override CCGetPlayerInfoResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCGetPlayerInfoResponse other)
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

			public Builder SetIsSuccess(bool value)
			{
				return null;
			}

			public Builder ClearIsSuccess()
			{
				return null;
			}

			public Builder SetReason(int value)
			{
				return null;
			}

			public Builder ClearReason()
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

		private static readonly CCGetPlayerInfoResponse defaultInstance;

		private static readonly string[] _cCGetPlayerInfoResponseFieldNames;

		private static readonly uint[] _cCGetPlayerInfoResponseFieldTags;

		public const int IsSuccessFieldNumber = 1;

		private bool hasIsSuccess;

		private bool isSuccess_;

		public const int ReasonFieldNumber = 2;

		private bool hasReason;

		private int reason_;

		public const int PlayerFieldNumber = 3;

		private bool hasPlayer;

		private CCPlayer player_;

		private int memoizedSerializedSize;

		public static CCGetPlayerInfoResponse DefaultInstance => null;

		public override CCGetPlayerInfoResponse DefaultInstanceForType => null;

		protected override CCGetPlayerInfoResponse ThisMessage => null;

		public bool HasIsSuccess => false;

		public bool IsSuccess => false;

		public bool HasReason => false;

		public int Reason => 0;

		public bool HasPlayer => false;

		public CCPlayer Player => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCGetPlayerInfoResponse()
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

		public static CCGetPlayerInfoResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCGetPlayerInfoResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetPlayerInfoResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCGetPlayerInfoResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetPlayerInfoResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCGetPlayerInfoResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetPlayerInfoResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCGetPlayerInfoResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetPlayerInfoResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCGetPlayerInfoResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCGetPlayerInfoResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCGetPlayerInfoResponse prototype)
		{
			return null;
		}

		static CCGetPlayerInfoResponse()
		{
		}
	}
}
