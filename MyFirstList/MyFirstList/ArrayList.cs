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
        //private int index;

        public int Lenght { get; private set; }
        public ArrayList()
        {
            _array = new int[5];
        }

        public void Add(int value)
        {
            if(!(Lenght < _array.Length))      
            {
                UpSize();                
            }
            _array[Lenght] = value;
            Lenght++;

        }

        public int DelleteVoid(int value)
        {
            int count = 0;
            for(int i = 0; i<Lenght; i++)
            {
                if(_array[i]==value)
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







       //public void AddToStart(int value)
       // {
       //     if(Lenght + 1 >= _array.Length)
       //     {
       //         int newLength = (int)(_array.Length * 1.5) + 1;
       //         int[] newArray = new int[newLength];
       //         Copy(newArray);
       //     }
       //     int[] tttArray = new int[Lenght + 1];
       //     for(int i = 0; i < index; i++)
       //     {
       //         tttArray[i] = _array[i];
       //     }
       //     for(int i = index; i < Lenght; i++)
       //     {
       //         tttArray[i + 1] = _array[i];
       //     }
       //     _array = tttArray;
       // }

        //private void Copy(int[] newArray)
        //{
        //    throw new NotImplementedException();
        //}

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

    //{
    //    public int Length { get; private set; }

    //    public int this[int index]

    //    {
    //        get
    //        {
    //            if (index < 0 || index >= Length)
    //            {
    //                throw new IndexOutOfRangeException();
    //            }
    //            return _array[index];
    //        }
    //        set
    //        {
    //            if (index < 0 || index >= Length)
    //            {
    //                throw new IndexOutOfRangeException();

    //            }
    //            _array[index] = value;
    //        }
    //    }


    //    private int[] _array;

    //    public ArrayList()
    //    {
    //        _array = new int[10];
    //        Length = 0;
    //    }

    //    public void Add(int value)
    //    {
    //        if (Length >= _array.Length)
    //        {
    //            UpSize();
    //        }
    //        _array[Length] = value;
    //        Length++;
    //    }

    //    public void Write()
    //    {
    //        for (int i = 0; i < Length; i++)
    //        {
    //            Console.Write($"{_array[i]} ");
    //        }
    //        Console.WriteLine();
    //    }

    //    private void UpSize()
    //    {
    //        int newLength = (int)(_array.Length * 1.5d + 1);
    //        int[] newArray = new int[newLength];
    //        for (int i = 0; i < _array.Length; i++)
    //        {
    //            newArray[i] = _array[i];
    //        }
    //        _array = newArray;

    //    }

    //}
}
