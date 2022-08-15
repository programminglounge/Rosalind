def findstring(strings):
  common_dnas = []
  common_dnas_copy = []
  strings_copy = []
  results = []
  for i in range(len(strings)):
    for j in range(i+1, len(strings)):
      match = SequenceMatcher(None, strings[i], strings[j]).find_longest_match()
      substr = strings[i][match.a:match.a+match.size]
      common_dnas.append([substr, i, j, match.a, match.b])
  common_dnas.sort(key = lambda x: len(x[0]), reverse = True)
  for i in range(len(common_dnas)):
    strings_copy.append(strings[i])
  if (len(strings) == 1 and len(common_dnas) == 0):
    return strings[0]
  else:
    for i in range(len(common_dnas)):
      if (common_dnas[i][3] == 0):
        x1 = strings[common_dnas[i][2]]
        l1 = common_dnas[i][3] + len(common_dnas[i][0])
        x = strings[common_dnas[i][2]] + strings[common_dnas[i][1]][l1:]
        strings.remove(strings[common_dnas[i][1]])
        strings.remove(strings[common_dnas[i][2]-1])
        strings.append(x)
        result = findstring(strings)
        results.append(result)
        common_dnas.clear()
        strings.clear()
        for j in range(len(common_dnas_copy)):
          common_dnas.append(common_dnas_copy[j])
        for j in range(len(strings_copy)):
          strings.append(strings_copy[j])
      if (common_dnas[i][4] == 0):
        x1 = strings[common_dnas[i][1]]
        l1 = common_dnas[i][4] + len(common_dnas[i][0])
        x = strings[common_dnas[i][4]] + strings[common_dnas[i][2]][l1:]
        strings.remove(strings[common_dnas[i][1]])
        strings.remove(strings[common_dnas[i][2]-1])
        strings.append(x)
        result = findstring(strings)
        results.append(result)
        common_dnas.clear()
        strings.clear()
        for j in range(len(common_dnas_copy)):
          common_dnas.append(common_dnas_copy[j])
        for j in range(len(strings_copy)):
          strings.append(strings_copy[j])
  results.sort(key = lambda x:len(x[0]))
  return results[0]
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
    
x = findstring (strings)
print(x)

#R1
#ATTAGACCTG
#R2
#CCTGCCGGAA
#R3
#AGACCTGCCG
#R4
#GCCGGAATAC
