using System;
using System.Collections.Generic;  

namespace interfaceandabstract.core
{
    class Program
    {
        public List<string> person = new List<string>();
        static void Main(string[] args)
        {
            List<string> person = new List<string>();
            

        }
        interface IPerson : IComparable
        {
            string Name { get; set; }
            int Age { get; set; }
            string Genger { get; set; }
        }
        class Person : IPerson
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Genger { get; set; }

            public void AddPersonList()
            {
                Person person = new Person() { Name = "Dude1", Age = 1, Genger = "male" };
                Person person1 = new Person() { Name = "Dude2", Age = 2, Genger = "Female" };
                Person person2 = new Person() { Name = "Dude3", Age = 3, Genger = "male" };
                Person person3 = new Person() { Name = "Dude4", Age = 9, Genger = "Female" };
                Person person4 = new Person() { Name = "Dude5", Age = 5, Genger = "Female" };
                Person person5 = new Person() { Name = "Dude6", Age = 6, Genger = "male" };
                Person person6 = new Person() { Name = "Dude7", Age = 24, Genger = "male" };
                Person person7 = new Person() { Name = "Dude8", Age = 8, Genger = "male" };
                Person person8 = new Person() { Name = "Dude9", Age = 87, Genger = "Female" };
                Person person9 = new Person() { Name = "Dude10", Age = 26, Genger = "Alien" };
                List<Person> NowAddedPeople = new List<Person> { person, person1, person2, person3, person4, person5, person6, person7, person8, person9 };
            }
            public int CompareTo(object obj)
            {
                return this.Name.CompareTo(((IPerson)obj).Name);
            }
        }
        /* public abstract class Hotel
         {
             public abstract void NumbersOfRooms();
         }
         public class Building : Hotel, InterFaceA
         {
             public override void NumbersOfRooms()
             {
                 throw new NotImplementedException();
             }

             void InterFaceA.Bathrooms()
             {
                 throw new NotImplementedException();
             }

             void InterFaceA.Beds()
             {
                 throw new NotImplementedException();
             }

             void InterFaceA.Name()
             {
                 throw new NotImplementedException();
             }
         }
         public class Floor : Hotel, InterFaceA
         {
             public void Bathrooms()
             {
                 throw new NotImplementedException();
             }

             public void Beds()
             {
                 throw new NotImplementedException();
             }

             public void Name()
             {
                 throw new NotImplementedException();
             }

             public override void NumbersOfRooms()
             {
                 throw new NotImplementedException();
             }
         }
         public class Room : Hotel
         {

         }*/
    }
}
