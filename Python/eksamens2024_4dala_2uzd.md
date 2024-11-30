https://skolo.lv/mod/book/view.php?id=83627824&chapterid=351661
```py
import requests
import sys

url = 'https://restcountries.com/v3.1/all' 

# 1.uzd. Pieprasījums uz API
response = requests.get(url) 

# 2.uzd. Pārbaudīt statusu
if response.status_code == 200:   
    print('OK')
else:
    print(f'Error code: {response.status_code}')
    sys.exit()

countries = response.json()

print("\nVisu valstu vispārpieņemtie nosaukumi:")
for country in countries:  # 3.uzd. Izvadīt visu valstu vispārpieņemtos nosaukumus 
        print(country['name']['common'])

total_countries = len(countries) # 4.uzd. Izvadīt kopējo valstu skaitu
print(f"\nKopējais valstu skaits: {total_countries}")

total_population = 0    # 5.uzd. Izvadīt visu valstu vidējo iedzīvotāju skaitu 
for country in countries:
     total_population += country['population']
print(f"\nVidējais iedzīvotāju skaits: {total_population/total_countries}")

populations = {}    # 6.uzd. Izvadīt valsti ar vislielāko iedzīvotāju skaitu.
for country in countries:
     populations.update({country['name']['common']: country['population']})
max_population = max(zip(populations.values(), populations.keys()))
print(f"\nValsts ar vislielāko iedzīvotāju skaitu: {max_population[1]}")

total_area = 0    # 7.uzd. Izvadīt visu valstu kopējo platību 
for country in countries:
     total_area += country['area']
print(f"\nValstu kopējā platība: {total_area}")

for country in countries:    # 8.uzd. Izvadīt informāciju par Latviju
    if country['name']['common'] == "Latvia":
        print(f"\nLatvijas apakšreģions: {country['subregion']}")
        print(f"Latvijas robežvalstu kodi: {country['borders']}")
```
