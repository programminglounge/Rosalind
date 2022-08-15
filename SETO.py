x = int(input("Enter a positive integer"))
universe = []
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

AUB_set = A_set.union(B_set)
ANB_set = A_set.intersection(B_set)
AMinusB_set = A_set.difference(B_set)
BMinusA_set = B_set.difference(A_set)
BPrime_set = universe_set.difference(B_set)
APrime_set = universe_set.difference(A_set)

print(AUB_set)
print(ANB_set)
print(AMinusB_set)
print(BMinusA_set)
print(APrime_set)
print(BPrime_set)
