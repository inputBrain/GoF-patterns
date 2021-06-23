using System;

namespace Prototype
{
    public class Person
    {
        public int Id { get; set; }

        public int Age { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public Profile Profile {get; set; }


        public Person ShallowClone()
        {
            return  (Person) MemberwiseClone();
        }


        public Person DeepClone()
        {
            var clone = (Person) MemberwiseClone();
            clone.Profile = new Profile(Profile.EyesColor, Profile.HairColor);
            return clone;
        }
    }
}