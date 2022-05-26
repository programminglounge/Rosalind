number = input("Enter the first and second number with a space between them:\n")
index = number.find(" ")
first_number = int(number[0:index])
second_number = int(number[index+1:])
result = 1

if (first_number>0 and second_number>0):
  for i in range (first_number, first_number-second_number, -1):
    result = (result * i)%1000000
else:
  result = 0
print(result)
