#include <string>
#include <map>

using namespace std;

string rna2protein (string rna)
{
  if (rna.length() % 3 == 0)
  {
    std::map<std::string, std::string> type;
    type["UUU] = "F";
    type["UUC] = "F";
    type["UUA] = "L";
    type["UUG] = "L";
    type["UCU] = "S";
    type["UCC] = "S";
    type["UCA] = "S";
    type["UCG] = "S";
    type["UAU] = "Y";
    type["UAC] = "Y";
    type["UAA] = "";
    type["UAG] = "";
    type["UGU] = "C";
    type["UGC] = "C";
    type["UGA] = "";
    type["UGG] = "W";
    type["CUU] = "L";
    type["CUC] = "L";
    type["CUA] = "L";
    type["CUG] = "L";
    type["CCU] = "P";
    type["CCC] = "P";
    type["CCA] = "P";
    type["CCG] = "P";
    type["CAU] = "H";
    type["CAC] = "H";
    type["CAA] = "Q";
    type["CAG] = "Q";
    type["CGU] = "R";
    type["CGC] = "R";
    type["CGA] = "R";
    type["CGG] = "R";
    type["AUU] = "I";
    type["AUC] = "I";
    type["AUA] = "I";
    type["AUG] = "M";
    type["ACU] = "T";
    type["ACC] = "T";
    type["ACA] = "T";
    type["ACG] = "T";
    type["AAU] = "N";
    type["AAC] = "N";
    type["AAA] = "K";
    type["AAG] = "K";
    type["AGU] = "S";
    type["AGC] = "S";
    type["AGA] = "R";
    type["AGG] = "R";
    type["GUU] = "V";
    type["GUC] = "V";
    type["GUA] = "V";
    type["GUG] = "V";
    type["GCU] = "A";
    type["GCC] = "A";
    type["GCA] = "A";
    type["GCG] = "A";
    type["GAU] = "D";
    type["GAC] = "D";
    type["GAA] = "E";
    type["GAG] = "E";
    type["GGU] = "G";
    type["GGC] = "G";
    type["GGA] = "G";
    type["GGG] = "G";
    string protein = "";
    for (int i = 0; i<rna.length(); i = i+3)
    {
      string s = rna.substr(i, 3);
      if (type[s] != "")
      {
        protein = protein + type[s];
      }
      else
      {
        break;
      }
    }
    return protein;
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
