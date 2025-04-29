class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string alphabet = "_AĀBCČDEĒFGĢHIĪJKĶLĻMNŅOPRSŠTUŪVZŽ";
        string[] words = new string[alphabet.Length];

        while (words.Any(i => i == null))
        {
            Console.Write("Ievadiet vārdu: ");
            string word = Console.ReadLine();

            while (!IsWordValid(word))
            {
                Console.WriteLine("Ievadītais vārds nav derīgs!");
                Console.Write("Ievadiet vārdu: ");
                word = Console.ReadLine();
            }

            char firstLetter = word[0];
            int letterIndex = alphabet.IndexOf(firstLetter);

            words[letterIndex] = word;
            Console.WriteLine($"Pievienoju vārdu {letterIndex}. vietā");
        }
    }

    static bool IsWordValid(string word)
    {
        return word.Length > 1 &&
            Char.IsUpper(word[0]) &&
            word.Skip(1).All(char.IsLower) &&
            word.All(char.IsLetter);
    }
}