def offspring():
  arr =[]
  count = 0
  number = input("Enter all 6 non negative integers with one space between each number\n")
  while(True):
    x = number.find(" ")
    if (x != -1):
      count = count + 1
      mynumber = int(number[:x])
      if (mynumber <0):
        print("error: expected 6 non negative integers but entered a negative integer")
        return -1
      else:
        arr.append(mynumber)
        number = number[x+1:]
    if (x==-1 and count ==5):
      arr.append(int(number))
      break
    if (x==-1 and count !=5):
      print("error: expected 6 non negative integers but got fewer than 6")
      return -1
  res = ((arr[0]*1)+(arr[1]*1)+(arr[2]*1)+(arr[3]*0.75)+(arr[4]*0.5)+(arr(5]*0))*2
  return res
 
print(offspring())
