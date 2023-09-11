using System;

using System.Collections.Generic;
using System.Linq;

namespace stringfinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.In.ReadLine();
            List<Int64> list = new List<Int64>();

            int len = str.Length;

            Console.WriteLine("\nResult: ");

            for (int i = 0; i < len; i++)
            {
                if (int.TryParse(str[i].ToString(), out int res))
                {
                    for (int j = i + 1; j < len; j++)
                    {
                        if (!int.TryParse(str[j].ToString(), out int res1))
                        {
                            break;
                        }

                        if (str[i] == str[j])
                        {
                            if (i == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("\x1b[1m" + str.Substring(i, j - i + 1) + "\x1b[0m");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write(str.Substring(j + 1));

                                list.Add(Int64.Parse(str.Substring(i, j - i + 1)));
                            }
                            else if (j == len - 1)
                            {
                                Console.Write(str.Substring(0, i));
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("\x1b[1m" + str.Substring(i) + "\x1b[0m");
                                Console.ForegroundColor = ConsoleColor.White;

                                list.Add(Int64.Parse(str.Substring(i)));
                            }
                            else
                            {
                                Console.Write(str.Substring(0, i));
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("\x1b[1m" + str.Substring(i, j - i + 1) + "\x1b[0m");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write(str.Substring(j + 1));

                                list.Add(Int64.Parse(str.Substring(i, j - i + 1)));
                            }

                            Console.WriteLine();
                            break;
                        }
                    }
                }

                
            }

            Console.WriteLine("\nSum of values: " + list.Sum());
        }
    }
}