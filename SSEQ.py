def findmotif():
  strfasta = input("Enter the fasta code:\n")
  strdna = input("Enter the dna code:\n")
  strfasta2 = input("Enter the fasta code:\n")
  strdna2 = input("Enter the dna code:\n")
  arr = []
  mysum = 0
  for i in range(len(strdna2)):
    while (strdna.find(strdna2[i])!= -1):
      index = strdna.find(strdna2[i])
      if (i == 0):
        strdna = strdna[index+1:]
        arr.apend(index)
        mysum = mysum + index+1
        break
      else:
        arraylength = len(arr)
        if (index+mysum>arr[arraylength-1]):
          arr.append(index+mysum)
          mysum = mysum+index+1
          strdna = strdna[index+1:]
          break
    if(strdna.find(strdna2[i]) == -1):
      arr = []
      return arr
  return arr

print(findmotif())
  
