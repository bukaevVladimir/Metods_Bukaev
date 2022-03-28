using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstList
{

    public class ArrayList
    {
        private int[] _array;
        public int Lenght { get; private set; }
        public ArrayList()
        {
            _array = new int[5];
        }

        public void Add(int value)
        {
            if (!(Lenght < _array.Length))
            {
                UpSize();
            }
            _array[Lenght] = value;
            Lenght++;

        }

        public int DelleteVoid(int value)
        {
            int count = 0;
            for (int i = 0; i < Lenght; i++)
            {
                if (_array[i] == value)
                {
                    count++;
                }
                else
                {
                    _array[i - count] = _array[i];
                }
            }
            Lenght -= count;
            return count;
        }

        private void UpSize()
        {
            int newArrayLenght = (int)(_array.Length * 1.5d + 1);
            int[] newArray = new int[newArrayLenght];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }

    }
}
