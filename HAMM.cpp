#include <iostream>
using namespace std;

int hamming (string dna1, string dna2)
{
  int count = 0;
  if (dna1.size()== dna2.size())
  {
    for (int i = 0; i<dna1.size(); i++)
    {
      if (dna1[i] != dna2[i])
      {
        count++;
      }
    }
    return count;
  }
}

void main ()
{
  string dna1, dna2;
  cin >> dna1;
  cin >> dna2;
  cout << "The hamming distance is: " << endl;
  cout << hamming(dna1, dna2) << endl;
}
