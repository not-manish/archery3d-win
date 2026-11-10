using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCVector3 : GeneratedMessageLite<CCVector3, CCVector3.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCVector3, Builder>
		{
			private bool resultIsReadOnly;

			private CCVector3 result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCVector3 MessageBeingBuilt => null;

			public override CCVector3 DefaultInstanceForType => null;

			public bool HasX => false;

			public float X
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public bool HasY => false;

			public float Y
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public bool HasZ => false;

			public float Z
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public Builder()
			{
			}

			internal Builder(CCVector3 cloneFrom)
			{
			}

			private CCVector3 PrepareBuilder()
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

			public override CCVector3 BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCVector3 other)
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

			public Builder SetX(float value)
			{
				return null;
			}

			public Builder ClearX()
			{
				return null;
			}

			public Builder SetY(float value)
			{
				return null;
			}

			public Builder ClearY()
			{
				return null;
			}

			public Builder SetZ(float value)
			{
				return null;
			}

			public Builder ClearZ()
			{
				return null;
			}
		}

		private static readonly CCVector3 defaultInstance;

		private static readonly string[] _cCVector3FieldNames;

		private static readonly uint[] _cCVector3FieldTags;

		public const int XFieldNumber = 1;

		private bool hasX;

		private float x_;

		public const int YFieldNumber = 2;

		private bool hasY;

		private float y_;

		public const int ZFieldNumber = 3;

		private bool hasZ;

		private float z_;

		private int memoizedSerializedSize;

		public static CCVector3 DefaultInstance => null;

		public override CCVector3 DefaultInstanceForType => null;

		protected override CCVector3 ThisMessage => null;

		public bool HasX => false;

		public float X => 0f;

		public bool HasY => false;

		public float Y => 0f;

		public bool HasZ => false;

		public float Z => 0f;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCVector3()
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

		public static CCVector3 ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCVector3 ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVector3 ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCVector3 ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVector3 ParseFrom(Stream input)
		{
			return null;
		}

		public static CCVector3 ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVector3 ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCVector3 ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCVector3 ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCVector3 ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCVector3 MakeReadOnly()
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

		public static Builder CreateBuilder(CCVector3 prototype)
		{
			return null;
		}

		static CCVector3()
		{
		}
	}
}
