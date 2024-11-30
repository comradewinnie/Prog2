https://skolo.lv/mod/book/view.php?id=83627824&chapterid=351661

```py
import urllib.request
import csv

def print_csv_lines(csv_lines):
    for line in csv_lines:
        print(f'{line["TIPS"]};{line["NOSAUKUMS"]};{line["ADRESE"]}')

csv_link = 'https://download.cloudycdn.services/dlt/izm/media/7277008/31f0762/media?gdRTiocAUGynmaTsnjBSDT04-0nEQ5rxbMmJ-1nlHQ6Lp3_DeFfSCORqQhF5PfQzq5GazBT0qS8elim7aFc4YmsvRsSha24dmwSLz4A'
csv_filename = 'agenti.csv'

with urllib.request.urlopen(csv_link) as page:
    with open(csv_filename, 'wb') as file:
        file.write(page.read())

lines_2 = [] # Līnijas 2.uzdevumam

print("2.uzdevums:\n\n\n")

with open(csv_filename, 'r', encoding='utf-8') as file:
    csv_file = csv.DictReader(file, delimiter=';')
    for line in csv_file:
        if line['TIPS'] == 'Izglītības iestāde' or line['TIPS'] == 'Valsts iestāde':
            lines_2.append(line)
            print(f'{line["TIPS"]};{line["NOSAUKUMS"]};{line["ADRESE"]}')

print("\n\n\n")


lines_3 = [] # Līnijas 3.uzdevumam

print("3.uzdevums:\n\n\n")

for line in lines_2:
    city = line['ADRESE'].split(', ')[1]
    if city == 'Rīga':
        lines_3.append(line)
        print(f'{line["NOSAUKUMS"]};{line["ADRESE"]}')

print("\n\n\n")

print("4.uzdevums:\n\n\n")

lines_4 = sorted(lines_3, key=lambda x: x['NOSAUKUMS'].lower()) # Līnijas 4.uzdevumam
for line in lines_4:
    print(f'{line["NOSAUKUMS"]};{line["ADRESE"]}')
```
