using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241202
{
    internal class Book
    {
        private int isbn;
        private string title;
        private int kiadas;
        private string nyelv;
        private int price;
        private int keszlet;
        public long Isbn
        {
            get
            {
                return isbn;
            }
            set
            {
                value = isbn;
            }
        }
        public List<Authors> Author { get; set; }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 64)
                {
                    title = value;
                }
            }
        }
        public int Kiadas
        {
            get
            {
                return kiadas;
            }
            set
            {
                if (value > 2007 && value <= DateTime.Now.Year)
                {
                    kiadas = value;
                }
            }
        }
        public string Language
        {
            get
            {
                return nyelv;
            }
            set
            {
                nyelv = value;
            }
        }
        public int Keszlet
        {
            get
            {
                return keszlet;
            }
            set
            {
                if (value >= 0)
                {
                    keszlet = value;
                }
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 1000 && value < 10000 && value % 100 == 0)
                {
                    price = value;
                }
            }
        }


        public Book(long isbn, List<Authors> author, string title, int kiadas, string language, int keszlet, int price)
        {
            Isbn = isbn;
            Author = author.ToList();
            Title = title;
            Kiadas = kiadas;
            Language = language;
            Keszlet = keszlet;
            Price = price;
        }
        public Book(string title, List<Authors> author) : this(Random.Shared.NextInt64(0000000000, 9999999999), author, title, 2024, "magyar", 0, 4500)
        {

        }
        public override string ToString()
        {
            string authorsString = Author.Count == 1 ? "szerző: " : "szerzők: ";
            authorsString = string.Join(", ", Author); string stockString = keszlet == 0 ? "beszerzés alatt" : $"{keszlet} db"; return $"{Title} ({kiadas})\n{authorsString}\nNyelv: {Language}\nÁr: {Price} Ft\nKészlet: {stockString}";
        }
    }
}
