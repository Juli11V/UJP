using System;
using System.IO;
using System.Collections.Generic;

namespace HW_6
{
    public delegate void MyDel(int d);

    public class Student
    {
        string name;
        public string Name { get { return  this.name = "Julia"; } }

        public event MyDel MarkChange;

         public List<int> marks = new List<int>();

        public void AddMark(int mark)
        {
            marks.Add(mark);
            if (MarkChange != null)
                MarkChange.Invoke(mark);
        }
    }

    public class Parent : Student
    {
        public void OnMarkChange(int someMark)
        {
            Console.WriteLine($"Your son {Name} has {someMark} mark");
        }
    }

    public class Bugalteria : Student
    {
        public void Scholarship(int mark)
        {
            if (mark >= 10)
                Console.WriteLine($"{Name} will have scholarship\n");
            else
                Console.WriteLine($"{Name} will not have scholarship\n");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            Parent parent = new Parent();
            Bugalteria bugalteriaa = new Bugalteria();

            MyDel father = parent.OnMarkChange;
            MyDel scholarship = bugalteriaa.Scholarship;

            student.MarkChange += father;
            student.MarkChange += scholarship;

            student.AddMark(20);
            student.AddMark(10);
            student.AddMark(55);
            student.AddMark(15);

            Console.WriteLine();
        }
    }
}
