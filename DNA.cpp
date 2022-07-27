#include <iostream>
#include <vector>
using namespace std;

vector <int> counts(string s)
{
  vector <int> count;
  int countA = 0;
  int countC = 0;
  int countG = 0;
  int countT = 0;
  for (int i = 0; i<s.size(); i++)
  {
    if (s[i] == 'A')
      countA++;
    else if (s[i] == 'C')
      countC++;
    else if (s[i] == 'G')
      countG++;
    else
      countT++;
  }
  count.push_back(countA);
  count.push_back(countC);
  count.push_back(countG);
  count.push_back(countT);
  return count;
}

int main ()
{
  string dna;
  cin >> dna;
  vector <int> mycount;
  mycount = counts(dna);
  for (int i = 0; i<mycount.size(); i++)
  {
    cout << mycount[i] << " ";
  }
  cout << endl;
}
