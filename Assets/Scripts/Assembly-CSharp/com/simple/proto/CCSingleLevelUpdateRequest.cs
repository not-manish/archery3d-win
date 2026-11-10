using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCSingleLevelUpdateRequest : GeneratedMessageLite<CCSingleLevelUpdateRequest, CCSingleLevelUpdateRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCSingleLevelUpdateRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCSingleLevelUpdateRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCSingleLevelUpdateRequest MessageBeingBuilt => null;

			public override CCSingleLevelUpdateRequest DefaultInstanceForType => null;

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

			public bool HasSingleData => false;

			public CCSingleData SingleData
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

			internal Builder(CCSingleLevelUpdateRequest cloneFrom)
			{
			}

			private CCSingleLevelUpdateRequest PrepareBuilder()
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

			public override CCSingleLevelUpdateRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCSingleLevelUpdateRequest other)
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

			public Builder SetSingleData(CCSingleData value)
			{
				return null;
			}

			public Builder SetSingleData(CCSingleData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeSingleData(CCSingleData value)
			{
				return null;
			}

			public Builder ClearSingleData()
			{
				return null;
			}
		}

		private static readonly CCSingleLevelUpdateRequest defaultInstance;

		private static readonly string[] _cCSingleLevelUpdateRequestFieldNames;

		private static readonly uint[] _cCSingleLevelUpdateRequestFieldTags;

		public const int UidFieldNumber = 1;

		private bool hasUid;

		private string uid_;

		public const int SingleDataFieldNumber = 2;

		private bool hasSingleData;

		private CCSingleData singleData_;

		private int memoizedSerializedSize;

		public static CCSingleLevelUpdateRequest DefaultInstance => null;

		public override CCSingleLevelUpdateRequest DefaultInstanceForType => null;

		protected override CCSingleLevelUpdateRequest ThisMessage => null;

		public bool HasUid => false;

		public string Uid => null;

		public bool HasSingleData => false;

		public CCSingleData SingleData => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCSingleLevelUpdateRequest()
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

		public static CCSingleLevelUpdateRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCSingleLevelUpdateRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleLevelUpdateRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCSingleLevelUpdateRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleLevelUpdateRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCSingleLevelUpdateRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleLevelUpdateRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCSingleLevelUpdateRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCSingleLevelUpdateRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCSingleLevelUpdateRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCSingleLevelUpdateRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCSingleLevelUpdateRequest prototype)
		{
			return null;
		}

		static CCSingleLevelUpdateRequest()
		{
		}
	}
}
