def rabbit (n, k):
  if (n==1):
    return 1;
  elif (n==2):
    return 1;
  else:
    return rabbit(n-1, k) + k* rabbit(n-2, k)

n = int(input("Enter a value for n\n"))
k = int(input("Enter the value for k\n"))
res = rabbit(n, k)
print (res)
