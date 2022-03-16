using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;

namespace Curse
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input;
            Boolean flag = true;
            string[] words = File.ReadAllLines("/Users/stephenwoodman/Desktop/badwords.txt");
            List<string> list = words.ToList();
            while (flag)
            {
                Console.WriteLine("Enter a word");
            input = Console.ReadLine();
            string[] split = input.Split(' ');

             
                    for (int i = 0; i < split.Length; i++)
                    {
                        if (list.Contains(split[i], StringComparer.OrdinalIgnoreCase))
                        {
                            string test = new string('*', split[i].Length);
                            split[i] = test;

                        }

                        else

                        {
                            continue;
                        }
                    }
                    List<string> listprint = split.ToList();
                    Console.WriteLine(string.Join(" ", split)); 

            }

          }

         } 
       }
    

        

    
