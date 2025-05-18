using Lab_7.Interfaces;

namespace Lab_7.Models
{
    public class Book : IHasName
    {
        public string Name { get; set; }

        public Book()
        {
            Name = "Book";
        }
    }
}
