using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystem
{
    internal class Book
    {
        public string Name;
        public string AuthorName;
        public int PublishedDate;
        public int PageCount;

        public override string ToString()
        {
            return $"{AuthorName} {$"\"{Name}\""} {PublishedDate}";

        }
        public void Book1()
        {
            if (PageCount > 10)
            {
                Console.WriteLine($"Əsər: {Name}\n" +
                $"Müəllif: {AuthorName}\n" +
                $"Nəşr ili: {PublishedDate}\n" +
                $"Səhifə sayı: {PageCount}\n");
            }
            else
            {
                Console.WriteLine("Səhifə sayı düzgün verilməyib.");
            }
        }
    }
}

