# k = AA
# m = Aa
# n = aa
#couples =[
# k*(k-1) AA * AA -> prbability of 1 showing of A
# k*m     AA * Aa -> prbability of 1 showing of A
# k*n     AA * aa -> prbability of 1 showing of A
# m*k     Aa * AA -> prbability of 1 showing of A
# m*m     Aa * Aa -> prbability of 0.75 showing of A
# m*n     Aa * aa -> prbability of 0.5 showing of A
# n*k     aa * AA -> prbability of 1 showing of A
# n*m     aa * Aa -> prbability of 0.5 showing of A
# n*n     aa * aa -> prbability of 0 showing of A
#]

def couples():
  arr = []
  count = 0
  my_in = input("Enter k m and n in order with one space between each of them")
  while(True):
    x = my_in.find(" ")
    if (x != -1):
      count = count + 1
      mynumber = int(number[:x])
      if (mynumber <=0):
        print("error: expected 3 positive integers but entered a wrong integer")
        return -1
      else:
        arr.append(mynumber)
        my_in = my_in[x+1:]
    if (x==-1 and count ==2):
      arr.append(int(number))
      break
    if (x==-1 and count !=2):
      print("error: expected 3 positive integers but got fewer than 3")
      return -1
  
  pop = arr[0]+arr[1]+arr[2]
  probability = ((arr[0]*(arr[0]-1))+(2*arr[0]*arr[2])+(2*arr[1]*arr[0])+(arr[1]*arr[0])+(arr[1]*(arr[1]-1)*0.75))/(pop*(pop-1))
  return probability

print(couples())
