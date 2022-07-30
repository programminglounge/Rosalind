bool isTrue(const pair<char, int> & v, const char & k)
{
  return v.first == k;
}
unsigned int mrnaeverse (string rna)
{
  unsigned int count = 3;
  if (rna.length() == 0)
  {
    return count;
  }
  else
  {
    std::vector<pair<char, int>> type;
    type.push_back(make_pair('F', 2));
    type.push_back(make_pair('L', 6));
    type.push_back(make_pair('S', 6));
    type.push_back(make_pair('P', 4));
    
    type.push_back(make_pair('Y', 2));
    type.push_back(make_pair('I', 3));
    type.push_back(make_pair('V', 4));
    type.push_back(make_pair('A', 4));
    
    type.push_back(make_pair('T', 4));
    type.push_back(make_pair('G', 4));
    type.push_back(make_pair('R', 6));
    type.push_back(make_pair('K', 2));
    
    type.push_back(make_pair('D', 2));
    type.push_back(make_pair('N', 2));
    type.push_back(make_pair('E', 2));
    type.push_back(make_pair('Q', 2));
    
    type.push_back(make_pair('H', 2));
    type.push_back(make_pair('C', 2));
    type.push_back(make_pair('W', 1));
    type.push_back(make_pair('M', 1));
    sort (type.begin(), type.end());
    
    for (int i = 0; i<rna.length(); i++)
    {
      vector<pair<char, int>>::iterator it = find_if(type.begin(), type.end(), [&](std::pair<char, int> const& ref)
      {
        return ref.first == dna[i];
      });
      pair <char, int> x = *it;
      count = count * x.second;
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
