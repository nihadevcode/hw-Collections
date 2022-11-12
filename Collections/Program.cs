using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Authors> AuthorList = new List<Authors>()
            {
                new Authors() {FullName = "Chingiz Abdullayev", Age = 67},
                new Authors() {FullName = "Aqata Kristi", Age = 26},
                new Authors() {FullName = "Artur Konan Doyl", Age = 30},
                new Authors() {FullName = "Nizami Gencevi", Age = 20},
                new Authors() {FullName = "Fuzuli", Age = 350}
            };
            
            foreach (Authors item in AuthorList)
            {
                if (Authors.Age > 40)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
