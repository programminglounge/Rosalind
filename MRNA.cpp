unsigned int mrnaeverse (string rna)
{
  unsigned int count = 3;
  if (rna.length() == 0)
  {
    return count;
  }
  else
  {
    for (int i = 0; i < rna.length(); i++)
    {
      switch(rna[i])
      {
        case 'F':
          count = count * 2;
          break;
        case 'L':
          count = count * 6;
          break;
        case 'S':
          count = count * 6;
          break;
        case 'P':
          count = count * 4;
          break;
        case 'Y':
          count = count * 2;
          break;
        case 'I':
          count = count * 3;
          break;
        case 'V':
          count = count * 4;
          break;
        case 'A':
          count = count * 4;
          break;
        case 'T':
          count = count * 4;
          break;
        case 'G':
          count = count * 4;
          break;
        case 'R':
          count = count * 6;
          break;
        case 'K':
          count = count * 2;
          break;
        case 'D':
          count = count * 2;
          break;
        case 'N':
          count = count * 2;
          break;
        case 'E':
          count = count * 2;
          break;
        case 'Q':
          count = count * 2;
          break;
        case 'H':
          count = count * 2;
          break;
        case 'C':
          count = count * 2;
          break;
        case 'W':
          count = count * 1;
          break;
        case 'M':
          count = count * 1;
          break;
      }
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
