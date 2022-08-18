# Rosalind

In this repostory I solve the following problems from the Rosalind website using Python as the preferred language of choice but I also try to learn the limits of other languages like C# and C++.
<br><br>

<a href = #problemDNA> Counting DNA Nucleotids</a>

<a href = #problemRNA> Transcribing DNA into RNA</a>

<a href = #problemREVC> Complementing a Strand of DNA</a> 

<a href = #problemFIB> Rabbits and Recurring Relations</a> 

<a href = #problemGC> Computing GC Content</a>

<a href = #problemHAMM> Counting Point Mutations</a> 

<a href = #problemIPRB> Mendel's First Law </a>

<a href = #problemPROT>Translating RNA into Protein</a>

<a href = #problemSUBS>Finding a Motif in DNA</a>

<a href = #problemCONS> Consensus and Profile</a>

<a href = #problemFIBD> Mortal Fibonacci Rabbits</a>

<a href = #problemGRPH> Overlap Graphs </a>

<a href = #problemIEV> Calculating Expected Offspring</a> 

<a href = #problemLCSM> Finding a Shared Motif</a> 

<a href = #problemLIA> Independent Alleles</a>

<a href = #problemMPRT> Finding a Protein Motif</a>

<a href = #problemMRNA> Inferring mRNA from Protein</a>

<a href = #problemORF>Open Reading Frames </a> 

<a href = #problemPERM>Enumerating Gene orders </a> 

<a href = #problemPRTM> Calculating Protein Mass</a>

<a href = #problemREVP>Locating Restriction Sites</a>

<a href = #problemSPLC>RNA Splicing</a>

<a href = #problemLGIS> Longest Increasing Subsequence</a>

<a href = #problemLONG> Genome Assembly as Shortest Superstring</a>

<a href = #problemPPER> Partial Permutation</a>

<a href = #problemSSEQ> Finding a Spliced Motif</a> 

<a href = #problemTRAN> Transitions and Transversions</a>

<a href = #problemCORR> Error Correction in Reads</a>

<a href = #problemKMER> k-Mer Composition</a>

<a href = #problemSETO> Introduction to Set Operations</a>


----------------------

<a href = #problemINI> Introduction to the Bioinformatics Armory</a>

<a href = #problemGBK> GenBank Introduction</a>

<a href = #problemFRMT> Data Formats</a>

<a href = #problemNEED> Pairwise Global Alignment</a>

-------------------------------------------------------------------

<a id = "problemDNA"> Counting DNA Nucleotids</a> <br><br>

Given: A DNA string s of length at most 1000 nt <br>
Return: Four integers (seperated by spaces) counting the respective number of times that the symbols 'A', 'C', 'G' and 'T' occur in s

<b>Sample Dataset:</b><br>
AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC

<b>Sample Output:</b> <br>
20 12 17 21

<p><a href = "DNA.py"> Solution in Python </a></p>
<p><a href = "DNA.cs"> Solution in C# </a></p>
<p><a href = "DNA.cpp"> Solution in C++ </a></p>

---------------------------------------------------------------------

<a id = "problemRNA">Transcribing DNA into RNA</a><br><br>

Given: a DNA string t having length at most 1000 nt<br> 
Return: the transcribed RNA string of t<br><br>

<b>Sample Dataset:</b><br>
GATGGAACTTGACTACGTAAATT<br><br>

<b>Sample Output:</b><br>
GAUGGAACUUGACUACGUAAAUU<br>

<p><a href = "RNA.py"> Solution in Python </a></p>
<p><a href = "RNA.cpp"> Solution in C++ </a></p>
<p><a href = "RNA.cs"> Solution in C# </a></p>

--------------------------------------------------------------------

<a id = "problemREVC">Complementing a Strand of DNA</a> <br><br>

Given: A DNA string s of length at most 1000 bp <br>
Return: The reverse complement s<sup>c</sup> of s <br><br>

<b>Sample Dataset:</b><br>
AAAACCCGGT<br><br>

<b>Sample Output:</b><br>
ACCGGGTTTT<br>

<p><a href = "REVC.py"> Solution in Python </a></p>
<p><a href = "REVC.cpp"> Solution in C++ </a></p>
<p><a href = "REVC.cs"> Solution in C# </a></p>

