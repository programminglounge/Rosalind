#include<iostream>
using namespace std;

string gccontent()
{
  string name = " ";
  string dna = "";
  int count = 0;
  double maxpercent = 0;
  string maxname = "";
  while (name != "")
  {
    std::getline(std::cin, name);
    if (name != "")
    {
      name = name.substr(1);
      std::getline(std::cin, dna);
      //dna =CCTGCGGAAGATCGGCACTAGAATAGCCAGAACCGTTTCTCTGAGGCTTCCGGCCTTTCCCACTAATAATTCTGAGG;
      for (int i = 0; i<dna.size(); i++)
      {
        if (dna[i] == 'G' || dna[i] == 'C')
        {
          count++;
        }
      }
      double percent = ((double)count/dna.size())*100;
      if (percent > maxpercent)
      {
        maxpercent = percent;
        maxname = name;
      }
      count = 0;
    }
  }
  return maxname + " " + std::to_string(maxpercent);
}

void main ()
{
  string gc = gccontent();
  int found = gc.find(" ");
  string name = gc.substr(0, found);
  double percent = std::stod(gc.substr(found));
  cout << name << endl;
  cout << percent << endl;

}
