using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace DemoTest
{
  [TestClass]
  public class MergeSortTests
  {
    [TestMethod]
    public void MergeMerges()
    {
      int[] ints = { 1, 3, 9, 2, 4, 8 };
      var mid = ints.Length / 2;
      int[] lefthalf = ints.Take(mid).ToArray();
      int[] righthalf = ints.Skip(mid).ToArray();

      var algorithms = new Demo.Algorithms();
      algorithms.Merge(ints, lefthalf, righthalf);

      CollectionAssert.AreEqual(ints, new int[] { 1, 2, 3, 4, 8, 9 });
    }
  }
}
