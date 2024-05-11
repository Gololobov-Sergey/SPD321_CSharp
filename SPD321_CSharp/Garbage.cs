using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPD321_CSharp
{
    public class Garbage
    {
        public void CreateGarbage()
        {
            for (int i = 0; i < 1000; i++)
            {
                Student s = new Student();
            }
        }

    }


    public class DB : IDisposable
    {
        public void Connect()
        {
            Console.WriteLine("DB Connect");
        }

        public void Disconnect()
        {
            Console.WriteLine("DB Disconnect");
        }

        public void Dispose()
        {
            Disconnect();
        }
    }
}
