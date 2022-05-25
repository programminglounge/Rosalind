# Rosalind

In this repostory I solve the following problems from the Rosalind website using Python as the preferred language of choice
<br><br>
Counting DNA Nucleotids (DNA.py) <br>

Given: A DNA string s of length at most 1000 nt <br>
Return: Four integers (seperated by spaces) counting the respective number of times that the symbols 'A', 'C', 'G' and 'T' occur in s

<b>Sample Dataset:</b><br>
AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC

<b>Sample Output:</b> <br>
20 12 17 21

---------------------------------------------------------------------

Transcribing DNA into RNA: (RNA.py) <br><br>

Given: a DNA string t having length at most 1000 nt<br> 
Return: the transcribed RNA string of t<br><br>

<b>Sample Dataset:</b><br>
GATGGAACTTGACTACGTAAATT<br><br>

<b>Sample Output:</b><br>
GAUGGAACUUGACUACGUAAAUU<br>

--------------------------------------------------------------------

Complementing a Strand of DNA: (REVC.py) <br><br>

Given: A DNA string s of length at most 1000 bp <br>
Return: The reverse complement s<sup>c</sup> of s <br><br>

<b>Sample Dataset:</b><br>
AAAACCCGGT<br><br>

<b>Sample Output:</b><br>
ACCGGGTTTT<br>

----------------------------------------------------------------------------

Rabbits and Recurring Relations: (FIB.py) <br><br>

Given: positive integers n <=40 and k<=5 <br>
Return: the total number of rabbit pairs that will be presented after n months, if we begin with 1 pair and in each generation, every pair of reproduction-age rabbits produces a litter of k rabbit pairs (instead of only 1 pair) <br><br>

<b>Sample Dataset:</b><br>
5, 3<br>

<b>Sample Output:</b><br> 
19<br>

-------------------------------------------------------------------------

Computing GC Content (GC.py) <br><br>

The GC-content of a DNA string is given by the percentage of symbols in the string that are 'C' or 'G'.<br>

Given: At most 10 DNA strings in FASTA format (of length at most 1 kbp each)<br>
Return: the ID of the string having the highest GC-content, followed by the GC-content of that string.<br><br>

<b>Sample Dataset:</b><br>

\>Rosalind_6404<br>
CCTGCGGAAGATCGGCACTAGAATAGCCAGAACCGTTTCTCTGAGGCTTCCGGCCTTTCCCACTAATAATTCTGAGG<br>
\>Rosalind_5959<br>
CCATCGGTAGCGCATCCTTAGTCCAATTAAGTCCCTATCCAGGCGCTCCGCCGAAGGTCTATATCCATTTGTCAGCAGACACGC<br>
\>Rosalind_0808<br>
CCACCCTCGTGGTATGGCTAGGCATTCAGGAACCGGAGAACGCTTCAGACCAGCCCGGACTGGGAACCTGCGGGCAGTAGGTGGAAT<br>

<b>Sample Output:</b><br>
Rosalind_0808<br>
60.919540<br>

--------------------------------

Counting Point Mutations (HAMM.py)<br><br>

Given: Two DNA strings s and t of equal length (not exceeding 1 kbp)<br>
Return: The Hamming distance d<sub>H</sub>(s, t)<br>

<b>Sample Dataset</b><br>

GAGCCTACTAACGGGAT<br>
CATCGTAATGACGGCCT<br>

<b>Sample Output:</b><br>
7

------------------------------

Translating RNA into Protein (PROT.py)<br><br>

Given: An RNA string s corresponding to a strand of mRNA (of length at most 10 kbp)<br>
Return: the proetein string encoded by s<br>

<b>Sample Dataset:</b><br>
AUGGCCAUGGCGCCCAGAACUGAGAUCAAUAGUACCCGUAUUAACGGGUGA<br>

<b>Sample Output:</b><br>
MAMAPRTEINSTRING<br>

-------------------------------------

Finding a Motif in DNA (SUBS.py)<br><br>

Given: Two DNA strings s and t (each of length at most 1 kbp)<br>
Return: All locations of t ass a substring of s.<br>

<b>Sample Dataset:</b><br>
GATATATGCATATACTT<br>
ATAT<br>

<b>Sample Output:</b><br>
2 4 10<br>

------------------------------------------

Consensus and Profile (CONS.py)<br><br>

