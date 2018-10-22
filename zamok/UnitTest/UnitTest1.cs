using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using секретный_замок;


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // исходные данные
            int[] mas = new int[10] {1,2,3,4,5,6,7,8,9,10};
            bool expected = false;
            // получение значения с помощью тестируемого метода
            Form1 f = new Form1();
            bool rezult =f.sravnenie(mas);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);
        }
        [TestMethod]
        public void TestMethod2()
        {
            // исходные данные
            int[] mas = new int[10] { 3, 3, 4, 4, 5, 6, 7, 8, 9, 10 };
            bool expected = true;
            // получение значения с помощью тестируемого метода
            Form1 f = new Form1();
            bool rezult = f.sravnenie(mas);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);
        }
        [TestMethod]
        public void TestMethod3()
        {
            // исходные данные
            int[] mas = new int[10] { ' ', 3, 4, 4, 5, 6, 7, 8, 9, 10 };
            bool expected = false;
            // получение значения с помощью тестируемого метода
            Form1 f = new Form1();
            bool rezult = f.sravnenie(mas);
            
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);
        }
        [TestMethod]
        public void TestMethod4()
        {
            // исходные данные
            int[] mas = new int[10] { '!', '!', '!', '!', '!', '!', '!', '!', '!', '!' };
            bool expected = false;
            // получение значения с помощью тестируемого метода
            Form1 f = new Form1();
            bool rezult = f.sravnenie(mas);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);
        }

        [TestMethod]
        public void TestMethod5()
        {
            // исходные данные
            int[] mas = new int[1] { '!' };
            bool expected = false;
            // получение значения с помощью тестируемого метода
            Form1 f = new Form1();
            bool rezult = f.sravnenie(mas);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);
        }
        [TestMethod]
        public void TestMethod6()
        {
            // исходные данные
            int[] mas = new int[0];
            bool expected = false;
            // получение значения с помощью тестируемого метода
            Form1 f = new Form1();
            bool rezult = f.sravnenie(mas);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);
        }
        //[TestMethod]
        //public void TestMethod7()
        //{
        //    // исходные данные
        //    int[] mas = new int[5] { null, 7, 8, 9, 10 };
        //    bool expected = false;
        //    // получение значения с помощью тестируемого метода
        //    Form1 f = new Form1();
        //    bool rezult = f.sravnenie(mas);
        //    // сравнение ожидаемого результата с полученным
        //    Assert.AreEqual(expected, rezult);
        //}
    }
}
