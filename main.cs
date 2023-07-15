using System;

namespace Pertemuan7
{
    public class Person
    {
        // Properti
        public string Name { get; set; }
        public int Age { get; set; }

        // Konstruktor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Fungsi
        public virtual void InfoPerson()
        {
            Console.WriteLine("Nama saya {0}, dan Umur saya {1} tahun", Name, Age);
        }
    }

    public class Karyawan : Person
    {
        // Properti class turunan
        public string KaryawanID { get; set; }
        public string Subject { get; set; }

        // Konstruktor
        public Karyawan(string name, int age, string karyawanID, string subject)
            : base(name, age)
        {
            KaryawanID = karyawanID;
            Subject = subject;
        }

        // Override
        public override void InfoPerson()
        {
            Console.WriteLine("Nama saya {0}, dan Umur saya {1} tahun", Name, Age);
            Console.WriteLine("Karyawan ID: {0}, Subject: {1}", KaryawanID, Subject);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek person1 menggunakan konstruktor
            Person person1 = new Person("Dwiky Arista Vitraihan", 20);
            person1.InfoPerson();

            // Membuat objek karyawanID menggunakan konstruktor
            Karyawan karyawanID = new Karyawan("Dwiky", 21, "K001", "Dosen");
            karyawanID.InfoPerson();
        }
    }
}
