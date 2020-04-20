using System;
using System.Collections.Generic;
using System.Text;

namespace MySolution
{
	/*
	 * So the reason this doesn't exactly work:
	 * 
	 * This works per field, but an editor likely has multiple fields.  So, ideally
	 * there would be an object, and an editor for that object.  Anytime a field
	 * on the object changes (aka, the state changes), a copy of the state would be
	 * stored in a List (or stack, etc.). Then, when an undo happens, the state of the
	 * object in the List would be restored to the editor.
	 * 
	 */
    public class Memento<T>
    {
        private Stack<T> _values;

		public Memento()
		{
			_values = new Stack<T>();
		}

		public T Value
		{
			get
			{
				T topOfStack = default(T);
				_values.TryPeek(out topOfStack);
				return topOfStack; 
			}
			set
			{
				_values.Push(value); 
			}
		}

		public bool Undo()
		{
			if (_values.Count <= 0)
				return false;
			
			_values.Pop();
			return true;
		}

		public override string ToString()
		{
			T topOfStack = default(T);
			_values.TryPeek(out topOfStack);

			if (!ReferenceEquals(topOfStack, default(T)))
				return _values.Peek().ToString();

			return string.Empty;
		}
	}
}
