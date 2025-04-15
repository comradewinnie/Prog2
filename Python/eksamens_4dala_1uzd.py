import requests
import json

result = requests.get("http://universities.hipolabs.com/search?country=latvia")
universities = json.loads(result.content)

uni_names = []
for uni in universities:
    uni_names.append(uni['name'])

uni_names.sort()

for uni in uni_names:
    print(uni)
