using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCVersionInf : GeneratedMessageLite<CCVersionInf, CCVersionInf.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCVersionInf, Builder>
		{
			private bool resultIsReadOnly;

			private CCVersionInf result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCVersionInf MessageBeingBuilt => null;

			public override CCVersionInf DefaultInstanceForType => null;

			public bool HasServerVersion => false;

			public string ServerVersion
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasClientUpgradeState => false;

			public int ClientUpgradeState
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

			internal Builder(CCVersionInf cloneFrom)
			{
			}

			private CCVersionInf PrepareBuilder()
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

			public override CCVersionInf BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCVersionInf other)
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

			public Builder SetServerVersion(string value)
			{
				return null;
			}

			public Builder ClearServerVersion()
			{
				return null;
			}

			public Builder SetClientUpgradeState(int value)
			{
				return null;
			}

			public Builder ClearClientUpgradeState()
			{
				return null;
			}
		}

		private static readonly CCVersionInf defaultInstance;

		private static readonly string[] _cCVersionInfFieldNames;

		private static readonly uint[] _cCVersionInfFieldTags;

		public const int ServerVersionFieldNumber = 1;

		private bool hasServerVersion;

		private string serverVersion_;

		public const int ClientUpgradeStateFieldNumber = 2;

		private bool hasClientUpgradeState;

		private int clientUpgradeState_;

		private int memoizedSerializedSize;

		public static CCVersionInf DefaultInstance => null;

		public override CCVersionInf DefaultInstanceForType => null;

		protected override CCVersionInf ThisMessage => null;

		public bool HasServerVersion => false;

		public string ServerVersion => null;

		public bool HasClientUpgradeState => false;

		public int ClientUpgradeState => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCVersionInf()
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

		public static CCVersionInf ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCVersionInf ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVersionInf ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCVersionInf ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVersionInf ParseFrom(Stream input)
		{
			return null;
		}

		public static CCVersionInf ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVersionInf ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCVersionInf ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVersionInf ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCVersionInf ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCVersionInf MakeReadOnly()
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

		public static Builder CreateBuilder(CCVersionInf prototype)
		{
			return null;
		}

		static CCVersionInf()
		{
		}
	}
}
