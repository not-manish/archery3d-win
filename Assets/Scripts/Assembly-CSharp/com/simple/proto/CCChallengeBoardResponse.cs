using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCChallengeBoardResponse : GeneratedMessageLite<CCChallengeBoardResponse, CCChallengeBoardResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCChallengeBoardResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCChallengeBoardResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCChallengeBoardResponse MessageBeingBuilt => null;

			public override CCChallengeBoardResponse DefaultInstanceForType => null;

			public bool HasGetPlayerSuccessMy => false;

			public bool GetPlayerSuccessMy
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasGetPlayerSuccessOpp => false;

			public bool GetPlayerSuccessOpp
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasUidMy => false;

			public string UidMy
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasUidOpp => false;

			public string UidOpp
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public IPopsicleList<CCChallengeLevel> ChallengeLevelMyList => null;

			public int ChallengeLevelMyCount => 0;

			public IPopsicleList<CCChallengeLevel> ChallengeLevelOppList => null;

			public int ChallengeLevelOppCount => 0;

			public Builder()
			{
			}

			internal Builder(CCChallengeBoardResponse cloneFrom)
			{
			}

			private CCChallengeBoardResponse PrepareBuilder()
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

			public override CCChallengeBoardResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCChallengeBoardResponse other)
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

			public Builder SetGetPlayerSuccessMy(bool value)
			{
				return null;
			}

			public Builder ClearGetPlayerSuccessMy()
			{
				return null;
			}

			public Builder SetGetPlayerSuccessOpp(bool value)
			{
				return null;
			}

			public Builder ClearGetPlayerSuccessOpp()
			{
				return null;
			}

			public Builder SetUidMy(string value)
			{
				return null;
			}

			public Builder ClearUidMy()
			{
				return null;
			}

			public Builder SetUidOpp(string value)
			{
				return null;
			}

			public Builder ClearUidOpp()
			{
				return null;
			}

			public CCChallengeLevel GetChallengeLevelMy(int index)
			{
				return null;
			}

			public Builder SetChallengeLevelMy(int index, CCChallengeLevel value)
			{
				return null;
			}

			public Builder SetChallengeLevelMy(int index, CCChallengeLevel.Builder builderForValue)
			{
				return null;
			}

			public Builder AddChallengeLevelMy(CCChallengeLevel value)
			{
				return null;
			}

			public Builder AddChallengeLevelMy(CCChallengeLevel.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeChallengeLevelMy(IEnumerable<CCChallengeLevel> values)
			{
				return null;
			}

			public Builder ClearChallengeLevelMy()
			{
				return null;
			}

			public CCChallengeLevel GetChallengeLevelOpp(int index)
			{
				return null;
			}

			public Builder SetChallengeLevelOpp(int index, CCChallengeLevel value)
			{
				return null;
			}

			public Builder SetChallengeLevelOpp(int index, CCChallengeLevel.Builder builderForValue)
			{
				return null;
			}

			public Builder AddChallengeLevelOpp(CCChallengeLevel value)
			{
				return null;
			}

			public Builder AddChallengeLevelOpp(CCChallengeLevel.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeChallengeLevelOpp(IEnumerable<CCChallengeLevel> values)
			{
				return null;
			}

			public Builder ClearChallengeLevelOpp()
			{
				return null;
			}
		}

		private static readonly CCChallengeBoardResponse defaultInstance;

		private static readonly string[] _cCChallengeBoardResponseFieldNames;

		private static readonly uint[] _cCChallengeBoardResponseFieldTags;

		public const int GetPlayerSuccessMyFieldNumber = 1;

		private bool hasGetPlayerSuccessMy;

		private bool getPlayerSuccessMy_;

		public const int GetPlayerSuccessOppFieldNumber = 2;

		private bool hasGetPlayerSuccessOpp;

		private bool getPlayerSuccessOpp_;

		public const int UidMyFieldNumber = 3;

		private bool hasUidMy;

		private string uidMy_;

		public const int UidOppFieldNumber = 4;

		private bool hasUidOpp;

		private string uidOpp_;

		public const int ChallengeLevelMyFieldNumber = 5;

		private PopsicleList<CCChallengeLevel> challengeLevelMy_;

		public const int ChallengeLevelOppFieldNumber = 6;

		private PopsicleList<CCChallengeLevel> challengeLevelOpp_;

		private int memoizedSerializedSize;

		public static CCChallengeBoardResponse DefaultInstance => null;

		public override CCChallengeBoardResponse DefaultInstanceForType => null;

		protected override CCChallengeBoardResponse ThisMessage => null;

		public bool HasGetPlayerSuccessMy => false;

		public bool GetPlayerSuccessMy => false;

		public bool HasGetPlayerSuccessOpp => false;

		public bool GetPlayerSuccessOpp => false;

		public bool HasUidMy => false;

		public string UidMy => null;

		public bool HasUidOpp => false;

		public string UidOpp => null;

		public IList<CCChallengeLevel> ChallengeLevelMyList => null;

		public int ChallengeLevelMyCount => 0;

		public IList<CCChallengeLevel> ChallengeLevelOppList => null;

		public int ChallengeLevelOppCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCChallengeBoardResponse()
		{
		}

		public CCChallengeLevel GetChallengeLevelMy(int index)
		{
			return null;
		}

		public CCChallengeLevel GetChallengeLevelOpp(int index)
		{
			return null;
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

		public static CCChallengeBoardResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCChallengeBoardResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeBoardResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCChallengeBoardResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeBoardResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCChallengeBoardResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeBoardResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCChallengeBoardResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeBoardResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCChallengeBoardResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCChallengeBoardResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCChallengeBoardResponse prototype)
		{
			return null;
		}

		static CCChallengeBoardResponse()
		{
		}
	}
}
