val = input("Enter the string for input\n")
s = list(val)
for i in range(len(val)):
  if (s[i] == 'T'):
    s[i] = 'A'
  elif (s[i] == 'A'):
    s[i] = 'T'
  elif (s[i] == 'C'):
    s[i] = 'G'    
  elif (s[i] == 'G'):
    s[i] = 'C'    
res = "".join(s)[::-1]
print(res)
