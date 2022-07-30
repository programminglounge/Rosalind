#include<map>
#include<string>

using namespace std;

unsigned int mrnaeverse (string rna)
{
  unsigned int count = 3;
  if (rna.length() == 0)
  {
    return count;
  }
  else
  {
    std::map<char, int> type;
    type['F'] = 2;
    type['L'] = 6;
    type['S'] = 6;
    type['P'] = 4;
    
    type['Y'] = 2;
    type['I'] = 3;
    type['V'] = 4;
    type['A'] = 4;
    
    type['T'] = 4;
    type['G'] = 4;
    type['R'] = 6;
    type['K'] = 2;
    
    type['D'] = 2;
    type['N'] = 2;
    type['E'] = 2;
    type['Q'] = 2;
    
    type['H'] = 2;
    type['C'] = 2;
    type['W'] = 1;
    type['M'] = 1;
    
    for (int i = 0; i<dna.length(); i++)
    {
      count = count * type[rna[i]];
    }
  }
  return count;
}  

void main()
{
  string mrna;
  cout << "enter the mRNA" << endl;
  cin >> mrna;
  unsigned int number = mrnaeverse (mrna);
  cout << number << endl;
}
