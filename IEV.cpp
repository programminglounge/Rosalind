#include <iostream>
using namespace std;

double offspring()
{
  unsigned int x1, x2, x3, x4, x5, x6;
  cout << "Please enter all six numbers with one space between each number" << endl;
  cin >> x1 >> x2 >> x3 >> x4 >> x5 >> x6;
  double result = ((x1*1)+(x2*1)+(x3*1)+(x4*0.75)+(x5*0.5) + (x6*0))*2;
  return result
}
void main()
{
  double offspringresult = offspring();
  cout << offspringresult << endl;
}
