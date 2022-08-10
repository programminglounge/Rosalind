using System;

public class Program
{
  public static void Main()
  {
    int n = 5;
    int k = 3;
    long fib = rabbit(n, k);
    Console.WriteLine(fib);
  }
  public static long rabbit (int n, int k)
  {
    if (n==1)
    {
      return 1;
    }
    else if (n==2)
    {
      return 1;
    }
    else
    {
      return rabbit(n-1, k)+ (k*rabbit(n-2, k));
    }
  }
}
