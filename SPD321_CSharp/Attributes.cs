using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPD321_CSharp
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ProgrammerAttribute : Attribute
    {
        string name = "Serg";
        DateTime date = DateTime.Now;

        public ProgrammerAttribute()
        {
            
        }

        public ProgrammerAttribute(string name, string date)
        {
            this.name = name;
            this.date = Convert.ToDateTime(date);
        }

        public override string ToString()
        {
            return $"Programmer: {name}, Date: {date.ToShortDateString()}";
        }
    }
}
