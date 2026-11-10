using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCChallengeRankResponse : GeneratedMessageLite<CCChallengeRankResponse, CCChallengeRankResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCChallengeRankResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCChallengeRankResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCChallengeRankResponse MessageBeingBuilt => null;

			public override CCChallengeRankResponse DefaultInstanceForType => null;

			public bool HasIsGetSuccess => false;

			public bool IsGetSuccess
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasChallengeState => false;

			public int ChallengeState
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasJoinCount => false;

			public int JoinCount
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasFinishCount => false;

			public int FinishCount
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasTimeLeft => false;

			public long TimeLeft
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public bool HasMyItem => false;

			public CCRankItem MyItem
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public IPopsicleList<CCRankItem> FinishedTop50ItemsList => null;

			public int FinishedTop50ItemsCount => 0;

			public IPopsicleList<CCRankItem> FinishedBack25ItemsList => null;

			public int FinishedBack25ItemsCount => 0;

			public IPopsicleList<CCRankItem> FrontItemsList => null;

			public int FrontItemsCount => 0;

			public IPopsicleList<CCRankItem> BackItemsList => null;

			public int BackItemsCount => 0;

			public IPopsicleList<CCRankItem> TopUnfinshedItemsList => null;

			public int TopUnfinshedItemsCount => 0;

			public bool HasShouldShowChalRank => false;

			public bool ShouldShowChalRank
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasChallengeRankPercent => false;

			public int ChallengeRankPercent
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasChallengeRankEstimate => false;

			public int ChallengeRankEstimate
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

			internal Builder(CCChallengeRankResponse cloneFrom)
			{
			}

			private CCChallengeRankResponse PrepareBuilder()
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

			public override CCChallengeRankResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCChallengeRankResponse other)
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

			public Builder SetIsGetSuccess(bool value)
			{
				return null;
			}

			public Builder ClearIsGetSuccess()
			{
				return null;
			}

			public Builder SetChallengeState(int value)
			{
				return null;
			}

			public Builder ClearChallengeState()
			{
				return null;
			}

			public Builder SetJoinCount(int value)
			{
				return null;
			}

			public Builder ClearJoinCount()
			{
				return null;
			}

			public Builder SetFinishCount(int value)
			{
				return null;
			}

			public Builder ClearFinishCount()
			{
				return null;
			}

			public Builder SetTimeLeft(long value)
			{
				return null;
			}

			public Builder ClearTimeLeft()
			{
				return null;
			}

			public Builder SetMyItem(CCRankItem value)
			{
				return null;
			}

			public Builder SetMyItem(CCRankItem.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeMyItem(CCRankItem value)
			{
				return null;
			}

			public Builder ClearMyItem()
			{
				return null;
			}

			public CCRankItem GetFinishedTop50Items(int index)
			{
				return null;
			}

			public Builder SetFinishedTop50Items(int index, CCRankItem value)
			{
				return null;
			}

			public Builder SetFinishedTop50Items(int index, CCRankItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddFinishedTop50Items(CCRankItem value)
			{
				return null;
			}

			public Builder AddFinishedTop50Items(CCRankItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeFinishedTop50Items(IEnumerable<CCRankItem> values)
			{
				return null;
			}

			public Builder ClearFinishedTop50Items()
			{
				return null;
			}

			public CCRankItem GetFinishedBack25Items(int index)
			{
				return null;
			}

			public Builder SetFinishedBack25Items(int index, CCRankItem value)
			{
				return null;
			}

			public Builder SetFinishedBack25Items(int index, CCRankItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddFinishedBack25Items(CCRankItem value)
			{
				return null;
			}

			public Builder AddFinishedBack25Items(CCRankItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeFinishedBack25Items(IEnumerable<CCRankItem> values)
			{
				return null;
			}

			public Builder ClearFinishedBack25Items()
			{
				return null;
			}

			public CCRankItem GetFrontItems(int index)
			{
				return null;
			}

			public Builder SetFrontItems(int index, CCRankItem value)
			{
				return null;
			}

			public Builder SetFrontItems(int index, CCRankItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddFrontItems(CCRankItem value)
			{
				return null;
			}

			public Builder AddFrontItems(CCRankItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeFrontItems(IEnumerable<CCRankItem> values)
			{
				return null;
			}

			public Builder ClearFrontItems()
			{
				return null;
			}

			public CCRankItem GetBackItems(int index)
			{
				return null;
			}

			public Builder SetBackItems(int index, CCRankItem value)
			{
				return null;
			}

			public Builder SetBackItems(int index, CCRankItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddBackItems(CCRankItem value)
			{
				return null;
			}

			public Builder AddBackItems(CCRankItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeBackItems(IEnumerable<CCRankItem> values)
			{
				return null;
			}

			public Builder ClearBackItems()
			{
				return null;
			}

			public CCRankItem GetTopUnfinshedItems(int index)
			{
				return null;
			}

			public Builder SetTopUnfinshedItems(int index, CCRankItem value)
			{
				return null;
			}

			public Builder SetTopUnfinshedItems(int index, CCRankItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddTopUnfinshedItems(CCRankItem value)
			{
				return null;
			}

			public Builder AddTopUnfinshedItems(CCRankItem.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeTopUnfinshedItems(IEnumerable<CCRankItem> values)
			{
				return null;
			}

			public Builder ClearTopUnfinshedItems()
			{
				return null;
			}

			public Builder SetShouldShowChalRank(bool value)
			{
				return null;
			}

			public Builder ClearShouldShowChalRank()
			{
				return null;
			}

			public Builder SetChallengeRankPercent(int value)
			{
				return null;
			}

			public Builder ClearChallengeRankPercent()
			{
				return null;
			}

			public Builder SetChallengeRankEstimate(int value)
			{
				return null;
			}

			public Builder ClearChallengeRankEstimate()
			{
				return null;
			}
		}

		private static readonly CCChallengeRankResponse defaultInstance;

		private static readonly string[] _cCChallengeRankResponseFieldNames;

		private static readonly uint[] _cCChallengeRankResponseFieldTags;

		public const int IsGetSuccessFieldNumber = 1;

		private bool hasIsGetSuccess;

		private bool isGetSuccess_;

		public const int ChallengeStateFieldNumber = 2;

		private bool hasChallengeState;

		private int challengeState_;

		public const int JoinCountFieldNumber = 3;

		private bool hasJoinCount;

		private int joinCount_;

		public const int FinishCountFieldNumber = 4;

		private bool hasFinishCount;

		private int finishCount_;

		public const int TimeLeftFieldNumber = 5;

		private bool hasTimeLeft;

		private long timeLeft_;

		public const int MyItemFieldNumber = 6;

		private bool hasMyItem;

		private CCRankItem myItem_;

		public const int FinishedTop50ItemsFieldNumber = 7;

		private PopsicleList<CCRankItem> finishedTop50Items_;

		public const int FinishedBack25ItemsFieldNumber = 8;

		private PopsicleList<CCRankItem> finishedBack25Items_;

		public const int FrontItemsFieldNumber = 9;

		private PopsicleList<CCRankItem> frontItems_;

		public const int BackItemsFieldNumber = 10;

		private PopsicleList<CCRankItem> backItems_;

		public const int TopUnfinshedItemsFieldNumber = 11;

		private PopsicleList<CCRankItem> topUnfinshedItems_;

		public const int ShouldShowChalRankFieldNumber = 12;

		private bool hasShouldShowChalRank;

		private bool shouldShowChalRank_;

		public const int ChallengeRankPercentFieldNumber = 13;

		private bool hasChallengeRankPercent;

		private int challengeRankPercent_;

		public const int ChallengeRankEstimateFieldNumber = 14;

		private bool hasChallengeRankEstimate;

		private int challengeRankEstimate_;

		private int memoizedSerializedSize;

		public static CCChallengeRankResponse DefaultInstance => null;

		public override CCChallengeRankResponse DefaultInstanceForType => null;

		protected override CCChallengeRankResponse ThisMessage => null;

		public bool HasIsGetSuccess => false;

		public bool IsGetSuccess => false;

		public bool HasChallengeState => false;

		public int ChallengeState => 0;

		public bool HasJoinCount => false;

		public int JoinCount => 0;

		public bool HasFinishCount => false;

		public int FinishCount => 0;

		public bool HasTimeLeft => false;

		public long TimeLeft => 0L;

		public bool HasMyItem => false;

		public CCRankItem MyItem => null;

		public IList<CCRankItem> FinishedTop50ItemsList => null;

		public int FinishedTop50ItemsCount => 0;

		public IList<CCRankItem> FinishedBack25ItemsList => null;

		public int FinishedBack25ItemsCount => 0;

		public IList<CCRankItem> FrontItemsList => null;

		public int FrontItemsCount => 0;

		public IList<CCRankItem> BackItemsList => null;

		public int BackItemsCount => 0;

		public IList<CCRankItem> TopUnfinshedItemsList => null;

		public int TopUnfinshedItemsCount => 0;

		public bool HasShouldShowChalRank => false;

		public bool ShouldShowChalRank => false;

		public bool HasChallengeRankPercent => false;

		public int ChallengeRankPercent => 0;

		public bool HasChallengeRankEstimate => false;

		public int ChallengeRankEstimate => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCChallengeRankResponse()
		{
		}

		public CCRankItem GetFinishedTop50Items(int index)
		{
			return null;
		}

		public CCRankItem GetFinishedBack25Items(int index)
		{
			return null;
		}

		public CCRankItem GetFrontItems(int index)
		{
			return null;
		}

		public CCRankItem GetBackItems(int index)
		{
			return null;
		}

		public CCRankItem GetTopUnfinshedItems(int index)
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

		public static CCChallengeRankResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCChallengeRankResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeRankResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCChallengeRankResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeRankResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCChallengeRankResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeRankResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCChallengeRankResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCChallengeRankResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCChallengeRankResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCChallengeRankResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCChallengeRankResponse prototype)
		{
			return null;
		}

		static CCChallengeRankResponse()
		{
		}
	}
}
