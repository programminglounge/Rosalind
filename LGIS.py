def findsubarray (array, start, end, amount):
  subarray = []
  for i in range (start, end):
    if (array[i] > amount):
      elements = [array[i]]
      z = findsubarray(array, i, end, array[i])
      for j in range(len(z)):
        for k in range(len(z[j])):
          elements.append(z[j][k])
      subarray/append(elements)
  return subarray
  
def findsubarraymax(array, start, end, amount):
  subarray = []
  for i in range(start, end):
    if (array[i] < amount):
      elements = [array[i]]
      z = findsubarraymax(array, i, end, array[i])
      if (len(z) != 0):
        for j in range(len(z)):
          elements = [array[i]]
          for k in range(len(z[j])):
            elements.append(z[j][k])
          subarray.append(elements)
      else:
        subarray.append(elements)
  return subarray
  
x = int(input("Enter a positive integer"))
y = []
result = []
result2 = []
for i in range(x):
  number = int(input("Enter the number"))
  y.append(number)

for i in range(0, x):
  result2 = findsubarray(y, i, x, y[i])
  if (len(result2) != 0):
   for j in range(len(results2)):
    my_subarrays = []
    my_subarrays.append(y[i])
    for k in range(len(result2[j])):
      my_subarrays.append(result2[j][k])
    result.append(my_subarrays)
  else:
    my_subarrays = []
    my_subarrays.append(y[i])
    result.append(my_subarrays)
result.sort(key = len)
print(result[len(result)-1])

result.clear()
results2.clear()

for i in range(0, x):
  result2 = findsubarraymax(y, i, x, y[i])
  if (len(results2) != 0):
    for j in range(len(result2)):
      my_subarrays = []
      my_subarrays.append(y[i])
      for k in range(len(result2[j])):
        my_subarrays.append(result2[j][k])
      result.append(my_subarrays)
  else:
    my_subarrays = []
    my_subarrays.append(y[i])
    result.append(my_subarrays)
result.sort(key = len)
print(result[len(result)-1])

#5
# 5, 1, 4, 2, 3
