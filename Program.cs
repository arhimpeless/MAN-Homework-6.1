namespace Задание_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение.");
            string maneString = string.Empty;
            int numberString = 0;
            maneString = Console.ReadLine().ToLower(); //вся строка в нижнем регистре

            Console.WriteLine("Введите число символов."); 
            numberString = int.Parse(Console.ReadLine());
            Dictionary<char, int> symbols = new Dictionary<char, int>();
            for (int i= 0; i< numberString; i++)
            {
                Console.Write($"Введите символ № {i + 1}: ");
                char newChar = Char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();
                if (!symbols.ContainsKey(newChar))
                {
                    symbols.Add(newChar, 0);
                    symbols.Add(newChar, 0);
                }
            }
            foreach (char ch in maneString)
            {
                if (symbols.ContainsKey(Char.ToLower(ch)) || symbols.ContainsKey(Char.ToUpper(ch)))
                 { 
                    symbols[ch]++;
                 }
            }
            foreach (var el in symbols)
            {
                Console.WriteLine($"Символ {el.Key} , в предложении встречается раз: {el.Value}.");
            }
            Console.ReadKey();
        }
    }
}