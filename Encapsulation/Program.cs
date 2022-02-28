using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student=new Student();
            student.Name1="Eren";
            student.Surname1="Akgöz";
            student.Grade1="12/D";
            student.StudentNumber1=213;

            student.OgrenciBilgileriniGetir();
        }
    }

    class Student
    {
        private string Name;
        private string Surname;
        private int StudentNumber;
        private int Grade;



        public string Name1 { get => Name; set => Name = value; }
        public string Surname1 { get => Surname; set => Surname = value; }
        public int StudentNumber1 { get => StudentNumber; set => StudentNumber = value; }
        public int Grade1 { get => Grade; set => Grade = value; }
        public Student(string name, string surname, int studentNumber, int grade)
        {
            this.Name = name;
            this.Surname = surname;
            this.StudentNumber = studentNumber;
            this.Grade = grade;

        }

        public Student(){}

        public void OgrenciBilgileriniGetir(){
            System.Console.WriteLine("****** Öğrenci Bilgileri ****");
            System.Console.WriteLine("Öğrencinin Adı-Soyadı:" +Name+" "+Surname);
            System.Console.WriteLine("Öğrencinin Numarası:"+StudentNumber);
        }

    }
}
