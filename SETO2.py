x = int(input("Enter a positive integer"))
A = []
B = []

for i in range(1, x+1):
  universe.append(i)
universe_set = set(universe)

y = input("Enter the first set")
setA = y[1:-1]
index = setA.index(',')
while(index != -1):
  A_element = int(setA[:index])
  A.append(A_element)
  setA = setA[index+1:]
  index = setA.count(',')
  if (index != 0):
    index = setA.index(',')
  else:
    A_element = int(setA)
    A.append(A_element)
    break
    
A_set = set(A)

y = input("Enter the second set")
setB = y[1:-1]
index = setB.index(',')
while(index != -1):
  B_element = int(setB[:index])
  B.append(B_element)
  setB = setB[index+1:]
  index = setB.count(',')
  if (index != 0):
    index = setB.index(',')
  else:
    B_element = int(setB)
    B.append(B_element)
    break
    
B_set = set(B)

AUB = []
for i in range(len(A)):
  AUB.append(A[i])
for i in range(len(B)):
  if (AUB.count(B[i]) == 0):
    AUB.append(B[i])
AUB_set = set (AUB)

AMinusB = []
for i in range(len(A)):
  AMinusB.append(A[i])
for i in range(len(B)):
  if (AMinusB.count(B[i]) != 0):
    AMinusB.remove(B[i])

AMinusB_set = set (AMinusB)

BMinusA = []
for i in range(len(B)):
  BMinusA.append(B[i])
for i in range(len(A)):
  if (BMinusA.count(A[i]) != 0):
    BMinusA.remove(A[i])
    
BMinusA_set = set(BMinusA)

BPrime = []
for i in range(len(universe)):
  BPrime.append(universe[i])
for i in range(len(B)):
  if (BPrime.count(B[i]) != 0):
    BPrime.remove(B[i])
    
BPrime_set = set(BPrime)

APrime = []
for i in range(len(universe)):
  APrime.append(universe[i])
for i in range(len(A)):
  if (APrime.count(A[i]) != 0):
    APrime.remove(A[i])
    
APrime_set = set(APrime)

ANB = []
for i in range(len(A)):
  ANB.append(A[i])
for i in range(len(AMinusB)):
  if (ANB.count(AMinusB[i]) != 0):
    ANB.remove(AMinusB[i])

ANB_set = set(ANB)

print("-------------------")
print(AUB_set)
print(ANB_set)
print(AMinusB_set)
print(BMinusA_set)
print(APrime_set)
print(BPrime_set)
