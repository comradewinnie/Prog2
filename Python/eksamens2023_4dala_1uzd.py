import requests
import sys

# 1.uzd.
response = requests.get('https://data.gov.lv/dati/lv/api/3/action/datastore_search?resource_id=92ac6e57-c5a5-444e-aaca-ae90c120cc3d')

# 2. un 3.uzd.
if response.status_code != 200:
  print('Nav izdevies saņemt atbildi')
  sys.exit()

json_data = response.json()

# 4.uzd.
if not json_data:
  print('Atbilde ir tukša')
  sys.exit()

baterijas = []
riepas = []
metals = []

atkritumu_punkti = json_data['result']['records']
for punkts in atkritumu_punkti:
  if punkts['8 : Baterijas un akumulatori'] == "x":
    baterijas.append(punkts)

  if punkts['10 : Nolietotās riepas'] == 'x':
    riepas.append(punkts)

  if punkts['3 : Metāls'] == 'x':
    metals.append(punkts)

# 5. un 6.uzd.
print('Baterijas un akumulatori:')
for punkts in baterijas:
  print(f"{punkts['pilsetanovads']}, {punkts['adrese']}")
# 7. un 8.uzd.
print('Riepas:')
for punkts in riepas:
  print(f"{punkts['pilsetanovads']}, {punkts['adrese']}")
# 9. un 10.uzd.
print('Metāls:')
for punkts in metals:
  print(f"{punkts['pilsetanovads']}, {punkts['adrese']}")
