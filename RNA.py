val = input("Enter the string for input\n")
s = list(val)
for i in range(len(val)):
  if (s[i] == 'T'):
    s[i] = 'U'
res = "".join(s)
print(res)
