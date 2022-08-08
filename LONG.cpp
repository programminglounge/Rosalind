#include <iostream>
#include <string>
#include <vector>

using namespace std;

string LCSubStr(string X, string Y)
{
  int m = X.length();
  int n = Y.length();
  int result = 0;
  int end;
  int ** len = new int * [2];
  for (int i = 0; i<2; i++)
  {
    len[i] = new int [n+1];
  }
  int current = 0;
  for (int i = 0; i<= m; i++)
  {
    for (int j = 0; j<=n; j++)
    {
      if (i == 0 || j == 0)
      {
        len[current][j] = 0;
      }
      else if (X[i-1] == Y[j-1])
      {
        len[current][j] = len[1-current][j-1] + 1;
        if (len[current][j] > result)
        {
          result = len[current][j];
          end = i-1;
        }
      }
      else
      {
        len[current][j] = 0;
      }
    }
    current = 1-current;
  }
  if (result == 0)
  {
    return "-1";
  }
  return X.substr(end-result+1, result);
}

string createstring(vector<string> dnas)
{
  vector<string> dnas_copy;
  vector<pair<string, pair <int, int>>> combos;
  vector <string> results;
  for (int i = 0; i<dnas.size(); i++)
  {
    for (int j = i+1; j<dnas.size(); j++)
    {
      string common = LCSubStr(dnas[i], dnas[j]);
      combos.push_back(make_pair(common, make_pair(i, j)));
    }
  }
  sort (combos.begin(), combos.end(), [](pair<string, pair<int, int>> & a, pair<string, pair<int, int>> & b)
  {
    return a.first.length() > b.first.length();
  });
  if (dnas.size() == 1)
  {
    return dnas[0];
  }
  for (int i = 0; i<combos.size(); i++)
  {
    string common = combos[i].first;
    int index1 = dnas[combos[i].second.first].find(common);
    int index2 = dnas[combos[i].second.second].find(common);
    if (index2 == 0)
    {
      dnas_copy = dnas;
      string space = dnas[combos[i].second.second].substr(index2+common.length());
      string resultsum = dnas[combos[i].second.first]+space;
      dnas.erase(dnas.begin()+combos[i].second.first);
      dnas.erase(dnas.begin()+combos[i].second.second-1);
      dnas.push_back(resultsum);
      string combo_string = createstring(dnas);
      results.push_back(combo_string);
      dnas = dnas_copy;
    }
    else if (index1 == 0)
    {
      dnas_copy = dnas;
      string space = dnas[combos[i].second.second].substr(index1+common.length());
      string resultsum = dnas[combos[i].second.first]+space;
      dnas.erase(dnas.begin()+combos[i].second.first);
      dnas.erase(dnas.begin()+combos[i].second.second - 1);
      dnas.push_back(resultsum);
      string combo_string = createstring(dnas);
      results.push_back(combo_string);
      dnas = dnas_copy;
    }
    else
    {
      if (dnas2.size() == 2)
      {
        return dnas[0]+dnas[1];
      }
    }
  }
  sort (results.begin(), results.end(), [](string & a, string &b)
  {
    return a.length() <b.length();
  });
  result results[0];
}


string find_common_dna()
{
  vector<string> dnas;
  
  string dna_name = " ";
  string dna_string = " ";
  while (dna_name != "")
  {
    getline(cin, dna_name);
    if (dna_name != "")
    {
      getline(cin, dna_string);
      dnas.push_back(dna_string);
    }
    else
    {
      break;
    }
  }
  string dnastring = createstring(dnas);
  return dnastring;
}

void main()
{
  string result = find_common_dna();
  cout << result << endl;
}
