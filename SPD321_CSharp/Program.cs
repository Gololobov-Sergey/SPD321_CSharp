using System.Text;

namespace SPD321_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Title = "SPD321";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();




            //int? a = null;

            //a = a ?? 50;

            //string? s = null;

            //Console.WriteLine("fere\"r\"f");

            //Console.WriteLine("Слава Україні!");


            //int b = (int)3.21;

            //double f = 3.25f;

            //int a;
            //a = Convert.ToInt32(Console.ReadLine());
            //int b;
            //b = int.Parse(Console.ReadLine());
            //int.TryParse(Console.ReadLine(), out b);

            //a = b > 10 ? b : 10;

            //bool c = true;
            //if(c)
            //{
            //    Console.WriteLine("True");
            //}

            //switch(a)
            //{
            //    case 1:
                   
            //    case 2:
            //        c = false;
            //        break;
            //    case 3:
            //        b = 0;
            //        break;
            //}

            //int d = a switch
            //{
            //    1 => 34,
            //    2 => a + b,
            //    _ => 0
            //};


            Random random = new Random();
            int g = random.Next(100, 200);
            Console.WriteLine(random.NextDouble());

            DateTime dt = new DateTime(2024, 03, 29, 12, 12, 54);
            DateTime dt1 = DateTime.Now;
            Console.WriteLine(dt1.ToLongDateString());
            Console.WriteLine(dt1.ToLongTimeString());
            Console.WriteLine(dt1.ToShortDateString());
            Console.WriteLine(dt1.ToShortTimeString());
            Console.WriteLine(dt1.ToString("yyyy-MM-dd"));

            ConsoleKeyInfo cc =  Console.ReadKey();
            Console.WriteLine(cc.Key);
            Console.WriteLine(cc.KeyChar);
            Console.WriteLine(cc.Modifiers);

            

            //for( int i = 0; i < d; i++ )
            //{
            //    Console.WriteLine(random.NextDouble());
            //}

            //while( true )
            //{
            //    Console.WriteLine( Console.ReadLine() );
            //}

            //do 
            //{ 
            //    Console.WriteLine( Console.ReadLine() ); 
            //} while( true );

        }
    }
}
