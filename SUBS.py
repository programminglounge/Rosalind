dna = input ("enter first sequence\n")
dna2 = input ("enter second sequence\n")
if (len(dna2)<=len(dna)):
  copydna = dna
  index = 0
  index = copydna.find(dna2)
  count =[]
  while (index != -1):
    first = list(copydna)
    count.append(index+1)
    first[index]='0'
    copydna = "".join(first)
    index = copydna.find(dna2)
  print(count)
else:
  print ("")
