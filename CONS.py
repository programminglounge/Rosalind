def findmax(countA, countT, countC, countG):
  if (countA >= countG and countA >= countC and countA >= countT):
    return "A"
  if (countT >= countG and countT >= countC and countT >= countA):
    return "T"
  if (countC >= countG and countC >= countA and countC >= countT):
    return "C"
  if (countG >= countA and countG >= countC and countG >= countT):
    return "G"
  
n = int(input("enter the number of dna sequences\n"))
dna = []

for i in range (n):
  seq = input("enter the dna sequence\n")
  len_seq = len(seq)
  dna.append(seq)
countA = 0
countT = 0
countC = 0
countG = 0
profile_t = []
profile_row = ("A", "C", "G", "T")
profile_t.append(profile_row)
result = [*zip(*dna)]
consensus = ""
for i in range (len_seq):
  for j in range(n):
    if (result[i][j] == 'A'):
      countA = countA+1
    if (result[i][j] == 'T'):
      countT = countT+1
    if (result[i][j] == 'C'):
      countC = countC+1
    if (result[i][j] == 'G'):
      countG = countG+1
  profile_row = (countA, countC, countG, countT)
  profie_t.append(profile_row)
  max_symbol = findmax(countA, countT, countC, countG)
  countA = 0
  countT = 0
  countC = 0
  countG = 0
  consensus = consensus + max_symbol
profile = [*zip(*profile_t)]
print(profile)
print(consensus)


    
