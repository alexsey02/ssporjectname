using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSproject2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSproject2.Controllers.Tests
{
    [TestClass()]
    public class ApplicationControllerTests
    {
        [TestMethod()]
        public void mailTestTest()
        {
            string emailTrue = "isip_a.r.jerihin@mpt.ru";
            string emailFalse = "skoro_av@mail.ru";
            string expected = "ошибка";
        }
    }
}