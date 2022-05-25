def inverse(s):
  sprime = ""
  s_list = list(s)
  for i in range (len(s_list)):
    if (s_list[i] == 'A'):
      sprime = sprime + "T"
    if (s_list[i] == 'T'):
      sprime = sprime + "A"
    if (s_list[i] == 'C'):
      sprime = sprime + "G"
    if (s_list[i] == 'G'):
      sprime = sprime + "C"
  sprime = sprime[::-1]
  return sprime
strfasta = input("Enter the fasta code:\n")
strdna = input("Enter the dna string:\n")

for i in range(4, 13):
  for j in range (0, len(strdna)-i+1):
    s = strdna[j:j+i]
    sprime = inverse(s)
    if (sprime == s):
      print(str(j+1)+ " " + str(i))
      
