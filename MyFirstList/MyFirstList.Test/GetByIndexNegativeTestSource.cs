using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstList.Test
{
    public class GetByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = -1;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { index, list };

            index = 5;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { index, list };

            index = -1;
            list = new ArrayList(new int[] { 1 });
            yield return new object[] { index, list };

            index = 1;
            list = new ArrayList(new int[] { 1 });
            yield return new object[] { index, list };

            index = -1;
            list = new ArrayList(new int[] { });
            yield return new object[] { index, list };

            index = 1;
            list = new ArrayList(new int[] { });
            yield return new object[] { index, list };



        }
    }
}
