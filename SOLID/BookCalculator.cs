using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class BookCalculator
    {
        Book _book;

        public BookCalculator(Book book)
        {
            _book = book;
        }
        public int GetWorldsNumber()
        {
            return GetSpacesNumber() + 1;
        }
        public int GetCharactersNumber()
        {
            return GetAllCharactersNumber() - GetSpacesNumber();
        }
        private int GetAllCharactersNumber()
        {
            return _book.Text.Length;
        }
        private int GetSpacesNumber()
        {
            return _book.Text.Where( c => c == ' ').Count();
        }
    }

}
