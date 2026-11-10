using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCEmailSupportRequest : GeneratedMessageLite<CCEmailSupportRequest, CCEmailSupportRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCEmailSupportRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCEmailSupportRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCEmailSupportRequest MessageBeingBuilt => null;

			public override CCEmailSupportRequest DefaultInstanceForType => null;

			public bool HasEmailAddr => false;

			public string EmailAddr
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasTitle => false;

			public string Title
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasContent => false;

			public string Content
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

			internal Builder(CCEmailSupportRequest cloneFrom)
			{
			}

			private CCEmailSupportRequest PrepareBuilder()
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

			public override CCEmailSupportRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCEmailSupportRequest other)
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

			public Builder SetEmailAddr(string value)
			{
				return null;
			}

			public Builder ClearEmailAddr()
			{
				return null;
			}

			public Builder SetTitle(string value)
			{
				return null;
			}

			public Builder ClearTitle()
			{
				return null;
			}

			public Builder SetContent(string value)
			{
				return null;
			}

			public Builder ClearContent()
			{
				return null;
			}
		}

		private static readonly CCEmailSupportRequest defaultInstance;

		private static readonly string[] _cCEmailSupportRequestFieldNames;

		private static readonly uint[] _cCEmailSupportRequestFieldTags;

		public const int EmailAddrFieldNumber = 1;

		private bool hasEmailAddr;

		private string emailAddr_;

		public const int TitleFieldNumber = 2;

		private bool hasTitle;

		private string title_;

		public const int ContentFieldNumber = 3;

		private bool hasContent;

		private string content_;

		private int memoizedSerializedSize;

		public static CCEmailSupportRequest DefaultInstance => null;

		public override CCEmailSupportRequest DefaultInstanceForType => null;

		protected override CCEmailSupportRequest ThisMessage => null;

		public bool HasEmailAddr => false;

		public string EmailAddr => null;

		public bool HasTitle => false;

		public string Title => null;

		public bool HasContent => false;

		public string Content => null;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCEmailSupportRequest()
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

		public static CCEmailSupportRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCEmailSupportRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEmailSupportRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCEmailSupportRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEmailSupportRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCEmailSupportRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEmailSupportRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCEmailSupportRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCEmailSupportRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCEmailSupportRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCEmailSupportRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCEmailSupportRequest prototype)
		{
			return null;
		}

		static CCEmailSupportRequest()
		{
		}
	}
}
