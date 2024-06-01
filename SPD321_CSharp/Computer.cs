using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPD321_CSharp
{
    public class Computer
    {
        public string Type { get; set; }
        public string MB { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string HD { get; set; }

        public override string ToString()
        {
            return $"{Type} {MB} {CPU} {RAM} {HD}";
        }
    }
}
