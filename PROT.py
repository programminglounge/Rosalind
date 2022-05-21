def useF():
  return "F"

def useL():
  return "L"

def useS():
  return "S"

def useY():
  return "Y"

def useStop():
  return ""

def useC():
  return "C"

def useW():
  return "W"

def useP():
  return "P"

def useH():
  return "H"

def useQ():
  return "Q"

def useR():
  return "R"

def useM():
  return "M"

def useI():
  return "I"

def useI():
  return "T"

def useN():
  return "N"

def useK():
  return "K"

def useV():
  return "V"

def useA():
  return "A"

def useD():
  return "D"

def useE():
  return "E"

def useG():
  return "G"

#map the input to function
options = { "UUU" : useF, "UUC": useF, "UUA" : useL, "UUG": useL, "UCU":useS, "UCC":useS,
            "UCA" : useS, "UCG": useS, "UAU" : useY, "UAC": useY, "UAA":useStop, "UAG":useStop,
            "UGU" : useC, "UGC": useC, "UGA" : useStop, "UGG": useW,
           
           "CUU" : useL, "CUC": useL, "CUA" : useL, "CUG": useL, "CCU":useP, "CCC":useP,
            "CCA" : useP, "CCG": useP, "CAU" : useH, "CAC": useH, "CAA":useQ, "CAG":useQ,
            "CGU" : useR, "CGC": useR, "CGA" : useR, "CGG": useR,
           
            "AUU" : useI, "AUC": useI, "AUA" : useI, "AUG": useM, "ACU":useT, "ACC":useT,
            "ACA" : useT, "ACG": useT, "AAU" : useN, "AAC": useN, "AAA":useK, "AAG":useK,
            "AGU" : useS, "AGC": useS, "AGA" : useR, "AGG": useR,
           
            "GUU" : useV, "GUC": useV, "GUA" : useV, "GUG": useV, "GCU":useA, "GCC":useA,
            "GCA" : useA, "GCG": useA, "GAU" : useD, "GAC": useD, "GAA":useE, "GAG":useE,
            "GGU" : useG, "GGC": useG, "GGA" : useG, "GGG": useG,
          }
res = ""
seq = input("Please enter the sequence")
for i in range(0, len(seq), 3):
  subseq = seq[1:i+3]
  if (len(subseq)==3):
    x = options[subseq]()
    if (x== ""):
      break
    res = res + x;
  else:
    res = res + subseq
print (res)

#UUU F      CUU L   AUU I   GUU V
#UUC F      CUC L   AUC I   GUC V
#UUA L      CUA L   AUA I   GUA V
#UUG L      CUG L   AUG M   GUG V
#UCU S      CCU P   ACU T   GCU A
#UCC S      CCC P   ACC T   GCC A
#UCA S      CCA P   ACA T   GCA A
#UCG S      CCG P   ACG T   GCG A
#UAU Y      CAU H   AAU N   GAU D
#UAC Y      CAC H   AAC N   GAC D
#UAA Stop   CAA Q   AAA K   GAA E
#UAG Stop   CAG Q   AAG K   GAG E
#UGU C      CGU R   AGU S   GGU G
#UGC C      CGC R   AGC S   GGC G
#UGA Stop   CGA R   AGA R   GGA G
#UGG W      CGG R   AGG R   GGG G



