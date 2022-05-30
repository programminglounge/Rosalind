from Bio.Seq import Seq

my_seq = Seq(input("Enter the Sequence:\n"))
print(str(my_seq.count("A")) + " " + str(my_seq.count("T")) + " " + str(my_seq.count("C")) + " " + str(my_seq.count("G"))