----------------------------------------------------------------------------

<a id = "problemFIB"> Rabbits and Recurring Relations</a> <br><br>

Given: positive integers n <=40 and k<=5 <br>
Return: the total number of rabbit pairs that will be presented after n months, if we begin with 1 pair and in each generation, every pair of reproduction-age rabbits produces a litter of k rabbit pairs (instead of only 1 pair) <br><br>

<b>Sample Dataset:</b><br>
5, 3<br>

<b>Sample Output:</b><br> 
19<br>

<p><a href = "FIB.py"> Solution in Python </a></p>
<p><a href = "FIB.cpp"> Solution in C++ </a></p>
<p><a href = "FIB.cs"> Solution in C# </a></p>

-------------------------------------------------------------------------

<a id = "problemGC"> Computing GC Content</a> <br><br>

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

<p><a href = "GC.py"> Solution in Python </a></p>
<p><a href = "GC.cpp"> Solution in C++ </a></p>
<p><a href = "GC.cs"> Solution in C# </a></p>

---------------------------------------------------------------------

<a id = "problemHAMM"> Counting Point Mutations</a> <br><br>

Given: Two DNA strings s and t of equal length (not exceeding 1 kbp)<br>
Return: The Hamming distance d<sub>H</sub>(s, t)<br>

<b>Sample Dataset</b><br>

GAGCCTACTAACGGGAT<br>
CATCGTAATGACGGCCT<br>

<b>Sample Output:</b><br>
7

<p><a href = "HAMM.py"> Solution in Python </a></p>
<p><a href = "HAMM.cpp"> Solution in C++ </a></p>
<p><a href = "HAMM.cs"> Solution in C# </a></p>

------------------------------

<a id = "problemIPRB"> Mendel's First Law </a><br><br>

Given: Three positive integers k, m, and n, representing a population containing k+m+n organisms: k individuals are homozygous dominant for a factor, m are heterozygous, and n are homozygous recessive

Return: The probability that two randomly selected mating organisms will produce an individual possessing a dominant allele. Assume that any two organisms can mate

<b>Sample Dataset:</b><br>
2 2 2<br>

<b>Sample Output</b><br>
0.78333

<p><a href = "IPRB.py"> Solution in Python </a></p>

----------------------------------------------------------------------

<a id = "problemPROT">Translating RNA into Protein</a><br><br>

Given: An RNA string s corresponding to a strand of mRNA (of length at most 10 kbp)<br>
Return: the proetein string encoded by s<br>

<b>Sample Dataset:</b><br>
AUGGCCAUGGCGCCCAGAACUGAGAUCAAUAGUACCCGUAUUAACGGGUGA<br>

<b>Sample Output:</b><br>
MAMAPRTEINSTRING<br>

<p><a href = "PROT.py"> Solution in Python </a></p>
<p><a href = "PROT.cpp"> Solution in C++ using map</a></p>
<p><a href = "PROT2.cpp"> Solution in C++ using vector of pairs </a></p>
<p><a href = "PROT3.cpp"> Solution in C++ using vector of pairs and binary search</a></p>
<p><a href = "PROT.cs"> Solution in C# </a></p>

-------------------------------------

<a id = "problemSUBS">Finding a Motif in DNA</a><br><br>

Given: Two DNA strings s and t (each of length at most 1 kbp)<br>
Return: All locations of t ass a substring of s.<br>

<b>Sample Dataset:</b><br>
GATATATGCATATACTT<br>
ATAT<br>

<b>Sample Output:</b><br>
2 4 10<br>

<p><a href = "SUBS.py"> Solution in Python </a></p>
<p><a href = "SUBS.cpp"> Solution in C++ </a></p>

------------------------------------------

<a id = "problemCONS"> Consensus and Profile</a><br><br>

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

<p><a href = "CONS.py"> Solution in Python </a></p>

-------------------------------------------

<a id = "problemFIBD"> Mortal Fibonacci Rabbits</a> <br><br>

Given: Positive integers n <= 100 and m <= 20 <br>
Return: the total number of pairs of rabbits that will remain after the n-th month if all rabbits live for m months <br>

