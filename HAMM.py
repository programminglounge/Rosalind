count = 0;
s = input("Enter the first DNA sequence\n")
t = input("Enter the second DNA sequence\n")
for i in range (len(s)):
  if (s[i] != t[i]):
    count = count+1
print(count)
