def factorial(x):
  result = 1
  for i in range(1, x):
    result = result * i
  return result
  
s = input("Please enter DNA string")
NumberA = 0
NumberG = 0
for i in range(len(s)):
  if (s[i] == 'A'):
    NumberA = NumberA + 1
  if (s[i] == 'G'):
    NumberG = NumberG + 1
matchings = factorial(NumberA) * factorial(NumberG)
print(matchings)
