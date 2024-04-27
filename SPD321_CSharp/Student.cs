using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPD321_CSharp
{
    internal class Student_1
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        private DateOnly? bd;

        public DateOnly? BirthDay
        {
            get { return bd; }
            set 
            { 
                if(value < DateOnly.FromDateTime(DateTime.Now))
                    bd = value;
                
            }
        }

        public Group_1? Group { get; set; }


        public void Print()
        {
            Console.WriteLine($"{Id.ToString().PadLeft(3)} {Name!.PadRight(10)} {BirthDay}");
        }

        
    }

    class Group_1
    {
        public int Id { get; set; }
        public string? Name { get; set; }

    }
}
