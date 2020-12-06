using System;
using System.Collections.Generic;
namespace PackLibrary
{
    public class Person
    {
        //event delegate field
        public EventHandler Shout;
        public int AngerLevel;
        public string Name;
        public DateTime DateOfBirth;
        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                Shout?.Invoke(this, EventArgs.Empty);
            }
        }
        public List<Person> Children = new List<Person>();
        public Person(string name)
        {
            Name = name;
        }
        public static Person Procreate(Person person1, Person person2)
        {
            var baby = new Person($"Baby of {person1.Name} & {person2.Name}");
            person1.Children.Add(baby);
            person2.Children.Add(baby);
            return baby;
        }
        public Person ProcreateWith(Person person)
        {
            return Procreate(this, person);
        }
        /// <summary>
        /// Operation Overloading
        /// </summary>
        /// <param name="person1"></param>
        /// <param name="person2"></param>
        /// <returns></returns>
        public static Person operator *(Person person1, Person person2)
        {
            return Procreate(person1, person2);
        }

    }
}