<b>Sample Dataset:</b><br>
6 3<br>

<b>Sample Output:</b> <br>
4 <br>

<p><a href = "FIBD.py"> Solution in Python </a></p>

-------------------------------------------------

<a id = "problemGRPH"> Overlap Graphs </a><br><br>

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

<p><a href = "GRPH.py"> Solution in Python</a></p>

--------------------------------------------------------------------------

<a id = "problemIEV"> Calculating Expected Offspring</a> <br><br>

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

<p><a href = "IEV.py"> Solution in Python </a></p>
<p><a href = "IEV.cpp"> Solution in C++ </a></p>

-----------------------------------------------

<a id = "problemLCSM"> Finding a Shared Motif </a> <br><br>

Given: A collection of k (k <= 100) DNA strings of length at most 1 kbp each in FASTA format <br>

Return: A longest common substring of the collection. (If multiple solutions exist, you may return any single solution) <br>

<b>Sample Dataset:</b><br>
\>Rosalind_1<br>
GATTACA<br>
\>Rosalind_2<br>
TAGACCA<br>
\>Rosalind_3<br>
ATACA<br>

<b>Sample Output:</b> <br>
AC<br>

<p><a href = "LCSM.py"> Solution in Python </a></p>

------------------------------------------------------------------

<a id = "problemMPRT"> Finding a Protein Motif</a><br><br>

Given: at most 15 UniProt Protein Database access IDs <br>

Return: for each rpotein possessing the N-glycosylation motif (N{P}[ST]{P}) output its given access ID followed by a list of locations in the protein string where the motif can be found. <br>

<b>Sample Dataset:</b><br>
A2Z669<br>
B5ZC00<br>
P07204_TRBM_HUMAN<br>
P20840_SAG1_YEAST<br><br>

<b>Sample Output:</b><br>
B5ZC00<br>
85 118 142 306 395<br>
P07204_TRBM_HUMAN<br>
47 115 116 382 409<br>
P20840_SAG1_YEAST<br>
79 109 135 248 306 348 364 402 485 501 614<br>

<p><a href = "MPRT.py">Solution in Python</a></p>

----------------------------------------------------

<a id = "problemMRNA"> Inferring mRNA from Protein</a> <br><br>

Given: protein string of length at most 1000 aa <br>

