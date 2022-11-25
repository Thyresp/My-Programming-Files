using System;
using System.Collections;

namespace HashTable_Challange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();

            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ranger", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);


            foreach (Student i in students)
            {
                if (hashtable.ContainsKey(i.Id))
                {
                    Console.WriteLine("Sorry, A student with the same id already exists");
                }
                else
                {
                    hashtable.Add(i.Id, i);
                }

            }
        }
    }
    class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float GPA { get; set; }

        public Student(int ıd, string name, float gPA)
        {
            Id = ıd;
            Name = name;
            GPA = gPA;
        }
    }
}
