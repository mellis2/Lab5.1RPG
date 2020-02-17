using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsPractice
{
    
    class book
    {
        private string title;
        private string author;
        private int pages;
        private int length;
        private int width;

        public book(string title, string author, int pages, int length, int width)
        {
            this.Title = title;
            this.Author = author;
            this.Pages = pages;
            this.Length = length;
            this.Width = width;
        }

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public int Pages { get => pages; set => pages = value; }
        public int Length { get => length; set => length = value; }
        public int Width { get => width; set => width = value; }

        public int CalculateArea2(int x, int y) 
        {
            return x * y;
        }
    }

}
