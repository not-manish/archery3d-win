using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCPVPResponse : GeneratedMessageLite<CCPVPResponse, CCPVPResponse.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCPVPResponse, Builder>
		{
			private bool resultIsReadOnly;

			private CCPVPResponse result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCPVPResponse MessageBeingBuilt => null;

			public override CCPVPResponse DefaultInstanceForType => null;

			public bool HasStatus => false;

			public CCStatus Status
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasType => false;

			public int Type
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasGameType => false;

			public int GameType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasPvpType => false;

			public int PvpType
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasRoundData => false;

			public CCRoundData RoundData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasShootBowId => false;

			public int ShootBowId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasShootArrowId => false;

			public int ShootArrowId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasShootArmId => false;

			public int ShootArmId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasShootSightId => false;

			public int ShootSightId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasShootStabilizerId => false;

			public int ShootStabilizerId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasShootTargetTime => false;

			public float ShootTargetTime
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public bool HasHasShoot => false;

			public bool HasShoot
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool HasIsMyShoot => false;

			public bool IsMyShoot
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public IPopsicleList<int> MyTargetIdsList => null;

			public int MyTargetIdsCount => 0;

			public IPopsicleList<int> OppTargetIdsList => null;

			public int OppTargetIdsCount => 0;

			public bool HasTargetMoveTime => false;

			public int TargetMoveTime
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasCamStartPos => false;

			public CCVector3 CamStartPos
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasCamStartDir => false;

			public CCVector3 CamStartDir
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasTargetZ => false;

			public float TargetZ
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public IPopsicleList<int> HitTargetIdsList => null;

			public int HitTargetIdsCount => 0;

			public IPopsicleList<CCVector3> HitTargetPosList => null;

			public int HitTargetPosCount => 0;

			public bool HasLastRoundData => false;

			public CCRoundData LastRoundData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasLastHitLocalPos => false;

			public CCVector3 LastHitLocalPos
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasNextRound => false;

			public int NextRound
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public IPopsicleList<int> ScoreMyList => null;

			public int ScoreMyCount => 0;

			public IPopsicleList<int> ScoreOppList => null;

			public int ScoreOppCount => 0;

			public bool HasTimeLeft => false;

			public float TimeLeft
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public IPopsicleList<int> RoundCountMyList => null;

			public int RoundCountMyCount => 0;

			public IPopsicleList<int> RoundCountOppList => null;

			public int RoundCountOppCount => 0;

			public bool HasEquipData => false;

			public CCEquipData EquipData
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public bool HasAiNextRount => false;

			public int AiNextRount
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasAiNextScore => false;

			public int AiNextScore
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public IPopsicleList<CCVector3> TargetPosList => null;

			public int TargetPosCount => 0;

			public IPopsicleList<CCVector3> HitTargetForwardList => null;

			public int HitTargetForwardCount => 0;

			public IPopsicleList<CCVector3> HitTargetTopList => null;

			public int HitTargetTopCount => 0;

			public IPopsicleList<CCKeyValueIntInt> IdToScoresMyList => null;

			public int IdToScoresMyCount => 0;

			public IPopsicleList<CCKeyValueIntInt> IdToScoresOppList => null;

			public int IdToScoresOppCount => 0;

			public bool HasCurArrowId => false;

			public int CurArrowId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasShootArrowLeft => false;

			public int ShootArrowLeft
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

			internal Builder(CCPVPResponse cloneFrom)
			{
			}

			private CCPVPResponse PrepareBuilder()
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

			public override CCPVPResponse BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCPVPResponse other)
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

			public Builder SetStatus(CCStatus value)
			{
				return null;
			}

			public Builder SetStatus(CCStatus.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeStatus(CCStatus value)
			{
				return null;
			}

			public Builder ClearStatus()
			{
				return null;
			}

			public Builder SetType(int value)
			{
				return null;
			}

			public Builder ClearType()
			{
				return null;
			}

			public Builder SetGameType(int value)
			{
				return null;
			}

			public Builder ClearGameType()
			{
				return null;
			}

			public Builder SetPvpType(int value)
			{
				return null;
			}

			public Builder ClearPvpType()
			{
				return null;
			}

			public Builder SetRoundData(CCRoundData value)
			{
				return null;
			}

			public Builder SetRoundData(CCRoundData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeRoundData(CCRoundData value)
			{
				return null;
			}

			public Builder ClearRoundData()
			{
				return null;
			}

			public Builder SetShootBowId(int value)
			{
				return null;
			}

			public Builder ClearShootBowId()
			{
				return null;
			}

			public Builder SetShootArrowId(int value)
			{
				return null;
			}

			public Builder ClearShootArrowId()
			{
				return null;
			}

			public Builder SetShootArmId(int value)
			{
				return null;
			}

			public Builder ClearShootArmId()
			{
				return null;
			}

			public Builder SetShootSightId(int value)
			{
				return null;
			}

			public Builder ClearShootSightId()
			{
				return null;
			}

			public Builder SetShootStabilizerId(int value)
			{
				return null;
			}

			public Builder ClearShootStabilizerId()
			{
				return null;
			}

			public Builder SetShootTargetTime(float value)
			{
				return null;
			}

			public Builder ClearShootTargetTime()
			{
				return null;
			}

			public Builder SetHasShoot(bool value)
			{
				return null;
			}

			public Builder ClearHasShoot()
			{
				return null;
			}

			public Builder SetIsMyShoot(bool value)
			{
				return null;
			}

			public Builder ClearIsMyShoot()
			{
				return null;
			}

			public int GetMyTargetIds(int index)
			{
				return 0;
			}

			public Builder SetMyTargetIds(int index, int value)
			{
				return null;
			}

			public Builder AddMyTargetIds(int value)
			{
				return null;
			}

			public Builder AddRangeMyTargetIds(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearMyTargetIds()
			{
				return null;
			}

			public int GetOppTargetIds(int index)
			{
				return 0;
			}

			public Builder SetOppTargetIds(int index, int value)
			{
				return null;
			}

			public Builder AddOppTargetIds(int value)
			{
				return null;
			}

			public Builder AddRangeOppTargetIds(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearOppTargetIds()
			{
				return null;
			}

			public Builder SetTargetMoveTime(int value)
			{
				return null;
			}

			public Builder ClearTargetMoveTime()
			{
				return null;
			}

			public Builder SetCamStartPos(CCVector3 value)
			{
				return null;
			}

			public Builder SetCamStartPos(CCVector3.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeCamStartPos(CCVector3 value)
			{
				return null;
			}

			public Builder ClearCamStartPos()
			{
				return null;
			}

			public Builder SetCamStartDir(CCVector3 value)
			{
				return null;
			}

			public Builder SetCamStartDir(CCVector3.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeCamStartDir(CCVector3 value)
			{
				return null;
			}

			public Builder ClearCamStartDir()
			{
				return null;
			}

			public Builder SetTargetZ(float value)
			{
				return null;
			}

			public Builder ClearTargetZ()
			{
				return null;
			}

			public int GetHitTargetIds(int index)
			{
				return 0;
			}

			public Builder SetHitTargetIds(int index, int value)
			{
				return null;
			}

			public Builder AddHitTargetIds(int value)
			{
				return null;
			}

			public Builder AddRangeHitTargetIds(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearHitTargetIds()
			{
				return null;
			}

			public CCVector3 GetHitTargetPos(int index)
			{
				return null;
			}

			public Builder SetHitTargetPos(int index, CCVector3 value)
			{
				return null;
			}

			public Builder SetHitTargetPos(int index, CCVector3.Builder builderForValue)
			{
				return null;
			}

			public Builder AddHitTargetPos(CCVector3 value)
			{
				return null;
			}

			public Builder AddHitTargetPos(CCVector3.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeHitTargetPos(IEnumerable<CCVector3> values)
			{
				return null;
			}

			public Builder ClearHitTargetPos()
			{
				return null;
			}

			public Builder SetLastRoundData(CCRoundData value)
			{
				return null;
			}

			public Builder SetLastRoundData(CCRoundData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeLastRoundData(CCRoundData value)
			{
				return null;
			}

			public Builder ClearLastRoundData()
			{
				return null;
			}

			public Builder SetLastHitLocalPos(CCVector3 value)
			{
				return null;
			}

			public Builder SetLastHitLocalPos(CCVector3.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeLastHitLocalPos(CCVector3 value)
			{
				return null;
			}

			public Builder ClearLastHitLocalPos()
			{
				return null;
			}

			public Builder SetNextRound(int value)
			{
				return null;
			}

			public Builder ClearNextRound()
			{
				return null;
			}

			public int GetScoreMy(int index)
			{
				return 0;
			}

			public Builder SetScoreMy(int index, int value)
			{
				return null;
			}

			public Builder AddScoreMy(int value)
			{
				return null;
			}

			public Builder AddRangeScoreMy(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearScoreMy()
			{
				return null;
			}

			public int GetScoreOpp(int index)
			{
				return 0;
			}

			public Builder SetScoreOpp(int index, int value)
			{
				return null;
			}

			public Builder AddScoreOpp(int value)
			{
				return null;
			}

			public Builder AddRangeScoreOpp(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearScoreOpp()
			{
				return null;
			}

			public Builder SetTimeLeft(float value)
			{
				return null;
			}

			public Builder ClearTimeLeft()
			{
				return null;
			}

			public int GetRoundCountMy(int index)
			{
				return 0;
			}

			public Builder SetRoundCountMy(int index, int value)
			{
				return null;
			}

			public Builder AddRoundCountMy(int value)
			{
				return null;
			}

			public Builder AddRangeRoundCountMy(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearRoundCountMy()
			{
				return null;
			}

			public int GetRoundCountOpp(int index)
			{
				return 0;
			}

			public Builder SetRoundCountOpp(int index, int value)
			{
				return null;
			}

			public Builder AddRoundCountOpp(int value)
			{
				return null;
			}

			public Builder AddRangeRoundCountOpp(IEnumerable<int> values)
			{
				return null;
			}

			public Builder ClearRoundCountOpp()
			{
				return null;
			}

			public Builder SetEquipData(CCEquipData value)
			{
				return null;
			}

			public Builder SetEquipData(CCEquipData.Builder builderForValue)
			{
				return null;
			}

			public Builder MergeEquipData(CCEquipData value)
			{
				return null;
			}

			public Builder ClearEquipData()
			{
				return null;
			}

			public Builder SetAiNextRount(int value)
			{
				return null;
			}

			public Builder ClearAiNextRount()
			{
				return null;
			}

			public Builder SetAiNextScore(int value)
			{
				return null;
			}

			public Builder ClearAiNextScore()
			{
				return null;
			}

			public CCVector3 GetTargetPos(int index)
			{
				return null;
			}

			public Builder SetTargetPos(int index, CCVector3 value)
			{
				return null;
			}

			public Builder SetTargetPos(int index, CCVector3.Builder builderForValue)
			{
				return null;
			}

			public Builder AddTargetPos(CCVector3 value)
			{
				return null;
			}

			public Builder AddTargetPos(CCVector3.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeTargetPos(IEnumerable<CCVector3> values)
			{
				return null;
			}

			public Builder ClearTargetPos()
			{
				return null;
			}

			public CCVector3 GetHitTargetForward(int index)
			{
				return null;
			}

			public Builder SetHitTargetForward(int index, CCVector3 value)
			{
				return null;
			}

			public Builder SetHitTargetForward(int index, CCVector3.Builder builderForValue)
			{
				return null;
			}

			public Builder AddHitTargetForward(CCVector3 value)
			{
				return null;
			}

			public Builder AddHitTargetForward(CCVector3.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeHitTargetForward(IEnumerable<CCVector3> values)
			{
				return null;
			}

			public Builder ClearHitTargetForward()
			{
				return null;
			}

			public CCVector3 GetHitTargetTop(int index)
			{
				return null;
			}

			public Builder SetHitTargetTop(int index, CCVector3 value)
			{
				return null;
			}

			public Builder SetHitTargetTop(int index, CCVector3.Builder builderForValue)
			{
				return null;
			}

			public Builder AddHitTargetTop(CCVector3 value)
			{
				return null;
			}

			public Builder AddHitTargetTop(CCVector3.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeHitTargetTop(IEnumerable<CCVector3> values)
			{
				return null;
			}

			public Builder ClearHitTargetTop()
			{
				return null;
			}

			public CCKeyValueIntInt GetIdToScoresMy(int index)
			{
				return null;
			}

			public Builder SetIdToScoresMy(int index, CCKeyValueIntInt value)
			{
				return null;
			}

			public Builder SetIdToScoresMy(int index, CCKeyValueIntInt.Builder builderForValue)
			{
				return null;
			}

			public Builder AddIdToScoresMy(CCKeyValueIntInt value)
			{
				return null;
			}

			public Builder AddIdToScoresMy(CCKeyValueIntInt.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeIdToScoresMy(IEnumerable<CCKeyValueIntInt> values)
			{
				return null;
			}

			public Builder ClearIdToScoresMy()
			{
				return null;
			}

			public CCKeyValueIntInt GetIdToScoresOpp(int index)
			{
				return null;
			}

			public Builder SetIdToScoresOpp(int index, CCKeyValueIntInt value)
			{
				return null;
			}

			public Builder SetIdToScoresOpp(int index, CCKeyValueIntInt.Builder builderForValue)
			{
				return null;
			}

			public Builder AddIdToScoresOpp(CCKeyValueIntInt value)
			{
				return null;
			}

			public Builder AddIdToScoresOpp(CCKeyValueIntInt.Builder builderForValue)
			{
				return null;
			}

			public Builder AddRangeIdToScoresOpp(IEnumerable<CCKeyValueIntInt> values)
			{
				return null;
			}

			public Builder ClearIdToScoresOpp()
			{
				return null;
			}

			public Builder SetCurArrowId(int value)
			{
				return null;
			}

			public Builder ClearCurArrowId()
			{
				return null;
			}

			public Builder SetShootArrowLeft(int value)
			{
				return null;
			}

			public Builder ClearShootArrowLeft()
			{
				return null;
			}
		}

		private static readonly CCPVPResponse defaultInstance;

		private static readonly string[] _cCPVPResponseFieldNames;

		private static readonly uint[] _cCPVPResponseFieldTags;

		public const int StatusFieldNumber = 1;

		private bool hasStatus;

		private CCStatus status_;

		public const int TypeFieldNumber = 2;

		private bool hasType;

		private int type_;

		public const int GameTypeFieldNumber = 4;

		private bool hasGameType;

		private int gameType_;

		public const int PvpTypeFieldNumber = 5;

		private bool hasPvpType;

		private int pvpType_;

		public const int RoundDataFieldNumber = 6;

		private bool hasRoundData;

		private CCRoundData roundData_;

		public const int ShootBowIdFieldNumber = 7;

		private bool hasShootBowId;

		private int shootBowId_;

		public const int ShootArrowIdFieldNumber = 8;

		private bool hasShootArrowId;

		private int shootArrowId_;

		public const int ShootArmIdFieldNumber = 9;

		private bool hasShootArmId;

		private int shootArmId_;

		public const int ShootSightIdFieldNumber = 10;

		private bool hasShootSightId;

		private int shootSightId_;

		public const int ShootStabilizerIdFieldNumber = 11;

		private bool hasShootStabilizerId;

		private int shootStabilizerId_;

		public const int ShootTargetTimeFieldNumber = 12;

		private bool hasShootTargetTime;

		private float shootTargetTime_;

		public const int HasShootFieldNumber = 13;

		private bool hasHasShoot;

		private bool hasShoot_;

		public const int IsMyShootFieldNumber = 14;

		private bool hasIsMyShoot;

		private bool isMyShoot_;

		public const int MyTargetIdsFieldNumber = 15;

		private PopsicleList<int> myTargetIds_;

		public const int OppTargetIdsFieldNumber = 16;

		private PopsicleList<int> oppTargetIds_;

		public const int TargetMoveTimeFieldNumber = 17;

		private bool hasTargetMoveTime;

		private int targetMoveTime_;

		public const int CamStartPosFieldNumber = 18;

		private bool hasCamStartPos;

		private CCVector3 camStartPos_;

		public const int CamStartDirFieldNumber = 19;

		private bool hasCamStartDir;

		private CCVector3 camStartDir_;

		public const int TargetZFieldNumber = 20;

		private bool hasTargetZ;

		private float targetZ_;

		public const int HitTargetIdsFieldNumber = 21;

		private PopsicleList<int> hitTargetIds_;

		public const int HitTargetPosFieldNumber = 22;

		private PopsicleList<CCVector3> hitTargetPos_;

		public const int LastRoundDataFieldNumber = 23;

		private bool hasLastRoundData;

		private CCRoundData lastRoundData_;

		public const int LastHitLocalPosFieldNumber = 24;

		private bool hasLastHitLocalPos;

		private CCVector3 lastHitLocalPos_;

		public const int NextRoundFieldNumber = 25;

		private bool hasNextRound;

		private int nextRound_;

		public const int ScoreMyFieldNumber = 26;

		private PopsicleList<int> scoreMy_;

		public const int ScoreOppFieldNumber = 27;

		private PopsicleList<int> scoreOpp_;

		public const int TimeLeftFieldNumber = 28;

		private bool hasTimeLeft;

		private float timeLeft_;

		public const int RoundCountMyFieldNumber = 29;

		private PopsicleList<int> roundCountMy_;

		public const int RoundCountOppFieldNumber = 30;

		private PopsicleList<int> roundCountOpp_;

		public const int EquipDataFieldNumber = 31;

		private bool hasEquipData;

		private CCEquipData equipData_;

		public const int AiNextRountFieldNumber = 32;

		private bool hasAiNextRount;

		private int aiNextRount_;

		public const int AiNextScoreFieldNumber = 33;

		private bool hasAiNextScore;

		private int aiNextScore_;

		public const int TargetPosFieldNumber = 34;

		private PopsicleList<CCVector3> targetPos_;

		public const int HitTargetForwardFieldNumber = 35;

		private PopsicleList<CCVector3> hitTargetForward_;

		public const int HitTargetTopFieldNumber = 36;

		private PopsicleList<CCVector3> hitTargetTop_;

		public const int IdToScoresMyFieldNumber = 37;

		private PopsicleList<CCKeyValueIntInt> idToScoresMy_;

		public const int IdToScoresOppFieldNumber = 38;

		private PopsicleList<CCKeyValueIntInt> idToScoresOpp_;

		public const int CurArrowIdFieldNumber = 39;

		private bool hasCurArrowId;

		private int curArrowId_;

		public const int ShootArrowLeftFieldNumber = 41;

		private bool hasShootArrowLeft;

		private int shootArrowLeft_;

		private int memoizedSerializedSize;

		public static CCPVPResponse DefaultInstance => null;

		public override CCPVPResponse DefaultInstanceForType => null;

		protected override CCPVPResponse ThisMessage => null;

		public bool HasStatus => false;

		public CCStatus Status => null;

		public bool HasType => false;

		public int Type => 0;

		public bool HasGameType => false;

		public int GameType => 0;

		public bool HasPvpType => false;

		public int PvpType => 0;

		public bool HasRoundData => false;

		public CCRoundData RoundData => null;

		public bool HasShootBowId => false;

		public int ShootBowId => 0;

		public bool HasShootArrowId => false;

		public int ShootArrowId => 0;

		public bool HasShootArmId => false;

		public int ShootArmId => 0;

		public bool HasShootSightId => false;

		public int ShootSightId => 0;

		public bool HasShootStabilizerId => false;

		public int ShootStabilizerId => 0;

		public bool HasShootTargetTime => false;

		public float ShootTargetTime => 0f;

		public bool HasHasShoot => false;

		public bool HasShoot => false;

		public bool HasIsMyShoot => false;

		public bool IsMyShoot => false;

		public IList<int> MyTargetIdsList => null;

		public int MyTargetIdsCount => 0;

		public IList<int> OppTargetIdsList => null;

		public int OppTargetIdsCount => 0;

		public bool HasTargetMoveTime => false;

		public int TargetMoveTime => 0;

		public bool HasCamStartPos => false;

		public CCVector3 CamStartPos => null;

		public bool HasCamStartDir => false;

		public CCVector3 CamStartDir => null;

		public bool HasTargetZ => false;

		public float TargetZ => 0f;

		public IList<int> HitTargetIdsList => null;

		public int HitTargetIdsCount => 0;

		public IList<CCVector3> HitTargetPosList => null;

		public int HitTargetPosCount => 0;

		public bool HasLastRoundData => false;

		public CCRoundData LastRoundData => null;

		public bool HasLastHitLocalPos => false;

		public CCVector3 LastHitLocalPos => null;

		public bool HasNextRound => false;

		public int NextRound => 0;

		public IList<int> ScoreMyList => null;

		public int ScoreMyCount => 0;

		public IList<int> ScoreOppList => null;

		public int ScoreOppCount => 0;

		public bool HasTimeLeft => false;

		public float TimeLeft => 0f;

		public IList<int> RoundCountMyList => null;

		public int RoundCountMyCount => 0;

		public IList<int> RoundCountOppList => null;

		public int RoundCountOppCount => 0;

		public bool HasEquipData => false;

		public CCEquipData EquipData => null;

		public bool HasAiNextRount => false;

		public int AiNextRount => 0;

		public bool HasAiNextScore => false;

		public int AiNextScore => 0;

		public IList<CCVector3> TargetPosList => null;

		public int TargetPosCount => 0;

		public IList<CCVector3> HitTargetForwardList => null;

		public int HitTargetForwardCount => 0;

		public IList<CCVector3> HitTargetTopList => null;

		public int HitTargetTopCount => 0;

		public IList<CCKeyValueIntInt> IdToScoresMyList => null;

		public int IdToScoresMyCount => 0;

		public IList<CCKeyValueIntInt> IdToScoresOppList => null;

		public int IdToScoresOppCount => 0;

		public bool HasCurArrowId => false;

		public int CurArrowId => 0;

		public bool HasShootArrowLeft => false;

		public int ShootArrowLeft => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCPVPResponse()
		{
		}

		public int GetMyTargetIds(int index)
		{
			return 0;
		}

		public int GetOppTargetIds(int index)
		{
			return 0;
		}

		public int GetHitTargetIds(int index)
		{
			return 0;
		}

		public CCVector3 GetHitTargetPos(int index)
		{
			return null;
		}

		public int GetScoreMy(int index)
		{
			return 0;
		}

		public int GetScoreOpp(int index)
		{
			return 0;
		}

		public int GetRoundCountMy(int index)
		{
			return 0;
		}

		public int GetRoundCountOpp(int index)
		{
			return 0;
		}

		public CCVector3 GetTargetPos(int index)
		{
			return null;
		}

		public CCVector3 GetHitTargetForward(int index)
		{
			return null;
		}

		public CCVector3 GetHitTargetTop(int index)
		{
			return null;
		}

		public CCKeyValueIntInt GetIdToScoresMy(int index)
		{
			return null;
		}

		public CCKeyValueIntInt GetIdToScoresOpp(int index)
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

		public static CCPVPResponse ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCPVPResponse ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPVPResponse ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCPVPResponse ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPVPResponse ParseFrom(Stream input)
		{
			return null;
		}

		public static CCPVPResponse ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPVPResponse ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCPVPResponse ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPVPResponse ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCPVPResponse ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCPVPResponse MakeReadOnly()
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

		public static Builder CreateBuilder(CCPVPResponse prototype)
		{
			return null;
		}

		static CCPVPResponse()
		{
		}
	}
}
