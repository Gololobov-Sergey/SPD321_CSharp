﻿using System.Text;

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

            //// 06.04.2024 ///////
            ///

            //int[] arr = new int[5] { 1, 2, 3, 4, 5};
            //int[] arr2 = new int[] { 1, 2, 3, 4, 5};
            //int[] arr1 = { 1, 2, 3, 4, 5};

            //int[] arr3;
            //arr3 = new int[] { 1,2,3};

            //arr[2] = 45;
            //Console.WriteLine(arr[2]);

            //Console.WriteLine(arr.Sum());

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] += 5;
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();

            //foreach (int i in arr)
            //{
            //    //i += 5;
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            //Array.Reverse(arr);
            //foreach (int i in arr)
            //{
            //    //i += 5;
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();


            //int[,] arr5 = new int[3, 2] { {1, 2 }, {3, 4 }, {5, 6 } };
            //arr5[1, 1] = 999;
            //for (int i = 0; i < arr5.GetLength(0); i++)
            //{
            //    for (int j = 0;j < arr5.GetLength(1);j++)
            //    {
            //        Console.Write(arr5[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();


            //int[][] arr6 = new int[3][];
            //arr6[0] = new int[] { 1, 2, 3 };
            //arr6[1] = new int[] { 1, 2, 3, 4, 5, 6 };
            //arr6[2] = new int[] { 1, 2 };
            //Console.WriteLine(arr6.Length);
            //for (int i = 0; i < arr6.Length; i++)
            //{
            //    //for (int j = 0; j < arr6[i].Length; j++)
            //    //{
            //    //    Console.Write(arr6[i][j] + " ");
            //    //}

            //    foreach (int j in arr6[i])
            //    {
            //        Console.Write(j + " ");
            //    }

            //    Console.WriteLine();
            //}

            //int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            ////Console.WriteLine(arr.Count(a => a > 3));
            //Console.WriteLine(String.Join(", ", arr.Select(a => a.ToString()).ToArray(), 2, 2));




            //string st1 = "\\mama\\";
            //string st2 = @"C:\Dir1\text.txt";
            //Console.WriteLine(st2);
            //st1.CompareTo(st2);

            //Console.WriteLine("mama".PadLeft(10) + "mama");
            //Console.WriteLine("mama".PadRight(10) + "mama");

            //string str = "     Hkjh, kjhk j. hle'wi poiqwepoweori!   wieowei uwe     ";
            //var s = str.Split(".,!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            //foreach (var item in s)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(str.Substring(5));

            //int a = 100;
            //DateOnly d = new DateOnly(2024,2,2);
            //Console.WriteLine($"Hkkjhk {a} ipoppo {d.ToShortDateString()} ekjwoer");
            //Console.WriteLine(str.Trim());
            //Console.WriteLine(str.TrimStart());
            //Console.WriteLine(str.TrimEnd());

            ////str[0] = 'D';
            //Console.WriteLine(str[11]);

            //StringBuilder sb = new();
            //sb.Append(100);
            //sb.Append("mama");
            //sb.Insert(2, "dwe");
            //string s1 = sb.ToString();
            //Console.WriteLine(s1);
            //Console.WriteLine(sb.Capacity);


            string str = "today is a good day for walking? i will try to walk near the sea.";
            var st = str.Split(" ".ToCharArray());
            st[0]  = st[0].ToCharArray()[0].ToString().ToUpper();
            foreach (string s in st)
            {
                Console.WriteLine(s);
            }



            /////////////////////////////////////////////////

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


            //Random random = new Random();
            //int g = random.Next(100, 200);
            //Console.WriteLine(double.Round(random.NextDouble(), 5));

            //DateTime dt = new DateTime(2024, 03, 29, 12, 12, 54);
            //DateTime dt1 = DateTime.Now;
            //Console.WriteLine(dt1.ToLongDateString());
            //Console.WriteLine(dt1.ToLongTimeString());
            //Console.WriteLine(dt1.ToShortDateString());
            //Console.WriteLine(dt1.ToShortTimeString());
            //Console.WriteLine(dt1.ToString("yyyy-MM-dd"));

            //ConsoleKeyInfo cc =  Console.ReadKey();
            //Console.WriteLine(cc.Key);
            //Console.WriteLine(cc.KeyChar);
            //Console.WriteLine(cc.Modifiers);



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
