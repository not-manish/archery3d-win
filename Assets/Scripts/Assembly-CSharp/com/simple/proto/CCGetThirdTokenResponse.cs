using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCGetThirdTokenResponse : GeneratedMessageLite<CCGetThirdTokenResponse, CCGetThirdTokenResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCGetThirdTokenResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCGetThirdTokenResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCGetThirdTokenResponse MessageBeingBuilt => null;

			public override CCGetThirdTokenResponse DefaultInstanceForType => null;

			public bool HasResult => false;

			public int Result
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasItem => false;

			public CCThirdAccountItem Item
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasValidEt => false;

			public long ValidEt
			{
				get
				{
					return 0L;
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

			public bool HasIsLink => false;

			public bool IsLink
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

			internal Builder(CCGetThirdTokenResponse cloneFrom)
			{
			}

			private CCGetThirdTokenResponse PrepareBuilder()
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

			public override CCGetThirdTokenResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCGetThirdTokenResponse other)
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

			public Builder SetResult(int value)
			{
				return null;
			}

			public Builder ClearResult()
			{
				return null;
			}

			public Builder SetItem(CCThirdAccountItem value)
			{
				return null;
			}

			public Builder SetItem(CCThirdAccountItem.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeItem(CCThirdAccountItem value)
			{
				return null;
			}

			public Builder ClearItem()
			{
				return null;
			}

			public Builder SetValidEt(long value)
			{
				return null;
			}

			public Builder ClearValidEt()
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

			public Builder SetIsLink(bool value)
			{
				return null;
			}

			public Builder ClearIsLink()
			{
				return null;
			}
		}

		private static readonly CCGetThirdTokenResponse defaultInstance;

		private static readonly string[] _cCGetThirdTokenResponseFieldNames;

		private static readonly uint[] _cCGetThirdTokenResponseFieldTags;

		public const int ResultFieldNumber = 1;

		private bool hasResult;

		private int result_;

		public const int ItemFieldNumber = 2;

		private bool hasItem;

		private CCThirdAccountItem item_;

		public const int ValidEtFieldNumber = 3;

		private bool hasValidEt;

		private long validEt_;

		public const int PlayerFieldNumber = 4;

		private bool hasPlayer;

		private CCPlayer player_;

		public const int IsLinkFieldNumber = 5;

		private bool hasIsLink;

		private bool isLink_;

		private int memoizedSerializedSize;

		public static CCGetThirdTokenResponse DefaultInstance => null;

		public override CCGetThirdTokenResponse DefaultInstanceForType => null;

		protected override CCGetThirdTokenResponse ThisMessage => null;

		public bool HasResult => false;

		public int Result => 0;

		public bool HasItem => false;

		public CCThirdAccountItem Item => null;

		public bool HasValidEt => false;

		public long ValidEt => 0L;

		public bool HasPlayer => false;

		public CCPlayer Player => null;

		public bool HasIsLink => false;

		public bool IsLink => false;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCGetThirdTokenResponse()
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

		public static CCGetThirdTokenResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCGetThirdTokenResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetThirdTokenResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCGetThirdTokenResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetThirdTokenResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCGetThirdTokenResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetThirdTokenResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCGetThirdTokenResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCGetThirdTokenResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCGetThirdTokenResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCGetThirdTokenResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCGetThirdTokenResponse prototype)
		{
			return null;
		}

		static CCGetThirdTokenResponse()
		{
		}
	}
}
