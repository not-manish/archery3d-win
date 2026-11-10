using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCShootItem : GeneratedMessageLite<CCShootItem, CCShootItem.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCShootItem, Builder>
		{
			private bool resultIsReadOnly;

			private CCShootItem result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCShootItem MessageBeingBuilt => null;

			public override CCShootItem DefaultInstanceForType => null;

			public bool HasShootTime => false;

			public float ShootTime
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public bool HasShootScore => false;

			public int ShootScore
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

			internal Builder(CCShootItem cloneFrom)
			{
			}

			private CCShootItem PrepareBuilder()
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

			public override CCShootItem BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCShootItem other)
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

			public Builder SetShootTime(float value)
			{
				return null;
			}

			public Builder ClearShootTime()
			{
				return null;
			}

			public Builder SetShootScore(int value)
			{
				return null;
			}

			public Builder ClearShootScore()
			{
				return null;
			}
		}

		private static readonly CCShootItem defaultInstance;

		private static readonly string[] _cCShootItemFieldNames;

		private static readonly uint[] _cCShootItemFieldTags;

		public const int ShootTimeFieldNumber = 1;

		private bool hasShootTime;

		private float shootTime_;

		public const int ShootScoreFieldNumber = 2;

		private bool hasShootScore;

		private int shootScore_;

		private int memoizedSerializedSize;

		public static CCShootItem DefaultInstance => null;

		public override CCShootItem DefaultInstanceForType => null;

		protected override CCShootItem ThisMessage => null;

		public bool HasShootTime => false;

		public float ShootTime => 0f;

		public bool HasShootScore => false;

		public int ShootScore => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCShootItem()
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

		public static CCShootItem ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCShootItem ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCShootItem ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCShootItem ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCShootItem ParseFrom(Stream input)
		{
			return null;
		}

		public static CCShootItem ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCShootItem ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCShootItem ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCShootItem ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCShootItem ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCShootItem MakeReadOnly()
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

		public static Builder CreateBuilder(CCShootItem prototype)
		{
			return null;
		}

		static CCShootItem()
		{
		}
	}
}
