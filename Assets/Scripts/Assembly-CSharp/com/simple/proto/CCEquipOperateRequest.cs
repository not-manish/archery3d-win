using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCEquipOperateRequest : GeneratedMessageLite<CCEquipOperateRequest, CCEquipOperateRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCEquipOperateRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCEquipOperateRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCEquipOperateRequest MessageBeingBuilt => null;

			public override CCEquipOperateRequest DefaultInstanceForType => null;

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

			public bool HasParam => false;

			public int Param
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public Builder()
			{
			}

			internal Builder(CCEquipOperateRequest cloneFrom)
			{
			}

			private CCEquipOperateRequest PrepareBuilder()
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

			public override CCEquipOperateRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCEquipOperateRequest other)
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

			public Builder SetParam(int value)
			{
				return null;
			}

			public Builder ClearParam()
			{
				return null;
			}
		}

		private static readonly CCEquipOperateRequest defaultInstance;

		private static readonly string[] _cCEquipOperateRequestFieldNames;

		private static readonly uint[] _cCEquipOperateRequestFieldTags;

		public const int UidFieldNumber = 5;

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

		public const int ParamFieldNumber = 4;

		private bool hasParam;

		private int param_;

		private int memoizedSerializedSize;

		public static CCEquipOperateRequest DefaultInstance => null;

		public override CCEquipOperateRequest DefaultInstanceForType => null;

		protected override CCEquipOperateRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasEquipType => false;

		public int EquipType => 0;

		public bool HasTypeId => false;

		public int TypeId => 0;

		public bool HasOperateType => false;

		public int OperateType => 0;

		public bool HasParam => false;

		public int Param => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCEquipOperateRequest()
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

		public static CCEquipOperateRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCEquipOperateRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEquipOperateRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCEquipOperateRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEquipOperateRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCEquipOperateRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEquipOperateRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCEquipOperateRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEquipOperateRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCEquipOperateRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCEquipOperateRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCEquipOperateRequest prototype)
		{
			return null;
		}

		static CCEquipOperateRequest()
		{
		}
	}
}
