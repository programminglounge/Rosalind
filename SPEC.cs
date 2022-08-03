using System;

public class Program
{
  public static int Main()
  {
    string result = inferring();
    Console.WriteLine(result);
  }
  public static string inferring()
  {
    string x = Console.ReadLine();
    List<double> numbers = new List<double> ();
    List<double> differences = new List<double>();
    while (x!= "")
    {
      double insert = Double.Parse(x);
      numbers.Add(insert);
      x = Console.Readline();
    }
    for (int i = 0; i< numbers.Count-1; i++)
    {
      differences.Add(Math.Round((numbers[i+1]-numbers[i]), 4));
    }
    Dictionary<double, List<string>> res = new Dictionary<double, List<string>>();
    List<string>[] strings = new List<string>[20];
    for (int i= 0; i<20; i++)
    {
      strings[i] = new List<string>();
    }
    strings[0].Add("A");
    res.Add(73.0371, strings[0]);
    strings[1].Add("C");
    res.Add(103.0092, strings[1]);
    strings[2].Add("D");
    res.Add(115.0269, strings[2]);
    strings[3].Add("E");
    res.Add(129.0426, strings[3]);
    strings[4].Add("F");
    res.Add(147.0684, strings[4]);
    strings[5].Add("G");
    res.Add(57.0215, strings[5]);
    strings[6].Add("H");
    res.Add(137.0589, strings[6]);
    strings[7].Add("I");
    strings[7].Add("L");
    res.Add(113.0841, strings[7]);
    strings[8].Add("K");
    res.Add(128.0950, strings[8]);
    strings[9].Add("M");
    res.Add(131.0405, strings[9]);
    strings[10].Add("N");
    res.Add(114.0429, strings[10]);
    strings[11].Add("P");
    res.Add(97.0528, strings[11]);
    strings[12].Add("Q");
    res.Add(128.0586, strings[12]);
    strings[13].Add("R");
    res.Add(156.1011, strings[13]);
    strings[14].Add("S");
    res.Add(87.0320, strings[14]);
    strings[15].Add("T");
    res.Add(101.0477, strings[15]);
    strings[16].Add("V");
    res.Add(99.0684, strings[16]);
    strings[17].Add("W");
    res.Add(186.0793, strings[17]);
    strings[18].Add("Y");
    res.Add(163.0633, strings[18]);
    for (int i = 0; i<differences.Count; i++)
    {
      if (res.ContainsKey(differences[i]))
      {
        List<string> list = res[differences[i]];
        my_result = my_result + list[0];
      }
    }
    return my_result;
  }
}
