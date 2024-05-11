using System.Collections;
using System.Text;

namespace SPD321_CSharp
{
    internal class Program
    {

        static void Func(ref int[] arr, ref int a, out int b)
        {
            arr = new int[] { 5, 6, 7, 8 };
            arr[0] = 100;
            a = 200;
            Console.WriteLine("In Func");
            Console.WriteLine(arr[0]);
            Console.WriteLine(a);
            b = 100;
        }

        static int Sum(int c, params object[] arr)
        {
            int res = 0;
            foreach (int i in arr)
            {
                res += i;
            }
            return res;
        }

        static void Div(int a, int b)
        {
            int r = a / b;
            Console.WriteLine(r);
        }

        static void Div2(int a, int b)
        {
            try
            {
                Div(a, b);
            }
            catch (Exception ex)
            {
                throw new Exception("InnerEx"/*, ex*/);
            }
        }

        static void Work(IWork obj)
        {
            obj.Work();
        }


        static void SuperFunc(string strname)
        {
            if (strname == null)
            {
                throw new ArgumentNullException(nameof(strname));
            }
            Console.WriteLine(strname);
        }


        static void PrintGroup(Hashtable group)
        {
            // LN FN - Marks
            foreach (Student st in group.Keys)
            {
                Console.Write(st.LastName + " " + st.FirstName + " - ");
                foreach (int i in (ArrayList)group[st])
                {
                    Console.Write(i + ", ");
                }
                Console.WriteLine();
            }
        }

