strfirstfasta = input ("Enter the first Fasta code:\n")
strfirstdna = inout("Enter the first DNA sequence: \n")

strsecondfasta = input("Enter the second Fasta code:\n")
strseconddna = input("Enter the second DNA sequence:\n")

transitions = 0
transversions = 0
for i in range (len(strfirstdna)):
  if (strfirstdna[i] != strseconddna[i]):
    if (strfirstdna[i] == 'A' and strseconddna[i] == 'T'):
      transversions = transversions+1
    if (strfirstdna[i] == 'A' and strseconddna[i] == 'C'):
      transversions = transversions+1
    if (strfirstdna[i] == 'A' and strseconddna[i] == 'G'):
      transitions = transitions+1
    
    if (strfirstdna[i] == 'T' and strseconddna[i] == 'A'):
      transversions = transversions+1
    if (strfirstdna[i] == 'T' and strseconddna[i] == 'C'):
      transitions = transitions+1
    if (strfirstdna[i] == 'T' and strseconddna[i] == 'G'):
      transversions = transversions+1

    if (strfirstdna[i] == 'C' and strseconddna[i] == 'A'):
      transversions = transversions+1
    if (strfirstdna[i] == 'C' and strseconddna[i] == 'T'):
      transitions = transitions+1
    if (strfirstdna[i] == 'C' and strseconddna[i] == 'G'):
      transversions = transversions+1

    if (strfirstdna[i] == 'G' and strseconddna[i] == 'A'):
      transitions = transitions+1
    if (strfirstdna[i] == 'G' and strseconddna[i] == 'T'):
      transversions = transversions+1
    if (strfirstdna[i] == 'G' and strseconddna[i] == 'C'):
      transversions = transversions+1

print(transitions/transversions)
      
    
