using HashTable;

namespace HashTables
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome tho the Hash Table");

            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words = paragraph.Split(' ');

            HashTable<string, int> frequency = new HashTable<string, int>(words.Length);

            foreach (string word in words)
            {
                int count = frequency.Get(word);
                if (count == default(int))
                {
                    count = 0;
                }
                frequency.Add(word, count + 1);
            }

            frequency.Display();
        }

    }
}