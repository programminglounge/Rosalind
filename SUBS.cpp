#include <iostream>
#include <vector>
using namespace std;

vector <int> motif (string dna1, string dna2)
{
  int count = 0;
  vector<int> result;
  while (dna1.find(dna2) != string::npos)
  {
    int x = dna1.find(dna2);
    x++;
    dna1 = dna1.substr(x+1);
    result.push_back(count+x);
    count = count + x+1;
  }
  return result;
}

void main()
{
  //string dna1 = "GATATATGCATATACTT";
  //string dna2 = "ATAT";
  string dna1, dna2;
  cout << "Enter the first dna string" << endl;
  cin >> dna1;
  cout << "Enter the second dna string" << endl;
  cin >> dna2;
  vector<int> result = motif(dna1, dna2);
  for (int i = 0; i<result.size(); i++)
  {
    cout << result[i] << " ";
  }
  cout << endl;
}
