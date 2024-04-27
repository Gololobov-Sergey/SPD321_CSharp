using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPD321_CSharp
{

    public class StudentCard
    {
        public string Series { get; set; }

        public int Number { get; set; }

        public override string ToString()
        {
            return $"{Series} {Number}";
        }
    }

    public class Student : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        public StudentCard StudentCard { get; set; }

        public int CompareTo(object? obj)
        {
            Student? s = obj as Student;
            return (LastName + FirstName).CompareTo(s!.LastName + s!.FirstName);
        }

        public override string ToString()
        {
            return $"{LastName.PadRight(10)} {FirstName.PadRight(10)} {BirthDay.ToShortDateString()} {StudentCard}";
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
            if(x is Student student && y is Student)
            {
                return DateTime.Compare((x as Student).BirthDay, (y as Student).BirthDay);
            }
            throw new NotImplementedException();
        }
    }
}
