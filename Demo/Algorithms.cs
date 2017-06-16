using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
  public class Algorithms
  {
    public async Task MergeSort(int[] ints)
    {
      if (ints.Length > 1)
      {
        var mid = ints.Length / 2;
        int[] lefthalf = ints.Take(mid).ToArray();
        int[] righthalf = ints.Skip(mid).ToArray();

        await Task.WhenAll(MergeSort(lefthalf), MergeSort(righthalf));

        Merge(ints, lefthalf, righthalf);
      }
    }

    internal void Merge(int[] ints, int[] lefthalf, int[] righthalf)
    {
      int i = 0;
      int j = 0;
      int k = 0;

      while (i < lefthalf.Length && j < righthalf.Length)
      {
        if (lefthalf[i] < righthalf[j])
        {
          ints[k++] = lefthalf[i++];
        }
        else
        {
          ints[k++] = righthalf[j++];
        }
      }

      while (i < lefthalf.Length)
      {
        ints[k++] = lefthalf[i++];
      }

      while (j < righthalf.Length)
      {
        ints[k++] = righthalf[j++];
      }
    }
  }
}
