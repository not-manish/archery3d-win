using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCPvpAimOperateResponse : GeneratedMessageLite<CCPvpAimOperateResponse, CCPvpAimOperateResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCPvpAimOperateResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCPvpAimOperateResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCPvpAimOperateResponse MessageBeingBuilt => null;

			public override CCPvpAimOperateResponse DefaultInstanceForType => null;

			public bool HasPvpAimRequest => false;

			public CCPvpAimOperateRequest PvpAimRequest
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

			internal Builder(CCPvpAimOperateResponse cloneFrom)
			{
			}

			private CCPvpAimOperateResponse PrepareBuilder()
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

			public override CCPvpAimOperateResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCPvpAimOperateResponse other)
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

			public Builder SetPvpAimRequest(CCPvpAimOperateRequest value)
			{
				return null;
			}

			public Builder SetPvpAimRequest(CCPvpAimOperateRequest.Builder builderForValue)
			{
				return null;
			}

			public Builder MergePvpAimRequest(CCPvpAimOperateRequest value)
			{
				return null;
			}

			public Builder ClearPvpAimRequest()
			{
				return null;
			}
		}

		private static readonly CCPvpAimOperateResponse defaultInstance;

		private static readonly string[] _cCPvpAimOperateResponseFieldNames;

		private static readonly uint[] _cCPvpAimOperateResponseFieldTags;

		public const int PvpAimRequestFieldNumber = 1;

		private bool hasPvpAimRequest;

		private CCPvpAimOperateRequest pvpAimRequest_;

		private int memoizedSerializedSize;

		public static CCPvpAimOperateResponse DefaultInstance => null;

		public override CCPvpAimOperateResponse DefaultInstanceForType => null;

		protected override CCPvpAimOperateResponse ThisMessage => null;

		public bool HasPvpAimRequest => false;

		public CCPvpAimOperateRequest PvpAimRequest => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCPvpAimOperateResponse()
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

		public static CCPvpAimOperateResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCPvpAimOperateResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPvpAimOperateResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCPvpAimOperateResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPvpAimOperateResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCPvpAimOperateResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPvpAimOperateResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCPvpAimOperateResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPvpAimOperateResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCPvpAimOperateResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCPvpAimOperateResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCPvpAimOperateResponse prototype)
		{
			return null;
		}

		static CCPvpAimOperateResponse()
		{
		}
	}
}
