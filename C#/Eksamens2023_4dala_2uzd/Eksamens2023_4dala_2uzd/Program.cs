class Program
{
    static void Main(string[] args)
    {
        string alphabet = "_AĀBCČDEĒFGĢHIĪJKĶLĻMNŅOPRSŠTUŪVZŽ";
        string[] words = new string[alphabet.Length];

        while (words.Any(x => x == null)) // пока какая-то позиция в words пустая, цикл работает
        {
            Console.WriteLine("Ievadiet vārdu:");
            string word = Console.ReadLine();

            while (!IsWordValid(word))
            {
                Console.WriteLine("Ievadītais vārds nav derīgs!");
                Console.WriteLine("Ievadiet vārdu:");
                word = Console.ReadLine();
            }

            char firstLetter = word[0];
            int letterIndex = alphabet.IndexOf(firstLetter);  // проверяет, на какой позиции в массиве алфавита находится буква, которая является первой буквой для введённого слова

            words[letterIndex] = word;
            Console.WriteLine($"Pievienoju vārdu {letterIndex}. vietā");
        } 
    }

    static bool IsWordValid(string word)
    {
        return word.Length > 1 &&
            Char.IsUpper(word[0]) &&   // заглавная ли первая буква
            word.Skip(1).All(char.IsLower) &&   // строчные ли все буквы, кроме первой
            word.All(char.IsLetter);    // все ли символы - буквы
    }
}