arr = {}
fastacode = input("Enter the FATSA code:\n")
dnacode = input("Enter the dna code:\n")
for i in range (0, len(dnacode)-3, 1):
  four_mer = dnacode[i:i+4]
  if (four_mer in arr):
    arr[four_mer] = arr[four_mer]+1
  else:
    arr[four_mer] = 1

for key, value in arr.items():
  print(value, end =' ')
