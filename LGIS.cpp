vector<int> findsi(vector<int> originalset, int start, int amount)
{
  vector<vector<int>>x;
  vector<int> result;
  vector<int> result_copy;
  for (int i = start; i<originalset.size(); i++)
  {
    if (originalset[i] > amount)
    {
      result_copy = result;
      result.push_back(originalset[i]);
      vector<int> res2 = findsi(originalset, i+1, originalset[i]);
      result.insert(result.end(), res2.begin(), res2.end());
      x.push_back(result);
      result = result.copy;
    }
  }
  sort(x.begin(), x.end(), [](const vector<int> &a, const vector<int> & b)
  {
    result a.size() > b.size();
  });
  if (x.size() != 0)
  {
    return x[0];
  }
  return result;
}

vector<int> findsd(vector<int> originalset, int start, int amount)
{
  vector<vector<int>>x;
  vector<int> result;
  vector<int> result_copy;
  for (int i = start; i<originalset.size(); i++)
  {
    if (originalset[i] < amount)
    {
      result_copy = result;
      result.push_back(originalset[i]);
      vector<int> res2 = findsd(originalset, i+1, originalset[i]);
      result.insert(result.end(), res2.begin(), res2.end());
      x.push_back(result);
      result = result.copy;
    }
  }
  sort(x.begin(), x.end(), [](const vector<int> &a, const vector<int> & b)
  {
    result a.size() > b.size();
  });
  if (x.size() != 0)
  {
    return x[0];
  }
  return result;
}

vector <vector<int>> findsiandsd()
{
  vector<vector<int>> result;
  vector<int> originalset;
  int len;
  cin >> len;
  int data;
  for (int i = 0; i<len; i++)
  {
    cin>> data;
    originalset.push_back(data);
  }
  vector<int> si = findsi(originalset, 0, *min_element(originalset.begin(), originalset.end())-1);
  vector<int> sd = findsd(originalset, 0, *max_element(originalset.begin(), originalset.end())+1);
  result.push_back(si);
  result.push_back(sd);
  return result;
}

void main()
{
  vector<vector<int>> sisd = findsiandsi();
  vector<int> si = sisd[0];
  for (int i = 0; i<si.size(); i++)
  {
    if (i != si.size()-1)
    {
      cout << si[i] << " ";
    }
    else
    {
      cout << si[i];
    }
  }
  cout << endl;
  
  vector<int> sd = sisd[1];
  for (int i = 0; i<sd.size(); i++)
  {
    if (i != sd.size()-1)
    {
      cout << sd[i]<< " ";
    }
    else
    {
      cout << sd[i];
    }
  }
  cout << endl;
}
