double tr_and_tr(string first_dna, string second_dna)
{
  int transversions = 0;
  int transitions = 0;
  for (int i = 0; i<first_dna.length(); i++)
  {
    if (first_dna[i] == 'A' and second_dna[i] == 'T')
    {
      transversions++;
    }
    if (first_dna[i] == 'A' and second_dna[i] == 'C')
    {
      transversions++;
    }
    if (first_dna[i] == 'A' and second_dna[i] == 'G')
    {
      transitions++;
    }
    
    if (first_dna[i] == 'T' and second_dna[i] == 'A')
    {
      transversions++;
    }
    if (first_dna[i] == 'T' and second_dna[i] == 'C')
    {
      transitions++;
    }
    if (first_dna[i] == 'T' and second_dna[i] == 'G')
    {
      transversions++;
    }
    

    if (first_dna[i] == 'C' and second_dna[i] == 'A')
    {
      transversions++;
    }
    if (first_dna[i] == 'C' and second_dna[i] == 'T')
    {
      transitions++;
    }
    if (first_dna[i] == 'C' and second_dna[i] == 'G')
    {
      transversions++;
    }


    if (first_dna[i] == 'G' and second_dna[i] == 'A')
    {
      transitions++;
    }
    if (first_dna[i] == 'G' and second_dna[i] == 'T')
    {
      transversions++;
    }
    if (first_dna[i] == 'G' and second_dna[i] == 'C')
    {
      transversions++;
    }


  }
  return (double)transitions/transversions;
}

void main()
{
  string first_fasta;
  string first_dna;
  string second_fasta;
  string second_dna;
  cin >> first_fasta;
  cin >> first_dna;
  cin >> second_fasta;
  cin >> second_dna;
  double answer = tr_and_tr(first_dna, second_dna);
  cout << answer << endl;
}
