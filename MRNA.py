RNA_REVERSE_TABLE = 
{
  'F':2, 'L':6, 'S':6, 'P':4, 'Y':2,
  'I':3, 'V':4, 'A':4, 'T':4, 'G':4,
  'R':6, 'K':2, 'D':2, 'N':2, 'E':2,
  'Q':2, 'H':2, 'C':2, 'W':1, 'M':1
  }
  result = 3
  stringRNA = input("Enter the RNA string:\n")
  length = len(stringRNA)
  if (length != 0):
    for i in range (len(stringRNA)):
      result = (result * RNA_REVERSE_TABLE[stringRNA[i]])%1000000
  else:
    result = 0
  print(result)
