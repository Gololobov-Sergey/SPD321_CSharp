using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPD321_CSharp
{

    public class StudentCard : IComparable<StudentCard>
    {
        public string Series { get; set; }

        public int Number { get; set; }

        public int CompareTo(StudentCard? sc)
        {
            return (Series+Number.ToString()).CompareTo(sc.Series+sc.Number.ToString());
        }

        public override string ToString()
        {
            return $"{Series} {Number}";
        }
    }

    [Serializable]
    [Programmer]
    public class Student : IComparable<Student>, ICloneable
    {
        int code = 20;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        public StudentCard StudentCard { get; set; }

        public static IComparer<Student> FromBirthDay { get { return new DateComparer(); } }
        public static IComparer<Student> FromStudentCard { get { return new StudentCardComparer(); } }

        [Programmer("Vasya", "2024-01-01")]
        public int CompareTo(Student? s)
        {
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


        //public void Exam(DateTime date)
        //{
        //    Console.WriteLine($"Студенту {LastName} {FirstName} назначений " +
        //        $"екзамен на {date.ToShortDateString()}");
        //}

        public void Exam(object sender, ExamEventArgs e)
        {
            Console.WriteLine($"Студенту {LastName} {FirstName} викладач {e.Teacher} назначив " +
                $"екзамен по {e.Course} на {e.Date.ToShortDateString()}, аудиторія {e.Room}");
        }
    }

    //public delegate void ExamDelegate(DateTime date);

    public class Teacher
    {
        //1 public event ExamDelegate ExamEvent;

        //2 public event Action<DateTime> ExamEvent;

        SortedList<string, EventHandler<ExamEventArgs>> list = new();
        
        public event EventHandler<ExamEventArgs> ExamEvent
        {
            add 
            {
                Student s = value.Target as Student;
                string key = s.LastName + s.FirstName;
                list.Add(key, value);
            }
            remove 
            {
                Student s = value.Target as Student;
                string key = s.LastName + s.FirstName;
                list.Remove(key);
            }
        }

        //public void SetExam(string date)
        //{
        //    if(ExamEvent != null)
        //    {
        //        ExamEvent(Convert.ToDateTime(date));
        //    }
        //}


        public void SetExam(ExamEventArgs e)
        {
            //if (ExamEvent != null)
            //{
            //    ExamEvent(this, e);
            //}

            foreach (EventHandler<ExamEventArgs> item in list.Values)
            {
                item(this, e);
            }
        }
    }

    public class ExamEventArgs : EventArgs
    {
        public DateTime Date { get; set; }
        public string Course { get; set; }
        public int Room { get; set; }
        public string Teacher { get; set; }

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

        public void Sort(IComparer<Student> comparer)
        {
            Array.Sort(students, comparer);
        }
    }

    public class DateComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            //if (x is Student && y is Student)
            //{
            return DateTime.Compare((x as Student).BirthDay, (y as Student).BirthDay);
            //}
            //throw new NotImplementedException();
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

    public class StudentCardComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return (x!.StudentCard.CompareTo(y!.StudentCard));
        }
    }

}
