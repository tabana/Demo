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

    internal static void DemoMergeSort(TextWriter output, string[] args)
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
        output.Write(HelpText);
        return;
      }

      Console.Write("Result ");
      foreach (int i in ints) { output.Write(i.ToString() + " "); }
    }

    internal static string HelpText
    {
      get
      {
        return "demo [-accept integers | -generate quantity biggest]" + Environment.NewLine
        + "parameters:" + Environment.NewLine
        + "integer:\t a series of integers to be sorted, seperated by a single space." + Environment.NewLine
        + "quantity:\t an integer indicating the number of random integers to generate" + Environment.NewLine
        + "biggest:\t an integer indicating the largest random integer to generate." + Environment.NewLine
        + "For example:" + Environment.NewLine
        + "demo -accept 12 4 7 99 13" + Environment.NewLine
        + "or:" + Environment.NewLine
        + "demo -generate 10 500";
      }
    }

    private static int[] AcceptInts(string[] args)
    {
      return args.Skip(1).Select(s => int.Parse(s)).ToArray();
    }

    private static int[] GenerateInts(string[] args, int[] ints)
    {
      var quantity = int.Parse(args[1]);
      var biggest = int.Parse(args[2]);
      Array.Resize(ref ints, quantity);

      var random = new Random();
      for (int i = 0; i < quantity; i++)
      {
        ints[i] = random.Next(biggest);
      }
      return ints;
    }
  }
}
