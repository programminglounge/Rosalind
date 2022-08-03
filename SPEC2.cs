public class Program
{
  public static int Main()
  {
    List<string> x = inferring();
    for (int i = 0; i<x.Count; i++)
    {
      Console.WriteLine(x[i];
    }
  }
  public static List<string> inferring()
  {
    List<string> s = new List<string>();
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
    string my_result = "";
    for (int i = 0; i< differences.Count; i++)
    {
      if (res.ContainsKey(differences[i]))
      {
        List<string> list = res[differences[i]];
        if (list.Count > 1)
        {
          s = combinestringslists(s, my_result, list);
          my_result = "";
        }
        else
        {
          my_result = my_result + list[0];
        }
      }
    }
    if (my_result != "")
    {
      s = combinestrings(s, my_result);
    }
    return s;
  }
  public static List<string> combinestrings(List<string> start, string my_result)
  {
    List<string> result = new List<string>();
    if (start.Count != 0)
    {
      for (int i = 0; i<start.Count; i++)
      {
        result.Add(start[i] + my_result);
      }
      return result;
    }
    result.Add(my_result);
    return result;
  }
  public static List<string> combinestringslist(List<string> start, string my_result, List<string> list)
  {
    List<string> ends = new List<string>();
    List<string> result = new List<string>();
    for (int i = 0; i<list.Count; i++)
    {
      ends.Add (my_result+ list[i]);
    }
    if (start.Count != 0)
    {
      for (int i = 0; i<start.Count; i++)
      {
        for (int j = 0; j<ends.Count; j++)
        {
          result.Add(start[i]+ends[j]);
        }
      }
      return result;
    }
    return ends;
  } 
}
