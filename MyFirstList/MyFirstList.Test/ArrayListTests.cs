using NUnit.Framework;
using System.Collections;
using System;

namespace MyFirstList.Test
{
    public class ArrayListTests
    {

        [TestCaseSource(typeof(DelleteAllByValueTestSourse))]

        public void DelleteAllByValueTest(int value, ArrayList list, ArrayList expectedList, int expectedNumber)
        {
            int actualNumber = list.DelleteAllByValue(value);

            ArrayList actualList = list;

            Assert.AreEqual(expectedNumber, actualNumber);
            Assert.AreEqual(expectedList, actualList);
        }

        [Test]

        public void DelleteLastTest_WhenListIsEmpty_ShouldThrowException()
        {
            ArrayList list = new ArrayList();
            Assert.Throws<Exception>(() => list.DelleteLast());
        }

        [TestCaseSource(typeof(GetByIndexNegativeTestSource))]
        public void DelleteLastTest_WhenIndexOutOfRangeOfList_ShouldThrowIndexOutOfRangeException(int index, ArrayList list)
        {
            int a;
            Assert.Throws<IndexOutOfRangeException>(() => a = list [index]);

        }
    }

    public class DelleteAllByValueTestSourse : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            ArrayList list = new ArrayList(new int[] {1,2,3,4,5});
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 4, 5});
            int expectedNumber = 1;
            yield return new object[] {value, list, expectedList, expectedNumber};

            value = 2;
            list = new ArrayList(new int[] { 1, 2, 2, 2, 5});
            expectedList = new ArrayList(new int[] { 1, 5});
            expectedNumber = 3;
            yield return new object[] { value, list, expectedList, expectedNumber };

        }
    }
}