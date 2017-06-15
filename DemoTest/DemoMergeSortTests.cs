using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace DemoTest
{
  [TestClass]
  public class DemoMergeSortTests
  {
    [TestMethod]
    public void DemoMergeSortAccepts()
    {
      var stringBuilder = new StringBuilder();
      var stringWriter = new StringWriter(stringBuilder);

      Demo.Program.DemoMergeSort(stringWriter, new string[] { "-accept", "1", "19", "77", "3", "100", "5", "55" });

      Assert.AreEqual(stringBuilder.ToString().Trim(), "1 19 77 3 100 5 55");
    }

    [TestMethod]
    public void DemoMergeSortGenerates()
    {
      var stringBuilder = new StringBuilder();
      var stringWriter = new StringWriter(stringBuilder);

      Demo.Program.DemoMergeSort(stringWriter, new string[] { "-generate", "10", "10" });

      Assert.IsTrue(true);
    }
  }
}
