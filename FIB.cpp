#include <iostream>
using namespace std;

unsigned int rabbit (unsigned int n, unsigned int k)
{
  if (n == 0)
    return 0;
  else if (n==1)
    return 1;
  else if (n == 2)
    return 1;
  else
    return rabbit(n-1, k) + k* rabbit(n-2, k);
}

void main ()
{
  unsigned int n;
  unsigned int k;
  cout << "enter n and k: " << endl;
  cin >> n >> k;
  cout << rabbit(n, k) << endl;
  /*
  unsigned int n = 5;
  unsigned int k = 3;
  unsigned int result = rabbit (n, k);
  cout << result << endl;
  */
}
