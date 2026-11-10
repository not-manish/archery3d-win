using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AssetUpdate.Util
{
	public class FileUtil
	{
		public delegate void WWWReadFileCallback(WWWFileInfo fileInfo);

		public struct WWWFileInfo
		{
			public string path;

			public string name;

			public byte[] content;

			public bool isTex2D;

			public Texture2D tex2D;

			public bool errorOccurred;

			public WWWReadFileCallback callback;

			public WWWFileInfo(string path, string _name, bool isTex2D, WWWReadFileCallback callback)
			{
				this.path = null;
				name = null;
				content = null;
				this.isTex2D = false;
				tex2D = null;
				errorOccurred = false;
				this.callback = null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CReadTxt_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WWWFileInfo fileInfo;

			private WWW _003Cwww_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CReadTxt_003Ed__7(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public static List<string> GetFilePaths(string path, string fileType)
		{
			return null;
		}

		private static void GetFilePaths(string path, string fileType, List<string> files)
		{
		}

		public static void CopyDirectory(string sourceDirectory, string destDirectory)
		{
		}

		private static void CopyFile(string sourceDirectory, string destDirectory)
		{
		}

		public static void WWWReadFile(WWWFileInfo wwwReadFile)
		{
		}

		[IteratorStateMachine(typeof(_003CReadTxt_003Ed__7))]
		private static IEnumerator ReadTxt(WWWFileInfo fileInfo)
		{
			return null;
		}

		public static bool IsFileExist(string path)
		{
			return false;
		}

		public static bool CheckLocalFileMD5(string path, string targetMD5)
		{
			return false;
		}

		public static string ReadLocalFile(string filePath)
		{
			return null;
		}

		public static string GetFileMD5(string filePath)
		{
			return null;
		}

		public static string GetMD5(Stream stream)
		{
			return null;
		}

		public static string GetMD5(string str)
		{
			return null;
		}

		public static string GetMD5(byte[] bytes)
		{
			return null;
		}

		public static void CopyInternalToExternal(string internalPath, string externalPath)
		{
		}

		public static void WriteLocalFile(string text, string filePath)
		{
		}

		public static void WriteLocalFile(byte[] bytes, string filePath)
		{
		}

		private static void CompressFileLZMA(string inFile, string outFile)
		{
		}

		public static void DecompressFileLZMA(string inFile, string outFile)
		{
		}
	}
}
