import urllib.request
import re

stringsearch = input ('Please enter the Uniprot ID')
while (stringsearch != ''):
  url = 'https://www.uniprot.org/uniprot/'+stringsearch + '.fasta'
  file = urllib.request.urlopen(url)
  string = []
  result = ""
  count = 0
  for line in file:
    line2 = line.decode("utf-8")
    if (count == 0):
      count = count+1
    else:
      line3 = line2[:len(line2)-1]
      result = result + line3
  sum = 0
  x = re.search("[N][^P][ST][^P]", result)
  while (x!= None):
    result = result[x.regs[0][0]+1:]
    print(x.regs[0][0]+1)
    sum = sum + x.regs[0][0]+1
    x = re.search("[N][^P][ST][^P]", result)
  stringsearch = input('Please enter the Uniprot ID')
