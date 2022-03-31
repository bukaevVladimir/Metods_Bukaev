using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstList
{
    public class LincedList
    {
        public int Length { get; private set; }

        private Node _root;

        public LincedList()
        {
            Length = 0;
            _root = null;
        }

        public LincedList(int value)
        {
            Length = 1;
            _root = new Node(value);
        }

        public Add(int value)
        {
            Node crnt = _root;
        }

    }
}
