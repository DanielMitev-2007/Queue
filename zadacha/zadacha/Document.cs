using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    internal class Document
    {
        public string Title { get; }
        public int Pages { get; }

        public Document(string title, int pages)
        {
            Title = title;
            Pages = pages;
        }

        public override string ToString()
        {
            return $"{Title} ({Pages} стр.)";
        }
    }
}
