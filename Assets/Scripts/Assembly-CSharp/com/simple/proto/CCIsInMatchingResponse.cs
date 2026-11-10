using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCIsInMatchingResponse : GeneratedMessageLite<CCIsInMatchingResponse, CCIsInMatchingResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCIsInMatchingResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCIsInMatchingResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCIsInMatchingResponse MessageBeingBuilt => null;

			public override CCIsInMatchingResponse DefaultInstanceForType => null;

			public bool HasUserId => false;

			public string UserId
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasIsInMatching => false;

			public bool IsInMatching
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

			internal Builder(CCIsInMatchingResponse cloneFrom)
			{
			}

			private CCIsInMatchingResponse PrepareBuilder()
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

			public override CCIsInMatchingResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCIsInMatchingResponse other)
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

			public Builder SetUserId(string value)
			{
				return null;
			}

			public Builder ClearUserId()
			{
				return null;
			}

			public Builder SetIsInMatching(bool value)
			{
				return null;
			}

			public Builder ClearIsInMatching()
			{
				return null;
			}
		}

		private static readonly CCIsInMatchingResponse defaultInstance;

		private static readonly string[] _cCIsInMatchingResponseFieldNames;

		private static readonly uint[] _cCIsInMatchingResponseFieldTags;

		public const int UserIdFieldNumber = 1;

		private bool hasUserId;

		private string userId_;

		public const int IsInMatchingFieldNumber = 2;

		private bool hasIsInMatching;

		private bool isInMatching_;

		private int memoizedSerializedSize;

		public static CCIsInMatchingResponse DefaultInstance => null;

		public override CCIsInMatchingResponse DefaultInstanceForType => null;

		protected override CCIsInMatchingResponse ThisMessage => null;

		public bool HasUserId => false;

		public string UserId => null;

		public bool HasIsInMatching => false;

		public bool IsInMatching => false;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCIsInMatchingResponse()
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

		public static CCIsInMatchingResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCIsInMatchingResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCIsInMatchingResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCIsInMatchingResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCIsInMatchingResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCIsInMatchingResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCIsInMatchingResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCIsInMatchingResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCIsInMatchingResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCIsInMatchingResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCIsInMatchingResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCIsInMatchingResponse prototype)
		{
			return null;
		}

		static CCIsInMatchingResponse()
		{
		}
	}
}
