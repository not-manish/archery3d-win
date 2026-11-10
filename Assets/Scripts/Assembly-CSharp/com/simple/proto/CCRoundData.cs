using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCRoundData : GeneratedMessageLite<CCRoundData, CCRoundData.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCRoundData, Builder>
		{
			private bool resultIsReadOnly;

			private CCRoundData result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCRoundData MessageBeingBuilt => null;

			public override CCRoundData DefaultInstanceForType => null;

			public bool HasHasWind => false;

			public bool HasWind
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasWindSpeed => false;

			public float WindSpeed
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public bool HasWindAngle => false;

			public float WindAngle
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

			internal Builder(CCRoundData cloneFrom)
			{
			}

			private CCRoundData PrepareBuilder()
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

			public override CCRoundData BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCRoundData other)
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

			public Builder SetHasWind(bool value)
			{
				return null;
			}

			public Builder ClearHasWind()
			{
				return null;
			}

			public Builder SetWindSpeed(float value)
			{
				return null;
			}

			public Builder ClearWindSpeed()
			{
				return null;
			}

			public Builder SetWindAngle(float value)
			{
				return null;
			}

			public Builder ClearWindAngle()
			{
				return null;
			}
		}

		private static readonly CCRoundData defaultInstance;

		private static readonly string[] _cCRoundDataFieldNames;

		private static readonly uint[] _cCRoundDataFieldTags;

		public const int HasWindFieldNumber = 1;

		private bool hasHasWind;

		private bool hasWind_;

		public const int WindSpeedFieldNumber = 2;

		private bool hasWindSpeed;

		private float windSpeed_;

		public const int WindAngleFieldNumber = 3;

		private bool hasWindAngle;

		private float windAngle_;

		private int memoizedSerializedSize;

		public static CCRoundData DefaultInstance => null;

		public override CCRoundData DefaultInstanceForType => null;

		protected override CCRoundData ThisMessage => null;

		public bool HasHasWind => false;

		public bool HasWind => false;

		public bool HasWindSpeed => false;

		public float WindSpeed => 0f;

		public bool HasWindAngle => false;

		public float WindAngle => 0f;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCRoundData()
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

		public static CCRoundData ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCRoundData ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRoundData ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCRoundData ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRoundData ParseFrom(Stream input)
		{
			return null;
		}

		public static CCRoundData ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRoundData ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCRoundData ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCRoundData ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCRoundData ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCRoundData MakeReadOnly()
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

		public static Builder CreateBuilder(CCRoundData prototype)
		{
			return null;
		}

		static CCRoundData()
		{
		}
	}
}
