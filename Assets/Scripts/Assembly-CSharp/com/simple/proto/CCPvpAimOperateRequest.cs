using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCPvpAimOperateRequest : GeneratedMessageLite<CCPvpAimOperateRequest, CCPvpAimOperateRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCPvpAimOperateRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCPvpAimOperateRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCPvpAimOperateRequest MessageBeingBuilt => null;

			public override CCPvpAimOperateRequest DefaultInstanceForType => null;

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

			public bool HasOperateType => false;

			public int OperateType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasArrowId => false;

			public int ArrowId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasPlayerRot => false;

			public CCVector3 PlayerRot
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

			internal Builder(CCPvpAimOperateRequest cloneFrom)
			{
			}

			private CCPvpAimOperateRequest PrepareBuilder()
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

			public override CCPvpAimOperateRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCPvpAimOperateRequest other)
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

			public Builder SetOperateType(int value)
			{
				return null;
			}

			public Builder ClearOperateType()
			{
				return null;
			}

			public Builder SetArrowId(int value)
			{
				return null;
			}

			public Builder ClearArrowId()
			{
				return null;
			}

			public Builder SetPlayerRot(CCVector3 value)
			{
				return null;
			}

			public Builder SetPlayerRot(CCVector3.Builder builderForValue)
			{
				return null;
			}

			public Builder MergePlayerRot(CCVector3 value)
			{
				return null;
			}

			public Builder ClearPlayerRot()
			{
				return null;
			}
		}

		private static readonly CCPvpAimOperateRequest defaultInstance;

		private static readonly string[] _cCPvpAimOperateRequestFieldNames;

		private static readonly uint[] _cCPvpAimOperateRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		public const int OperateTypeFieldNumber = 2;

		private bool hasOperateType;

		private int operateType_;

		public const int ArrowIdFieldNumber = 3;

		private bool hasArrowId;

		private int arrowId_;

		public const int PlayerRotFieldNumber = 4;

		private bool hasPlayerRot;

		private CCVector3 playerRot_;

		private int memoizedSerializedSize;

		public static CCPvpAimOperateRequest DefaultInstance => null;

		public override CCPvpAimOperateRequest DefaultInstanceForType => null;

		protected override CCPvpAimOperateRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasOperateType => false;

		public int OperateType => 0;

		public bool HasArrowId => false;

		public int ArrowId => 0;

		public bool HasPlayerRot => false;

		public CCVector3 PlayerRot => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCPvpAimOperateRequest()
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

		public static CCPvpAimOperateRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCPvpAimOperateRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPvpAimOperateRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCPvpAimOperateRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPvpAimOperateRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCPvpAimOperateRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPvpAimOperateRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCPvpAimOperateRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPvpAimOperateRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCPvpAimOperateRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCPvpAimOperateRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCPvpAimOperateRequest prototype)
		{
			return null;
		}

		static CCPvpAimOperateRequest()
		{
		}
	}
}
