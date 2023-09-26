using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint0.Task2.V0.Lib;

namespace Tyuiu.EmelianovaKP.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Ksenya";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Hello, Ksenya", res);
        }
    }
}