Return: The total number of different RNA strings from which the protein could have been translated, module 1000000 (Don't neglect the importance of the stop codon in protein translation.) <br>

<b>Sample Dataset:</b><br>
MA <br>

<b>Sample Output:</b><br>
12 <br>

<p><a href = "MRNA.py">Solution in Python</a></p>
<p><a href = "MRNA.cpp">Solution in C++ with switch</a></p>
<p><a href = "MRNA2.cpp">Solution in C++ with map</a></p>
<p><a href = "MRNA3.cpp">Solution in C++ with vector of pair</a></p>
<p><a href = "MRNA.cs">Solution in C# with list of tuples</a></p>
<p><a href = "MRNA2.cs">Solution in C# with list of tuples and binary search</a></p>
<p><a href = "MRNA3.cs">Solution in C# with array</a></p>
<p><a href = "MRNA4.cs">Solution in C# with switch</a></p>
<p><a href = "MRNA5.cs">Solution in C# with dictionary</a></p>

-----------------------------------------------------  

<a id = "problemORF"> Open Reading Frames </a> <br><br>

Given: A DNA string s of length at most 1 kbp in FASTA format <br>

Return: Every distinct candidate protein string that can be translated from ORFs of s. Strings can be returned in any order. <br>
  
<b>Sample Dataset:</b><br>
\>Rosalind_99<br>
AGCCATGTAGCTAACTCAGGTTACATGGGGATGACCCCGCGACTTGGATTAGAGTCTCTTTTGGAATAAGCCTGAATGATCCGAGTAGCATCTCAG<br>


<b>Sample Output:</b> <br>
MLLGSFRLIPKETLIQVAGSSPCNLS<br>
M<br>
MGMTPRLGLESLLE<br>
MTPRLGLESLLE<br>

-------------------------------------------------------------------

<a id = "problemPERM">Enumerating Gene orders </a> <br><br>

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

<p><a href = "PERM.py">Solution in Python</a></p>

------------------------------------------------------------------

<a id = "problemPRTM"> Calculating Protein Mass</a><br><br>

Given: A protein string P of length at most 1000 aa <br>
Return: the total weight of P. Consult the monoisoptic mass table<br>

<b>Sample Dataset:</b><br>
SKADYEK<br>

<b>Sample Output:</b><br>
821.392 <br>

<p><a href = "PRTM.py">Solution in Python</a></p>
<p><a href = "PRTM.cpp">Solution in C++ using array</a></p>
<p><a href = "PRTM2.cpp">Solution in C++ using map</a></p>
<p><a href = "PRTM3.cpp">Solution in C++ using vector of pair</a></p>
<p><a href = "PRTM4.cpp">Solution in C++ using switch</a></p>  

---------------------------------------------------------------------

<a id = "problemREVP">Locating Restriction Sites</a><br><br>

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

<p><a href = "REVP.py">Solution in Python</a></p>

---------------------------------------------------------------------

<a id = "problemSPLC"> RNA Splicing </a> <br><br>

Given: A DNA string s (of length at most 1 kbp) and a collection of substrings of s acting as introns. All strings are given in FASTA format <br>
Return: A protein string resulting and translating the exons of s (Note: Only one solution will exist for the dataset provided.) <br>

<b>Sample Dataset:</b><br>
\>Rosalind_10<br>
ATGGTCTACATAGCTGACAAACAGCACGTAGCAATCGGTCGAATCTCGAGAGGCATATGGTCACATGATCGGTCGAGCGTGTTTCAAAGTTTGCGCCTAG<br>
\>Rosalind_12<br>
ATCGGTCGAA<br>
\>Rosalind_5<br>
ATCGGTCGAGCGTGT<br>

<b>Sample Output:</b> <br>
MVYIADKQHVASREAYGHMFKVCA<br>

<p><a href = "SPLC.py"> Solution in Python </a></p>

------------------------------------------------------------------


<a id = "problemLGIS"> Longest Increasing Subsequence</a><br><br>

Given: A positive integer n <= 10000 followed by a permutation p of length n. <br>

Return: A longest increasing subsequence of p, followed by a longest decreasing subsequence of p. <br>

<b>Sample Dataset:</b><br>
5<br>
5 1 4 2 3<br>

<b>Sample Output:</b><br>
1 2 3<br>
5 4 2<br>

<p><a href = "LGIS.cs">Solution in C#</a></p>
<p><a href = "LGIS.cpp">Solution in C++</a></p>

------------------------------------------------------------------------

<a id = "problemLONG"> Genome Assembly as Shortest Superstring</a><br><br>

Given: At most 50 DNA strings of approximately equal length, not exceeding 1 kbp, in FASTA format (which represents reads deriving from the same strand of a single linear chromosome).

The dataset is guaranteed to satisfy the following condition: the exists a unique way to reconstruct the entire chromosome from these reads by gluing together pairs of reads that overlap by more than half their length. <br>

Return: A shortest superstring containing all the given strings (thus corresponding to a reconstructed chromosome). <br>


<b>Sample Dataset:</b><br>
\>Rosalind_56 <br>
ATTAGACCTG <br>
\>Rosalind_57 <br>
CCTGCCGGAA <br>
\>Rosalind_58 <br>
AGACCTGCCG <br>
\>Rosalind_59 <br>
GCCGGAATAC <br>

<b>Sample Output:</b><br>
ATTAGACCTGCCGGAATAC<br>

<p><a href = "LONG.py">Solution in Python</a></p>
<p><a href = "LONG.cs">Solution in C#</a></p>
<p><a href = "LONG.cpp">Solution in C++</a></p>

--------------------------------------------------------------------

<a id = "problemPPER"> Partial Permutation</a><br><br>

Given: positive integers n and k such that 100>=n>0 and 10>=k>0<br>

Return: the total number of partial permutations P(n, k) modulo 1000000 <br>

<b>Sample Dataset:</b><br>
21  7<br>

<b>Sample Output: </b><br>
51200<br>

<p><a href = "PPER.py">Solution in Python</a></p>
<p><a href = "PPER.cpp">Solution in C++</a></p>

----------------------------------------------------------

<a id = "problemSSEQ"> Finding a Spliced Motif</a> <br><br>

Given: Two DNA strings s and t (each of length at most 1 kbp) in FASTA format<br>
Return: one collection of indices of s in which the symbols of t appear as a subsequence of s. If multiple solutions exist,
you may return any one.<br>

<b>Sample Dataset:</b><br>
\>Rosalind_14<br>
ACGTACGTGACG<br>
\>Rosalind_18<br>
GTA<br>

<b>Sample Output:</b><br>
3  8  10

<p><a href = "SSEQ.py">Solution in Python</a></p>

---------------------------------------------------------------

<a id = "problemTRAN"> Transitions and Transversions</a><br><br>

Given: Two DNA strings s<sub>s</sub> and s<sub>2</sub> of equal length (at most 1 kbp).<br><br>

Return: The transition/transversion ratio R(s<sub>1</sub>, s<sub>2</sub>).<br><br>

<b>Sample Dataset:</b><br>
\>Rosalind_0209<br>
GCAACGCACAACGAAAACCCTTAGGGACTGGATTATTTCGTGATCGTTGTAGTTATTGGAAGTACGGGCATCAACCCAGTT<br>
\>Rosalind_2200<br>
TTATCTGACAAAGAAAGCCGTCAACGGCTGGATAATTTCGCGATCGTGCTGGTTACTGGCGGTACGAGTGTTCCTTTGGGT</br>

<b>Sample Output</b><br>
1.21428571429 <br>

<p><a href = "TRAN.py">Solution in Python</a></p>
<p><a href = "TRAN.cpp">Solution in Python</a></p>

----------------------------------------------------

<a id = "problemKMER"> k-Mer Composition</a><br><br>

Given: A DNA string s in FASTA format (having length at most 100 kbp)

Return: the 4-mer composition of S

<b>Sample Dataset:</b><br>
CTTCGAAAGTTTGGGCCGAGTCTTACAGTCGGTCTTGAAGCAAAGTAACGAACTCCACGG<br>
CCCTGACTACCGAACCAGTTGTGAGTACTCAACTGGGTGAGAGTGCAGTCCCTATTGAGT<br>
TTCCGAGACTCACCGGGATTTTCGATCCAGCCTGAGTCCAGTCTTGTGGCCAACTCACCA<br>
AATGACGTTGGAATATCCCTGTCTAGCTCACGCAGTACTTAGTAAGAGGTCGCTGCAGCG<br>
GGGCAAGGAGATCGGAAAATGTGCTCTATATGCGACTAAAGCTCCTAACTTACACGTAGA<br>
CTTGCCCGTGTTAAAAACTCGGCTCACATGCTGTCTGCGGCTGGCTGTATACAGTATCTA<br>
CCTAATACCCTTCAGTTCGCCGCACAAAAGCTGGGAGTTACCGCGGAAATCACAG<br>

<b>Sample Output:</b><br>
4 1 4 3 0 1 1 5 1 3 1 2 2 1 2 0 1 1 3 1 2 1 3 1 1 1 1 2 2 5 1 3 0 2 2 1 1 1 1 3 1 0 0 1 5 5 1 5 0 2 0 2 1 2 1 1 1 2 0 1 0 0 1 1 3 2 <br>
1 0 3 2 3 0 0 2 0 8 0 0 1 0 2 1 3 0 0 0 1 4 3 2 1 1 3 1 2 1 3 1 2 1 2 1 1 1 2 3 2 1 1 0 1 1 3 2 1 2 6 2 1 1 1 2 3 3 3 2 3 0 3 2 1 1 <br>
0 0 1 4 3 0 1 5 0 2 0 1 2 1 3 0 1 2 2 1 1 0 3 0 0 4 5 0 3 0 2 1 1 3 0 3 2 2 1 1 0 2 1 0 2 2 1 2 0 2 2 5 2 2 1 1 2 1 2 2 2 2 1 1 3 4 <br>
0 2 1 1 0 1 2 2 1 1 1 5 2 0 3 2 1 1 2 2 3 0 3 0 1 3 1 2 3 0 2 1 2 2 1 2 3 0 1 2 3 1 1 3 1 0 1 1 3 0 2 1 2 2 0 2 1 1 <br>

<p><a href = "KMER.py">Solution in Python</a></p>

----------------------------------------------------------------------------------

<a id = "problemCORR">Error Correction in Reads</a> <br><br>

Given: A collection of up to 1000 reads of equal length (at most 50 bp) in FASTA format. Some of these reads were generated with a single-nucleotide error. For each read s in the dataset, one of the following applies
<ul><li> s was correctly sequenced and appears in the dataset at least twice (possibly as a reverse complement)</li>
<li> s is incorrect, it appears in the dataset exactly once, and its hamming distance is 1 with respect to exactly one correct read in the dataset (or its reverse complement)</li></ul> <br>

Return: A list of all corrections in the form "[old read]->[new read]". (Each correction must be a single symbol substitution and you may return the corrections in any order.)

<b>Sample Dataset:</b><br>
\>Rosalind_52 <br>
TCATC <br>
\>Rosalind_44 <br>
TTCAT <br>
\>Rosalind_68 <br>
TCATC <br>
\>Rosalind_28 <br>
TGAAA <br>
\>Rosalind_95 <br>
GAGGA <br>
\>Rosalind_66 <br>
TTTCA <br>
\>Rosalind_33 <br>
ATCAA <br>
\>Rosalind_21 <br>
TTGAT <br>
\>Rosalind_18 <br>
TTTCC <br>

<b>Sample Output:</b><br>
TTCAT->TTGAT<br>
GAGGA->GATGA<br>
TTTCC->TTTCA<br>

<p><a href = "CORR.py">Solution in python</a></p>

------------------------------------------------------------------------

<a id = "problemLIA"> Indepedent Alleles </a> <br><br>

Given: Two positive integers k (k<=7) and N (N <= 2<sup>k</sup). In this problem , we begin with Tom, who in the 0th generation has genotype AaBb Tom has two children in the 1st generation, each of whom has two children, and so on. Each organism always mates with an organism having genotype AaBb <br>
  
Return: The probability that at least N AaBb organisms will belong to the k-th generation of Tom's family tree (don't count AaBb mates at each level). Assume that Mendel's second law holds for the factors. <br>

