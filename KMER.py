def printAllKLengthRec(set, prefix, n, k, arr):
  if (k == 0):
    arr.append(prefix)
    return
  for i in range(n):
    newprefix = prefix+set[i]
    printAllKLengthRec(set, newprefix, n, k-1, arr)
    
def printAllKLength(set, k, arr):
  n = len(set)
  printAllKLength*set, "", n, k, arr)

arr = {}
fastacode = input("Enter the FATSA code:\n")
dnacode = input("Enter the dna code:\n")
for i in range (0, len(dnacode)-3, 1):
  four_mer = dnacode[i:i+4]
  if (four_mer in arr):
    arr[four_mer] = arr[four_mer]+1
  else:
    arr[four_mer] = 1
myarr = []
set1 = ['A', 'T', 'C', 'G']
k = 4
printAllKLength(set1, k, myarr)
for i in range(len(myarr)):
  if (myarr[i] not in arr):
    arr[myarr[i]] = 0
for key, value in sorted(arr.items()):
  print(value, end =' ')
