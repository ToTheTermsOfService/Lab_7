using Lab_7.Attributes;
using Lab_7.Models.Base;
using System.Xml.Linq;

namespace Lab_7.Models.Person
{

    [Couple(Pair = "Girl", Probability = 0.7, ChildType = "SmartGirl")]
    [Couple(Pair = "PrettyGirl", Probability = 0.1, ChildType = "PrettyGirl")]
    [Couple(Pair = "SmartGirl", Probability = 0.8, ChildType = "Book")]
    public class Botan : Human
    {
        public Botan()
        {
            Name = "Botan";
        }

        public override bool IsMale()
        {
            return true;
        }
    }

}
