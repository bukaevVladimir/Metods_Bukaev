using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstList
{
    public class ArrayList
    {
        public int Length { get; private set; }

        private int[] _array;

        public ArrayList()
        {
            _array = new int[10];
            Length = 0;
        }

        public void Add(int value)
        {
            if (Length < _array.Length)
            {
                _array[Length] = value;
                Length++;
            }
            else
            {
                // видео на 2:23:50
            }
            _array[Length] = value;
        }
        public void Write()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"{_array[i]} ");
            }
            Console.WriteLine();
        }

        //public int this[int index]

        //{
        //    get
        //    {
        //        if(index < 0 || index>= Lenght)
        //        {
        //            throw new IndexOutOfRangeException();
        //        }
        //        return _array[index];   
        //    }
        //    set
        //    {
        //        if (index < 0 || index >= Lenght)
        //        {
        //            throw new IndexOutOfRangeException();

        //        }
        //        _array[index] = value;
        //    }
        //}

    }
}
