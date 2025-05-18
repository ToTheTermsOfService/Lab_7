using Lab_7.Attributes;
using Lab_7.Models.Base;
using System.Xml.Linq;

namespace Lab_7.Models.Person
{
    [Couple(Pair = "Student", Probability = 0.2, ChildType = "Girl")]
    [Couple(Pair = "Botan", Probability = 0.5, ChildType = "Book")]
    public class SmartGirl : Human
    {
        public SmartGirl()
        {
            Name = "SmartGirl";
        }

        public override bool IsMale()
        {
            return false;
        }
    }
}
