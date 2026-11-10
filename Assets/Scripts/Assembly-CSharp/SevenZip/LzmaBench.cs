using System;
using System.IO;

namespace SevenZip
{
	internal abstract class LzmaBench
	{
		private class CRandomGenerator
		{
			private uint A1;

			private uint A2;

			public void Init()
			{
			}

			public uint GetRnd()
			{
				return 0u;
			}
		}

		private class CBitRandomGenerator
		{
			private CRandomGenerator RG;

			private uint Value;

			private int NumBits;

			public void Init()
			{
			}

			public uint GetRnd(int numBits)
			{
				return 0u;
			}
		}

		private class CBenchRandomGenerator
		{
			private CBitRandomGenerator RG;

			private uint Pos;

			private uint Rep0;

			public uint BufferSize;

			public byte[] Buffer;

			public void Set(uint bufferSize)
			{
			}

			private uint GetRndBit()
			{
				return 0u;
			}

			private uint GetLogRandBits(int numBits)
			{
				return 0u;
			}

			private uint GetOffset()
			{
				return 0u;
			}

			private uint GetLen1()
			{
				return 0u;
			}

			private uint GetLen2()
			{
				return 0u;
			}

			public void Generate()
			{
			}
		}

		private class CrcOutStream : Stream
		{
			public CRC CRC;

			public override bool CanRead => false;

			public override bool CanSeek => false;

			public override bool CanWrite => false;

			public override long Length => 0L;

			public override long Position
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			public void Init()
			{
			}

			public uint GetDigest()
			{
				return 0u;
			}

			public override void Flush()
			{
			}

			public override long Seek(long offset, SeekOrigin origin)
			{
				return 0L;
			}

			public override void SetLength(long value)
			{
			}

			public override int Read(byte[] buffer, int offset, int count)
			{
				return 0;
			}

			public override void WriteByte(byte b)
			{
			}

			public override void Write(byte[] buffer, int offset, int count)
			{
			}
		}

		private class CProgressInfo : ICodeProgress
		{
			public long ApprovedStart;

			public long InSize;

			public DateTime Time;

			public void Init()
			{
			}

			public void SetProgress(long inSize, long outSize)
			{
			}
		}

		private const uint kAdditionalSize = 6291456u;

		private const uint kCompressedAdditionalSize = 1024u;

		private const uint kMaxLzmaPropSize = 10u;

		private const int kSubBits = 8;

		private static uint GetLogSize(uint size)
		{
			return 0u;
		}

		private static ulong MyMultDiv64(ulong value, ulong elapsedTime)
		{
			return 0uL;
		}

		private static ulong GetCompressRating(uint dictionarySize, ulong elapsedTime, ulong size)
		{
			return 0uL;
		}

		private static ulong GetDecompressRating(ulong elapsedTime, ulong outSize, ulong inSize)
		{
			return 0uL;
		}

		private static ulong GetTotalRating(uint dictionarySize, ulong elapsedTimeEn, ulong sizeEn, ulong elapsedTimeDe, ulong inSizeDe, ulong outSizeDe)
		{
			return 0uL;
		}

		private static void PrintValue(ulong v)
		{
		}

		private static void PrintRating(ulong rating)
		{
		}

		private static void PrintResults(uint dictionarySize, ulong elapsedTime, ulong size, bool decompressMode, ulong secondSize)
		{
		}

		public static int LzmaBenchmark(int numIterations, uint dictionarySize)
		{
			return 0;
		}
	}
}
