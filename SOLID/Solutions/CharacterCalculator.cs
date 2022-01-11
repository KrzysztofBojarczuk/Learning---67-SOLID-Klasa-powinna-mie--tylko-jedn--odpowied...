using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Solutions
{
    public class CharacterCalculator
    {
        Book _book;

        public CharacterCalculator(Book book)
        {
            _book = book;
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
            return _book.Text.Where(c => c == ' ').Count();
        }
    }
}
