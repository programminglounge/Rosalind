def printAllKLength(set, k):
  n = len(set)
  test = printAllKLengthRec(set, "", n, k)
  return test
  
def printAllKLengthRec(set, prefix, n, k):
  test = []
  if (k == 0):
    test.append(prefix)
    return test
  for i in range(n):
    newPrefix = prefix + set[i]
    test = test + printAllKLengthRec(set, newPrefix, n, k-1)
  return test
  
set = ['a', 'b', 'c', 'd']
k = 3
result = printAllKLength(set, 3)
for i in range(len(result)):
  print(result[i])
