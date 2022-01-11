using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Solutions
{
    public class WordCalculator
    {
        Book _book;

        public WordCalculator(Book book)
        {
            _book = book;
        }
        public int GetWorldsNumber()
        {
            return GetSpacesNumber() + 1;
        }
        private int GetSpacesNumber()
        {
            return _book.Text.Where(c => c == ' ').Count();
        }
    }
}
