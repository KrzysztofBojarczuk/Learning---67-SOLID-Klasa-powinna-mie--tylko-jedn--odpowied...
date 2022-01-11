// See https://aka.ms/new-console-template for more information


using SOLID;
using SOLID.Solutions;

var book = new Book()
{
    Text = "aaa bbb ccc."
};

var counter = new CharacterCalculator(book);
var counter1 = new WordCalculator(book);

Console.WriteLine(counter.GetCharactersNumber());
Console.WriteLine(counter1.GetWorldsNumber());