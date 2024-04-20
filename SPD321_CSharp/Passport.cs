using SPD321_CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPD321_CSharp
{
    internal class Passport
    {
        public string? Series { get; set; }
        public int Number { get; set; }
        
        public string? Name { get; set; }

        public DateOnly BirthDay { get; set; }

        public override string ToString()
        {
            return $"{Series} {Number} {Name} {BirthDay}";
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }

    class ForeignPassport : Passport
    {
        int count = 0;
        Visa[] visas = new Visa[3];

        public void AddVisa(Visa visa)
        {
            if(count != 3)
            {
                visas[count++] = visa;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Vises:");
            foreach(Visa visa in visas)
            {
                sb.AppendLine(visa.ToString());
            }
            return sb.ToString();
        }
    }

    internal class Visa
    {
        public string? Country { get; set; }

        public DateOnly DateStart { get; set; }

        public string? Period { get; set; }

        public override string ToString()
        {
            return $"{Country} {DateStart} {Period}";
        }
    }
}


//Passport p = new Passport()
//{
//    Series = "AB",
//    Number = 123456,
//    Name = "Serg",
//    BirthDay = new DateOnly(2000, 12, 5),
//};


//ForeignPassport p2 = new ForeignPassport()
//{
//    Series = "ABC",
//    Number = 123452346,
//    Name = "Serg",
//    BirthDay = new DateOnly(2000, 12, 5),
//};
//p2.AddVisa(new Visa { Country = "USA", DateStart = DateOnly.FromDateTime(DateTime.Now), Period = "1M" });
//p2.AddVisa(new Visa { Country = "Poland", DateStart = DateOnly.FromDateTime(DateTime.Now), Period = "3M" });
//p2.AddVisa(new Visa { Country = "Finland", DateStart = DateOnly.FromDateTime(DateTime.Now), Period = "1Y" });

//Console.WriteLine(p2);