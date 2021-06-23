using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person()
            {
                Id = 1,
                Age =  24,
                FirstName = "George",
                LastName = "Sonic",
                BirthDate = Convert.ToDateTime("2021-06-23"),
                Profile = new Profile("Blue", "Black")
            };

            var clonePerson = person.ShallowClone();
            var deepClonePerson = person.DeepClone();

            Console.WriteLine("\n Original data of person, clonePerson, deepClonePerson: ");
            Console.WriteLine("Person data: ");
            DisplayValues(person);

            Console.WriteLine("\n ClonePerson data: ");
            DisplayValues(clonePerson);

            Console.WriteLine("\n DeepClonePerson data: ");
            DisplayValues(deepClonePerson);


            Console.WriteLine("\n === Trying to change Person data. ===: ");
            person = new Person()
            {
                Id = 2,
                Age = 30,
                FirstName = "John",
                LastName = "Europe",
                BirthDate = Convert.ToDateTime("2021-06-23"),
                Profile = new Profile("Yellow", "Orange")
            };
            Console.WriteLine("New Person data:");
            DisplayValues(person);

            Console.WriteLine("\n ClonePerson data: ");
            DisplayValues(clonePerson);

            Console.WriteLine("\n DeepClonePerson data: ");
            DisplayValues(deepClonePerson);



        }


        public static void DisplayValues(Person person)
        {
            Console.WriteLine(
                "Id: {0:d}, Age: {1:d} FirstName: {2:s}, LastName: {3:s}, BirthDate: {4:MM/dd/yy}",
                person.Id, person.Age, person.FirstName, person.LastName, person.BirthDate
            );

            Console.WriteLine(
                "Profile.EyesColor: {0:s}, Profile.HairColor: {1:s},",
                person.Profile.EyesColor, person.Profile.HairColor
            );
        }
    }
}