<b>Sample Dataset:</b><br>
2  1<br>
<b>Sample Output:</b> <br>
0.684 <br>
  
-------------------------------------------------------------------

<a id = "problemINI"> Introduction to the Bioinformatics Armory</a><br><br>

Given: A DNA string s of length at most 1000 nt <br>
Return: Four integers (seperated by spaces) counting the respective number of times that the symbols 'A', 'C', 'G' and 'T' occur in s

<b>Sample Dataset:</b><br>
AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC<br>

<b>Sample Output:</b> <br>
20 12 17 21<br>

<p><a href = "INI.py">Solution in Python</a></p>

-----------------------------------------------------------------------------------------

<a id = "problemGBK"> GenBank Introduction</a><br><br>

Given: A genus name, followed by two dates in YYYY/M/D format <br>
Return: The number of Nucleotide Genbank entries for the given genus that were published between the dates specified<br>

<b>Sample Dataset:</b><br>
Anthoxantum<br>
2003/7/25<br>
2005/12/27 <br>

<b>Sample Output:</b><br>
7<br>

<p><a href = "GBK.py">Solution in Python</a></p>

------------------------------------------------------------------------------

<a id = "problemFRMT"> Data Formats</a><br><br>

Given: A collection of n (n <= 10) GenBank entry IDs<br>
Return: The shortest of the strings associated with the IDs in FASTA Format.<br>

