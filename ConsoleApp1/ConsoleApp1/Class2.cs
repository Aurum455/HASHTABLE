using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {

            var hashTable = new HashTable();

            hashTable.Insert("1", "плотину надо поднять рычагом я его дам канал нужно завалить камнем камень я не дам");
            hashTable.Insert("2", "не 21 обычно губит а к 11 туз");
            hashTable.Insert("3", "ПРОСЛУШКА В СТУЛЕ, УХОДИ БЛИЗАРД УХОДИ *ЗВУКИ УДАРА* ");
            hashTable.Insert("4", "BloodTrail ОПЯТЬ НОЕТ BloodTrail СИДИТ - НОЕТ BloodTrail ВЫИГРЫВАЕТ - НОЕТ BloodTrail ПРОИГРЫВАЕТ - НОЕТ BloodTrail НА КОМАНДУ НОЕТ BloodTrail НА ЧАТ НОЕТ BloodTrail НА ДОНАТЕРОВ НОЕТ BloodTrail НЕ НОЕТ - НОЕТ BloodTrail НОЕТ - НОЕТ BloodTrail");


            ShowHashTable(hashTable, "Created hashtable.");
            Console.ReadLine();

  
            Console.WriteLine("Саша Камень говорит:");
            var text1 = hashTable.Search("1");
            Console.WriteLine(text1);
            Console.ReadLine();

            Console.WriteLine("Леха Гранит говорит:");
            var text2 = hashTable.Search("2");
            Console.WriteLine(text2);
            Console.ReadLine();

            Console.WriteLine("Свинотов Влад говорит:");
            var text3 = hashTable.Search("3");
            Console.WriteLine(text3);
            Console.ReadLine();

            Console.WriteLine("Лена Головач говорит:");
            var text4 = hashTable.Search("4");
            Console.WriteLine(text4);
            Console.ReadLine();
        }

      
        private static void ShowHashTable(HashTable hashTable, string title)
        {
      
            if (hashTable == null)
            {
                throw new ArgumentNullException(nameof(hashTable));
            }

            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException(nameof(title));
            }

            Console.WriteLine(title);
            foreach (var item in hashTable.Items)
            {
           
                Console.WriteLine(item.Key);

         
                foreach (var value in item.Value)
                {
                    Console.WriteLine($"\t{value.Key} - {value.Value}");
                }
            }
            Console.WriteLine();
        }
    }
}