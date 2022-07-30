#include<string>

using namespace std;

double proteinmass (string protein)
{
  double mass = 0;
  double * p = new double[26];
  p[0] = 71.03711;
  p[1] = 0;
  p[2] = 103.00919;
  p[3] = 115.02694;
  p[4] = 129.042259;
  p[5] = 147.06841;
  p[6] = 57.02146;
  p[7] = 137.05891;
  p[8] = 113.08406;
  p[9] = 0;
  p[10] = 128.09496;
  p[11] = 113.08406;
  p[12] = 131.04049;
  p[13] = 114.04293;
  p[14] = 0;
  p[15] = 97.05276;
  p[16] = 128.05858;
  p[17] = 156.10111;
  p[18] = 87.03203;
  p[19] = 101.04768;
  p[20] = 0;
  p[21] = 99.06841;
  p[22] = 186.07931;
  p[23] = 0;
  p[24] = 163.063333;
  for (int i = 0; i< protein.length(); i++)
  {
    mass = mass + p[protein[i]-'A'];
  }
  return mass;
  
}

void main()
{
  string protein;
  cin >> protein;
  double weight = proteinmass(protein);
  cout << weight << endl;
}
