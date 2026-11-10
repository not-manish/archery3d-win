using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;

namespace com.simple.proto
{
	[DebuggerNonUserCode]
	public sealed class CCPVPRequest : GeneratedMessageLite<CCPVPRequest, CCPVPRequest.Builder>
	{
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilderLite<CCPVPRequest, Builder>
		{
			private bool resultIsReadOnly;

			private CCPVPRequest result;

			protected override Builder ThisBuilder => null;

			public override bool IsInitialized => false;

			protected override CCPVPRequest MessageBeingBuilt => null;

			public override CCPVPRequest DefaultInstanceForType => null;

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

			public bool HasIsRobot => false;

			public bool IsRobot
			{
				get
				{
					return false;
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

			public bool HasBowId => false;

			public int BowId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasArrowId => false;

			public int ArrowId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasArmId => false;

			public int ArmId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasSightId => false;

			public int SightId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public bool HasStabilizerId => false;

			public int StabilizerId
			{
				get
				{
					return 0;
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

			public IPopsicleList<CCVector3> TargetPosList => null;

			public int TargetPosCount => 0;

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

			public IPopsicleList<CCVector3> HitTargetForwardList => null;

			public int HitTargetForwardCount => 0;

			public IPopsicleList<CCVector3> HitTargetTopList => null;

			public int HitTargetTopCount => 0;

			public Builder()
			{
			}

			internal Builder(CCPVPRequest cloneFrom)
			{
			}

			private CCPVPRequest PrepareBuilder()
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

			public override CCPVPRequest BuildPartial()
			{
				return null;
			}

			public override Builder MergeFrom(IMessageLite other)
			{
				return null;
			}

			public override Builder MergeFrom(CCPVPRequest other)
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

			public Builder SetType(int value)
			{
				return null;
			}

			public Builder ClearType()
			{
				return null;
			}

			public Builder SetIsRobot(bool value)
			{
				return null;
			}

			public Builder ClearIsRobot()
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

			public Builder SetBowId(int value)
			{
				return null;
			}

			public Builder ClearBowId()
			{
				return null;
			}

			public Builder SetArrowId(int value)
			{
				return null;
			}

			public Builder ClearArrowId()
			{
				return null;
			}

			public Builder SetArmId(int value)
			{
				return null;
			}

			public Builder ClearArmId()
			{
				return null;
			}

			public Builder SetSightId(int value)
			{
				return null;
			}

			public Builder ClearSightId()
			{
				return null;
			}

			public Builder SetStabilizerId(int value)
			{
				return null;
			}

			public Builder ClearStabilizerId()
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

			public Builder SetShootTargetTime(float value)
			{
				return null;
			}

			public Builder ClearShootTargetTime()
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
		}

		private static readonly CCPVPRequest defaultInstance;

		private static readonly string[] _cCPVPRequestFieldNames;

		private static readonly uint[] _cCPVPRequestFieldTags;

		public const int UserIdFieldNumber = 1;

		private bool hasUserId;

		private string userId_;

		public const int TypeFieldNumber = 2;

		private bool hasType;

		private int type_;

		public const int IsRobotFieldNumber = 3;

		private bool hasIsRobot;

		private bool isRobot_;

		public const int GameTypeFieldNumber = 4;

		private bool hasGameType;

		private int gameType_;

		public const int PvpTypeFieldNumber = 5;

		private bool hasPvpType;

		private int pvpType_;

		public const int BowIdFieldNumber = 6;

		private bool hasBowId;

		private int bowId_;

		public const int ArrowIdFieldNumber = 7;

		private bool hasArrowId;

		private int arrowId_;

		public const int ArmIdFieldNumber = 8;

		private bool hasArmId;

		private int armId_;

		public const int SightIdFieldNumber = 9;

		private bool hasSightId;

		private int sightId_;

		public const int StabilizerIdFieldNumber = 10;

		private bool hasStabilizerId;

		private int stabilizerId_;

		public const int HasShootFieldNumber = 11;

		private bool hasHasShoot;

		private bool hasShoot_;

		public const int CamStartPosFieldNumber = 13;

		private bool hasCamStartPos;

		private CCVector3 camStartPos_;

		public const int CamStartDirFieldNumber = 14;

		private bool hasCamStartDir;

		private CCVector3 camStartDir_;

		public const int TargetZFieldNumber = 15;

		private bool hasTargetZ;

		private float targetZ_;

		public const int HitTargetIdsFieldNumber = 16;

		private PopsicleList<int> hitTargetIds_;

		public const int HitTargetPosFieldNumber = 17;

		private PopsicleList<CCVector3> hitTargetPos_;

		public const int TargetPosFieldNumber = 18;

		private PopsicleList<CCVector3> targetPos_;

		public const int HasWindFieldNumber = 19;

		private bool hasHasWind;

		private bool hasWind_;

		public const int WindSpeedFieldNumber = 20;

		private bool hasWindSpeed;

		private float windSpeed_;

		public const int WindAngleFieldNumber = 21;

		private bool hasWindAngle;

		private float windAngle_;

		public const int ShootTargetTimeFieldNumber = 22;

		private bool hasShootTargetTime;

		private float shootTargetTime_;

		public const int HitTargetForwardFieldNumber = 23;

		private PopsicleList<CCVector3> hitTargetForward_;

		public const int HitTargetTopFieldNumber = 24;

		private PopsicleList<CCVector3> hitTargetTop_;

		private int memoizedSerializedSize;

		public static CCPVPRequest DefaultInstance => null;

		public override CCPVPRequest DefaultInstanceForType => null;

		protected override CCPVPRequest ThisMessage => null;

		public bool HasUserId => false;

		public string UserId => null;

		public bool HasType => false;

		public int Type => 0;

		public bool HasIsRobot => false;

		public bool IsRobot => false;

		public bool HasGameType => false;

		public int GameType => 0;

		public bool HasPvpType => false;

		public int PvpType => 0;

		public bool HasBowId => false;

		public int BowId => 0;

		public bool HasArrowId => false;

		public int ArrowId => 0;

		public bool HasArmId => false;

		public int ArmId => 0;

		public bool HasSightId => false;

		public int SightId => 0;

		public bool HasStabilizerId => false;

		public int StabilizerId => 0;

		public bool HasHasShoot => false;

		public bool HasShoot => false;

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

		public IList<CCVector3> TargetPosList => null;

		public int TargetPosCount => 0;

		public bool HasHasWind => false;

		public bool HasWind => false;

		public bool HasWindSpeed => false;

		public float WindSpeed => 0f;

		public bool HasWindAngle => false;

		public float WindAngle => 0f;

		public bool HasShootTargetTime => false;

		public float ShootTargetTime => 0f;

		public IList<CCVector3> HitTargetForwardList => null;

		public int HitTargetForwardCount => 0;

		public IList<CCVector3> HitTargetTopList => null;

		public int HitTargetTopCount => 0;

		public override bool IsInitialized => false;

		public override int SerializedSize => 0;

		private CCPVPRequest()
		{
		}

		public int GetHitTargetIds(int index)
		{
			return 0;
		}

		public CCVector3 GetHitTargetPos(int index)
		{
			return null;
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

		public static CCPVPRequest ParseFrom(ByteString data)
		{
			return null;
		}

		public static CCPVPRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPVPRequest ParseFrom(byte[] data)
		{
			return null;
		}

		public static CCPVPRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPVPRequest ParseFrom(Stream input)
		{
			return null;
		}

		public static CCPVPRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPVPRequest ParseDelimitedFrom(Stream input)
		{
			return null;
		}

		public static CCPVPRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		public static CCPVPRequest ParseFrom(ICodedInputStream input)
		{
			return null;
		}

		public static CCPVPRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return null;
		}

		private CCPVPRequest MakeReadOnly()
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

		public static Builder CreateBuilder(CCPVPRequest prototype)
		{
			return null;
		}

		static CCPVPRequest()
		{
		}
	}
}
