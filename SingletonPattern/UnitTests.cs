using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternAndStatic
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

        [TestMethod]
        public void SingletonNotThreadSafeTest()
        {
            Task<int> task1 = Task.Factory.StartNew(() =>
            {
                return NotThreadSafeSingleton.Instance.GetHashCode();
            });

            Task<int> task2 = Task.Factory.StartNew(() =>
            {
                return NotThreadSafeSingleton.Instance.GetHashCode();
            });

            Task<int> task3 = Task.Factory.StartNew(() =>
            {
                return NotThreadSafeSingleton.Instance.GetHashCode();
            });

            Task.WaitAll();

            Assert.AreEqual(task1.Result, task2.Result, task3.Result);
        }
    }
}
