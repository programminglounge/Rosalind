#include <string>
#include <vector>

using namespace std;

int binarySearch(vector<pair<string, string>> arr, string x)
{
  int left = 0;
  int right = arr.size()-1;
  while (left <=right)
  {
    int middle = left + (right-left)/2;
    int result = 0;
    pair <string, string> test = arr[middle];
    if (x == test.first)
      return middle;
    if (x >test.first)
      left = middle + 1;
    else
      right = middle - 1;
  }
  return -1;
}

string rna2protein (string rna)
{
  if (rna.length() %3==0)
  {
    std::vector<pair<string, string>> type;
    type.push_back(make_pair("UUU", "F"));
    type.push_back(make_pair("UUC", "F"));
    type.push_back(make_pair("UUA", "L"));
    type.push_back(make_pair("UUG", "L"));
    type.push_back(make_pair("UCU", "S"));
    type.push_back(make_pair("UCC", "S"));
    type.push_back(make_pair("UCA", "S"));
    type.push_back(make_pair("UCG", "S"));
    type.push_back(make_pair("UAU", "Y"));
    type.push_back(make_pair("UAC", "Y"));
    type.push_back(make_pair("UAA", ""));
    type.push_back(make_pair("UAG", ""));
    type.push_back(make_pair("UGU", "C"));
    type.push_back(make_pair("UGC", "C"));
    type.push_back(make_pair("UGA", ""));
    type.push_back(make_pair("UGG", "W"));
    type.push_back(make_pair("CUU", "L"));
    type.push_back(make_pair("CUC", "L"));
    type.push_back(make_pair("CUA", "L"));
    type.push_back(make_pair("CUG", "L"));
    type.push_back(make_pair("CCU", "P"));
    type.push_back(make_pair("CCC", "P"));
    type.push_back(make_pair("CCA", "P"));
    type.push_back(make_pair("CCG", "P"));
    type.push_back(make_pair("CAU", "H"));
    type.push_back(make_pair("CAC", "H"));
    type.push_back(make_pair("CAA", "Q"));
    type.push_back(make_pair("CAG", "Q"));
    type.push_back(make_pair("CGU", "R"));
    type.push_back(make_pair("CGC", "R"));
    type.push_back(make_pair("CGA", "R"));
    type.push_back(make_pair("CGG", "R"));  
    type.push_back(make_pair("AUU", "I"));
    type.push_back(make_pair("AUC", "I"));
    type.push_back(make_pair("AUA", "I"));
    type.push_back(make_pair("AUG", "M"));
    type.push_back(make_pair("ACU", "T"));
    type.push_back(make_pair("ACC", "T"));
    type.push_back(make_pair("ACA", "T"));
    type.push_back(make_pair("ACG", "T"));
    type.push_back(make_pair("AAU", "N"));
    type.push_back(make_pair("AAC", "N"));
    type.push_back(make_pair("AAA", "K"));
    type.push_back(make_pair("AAG", "K"));
    type.push_back(make_pair("AGU", "S"));
    type.push_back(make_pair("AGC", "S"));
    type.push_back(make_pair("AGA", "R"));
    type.push_back(make_pair("AGG", "R"));
    type.push_back(make_pair("GUU", "V"));
    type.push_back(make_pair("GUC", "V"));
    type.push_back(make_pair("GUA", "V"));
    type.push_back(make_pair("GUG", "V"));
    type.push_back(make_pair("GCU", "A"));
    type.push_back(make_pair("GCC", "A"));
    type.push_back(make_pair("GCA", "A"));
    type.push_back(make_pair("GCG", "A"));
    type.push_back(make_pair("GAU", "D"));
    type.push_back(make_pair("GAC", "D"));
    type.push_back(make_pair("GAA", "E"));
    type.push_back(make_pair("GAG", "E"));
    type.push_back(make_pair("GGU", "G"));
    type.push_back(make_pair("GGC", "G"));
    type.push_back(make_pair("GGA", "G"));
    type.push_back(make_pair("GGG", "G"));
    sort (type.begin(), type.end());
    for (int i=0; i<rna.length(); i=i+3)
    {
      string s = rna.substr(i, 3);
      int pos = binarySearch(type, s);
      if (pos == -1)
        return "";
      else
      {
        pair<string, string> x = type[pos];
        result = result + x.second;
      }
    }
    return result;
  }
  return "";
}

void main()
{
  //string rna = "AUGGCCAUGGCGCCCAGAACUGAGAUCAAUAGUACCCGUAUUAACGGGUGA";
  string rna;
  cout << "Enter the RNA string" << endl;
  cin >> rna;
  string protein = rna2protein(rna);
  cout << protein << endl;
}
