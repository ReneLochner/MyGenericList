using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lists.ListLogic
{
    internal class MyListEnumerator<T> : IEnumerator<T>
    {
        private Node _head;
        private Node _actualNode;
        private bool _isReset;

        public MyListEnumerator(Node head) {
            this._head = head;
            Reset ();
        }

        object IEnumerator.Current => Current;

        public T Current => (T)_actualNode.DataObject;

        public void Dispose() {
            
        }

        public bool MoveNext() {
            if (_isReset) {
                _actualNode = _head;
                _isReset = false;
            } else {
                _actualNode = _actualNode.Next;
            }
            return _actualNode != null;
        }

        public void Reset() {
            _actualNode = null;
            _isReset = true;
        }
    }
}