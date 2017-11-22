using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void SingletonClassTest()
        {
            Task<int> task1 = Task.Factory.StartNew(() =>
            {
                return SingletonClass.Instance.GetHashCode();
            });

            Task<int> task2 = Task.Factory.StartNew(() =>
            {
                return SingletonClass.Instance.GetHashCode();
            });

            Task.WaitAll();

            Assert.AreEqual(task1.Result, task2.Result);
        }

        [TestMethod]
        public void DoubleCheckSingletonClassTest()
        {
            Task<int> task1 = Task.Factory.StartNew(() =>
            {
                return DoubleCheckSingleton.Instance.GetHashCode();
            });

            Task<int> task2 = Task.Factory.StartNew(() =>
            {
                return DoubleCheckSingleton.Instance.GetHashCode();
            });

            Task.WaitAll();

            Assert.AreEqual(task1.Result, task2.Result);
        }
    }
}
