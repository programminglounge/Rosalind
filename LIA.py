#probability = sum (from i = n to p) c(p, i)*(0.25^i)*(0.75^(p-i))

from math import comb
prob = 0
k = 2
n = 1
p = 2**k
for i in range (n, p+1):
  x = comb(p, i)
  prob = prob + (x*(0.25**i)*(0.75**(p-i)))
print(round(prob, 3))
