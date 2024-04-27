using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPD321_CSharp
{

    //class Array
    //{

    //}

    internal interface IWork
    {
        void Work();
        bool IsWorking { get; }
    }


    interface IA
    {
        //....
        void Show();
    }


    interface IB
    {
        //....
        void Show();
    }

    interface IC
    {
        //....
        void Show();
    }

    
    class AAA : IA, IB, IC
    {
        void IC.Show()
        {
            Console.WriteLine("Show C");
        }

        void IA.Show()
        {
            Console.WriteLine("Show A");
        }

        void IB.Show()
        {
            Console.WriteLine("Show B");
        }


    }
}
