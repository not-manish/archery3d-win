using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Pool3D.TimerUtil
{
	internal class PriorityQueue<TPriority, TValue> : IEnumerable<KeyValuePair<TPriority, TValue>>, IEnumerable
	{
		public class ValueCollection : IEnumerable<TValue>, IEnumerable
		{
			[CompilerGenerated]
			private sealed class _003CGetEnumerator_003Ed__2 : IEnumerator<TValue>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private TValue _003C_003E2__current;

				public ValueCollection _003C_003E4__this;

				private IEnumerator<KeyValuePair<TPriority, TValue>> _003C_003E7__wrap1;

				TValue IEnumerator<TValue>.Current
				{
					[DebuggerHidden]
					get
					{
						return default;
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
				public _003CGetEnumerator_003Ed__2(int _003C_003E1__state)
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

				private void _003C_003Em__Finally1()
				{
				}

				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}
			}

			private readonly PriorityQueue<TPriority, TValue> parentCollection;

			public ValueCollection(PriorityQueue<TPriority, TValue> parentCollection)
			{
			}

			[IteratorStateMachine(typeof(PriorityQueue<, >.ValueCollection._003CGetEnumerator_003Ed__2))]
			public IEnumerator<TValue> GetEnumerator()
			{
				return null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private readonly IComparer<TPriority> priorityComparer;

		private readonly List<KeyValuePair<TPriority, TValue>> queue;

		private ValueCollection valueCollection;

		public ValueCollection Values => null;

		public int Count => 0;

		public KeyValuePair<TPriority, TValue> Top => default;

		public PriorityQueue()
		{
		}

		public PriorityQueue(IComparer<TPriority> comparer)
		{
		}

		public IEnumerator<KeyValuePair<TPriority, TValue>> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public void Clear()
		{
		}

		public void Push(TPriority priority, TValue value)
		{
		}

		public KeyValuePair<TPriority, TValue> Pop()
		{
			return default;
		}

		public bool Contains(TValue value)
		{
			return false;
		}

		public bool Remove(TValue value)
		{
			return false;
		}

		public bool RemoveAtPriority(TPriority priority, Predicate<TValue> shouldRemove)
		{
			return false;
		}

		private void BubbleUp()
		{
		}

		private void BubbleDown()
		{
		}
	}
}
