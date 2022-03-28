using NUnit.Framework;

namespace MyFirstList.Test
{
    public class ArrayListTests
    {

        [TestCase(0,0)]
        public void AddTest(int value, int expected)
        {
            int actual = ArrayList.Add(int value);

            Assert.AreEqual(expected, actual);
        }
    }
}