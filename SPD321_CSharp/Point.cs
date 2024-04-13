using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPD321_CSharp
{
    public partial class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public readonly ConsoleColor Color;


        //public int X
        //{
        //    get { return x; }
        //    set 
        //    { 
        //        if(value >= 0) 
        //            x = value; 
        //    }
        //}


        //private string _name;

        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}


        //public int MyProperty { get; set; }


        //public int GetX()
        //{
        //    return X;
        //}

        //public void SetX(int x)
        //{
        //    X = x;
        //}


        public Point(ConsoleColor c)
        {
            Color = c;
        }

        public Point() : this(0, 0)
        {

        }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }


        public void Print()
        {
            Console.WriteLine($"({X}, {Y}, {Color})");
        }


        public static Point operator -(Point p)
        {
            return new Point(-p.X, -p.Y);
        }

        public static Point operator ++(Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static Point operator *(Point p1, int n)
        {
            return new Point(p1.X * n, p1.Y * n);
        }

        public static Point operator *(int n, Point p1)
        {
            return p1 * n;
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return (p1.X == p2.X) && (p1.Y == p2.Y);
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return (p1.X == p2.X) && (p1.Y == p2.Y);
        }

        public static bool operator true(Point p1)
        {
            return p1.X != 0 || p1.Y != 0 ? true : false;
        }

        public static bool operator false(Point p1)
        {
            return p1.X == 0 && p1.Y == 0 ? true : false;
        }

        public static Point operator &(Point p1, Point p2)
        {
            return new Point();
        }


        public static /*implicit*/ explicit operator float(Point p1)
        {
            return (float)Math.Sqrt(Math.Pow(p1.X, 2) + Math.Pow(p1.Y, 2));
        }

        public static implicit /*explicit*/ operator Point(int n)
        {
            return new Point(n, n);
        }

        public int this[string ind]
        {
            get
            {
                if (ind == "X")
                    return X;
                if (ind == "Y")
                    return Y;
                if (ind == "Color")
                    return (int)Color;
                return 0;
            }
            set
            {

            }
        }


        public int this[int ind]
        {
            get
            {
                if (ind == 0)
                    return X;
                if (ind == 1)
                    return Y;
                if (ind == 2)
                    return (int)Color;
                return 0;
            }
            set
            {

            }
        }



        public int this[int ind1, int ind2]
        {
            get
            {
                return 0;
            }
            set
            {

            }
        }


    }
}
