using IndexerCasting.Models;
using System;

namespace IndexerCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Indexer
            //string word = "Vuqar";
            //Console.WriteLine(word[0]);
            //Library libraff = new Library(1000);
            //Book book1 = new Book("Lotr");
            //libraff[0] = book1;
            //Console.WriteLine(libraff[0]);
            #endregion

            #region Casting
            #region Upcasting,boxing,implicit
            //Animal shark = new Shark();
            //shark.Eat();
            //Eagle eagle = new Eagle();
            //Animal animal = eagle;
            //Console.WriteLine(animal.GetType());
            #endregion

            #region Downcasting, unboxing, explicit
            //Eagle eagle = new Eagle();
            //Shark shark = new Shark();
            //Animal animal1 = shark;
            //int number = 5;
            //bool isMarried = false;
            //Object[] arr = { eagle, shark, number, isMarried,animal1 };
            //foreach (var item in arr)
            //{
            //    if(item is Animal animal)
            //    {
            //        animal.Eat();
            //    }
            //}
            //Security way Downcasting - as
            //Eagle eagle1 = animal as Eagle;
            //if (eagle1 != null)
            //{
            //    eagle1.Fly();
            //}
            //else
            //{
            //    Console.WriteLine("What is your purpose");
            //}
            //Security way Downcasting - is
            //if(animal is Eagle eagle1)
            //{
            //    //Eagle eagle1 =(Eagle) animal;
            //    eagle1.Fly();
            //}
            //else
            //{
            //    Console.WriteLine("What is your purpose");
            //}
            //int a = 1000;
            //long b = 10000000000;
            //int x =(int) b;
            //Console.WriteLine(x);
            //int number = int.Parse("12134sadsfdds");
            //bool isNumber = int.TryParse("12134sadsfdds",out number);
            //Console.WriteLine(isNumber);
            //Console.WriteLine(number);
            #endregion

            #region Implicit,Explicit operators
            //Manat manat = new Manat(340);
            //Dollar dollar =manat;
            //Console.WriteLine(dollar.Usd+"$");
            //Dollar dollar = new Dollar(300);
            //Manat manat =(Manat)dollar;
            //Console.WriteLine(manat.Azn);
            #endregion
            #endregion

            #region Operator overloading
            Person p1 = new Person("Seymur", 19);
            Person p2 = new Person("Seyfulla", 20);
            Person p3 = new Person("Seyfulla", 20);
            Person[] people = new Person[18];
            Array.Sort(people);
            Console.WriteLine(p1+p2);
            #endregion
        }
    }

    #region Operator overloading
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public static bool operator >(Person p1,Person p2)
        {
            return p1.Age > p2.Age;
        }

        public static bool operator <(Person p1, Person p2)
        {
            return p1.Age < p2.Age;
        }

        public static int operator +(Person p1, Person p2)
        {
            return p1.Age + p2.Age;
        }
    }
    #endregion

    #region Casting
    #region Implicit,Explicit operators
    class Manat
    {
        public double Azn { get; set; }
        public Manat(double azn)
        {
            Azn = azn;
        }

        public static implicit operator Dollar(Manat manat)
        {
            return new Dollar(manat.Azn / 1.7);
        }

        public static explicit operator Manat(Dollar dollar)
        {
            return new Manat(dollar.Usd * 1.7);
        }
    }

    class Dollar
    {
        public double Usd { get; set; }
        public Dollar(double usd)
        {
            Usd = usd;
        }
    }
    #endregion

    #region Upcasting,boxing,implicit
    abstract class Animal
    {
        public abstract void Eat();
    }

    abstract class Bird:Animal
    {
        public abstract void Fly();
    }

    class Eagle : Bird
    {
        public int Age { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }
    }

    abstract class Fish:Animal
    {
        public abstract void Swim();
    }

    class Shark:Fish
    {
        public int Teeth { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Eat as Shark");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim as Shark");
        }
    }
    #endregion
    #endregion
}
