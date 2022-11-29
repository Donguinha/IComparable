using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using IComparablee.Entities;

namespace Icomparablee
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\code\IComparable\arquivo.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employees> list = new List<Employees>();

                    while (!(sr.EndOfStream))
                    {
                        list.Add(new Employees(sr.ReadLine()));
                    }

                    list.Sort();

                    foreach (Employees line in list)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }
        }
    }
}