<b>Sample Dataset:</b><br>
FJ817486 JX069768 JX469983<br>

<b>Sample Output:</b><br>
\>JX469983.1 Zea mays subsp. mays clone UT3343 G2-like transcription factor mRNA, partial cds
ATGATGTATCATGCGAAGAATTTTTCTGTGCCCTTTGCTCCGCAGAGGGCACAGGATAATGAGCATGCAA
GTAATATTGGAGGTATTGGTGGACCCAACATAAGCAACCCTGCTAATCCTGTAGGAAGTGGGAAACAACG
GCTACGGTGGACATCGGATCTTCATAATCGCTTTGTGGATGCCATCGCCCAGCTTGGTGGACCAGACAGA
GCTACACCTAAAGGGGTTCTCACTGTGATGGGTGTACCAGGGATCACAATTTATCATGTGAAGAGCCATC
TGCAGAAGTATCGCCTTGCAAAGTATATACCCGACTCTCCTGCTGAAGGTTCCAAGGACGAAAAGAAAGA
TTCGAGTGATTCCCTCTCGAACACGGATTCGGCACCAGGATTGCAAATCAATGAGGCACTAAAGATGCAA
ATGGAGGTTCAGAAGCGACTACATGAGCAACTCGAGGTTCAAAGACAACTGCAACTAAGAATTGAAGCAC
AAGGAAGATACTTGCAGATGATCATTGAGGAGCAACAAAAGCTTGGTGGATCAATTAAGGCTTCTGAGGA
TCAGAAGCTTTCTGATTCACCTCCAAGCTTAGATGACTACCCAGAGAGCATGCAACCTTCTCCCAAGAAA
CCAAGGATAGACGCATTATCACCAGATTCAGAGCGCGATACAACACAACCTGAATTCGAATCCCATTTGA
TCGGTCCGTGGGATCACGGCATTGCATTCCCAGTGGAGGAGTTCAAAGCAGGCCCTGCTATGAGCAAGTC
A

