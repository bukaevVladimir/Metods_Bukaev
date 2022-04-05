using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstList
{
    public class LincedList
    {
        private Node _root;

        public int this[int index]
        {
            get
            {
                Node crnt = _root;
                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }
                return crnt.Value;
            }
            set
            {

            }
        }
        public int Length
        {
            get
            {
                int count = 0;

                Node crnt = _root;

                while (crnt!= null)
                {
                    crnt = crnt.Next;
                    count++;
                }
                return count;
            }
            private set
            {

            }
        }


        public LincedList()
        {
            _root = null;
        }

        public LincedList(int value)
        {
            _root = new Node(value);
        }

        public void Add(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
            }
            else
            {
                Node crnt = _root;

                while (crnt.Next != null)
                {
                    crnt = crnt.Next;
                }

                crnt.Next = new Node(value);

            }
        }
        public void DeleteByIndex(int index)
        {
            if (index < 0 || index > Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
            else if (index == 0)
            {
                _root = _root.Next;
            }
            else
            {
                Node crnt = _root;
                for (int i = 1; i < index; i++)
                {
                    crnt = crnt.Next;
                }
                crnt.Next = crnt.Next.Next;
            }
        }

    }
}
