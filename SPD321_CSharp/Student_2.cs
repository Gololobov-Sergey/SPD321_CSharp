using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPD321_CSharp
{

    public class StudentCard : IComparable
    {
        public string Series { get; set; }

        public int Number { get; set; }

        public int CompareTo(object? obj)
        {
            StudentCard sc = obj as StudentCard;
            return (Series+Number.ToString()).CompareTo(sc.Series+sc.Number.ToString());
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Series} {Number}";
        }
    }

    public class Student : IComparable, ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        public StudentCard StudentCard { get; set; }

        public static IComparer FromBirthDay { get { return new DateComparer(); } }
        public static IComparer FromStudentCard { get { return new StudentCardComparer(); } }

        public int CompareTo(object? obj)
        {
            Student? s = obj as Student;
            return (LastName + FirstName).CompareTo(s!.LastName + s!.FirstName);
        }

        public override string ToString()
        {
            return $"{LastName.PadRight(10)} {FirstName.PadRight(10)} {BirthDay.ToShortDateString()} {StudentCard}";
        }

        public object Clone()
        {
            Student s = (Student)this.MemberwiseClone();
            s.StudentCard = new StudentCard 
            { 
                Series = this.StudentCard.Series, 
                Number =  this.StudentCard.Number 
            };
            return s;
        }
    }


    public class Group : IEnumerable
    {
        Student[] students =
        {
            new Student
            {
                FirstName="Olga",
                LastName="Pirogova",
                BirthDay=new DateTime(2000, 10,10),
                StudentCard = new StudentCard { Series="AB", Number=123456}
            },
            new Student
            {
                FirstName="Serg",
                LastName="Petroff",
                BirthDay=new DateTime(2000, 10,4),
                StudentCard = new StudentCard { Series="AB", Number=123416}
            },
            new Student
            {
                FirstName="Frol",
                LastName="Sidorov",
                BirthDay=new DateTime(2001, 3,15),
                StudentCard = new StudentCard { Series="AA", Number=123456}
            },
            new Student
            {
                FirstName="Anna",
                LastName="Pirogova",
                BirthDay=new DateTime(1999, 5,1),
                StudentCard = new StudentCard { Series="AA", Number=123455}
            }
        };

        IEnumerator IEnumerable.GetEnumerator()
        {
            return students.GetEnumerator();
        }

        public void Sort()
        {
            Array.Sort(students);
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(students, comparer);
        }
    }

    public class DateComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Student student && y is Student)
            {
                return DateTime.Compare((x as Student).BirthDay, (y as Student).BirthDay);
            }
            throw new NotImplementedException();
        }
    }


    //public class StudentCardComparer : IComparer
    //{
    //    public int Compare(object? x, object? y)
    //    {
    //        if (x is Student student && y is Student)
    //        {

    //        }
    //        throw new NotImplementedException();
    //    }
    //}

    public class StudentCardComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Student student && y is Student)
            {
                return (x as Student).StudentCard.CompareTo((y as Student).StudentCard);
            }

            throw new NotImplementedException();
        }
    }

}
