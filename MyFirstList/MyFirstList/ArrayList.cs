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

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }

        public int Length { get; private set; }
        public ArrayList()
        {
            _array = new int[10];
            Length = 0;
        }

        public ArrayList(int[] array)
        {
            if(array == null || array.Length==0)
            {
                _array = new int[10];
                Length = 0;
            }
            else
            {
                _array = array;
                Length = array.Length;
                UpSize();
            }
            
        }

        public void Add(int value)
        {
            if (!(Length < _array.Length))
            {
                UpSize();
            }
            _array[Length] = value;
            Length++;

        }

        public void DelleteLast()
        {
            if(Length == 0)
            {
                throw new Exception("Length == 0");
            }

            Length--;
        }

        public void AddList(ArrayList list) //24
        {
            if(list == null)
            {
                throw new NullReferenceException();
            }
            for(int i = 0; i < list.Length; i++)
            {
                this.Add(list[i]);
            }
        }

        public int DelleteAllByValue(int value)//22
        {
            int count = 0;
            for (int i = 0; i < Length; i++)
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
            Length -= count;
            return count;
        }

        public void Write()
        {
            Console.Write($"L={Length}  RL={_array.Length}   ");
            for(int i = 0; i < Length; i++)
            {
                Console.Write($"{_array[i]} ");
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            string s = "[";

            
            for (int i = 0; i < Length; i++)
            {
                s+=$"{_array[i]} ";
            }
            s += "]";
            return s;
        }

        public override bool Equals(object? obj)
        {
            bool isEqual = true;

            if (obj == null || !(obj is ArrayList))
            {
                isEqual = false;
            }
            else
            {
                ArrayList list = (ArrayList)obj;

                if (list.Length != this.Length)
                {
                    isEqual = false;
                }
                else
                {
                    for (int i = 0; i < this.Length; i++)
                    {
                        if (list[i] != this[i])
                        {
                            isEqual = false;
                        }
                    }
                }
            }
            return isEqual;
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
