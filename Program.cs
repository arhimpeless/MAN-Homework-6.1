namespace Задание_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение.");
            string maneString = string.Empty;
            string numberString = string.Empty;
            string searchString = string.Empty;
            maneString = Console.ReadLine();
            //Console.WriteLine(maneString);
            Console.WriteLine("Введите число символов.");  //цикл с заданием количества
            numberString = Console.ReadLine();
            //Console.WriteLine(numberString);
            Console.WriteLine("Введите символы для поиска.");   //цикл с заданием кол-ва на основе numberString
            searchString = Console.ReadLine();
            //Console.WriteLine(searchString);
            //Console.WriteLine("Количество символов " + searchString + ": ");
            char searchString2 = Convert.ToChar(searchString);
            Dictionary<char, int> symbols = new Dictionary<char, int>();    //добавить в словарь уже введённые searchString2
            for (int i = 0; i < maneString.Length; i++)
            {
                ICollection<char> keys = symbols.Keys;
                bool b = true;
                foreach (char searchString3 in keys)
                {
                    if (maneString[i] == searchString3)
                    {
                        b = false;
                    }
                }
                //if (b)
                //{
                //    symbols.Add(maneString[i], 1);
                //}
                int countSmbls = 0;
                foreach (char searchString3 in keys)
                {
                    countSmbls = symbols[searchString3];

                }
                countSmbls = countSmbls + 1;
                symbols.Remove(maneString[i]);  //удаление ключа??
            }
            ICollection<char> k = symbols.Keys;
            Console.Write("Итоговый результат: ");
            foreach (char searchString3 in k)
            {
                Console.WriteLine(searchString.ToString() + " - " + symbols[searchString3].ToString());   //вывод на экран символа и его количество
            }
            //Console.WriteLine(searchString.Where(countSymbols => searchString.IndexOf(countSymbols) != +1).Count());

            //bool isContains = maneString.Contains(searchString);
            //Console.WriteLine(maneString);
            Console.ReadKey();
        }
    }
}