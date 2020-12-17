using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayExercises
{
    class Program
    {
        
        private static Dictionary<string, List <int> > programVocab = new Dictionary<string, List<int>>();
        private static void Add(string strKey, int index)
            
        {
            if (!programVocab.ContainsKey(strKey))
            {
                programVocab.Add(strKey, new List<int>());
            }
            
            
                programVocab[strKey].Add(index);
            

        }
      
        static void Main(string[] args)
        {
            


            for (int i = 0; i < 5; i++)
             
            {

                Console.Write($"Enter string {i}: ");

                string input = Console.ReadLine();
                

                Add(input, i);

                
            }

            foreach (var kv in programVocab)
            {
                
                if (kv.Value.Count > 1)
                {
                    
                        Console.WriteLine($" \nThe word \"{kv.Key}\" appears {kv.Value.Count} times in the list at indexes:   ");
                  string[] indexArray = kv.Value.Select(i => i.ToString()).ToArray();
                    {
                        Console.Write(String.Join(", ", indexArray));
                     
                        Console.WriteLine();
                    }     
                }  

            }

            Console.WriteLine("\nThank you for your input! Have a wonderful day! =) ");
            Console.ReadKey();

        }
    }
}
 