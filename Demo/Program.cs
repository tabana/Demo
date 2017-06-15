using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
  public class Program
  {
    static void Main(string[] args)
    {
      DemoMergeSort(Console.Out, args);
      Console.ReadKey();
    }

    public static void DemoMergeSort(TextWriter output, string[] args)
    {
      int[] ints = new int[0];

      if (args[0] == "-generate")
      {
        ints = GenerateInts(args, ints);
      }
      else if (args[0] == "-accept")
      {
        ints = AcceptInts(args);
      }
      else
      {
        output.WriteLine("Invalid input");
      }

      Console.Write("Result ");
      foreach (int i in ints) { output.Write(i.ToString() + " "); }
    }

    private static int[] AcceptInts(string[] args)
    {
      return args.Skip(1).Select(s => int.Parse(s)).ToArray();
    }

    private static int[] GenerateInts(string[] args, int[] ints)
    {
      return new int[0];
    }
  }
}