        static void SetMark(Hashtable group, string lastName, string firstName, int mark) 
        {
            foreach(Student st in group.Keys)
            {
                if(st.LastName == lastName && st.FirstName == firstName) 
                {
                    (group[st] as ArrayList).Add(mark);
                }
            }

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Title = "SPD321";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            //// 11.05.2024 ///////
            ///

            Point2D<int> p = new Point2D<int>();
            Point2D<Student> p1 = new Point2D<Student>();




            //A1<int>.B1 b = new A1<int>.B1();

            //A2<int>.B2<double> d = new A2<int>.B2<double>();



            //Dictionary<string, int> dict = new Dictionary<string, int>
            //{
            //    ["tree"] = 3,
            //    ["one"] = 1,
            //    ["two"] = 2
            //};

            //dict["4"] = 4;
            //dict["4"] = 0;

            //foreach (var item in dict.Keys)
            //{
            //    Console.WriteLine(dict[item]);
            //}

            //int val;
            //Console.WriteLine(dict.TryGetValue("4", out val));
            //Console.WriteLine(val);
            //Console.WriteLine(dict["one"]);



            //using(new OperationTimer("ArrayList"))
            //{
            //    ArrayList arrayList = new ArrayList();
            //    for(int i = 0; i < 100000000; i++)
            //    {
            //        arrayList.Add(i);
            //        int a = (int)arrayList[i];
            //    }
            //    arrayList = null;
            //}

            //using (new OperationTimer("List"))
            //{
            //    List<int> list = new List<int>();
            //    for (int i = 0; i < 100000000; i++)
            //    {
            //        list.Add(i);
            //        int a = list[i];
            //    }
            //    list = null;
            //}

            //Hashtable group = new Hashtable
            //{
            //    {
            //        new Student
            //        {
            //            FirstName="Olga",
            //            LastName="Pirogova",
            //            BirthDay=new DateTime(2000, 10,10),
            //            StudentCard = new StudentCard { Series="AB", Number=123456}
            //        },
            //        new ArrayList{8,10,12}
            //    },
            //    {
            //        new Student
            //        {
            //            FirstName="Serg",
            //            LastName="Petroff",
            //            BirthDay=new DateTime(2000, 10,4),
            //            StudentCard = new StudentCard { Series="AB", Number=123416}
            //        },
            //        new ArrayList{11,12,12}
            //    },
            //    {
            //        new Student
            //        {
            //            FirstName="Frol",
            //            LastName="Sidorov",
            //            BirthDay=new DateTime(2001, 3,15),
            //            StudentCard = new StudentCard { Series="AA", Number=123456}
            //        },
            //        new ArrayList{7,8,7}
            //    },
            //    {
            //        new Student
            //        {
            //            FirstName="Anna",
            //            LastName="Pirogova",
            //            BirthDay=new DateTime(1999, 5,1),
            //            StudentCard = new StudentCard { Series="AA", Number=123455}
            //        },
            //        new ArrayList{11,12,12}
            //    }
            //};

            //PrintGroup(group);
            //SetMark(group, "Pirogova", "Anna", 12);
            //SetMark(group, "Pirogova", "Maria", 12);
            //Console.WriteLine();
            //PrintGroup(group);


            //ArrayList arrayList = [1, "1", true];
            //foreach (var i in arrayList)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(arrayList.Capacity);

            //Stack stack = new Stack(arrayList);
            //foreach (var i in stack)
            //{
            //    Console.WriteLine(i);
            //}


            //SortedList sList = new SortedList();
            //sList.Add("31", 1);
            //sList.Add("21", "2");
            //foreach (var i in sList)
            //{
            //    Console.WriteLine(i);
            //}




            //Console.WriteLine(GC.MaxGeneration);
            //Garbage g = new Garbage();
            //Console.WriteLine(GC.GetGeneration(g));
            //Console.WriteLine(GC.GetTotalMemory(false));
            //g.CreateGarbage();
            //Console.WriteLine(GC.GetTotalMemory(false));
            //GC.Collect(0);
            //Console.WriteLine(GC.GetGeneration(g));
            //Console.WriteLine(GC.GetTotalMemory(false));
            //GC.Collect();
            //Console.WriteLine(GC.GetGeneration(g));
            //Console.WriteLine(GC.GetTotalMemory(false));


            //using (DB dB = new DB())
            //{
            //    dB.Connect();
            //}

            ///


            //dB.Disconnect();


            //// 27.04.2024 ///////
            ///

            //try
            //{
            //    SuperFunc(null);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //int c = ConsoleMenu.SelectVertical(HPosition.Left, VPosition.Top, HorizontalAlignment.Center, "DEC to BIN", "BIN to DEC");


            //byte b = 100;
            //Console.WriteLine(b);
            //b += 200;
            //Console.WriteLine(b);


            //int a, b;

            //try
            //{
            //    a = Convert.ToInt32(Console.ReadLine());
            //    b = Convert.ToInt32(Console.ReadLine());

            //    Div2(a, b);
            //}
            ////catch (DivideByZeroException e)
            ////{ 

            ////}
            //catch (MyException ex) 
            //{
            //    foreach (var item in ex.Data.Keys)
            //    {
            //        Console.WriteLine($"{item} - {ex.Data[item]}");
            //    }

            //}
            //catch (Exception ex) when (!ex.Source.Contains("SPD321"))
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.Source);
            //    Console.WriteLine(ex.InnerException);
            //    //foreach (var item in ex.Data.Keys)
            //    //{
            //    //    Console.WriteLine($"{item} - {ex.Data[item]}");
            //    //}
            //    Console.WriteLine(ex.HelpLink);
            //    Console.WriteLine(ex.HResult);
            //    Console.WriteLine(ex.TargetSite);
            //    Console.WriteLine(ex.StackTrace);
            //}
            //finally
            //{

            //}




            //Group group = new Group();
            //foreach (Student s in group)
            //{
            //    Console.WriteLine(s);
            //}

            ////group.Sort(new DateComparer());
            ////group.Sort(Student.FromBirthDay);
            //group.Sort(Student.FromStudentCard);
            //Console.WriteLine();
            //foreach (Student s in group)
            //{
            //    Console.WriteLine(s);
            //}


            //Student s1 = new Student
            //{
            //    FirstName = "Olga",
            //    LastName = "Pirogova",
            //    BirthDay = new DateTime(2000, 10, 10),
            //    StudentCard = new StudentCard { Series = "AB", Number = 123456 }
            //};

            //Student s2 = (Student)s1.Clone();

            //s2.StudentCard.Series = "XX";

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);




            //group.GetEnumerator();

            //// 20.04.2024 ///////
            ///


            //Array array = new Array();



            //AAA aaa = new AAA();
            //aaa.Show();

            //((IA)aaa).Show();

