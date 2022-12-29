using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Glasnie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый путь");
            string Path = Convert.ToString(Console.ReadLine());
            
            Console.WriteLine("Введите второй путь");
            string Path1 = Convert.ToString(Console.ReadLine());
            

            using (StreamReader reader = new StreamReader(Path))
            {
                string text = reader.ReadToEnd();
                Console.WriteLine($"{text}");
                while (text.Length > 0)
                {
                    Console.Write(text[0] + "=");
                    int count = 0;
                    for (int i = 0; i < text.Length; i++)
                    {
                        if(text[0] == text[i])
                        {
                            count++;
                        }
                    }

                    Console.WriteLine(count);
                    text = text.Replace(text[0].ToString(), string.Empty);
                    
                }

                Console.WriteLine("");

                
               
            }

            using (StreamReader reader = new StreamReader(Path1))
            {
                string text = reader.ReadToEnd();
                Console.WriteLine($"{text}");
                text = text.ToLower();
                while (text.Length > 0)
                {
                    Console.Write(text[0] + "=");
                    int count = 0;
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (text[0] == text[i])
                        {
                            count++;
                        }
                    }

                    Console.WriteLine(count);
                    text = text.Replace(text[0].ToString(), string.Empty);
                }

                Console.WriteLine("");


            }
            Console.WriteLine("Нажмите на любую кнопку чтобы продолжить");
            Console.Read();

            
            Console.ReadKey();
        }
    }
}
