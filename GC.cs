using System;

public class Program
{
  public static void Main()
  {
    string gc_content = gccontent();
    int index = gc_content.IndexOf(' ');
    if (index != -1)
    {
      Console.WriteLine(gc_content(0, index);
      Console.WriteLine(gc_content(index+1);
    }
  }
  public static string gccontent()
  {
    string name = " ";
    string dnasequence;
    float max = 0;
    string maxname = "";
    while (name != "")
    {
      name = Console.ReadLine();
      if (name == "")
      {
        break;
      }
      else
      {
        int count = 0;
        name = name.Substring(1);
        dnasequence = Console.ReadLine();
        for (int i = 0; i<dnasequence.Length; i++)
        {
          if (dnasequence[i] == 'G' || dnasequence[i] == 'C')
          {
            count++;
          }
        }
        float percent = ((float)count/dnasequence.Length)*100;
        if (percent>max)
        {
          max = percent;
          maxname = dnasequence;
        }
      }
    }
    return max.ToString() + " " + maxname;
  }
}
