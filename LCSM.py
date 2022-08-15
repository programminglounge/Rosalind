from difflib import SequenceMatcher

strings = []
dna_name = ' '
dna_string = ' '

while (dna_name != ''):
  dna_name = input('Enter the name:\n')
  if (dna_name == ''):
    break
  else:
    dna_string = input('Enter the dna string:\n')
    strings.append(dna_string)

strings.sort(key = lambda x: len(x))
string1 = strings[0]
for i in range (1, len(strings)):
  string2 = strings[i]
  match = SequenceMatcher(None, string1, string2).find_longesr_match()
  string1 = string1[match.a:match.a+match.size]
  
print(string1)

#R1
#GATTACA
#R2
#TAGACCA
#R3
#ATACA
