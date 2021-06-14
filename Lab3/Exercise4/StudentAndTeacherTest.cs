using System;

namespace Exercise4
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Greet();
            Student s = new Student(21);
            s.Greet();
            s.ShowAge();
            Teacher t = new Teacher(30);
            t.Greet();
            t.Explain();
        }
    }
}
