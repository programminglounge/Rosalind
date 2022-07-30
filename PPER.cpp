unsigned int partial(int first, int second)
{
  unsigned int x = 1;
  for (unsigned int i = first; i>first-second; i--)
  {
    x = (x*i) %1000000;
  }
  return x;
}

void main()
{
  unsigned int first;
  cin >> first;
  unsigned int second;
  cin >> second;
  unsigned int result;
  if (first>second)
  {
    result = partial (first, second);
  }
  else
  {
    result = partial (second, first);
  }
  cout << result << endl;
}