<p><a href = "FRMT.py">Solution in Python</a></p>

-----------------------------------------------------------------------------

<a id = "problemNEED"> Pairwise Global Alignment</a><br><br>

Given: Two GenBank IDs

Return: The maximum global alignment score between the DNA strings associated with these IDs

<b>Sample Dataset:</b><br>
JX205496.1 JX469991.1<br>

<b>Sample Output</b><br>
257<br>

<p><a href = "NEED.py">Solution in Python</a></p>

----------------------------------------------------------------

<a id = "problemSETO"> Introduction to Set Operations</a><br><br>

Given: A positive integer n (n <=20000) and two subsets A and B of {1, 2, ... n} <br>

Return : Six sets A &cup B, A &cap; &#8745; &#x2229;  B, A - B, B - A, A' and B'(where set complements are taken with respect to {1, 2, ..., n} <br>

<b>Sample Dataset:</b><br>
10<br>
{1, 2, 3, 4, 5}<br>
{2, 8, 5, 10}<br>

<b>Sample Output:</b><br>
{1, 2, 3, 4, 5, 8, 10}<br>
{2, 5}<br>
{1, 3, 4}<br>
{8, 10}<br>
{8, 9, 10, 6, 7}<br>
{1, 3, 4, 6, 7, 9}<br>

<p><a href = "SETO.cs">Solution in C# using list of hashset </a></p>
<p><a href = "SETO2.cs">Solution in C# using list of sortedset</a></p>
<p><a href = "SETO3.cs">Solution in C# using list of IEnumerable</a></p>
<p><a href = "SETO4.cs">Solution in C# using lost of sortedset and By</a></p>
<p><a href = "SETO.py">Solution in Python using sets</a></p>
<p><a href = "SETO2.py">Solution in Python using lists </a></p>
<p><a href = "SETO.cpp">Solution in C++</a></p>

-------------------------------------------------------------------

<a id = "problemSPEC"> Inferring Protein from Spectrum</a><br><br>

Given: A list L of n (n <= 100) positive real numbers. <br>

Return: A protein string of length n-1 whose prefix spectrum is equal to L (if multiple solutions exist, you may output any of them). 

<b>Sample Dataset:</b><br>
3524.8542<br>
3710.9335<br>
3841.974<br>
3970.0326<br>
4057.0646<br>

<b>Sample Output:</b><br>
WMQS<br>

<p><a href = "SPEC.cs">Solution in C# using Dictionary</a></p>
<p><a href = "SPEC2.cs">Solution in C# using Dictionary and all combos</a></p>
<p><a href = "SPEC3.cs">Solution in C# using List of Tuples</a></p>

-------------------------------------------------------------
