#include <iostream>
using namespace std;

string dnareversecompliment(string dna)
{
  std::reverse(dna.begin(), dna.end());
  for (int i = 0; i<dna.size(); i++)
  {
    if (dna[i] == 'A')
      dna[i] = 'T';
    else if (dna[i]== 'T')
      dna[i] = 'A';
    else if (dna[i] == 'G')
      dna[i] = 'C';
    else
      dna[i] = 'G';
  }
  return dna;
}

void main()
{
  string dna;
  cout << "Please enter the DNA string" << endl;
  cin >> dna;
  string reverse_compliment = dnareversecompliment(dna);
  cout << "The resulting reverse compliment is: " << endl;
  cout << reverse_compliment << endl;
  
  /*
  string dna = "AAAACCCGGT"; //output should be ACCGGGTTTT
  string reversecompliment = dnareversecompliment(dna);
  cout << reversecompliment << endl;   
  */
  
}
