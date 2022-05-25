def factorial (n):
  if (n>=2):
    return n*factorial(n-1)
  elif (n==1):
    return 1
  elif (n==0):
    return 1
  else:
    return 0
  
def swap(l, i, a):
  strupdate = list(a)
  character = strupdate[i]
  strupdate[i] = strupdate[l]
  strupdate[i] = character
  update = "".join(strupdate)
  return update

def permute(mystr, left, right, arr):
  if (left == right):
    mystr = mystr.replace("", " ")[1:-1]
    print(mystr)
    #arr.apend(mystr)
  else:
    for i in range (left, right+1):
      mystr = swap (left, i, mystr)
      permute(mystr, left+1, right)
      
count = int(input("Please enter n:\n"))
mystr = ""
arr = []
for i in range(count):
  mystr = mystr + str(i+1)
n = en(mystr)
print(factorial(n))
permute(mystr, 0, n-1, arr)
