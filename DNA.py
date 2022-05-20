val = input("Enter the string for input\n")
countA = 0;
countT = 0;
countC = 0;
countG = 0;
for i in range(len(val)):
  if (val[i] == 'A'):
    countA = countA+1
  if (val[i] == 'T'):
    countT = countT+1
  if (val[i] == 'C'):
    countC = countC+1
  if (val[i] == 'G'):
    countG = countG+1
print(str(countA) + " " + str(countT) + " " + str(countC) + str(countG))