            //IA ia = new AAA();
            //ia.Show();

            //IB ib = new AAA();
            //ib.Show();

            //IC ic = new AAA();
            //ic.Show();


            //Passport p = new Passport()
            //{
            //    Series = "AB",
            //    Number = 123456,
            //    Name = "Serg",
            //    BirthDay = new DateOnly(2000, 12, 5),
            //};

            //Console.WriteLine(p.GetHashCode());

            //var m = p.GetType().GetMethods();
            //foreach (var m2 in m)
            //{
            //    Console.WriteLine(m2.Name);
            //}


            //Human h = new Human(1, "Serg");
            //h.Print();

            //Employee e = new Employee(2, "Anna", 1000);
            //e.Print();

            //IWork[] empl = new IWork[]
            //{
            //    new Director(1, "Serg", 1000, 5),
            //    new Buhgalter(2, "Anna", 500, 10),
            //    new CleaningManager(3, "Olga", 200, 100)
            //};

            //foreach (IWork emp in empl)
            //{
            //    ((Employee)emp).WhoAmI();
            //    emp.Work();
            //    Console.WriteLine(emp);


            //    //try
            //    //{
            //    //    ((Director)emp).PrintDirector();
            //    //}
            //    //catch { }


            //    //Buhgalter b = emp as Buhgalter;
            //    //if (b != null)
            //    //{
            //    //    b.PrintBuhgalter();
            //    //}

            //    //if(emp is CleaningManager)
            //    //{
            //    //    (emp as CleaningManager).PrintCleaningManager();
            //    //}
            //}







            //// 13.04.2024 ///////
            ///

            //Point p = new Point(ConsoleColor.Red);
            //p.Print();
            //p.X = -100;
            //p.MyProperty = 0;


            //Console.WriteLine(Point.X);
            //Console.WriteLine(p.Color);
            //p.Color = ConsoleColor.Red;
            //int[] arr = { 1, 2, 3, 4 };
            //int a = 0;
            //int b;
            //Func(ref arr, ref a, out b);
            //Console.WriteLine(arr[0]);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(Sum(1,2,3,5,5));


            //Student[] students =  
            //{ 
            //    new Student(){ Id=1,  Name="Anna", BirthDay = new DateOnly(2000, 2, 10), Group = new Group(){ Id=321, Name="SPD321"} },
            //    new Student(){ Id=2,  Name="Olga", BirthDay = new DateOnly(1999, 2, 17) , Group = new Group(){ Id=321, Name="SPD321"} },
            //    new Student(){ Id=3,  Name="Egor", BirthDay = new DateOnly(2025, 12, 25), Group = new Group(){ Id=321, Name="SPD321"}  },
            //    new Student(){ Id=4,  Name="Frol", BirthDay = new DateOnly(2001, 5, 15), Group = new Group(){ Id=321, Name="SPD321"}  },
            //};

            //foreach (Student s in students)
            //{
            //    s.Print();
            //}

            //Console.WriteLine(students[0].Group!.Name);
            //#A1BBE3FF
            //

            // -, ++, --
            // + - * / % | & >> << 
            // !
            // > <    <= >=    == !=  && ||

            //Point p = new Point(2, 5);
            //Point p2 = -p;
            //p2.Print();
            //p++;
            //++p;
            //p.Print();
            //Point p3 = p * 3;  //p.op+(3)
            //p3.Print();

            //Point p4 = 3 * p; //3
            //p3.Print();

            //p *= 3;
            //p += p2;

            //Console.WriteLine(p.GetHashCode());
            //Console.WriteLine(p3.GetHashCode());


            //if (p && p2)
            //{

            //}


            //float f = (float)p;

            //Point p5 = 10;

            //Console.WriteLine(p["Color"]);
            //Console.WriteLine(p[2]);
            //Console.WriteLine(p[2, 5]);

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


            //string str = "today is a good day for walking? i will try to walk near the sea.";
            //var st = str.Split(" ".ToCharArray());
            //st[0]  = st[0].ToCharArray()[0].ToString().ToUpper();
            //foreach (string s in st)
            //{
            //    Console.WriteLine(s);
            //}



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
