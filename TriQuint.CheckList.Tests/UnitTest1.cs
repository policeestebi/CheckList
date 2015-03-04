using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriQuint.CheckList.DAL.Context;
using TriQuint.CheckList.Entities;
using System.Linq;
using System.Collections.Generic;


namespace TriQuint.CheckList.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IList<CheckListTemplate> list = null;

            using (var context = new CheckListContext())
            {
                list = context.CheckListTemplates.ToList();
            }

            Assert.IsTrue(list.Count == 0);
        }
    }
}
