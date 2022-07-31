double proteinweight (string protein)
{
  double weight = 0;
  for (int i = 0; i<protein.length(); i++)
  {
    switch (protein[i])
    {
      case 'A':
        weight = weight + 71.03711;
        break;
      case 'C':
        weight = weight + 103.00919;
        break;
      case 'D':
        weight = weight + 115.02694;
        break;
      case 'E':
        weight = weight + 129.04259;
        break;
      case 'F':
        weight = weight + 147.06841;
        break;
      case 'G':
        weight = weight + 57.02146;
        break;
      case 'H':
        weight = weight + 137.05891;
        break;
      case 'I':
        weight = weight + 113.08406;
        break;
      case 'K':
        weight = weight + 128.09496;
        break;
      case 'L':
        weight = weight + 113.08406;
        break;
      case 'M':
        weight = weight + 131.04049;
        break;
      case 'N':
        weight = weight + 114.04293;
        break;
      case 'P':
        weight = weight + 97.05276;
        break;
      case 'Q':
        weight = weight + 128.05858;
        break;
      case 'R':
        weight = weight + 156.10111;
        break;
      case 'S':
        weight = weight + 87.03203;
        break;
      case 'T':
        weight = weight + 101.04768;
        break;
      case 'V':
        weight = weight + 99.06841;
        break;
      case 'W':
        weight = weight + 186.07931;
        break;
      case 'Y':
        weight = weight + 163.06333;
        break;
    }
  }
  return weight;
}

