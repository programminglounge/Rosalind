from Bio import Entrez, SeqIO, pairwise2

ids = input ("Enter all IDs wach with one space apart:\n")
ids = ids.replace(' ', ', ')
Entrez.email = "b@example.com"
handle = Entrez.efetch(db = "nucleotide", id = [ids], rettype = "fasta")
records = list(SeqIO.parse(handle, "fasta"))
print(pairwise2.align.globalms(records[0].seq, records[1].seq, match = 5, mismatch = -4, open = -10, extend = -1)[0][2])
