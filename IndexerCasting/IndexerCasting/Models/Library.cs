using System;
using System.Collections.Generic;
using System.Text;

namespace IndexerCasting.Models
{
    class Library
    {
        private Book[] _books;
        public Library(int size)
        {
            _books = new Book[size];
        }

        public Book this[int index]
        {
            get
            {
                if (index < _books.Length)
                {
                    return _books[index];
                }
                throw new Exception();
            }
            set
            {
                if (index < _books.Length)
                {
                    _books[index] = value;
                    return;
                }
                throw new Exception();
            }
        }

    }
}
