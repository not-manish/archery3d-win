using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCChallengeJoinResponse : GeneratedMessageLite<CCChallengeJoinResponse, CCChallengeJoinResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCChallengeJoinResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCChallengeJoinResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCChallengeJoinResponse MessageBeingBuilt => null;

			public override CCChallengeJoinResponse DefaultInstanceForType => null;

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

			internal Builder(CCChallengeJoinResponse cloneFrom)
			{
			}

			private CCChallengeJoinResponse PrepareBuilder()
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

			public override CCChallengeJoinResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCChallengeJoinResponse other)
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

		private static readonly CCChallengeJoinResponse defaultInstance;

		private static readonly string[] _cCChallengeJoinResponseFieldNames;

		private static readonly uint[] _cCChallengeJoinResponseFieldTags;

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

		public static CCChallengeJoinResponse DefaultInstance => null;

		public override CCChallengeJoinResponse DefaultInstanceForType => null;

		protected override CCChallengeJoinResponse ThisMessage => null;

		public bool HasIsSuccess => false;

		public bool IsSuccess => false;

		public bool HasReason => false;

		public int Reason => 0;

		public bool HasPlayer => false;

		public CCPlayer Player => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCChallengeJoinResponse()
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

		public static CCChallengeJoinResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCChallengeJoinResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeJoinResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCChallengeJoinResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeJoinResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCChallengeJoinResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeJoinResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCChallengeJoinResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeJoinResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCChallengeJoinResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCChallengeJoinResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCChallengeJoinResponse prototype)
		{
			return null;
		}

		static CCChallengeJoinResponse()
		{
		}
	}
}
