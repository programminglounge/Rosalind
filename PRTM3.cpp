double proteinweight (string protein)
{
  double weight = 0;
  std::vector<pair<char, double>> type;
  type.push_back(make_pair('A', 71.03711));
  type.push_back(make_pair('C', 103.00919));
  type.push_back(make_pair('D', 115.02694));
  type.push_back(make_pair('E', 129.04259));
  type.push_back(make_pair('F', 147.06841));
  type.push_back(make_pair('G', 57.02146));
  type.push_back(make_pair('H', 137.05891));
  type.push_back(make_pair('I', 113.08406));
  type.push_back(make_pair('K', 128.09496));
  type.push_back(make_pair('L', 113.08406));
  type.push_back(make_pair('M', 131.04049));
  type.push_back(make_pair('N', 114.04293));
  type.push_back(make_pair('P', 97.05276));
  type.push_back(make_pair('Q', 128.05858));
  type.push_back(make_pair('R', 156.10111));
  type.push_back(make_pair('S', 87.03203));
  type.push_back(make_pair('T', 101.04768));
  type.push_back(make_pair('V', 99.06841));
  type.push_back(make_pair('W', 186.07931));
  type.push_back(make_pair('Y', 163.06333));
  sort(type.begin(), type.end());
  for (int i = 0; i<protein.length(); i++)
  {
    vector<pair<char, double>>::iterator it = find_if(type.begin(), type.end(), [&](std::pair<char, double> &ref)
    {
      return ref.first == protein[i];
    });
    pair<char, double> x = *it;
    weight = weight + x.second;
  }
  return weight;
}
