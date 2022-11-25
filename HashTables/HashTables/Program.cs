using System;
using System.Collections;

namespace HashTables
{
    internal class Program
    {
        //Key - Value
        //Auto - Car
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            // retrive individual item with known ID
            // Didnt Understand this part but ı believe we cast this in to a studnet so we can acces student properties
            // the reason that we do this is probably because its values are from a Student Class so we do this to get every property in it
            Student storedStudent1 = (Student)studentsTable[stud1.Id];

            //retrieve all values from a Hashtable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine($"Student ID: {temp.Id}");
                Console.WriteLine($"Student Name: {temp.Name}");
                Console.WriteLine($"Student GPA: {temp.GPA}");
            }

            foreach(Student value in studentsTable.Values)
            {
                Console.WriteLine(value.Id);
                Console.WriteLine(value.Name);
                Console.WriteLine(value.GPA);
            }


            Console.WriteLine($"Student ID: {storedStudent1.Id}, Name {storedStudent1.Name}, GPA {storedStudent1.GPA}");
        }
    }


    class Student
    {
        //property called Id
        public int Id { get; set; }
        
        //property called Name
        public string Name { get; set; }
        
        //property called GPA
        public float GPA { get; set;}

        public Student(int ıd, string name, float gpa)
        {
            this.Id = ıd;
            this.Name = name;
            this.GPA = gpa;
        }
    }
}
