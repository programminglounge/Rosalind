#include <iostream>
#include <string>
using namespace std;

string dna2rna (string dna)
{
  std::replace(dna.begin(), dna.end(), 'T', 'U');
  return dna;
}

void main()
{
  string dna;
  cout << "Please enter the DNA string" << endl;
  cin >> dna;
  string rna = dna2rna(dna2);
  cout << "RNA string is as follows" << endl;
  cout << rna << endl;
  
}