Given: A collection of at most 10 DNA strings of equal length (at most 1 kbp) in FASTA format <br>
Return: A consensus string and profile matrix for the collection. (If several possible consensus strings exist, then you may return any one of them.) <br>

<b>Sample Dataset:</b> <br>

\>Rosalind_1<br>
ATCCAGCT<br>
\>Rosalind_2<br>
GGGCAACT <br>
\>Rosalind_3 <br>
ATGGATCT <br>
\>Rosalind_4 <br>
AAGCAACC <br>
\>Rosalind_5 <br>
TTGGAACT <br>
\>Rosalind_6 <br>
ATGCCATT <br>
\>Rosalind_7 <br>
ATGGCACT <br>

<b>Sample Output:</b><br>

ATGCAACT<br>
A: 5 1 0 0 5 5 0 0<br>
C: 0 0 1 4 2 0 6 1 <br>
G: 1 1 6 3 0 1 0 0 <br>
T: 1 5 0 0 0 1 1 6 <br>

-------------------------------------------
Calculating Expected Offspring (IEV.py)<br><br>

Given: Six nonnegative integers, each of which does not exceed 20,000. The integers correspond to the number of couples
in a population possessing each genotype pairing for a given factor. In order, the six given integers represent the number of couples having the following genotypes: <br>

1. AA-AA<br>
2. AA-Aa
3. AA-aa
4. Aa-Aa
5. Aa-aa
6. aa-aa

Return: The expected number of offspring displaying the dominant phenotype in the next generation, under the assumption that every couple has exactly two offspring

<b>Example Dataset:</b><br>
1 0 0 1 0 1<br>

<b>Example Output</b><br>
3.5

-----------------------------------------------

Mendel's First Law (IPRB.py)<br><br>

Given: Three positive integers k, m, and n, representing a population containing k+m+n organisms: k individuals are homozygous dominant for a factor, m are heterozygous, and n are homozygous recessive

Return: The probability that two randomly selected mating organisms will produce an individual possessing a dominant allele. Assume that any two organisms can mate

<b>Sample Dataset:</b><br>
2 2 2<br>

<b>Sample Output</b><br>
0.78333

----------------------------------------------------------------------
Overlap Graphs (GRPH.py) <br><br>

Given: A collection of DNA strings in Fasta format having total length at most 10 kbp<br>

Return: The adjacency list corresponding to O<sub>3</sub>. You may return edges in any order<br>

<b>Sample Dataset:</b><br>
\>Rosalind_0498<br>
AAATAAA<br>
\>Rosalind_2391<br>
AAATTTT<br>
\>Rosalind_2323<br>
TTTTCCC<br>
\>Rosalind_0442<br>
AAATCCC<br>
\>Rosalind_5013<br>
GGGTGGG<br>

<b>Sample Output:</b><br>
Rosalind_0498 Rosalind_2391<br>
Rosalind_0498 Rosalind_0442<br>
Rosalind_2391 Rosalind_2323<br>

--------------------------------------------------------------------------

Locating Restriction Sites (REVP.py) <br><br>

Given: A DNA string of length at most 1 kbp in FATSA format<br>
Return: the position and length of every reverse palindrome in the string having length between 4 and 12. You may return these pairs in any order<br>

<b>Sample Dataset:</b><br>
\>Rosalind_24 <br>
TCAATGCATGCATGCGGGTCTATATGCAT<br>

<b> Sample Output:</b><br>
4  6<br>
5  4<br>
6  6<br>
7  4<br>
17  4<br>
18  4<br>
20  6<br>
21  4<br>

---------------------------------------------------------------------

Calculating Protein Mass (PRTM.py) <br><br>

Given: A protein string P of length at most 1000 aa <br>
Return: the total weight of P. Consult the monoisoptic mass table<br>

<b>Sample Dataset:</b><br>
SKADYEK<br>

<b>Sample Output:</b><br>
821.392 <br>

---------------------------------------------------------------------

Enumerating Gene orders (PERM.py) <br><br>

Given: A positive integer n <=7
Return: the total number of permutations of length n, followed by a list of all such permutations (in any order).

<b>Sample Dataset:</b><br>
3 <br>

<b>Sample Output:</b><br>
6<br> 1 2 3<br>
1 3 2<br>
2 1 3<br>
2 3 1<br>
3 1 2<br>
3 2 1<br>
