from Bio.Seq import Seq
from Bio import Entrez

def validate(date_text):
  try:
    datetime.datetime.strptime(date_text, '%Y/%m/%d')
    return True
  except ValueError:
    raise ValueError("Incorrect data format, should be YYYY/MM/DD")

def validate2(start_date_text, end_date_text):
  try:
    past = datetime.datetime.strptime(start_date_text, '%Y/%m/%d')
    past2 = datetime.datetime.strptime(end_date_text, '%Y/%m/%d')
    today_day = datetime.datetime.now()
    if (past.date() < present.date() and past2.date() < present.date() and past.date() < past2.date() ):
      return True
    else:
      return False
  except ValueError:
    raise ValueError("Incorrect data format, should be YYYY/MM/DD")

    
gene_name = input("Please enter the name of the Genus name:\n")
start_date = input("Please enter the start date using the format YYYY/M/D :\n")
end_date = input("Please enter the end date using the format YYYY/M/D :\n")
if (validate(start_date) and validate(end_date)):
  if (validate2(start_date, end_date)):
    search = f'({gene_name}[Organism]) AND ("{start_date}"[Publication Date]: "{end_date}"[Publication Date])'
    Entrez.email = "b@example.com"
    handle = Entrez.esearch(db="nucleotide", term = search)
    record = Entrez.read(handle)
    print(record["Count"])
  else:
    print("one of the dates specified is in the future or the end date is before the start date, please correct this and try again")
