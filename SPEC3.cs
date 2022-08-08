using System;

public class Program
{
  public static string find()
  {
    string found = "";
    List<Tuple<double, List<char>>> weightpairs = new List<Tuple<double, List<char>>>();
    weightpairs.Add(new Tuple<double, List<char>>(71.03711, new List<char> {'A'}));
    weightpairs.Add(new Tuple<double, List<char>>(103.00919, new List<char> {'C'}));
    weightpairs.Add(new Tuple<double, List<char>>(115.02694, new List<char> {'D'}));
    weightpairs.Add(new Tuple<double, List<char>>(129.04259, new List<char> {'E'}));
    weightpairs.Add(new Tuple<double, List<char>>(147.06841, new List<char> {'F'}));
    weightpairs.Add(new Tuple<double, List<char>>(57.02146, new List<char> {'G'}));
    weightpairs.Add(new Tuple<double, List<char>>(137.05891, new List<char> {'H'}));
    weightpairs.Add(new Tuple<double, List<char>>(128.09496, new List<char> {'K'}));
    weightpairs.Add(new Tuple<double, List<char>>(113.08406, new List<char> {'I', 'L'}));
    weightpairs.Add(new Tuple<double, List<char>>(131.04049, new List<char> {'M'}));
    weightpairs.Add(new Tuple<double, List<char>>(114.04293, new List<char> {'N'}));
    weightpairs.Add(new Tuple<double, List<char>>(97.05276, new List<char> {'P'}));
    weightpairs.Add(new Tuple<double, List<char>>(128.05858, new List<char> {'Q'}));
    weightpairs.Add(new Tuple<double, List<char>>(156.10111, new List<char> {'R'}));
    weightpairs.Add(new Tuple<double, List<char>>(87.03203, new List<char> {'S'}));
    weightpairs.Add(new Tuple<double, List<char>>(101.04768, new List<char> {'T'}));
    weightpairs.Add(new Tuple<double, List<char>>(99.06841, new List<char> {'V'}));
    weightpairs.Add(new Tuple<double, List<char>>(186.07931, new List<char> {'W'}));
    weightpairs.Add(new Tuple<double, List<char>>(163.06333, new List<char> {'Y'}));
    weightpairs = weightpairs.OrderByDescending(x =>x.Item1).ToList();
    int i = 0;
    int j = 0;
    List<double> numbers = new List<double>();
    List<double> weights = new List<double>();
    string number = " ";
    number = Console.ReadLine();
    while (number != "")
    {
      double x = double.Parse(number);
      numbers.Add(x);
      number = Console.ReadLine();
    }
    found = find2(numbers, numbers.Count-1, weightpairs);
    return found;
  }
  public static string find2(List<double>numbers, int start, List<Tuple<double, List<char>>> weightpairs)
  {
    int i = 0;
    string found = "";
    for (i = start-1; i>0; i--)
    {
      double x = Math.Round(numbers[start] - numbers[i], 5);
      Tuple<double, List<char>> res = weightpairs.Find(o=>o.Item1.Equals(x));
      if (res != null)
      {
        char res2 = res.Item2[0];
        found = found + res2.ToString();
        found = found + find2(numbers, i, weightpairs);
        break;
      }
    }
    return found;
  }
  public static int Main()
  {
    string my_find = find();
    Console.WriteLine(my_find);
  }
}


