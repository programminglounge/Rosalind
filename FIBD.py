def fib(n, m):
  if (n==1):
    return 1
  if (n==2):
    return 1
  if (n<=0):
    return 0
  a = 1
  b = 1
  for i in range(2, n):
    tmp = a+b
    if (i == m):
      temp = tmp -1
    if (i>m):
      tmp = tmp - fib(i-m, m)
    a = b
    b = tmp
  return tmp

print(fib(6, 3))
print(fib(96, 17))
