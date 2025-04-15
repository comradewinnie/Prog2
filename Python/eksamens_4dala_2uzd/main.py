from string import punctuation

text = ''

with open('text.txt', 'r', encoding='utf8') as file:
    text = file.read()
    
text = text.lower()

for character in punctuation:
    text = text.replace(character, '')

words = text.split(' ')

word_count = {}
for word in words:
    if len(word) < 4:
        continue

    word_count[word] = words.count(word)
    
sorted_words = sorted(word_count, key=word_count.get, reverse=True)
top_5 = sorted_words[:5]

for word in top_5:
    print(f"{word}: {word_count[word]}")