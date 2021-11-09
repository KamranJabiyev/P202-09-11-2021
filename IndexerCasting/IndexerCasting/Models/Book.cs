using System;
using System.Collections.Generic;
using System.Text;

namespace IndexerCasting.Models
{
    class Book
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Book(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
