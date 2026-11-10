using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCEquipOperateResponse : GeneratedMessageLite<CCEquipOperateResponse, CCEquipOperateResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCEquipOperateResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCEquipOperateResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCEquipOperateResponse MessageBeingBuilt => null;

			public override CCEquipOperateResponse DefaultInstanceForType => null;

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

			public bool HasEquipType => false;

			public int EquipType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasTypeId => false;

			public int TypeId
			{
				get
				{
					return 0;
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

			public bool HasIsResultSuccess => false;

			public bool IsResultSuccess
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

			public bool HasMyPlayer => false;

			public CCPlayer MyPlayer
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

			internal Builder(CCEquipOperateResponse cloneFrom)
			{
			}

			private CCEquipOperateResponse PrepareBuilder()
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

			public override CCEquipOperateResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCEquipOperateResponse other)
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

			public Builder SetEquipType(int value)
			{
				return null;
			}

			public Builder ClearEquipType()
			{
				return null;
			}

			public Builder SetTypeId(int value)
			{
				return null;
			}

			public Builder ClearTypeId()
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

			public Builder SetIsResultSuccess(bool value)
			{
				return null;
			}

			public Builder ClearIsResultSuccess()
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

			public Builder SetMyPlayer(CCPlayer value)
			{
				return null;
			}

			public Builder SetMyPlayer(CCPlayer.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeMyPlayer(CCPlayer value)
			{
				return null;
			}

			public Builder ClearMyPlayer()
			{
				return null;
			}
		}

		private static readonly CCEquipOperateResponse defaultInstance;

		private static readonly string[] _cCEquipOperateResponseFieldNames;

		private static readonly uint[] _cCEquipOperateResponseFieldTags;

		public const int UidFieldNumber = 7;

		private bool hasUid;

		private string uid_;

		public const int EquipTypeFieldNumber = 1;

		private bool hasEquipType;

		private int equipType_;

		public const int TypeIdFieldNumber = 2;

		private bool hasTypeId;

		private int typeId_;

		public const int OperateTypeFieldNumber = 3;

		private bool hasOperateType;

		private int operateType_;

		public const int IsResultSuccessFieldNumber = 4;

		private bool hasIsResultSuccess;

		private bool isResultSuccess_;

		public const int ReasonFieldNumber = 5;

		private bool hasReason;

		private int reason_;

		public const int MyPlayerFieldNumber = 6;

		private bool hasMyPlayer;

		private CCPlayer myPlayer_;

		private int memoizedSerializedSize;

		public static CCEquipOperateResponse DefaultInstance => null;

		public override CCEquipOperateResponse DefaultInstanceForType => null;

		protected override CCEquipOperateResponse ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasEquipType => false;

		public int EquipType => 0;

		public bool HasTypeId => false;

		public int TypeId => 0;

		public bool HasOperateType => false;

		public int OperateType => 0;

		public bool HasIsResultSuccess => false;

		public bool IsResultSuccess => false;

		public bool HasReason => false;

		public int Reason => 0;

		public bool HasMyPlayer => false;

		public CCPlayer MyPlayer => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCEquipOperateResponse()
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

		public static CCEquipOperateResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCEquipOperateResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEquipOperateResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCEquipOperateResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEquipOperateResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCEquipOperateResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEquipOperateResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCEquipOperateResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEquipOperateResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCEquipOperateResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCEquipOperateResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCEquipOperateResponse prototype)
		{
			return null;
		}

		static CCEquipOperateResponse()
		{
		}
	}
}
