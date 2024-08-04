using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IT481_Unit04_UnitTest;
using Alexander_Fearday__Unit4_IT481;

namespace IT481_Unit04_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Alexander_Fearday__Unit4_IT481.IT481_Uint04 myUnitTest = new Alexander_Fearday__Unit4_IT481.IT481_Uint04();
            int[] myArray = new int[] { 1, 2, 3, 50, 222 };
            int n = 5;
            int result = myUnitTest.Example1(myArray, n);
            Assert.AreEqual(result, 1, "The minimum value is 1.");
            Assert.AreNotEqual(result, 50, "The minimum value is not 50.");
        }
        [TestMethod]
        public void TestMethod2()
        {
            Alexander_Fearday__Unit4_IT481.IT481_Uint04 myUnitTest = new Alexander_Fearday__Unit4_IT481.IT481_Uint04();
            int[] myArray = new int[100];
            for (int i = 0; i < 100; i++)
            {
                myArray[i] = i + 1;
            }

            myUnitTest.Example2(myArray);
            Assert.IsTrue(true, "Fuction works.");
            Assert.IsFalse(false, "Function did not work.");
        }

        [TestMethod]    
        public void TestMethod3()
        {
            Alexander_Fearday__Unit4_IT481.IT481_Uint04 myUnitTest = new Alexander_Fearday__Unit4_IT481.IT481_Uint04();
            int[] myArray = new int[] { 1, 2, 3, 50, 222 };
            
            bool result = myUnitTest.Example3(myArray);

            Assert.IsTrue(true, "Fuction works.");
            Assert.AreNotEqual(result, true, "The values searched are in the arrray.");
        }
    }
}
