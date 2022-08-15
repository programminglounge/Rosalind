def reversecompliment(x):
  y = x[::-1]
  z = ''
  for i in range(len(y)):
    if (y[i] == 'A'):
      z = z+ 'T'
    elif (y[i] == 'T'):
      z = z+ 'A'
    elif (y[i] == 'C'):
      z = z + 'G'
    elif (y[i] == 'G'):
      z = z + 'C'
  return z
  
def hamming(x, y):
  count = 0
  for i in range(len(x)):
    if (x[i] != y[i]):
      count = count + 1
  return count
  
dnas = []
dnas2 = []
dnas3 = []
results = []
dna_string_name = " "
while dna_string_name != "":
  dna_string_name = input("")
  if dna_string_name != "":
    dna_string = input("")
    dnas.append(dna_string)
    
for i in range(len(dnas)-1):
  j = i+1
  while(j != len(dnas)):
    if (dnas[i] == dnas[j]):
      if (dnas2.count(dnas[i]) == 0):
        dnas2.append(dnas[i])
        dnas.pop(j)
      elif (dnas2.count(dnas[i]) != 0):
        dnas.pop(j)
    else:
      j = j+1
      
for i in range(len(dnas)-1):
  j = i+1
  while (j <=len(dnas)-1):
    if (hamming(dnas[i], dnas[j]) == 1):
      if (dnas2.count(dnas[i]) == 0):
        dnas2.append(dnas[i])
        results.append([dnas[i], dnas[j]])
        dnas.pop(j)
      elif (dnas2.count(dnas[i]) != 0):
        results.append([dnas[i], dnas[j]])
        dnas.pop(j)
    else:
      j = j+1

for i in range(len(dnas2)):
  dnas3.append(reversecompliment(dnas2[i]))
  
for i in range(len(dnas2)):
  dnas.remove(dnas2[i])
  
for i in range(len(dnas2)):
  dnas2.append(dnas3[i])
  
i = 0
while (len(dnas) != 0):
  for j in range(len(dnas2)):
    if (dnas[i] == dnas2[j]):
      dnas.remove(dnas[i])
      break
    if (hamming(dnas[i], dnas2[j]) == 1):
      results.append([dnas[i], dnas2[j]])
      dnas.remove(dnas[i])
      break
      
results2 = ''
for i in range(len(results)):
  results2 = results2 + results[i][0] + '->' + results[i][1] + '\n'
print(results2)

#R1
#TCATC
#R2
#TTCAT
#R3
#TCATC
#R4
#TGAAA
#R5
#GAGGA
#R6
#TTTCA
#R7
#ATCAA
#R8
#TTGAT
#R9
#TTTCC
