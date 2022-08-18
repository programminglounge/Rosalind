import math

dna_string = input("Please enter the DNA string")
AT = 0
CG = 0
for i in range(len(s)):
  if (s[i] == 'A') or (s[i] == 'T'):
    AT = AT+1
  if (s[i] == 'C') or (s[i] == 'G'):
    CG = CG+1
num = []
results = []
s2 = input("enter the numbers")
while (s2.count(' ') != 0):
  index = s2.find(' ')
  s3 = s2[:index]
  num.append(float(s3))
  s2 = s2[index+1:]
  
for i in range(len(num)):
  probability = CG * math.log10(num[i]/2) + AT * math.log10((1-num[i])/2)
  results.append(round(probability, 3))
  
for i in range(len(results)):
  print(results[i])
