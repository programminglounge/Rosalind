#Do not forget to install the Biopython library

from Bio import Entrez
from Bio import SeqIO

Entrez.email = "b@example.com"
ids = input("Enter all IDs each with one space apart:\n")
ids = ods.replace(' ', ', ')
handle = Entrez.efetch(db = "nucleotide", id = [ids], rettype = "fasta")
records = list(SeqIO.parse(handle, "fasta"))
max = 0
max_i = 0

for i in range(len(records)):
  if (len(records[i].seq)>max):
    max = len(records[i].seq)
    max_i = i
    
print(records[max_i].description)
print(records[max_i].seq)
