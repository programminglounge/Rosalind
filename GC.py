array = []
count = int(input("Enter the number of DNA sequences\n"))
if count>0:
  number = 0
  for i in range(count):
    fasta = input("Enter the FASTA string \n")
    dna = input("Enter the DNA sequence\n")
    fastaresult = fasta[1:]
    for j in range (len(dna)):
      if (dna[j] == 'G' or dna[j] == 'C'):
        number = number+1
    percent = float(number/len(dna))
    number = 0
    result = percent, fastaresult]
    array.append(result)
  array.sort(reverse=True)
  print(array[0][1])
  print(array[0][0])
else:
  print("number of DNA sequences must be bigger than zero")
