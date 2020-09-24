using System;

namespace DatingProfile
{
    class Profile
    {

        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;
        private string bio;

        public Profile(string name, int age, string city = "New York", string country = "USA", string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            hobbies = new string[0];

        }

        public string ViewProfile()
        {
            bio = $"Name: {name} \nAge: {age} \nCity: {city} , {country} \nPronouns: {pronouns}";

            if (this.hobbies.Length > 0)
            {
                bio += "\nHobbies:\n";
                foreach (string hobby in hobbies)
                {
                    bio += $"- {hobby} \n";
                }
            }
            return bio;

        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;

        }
    }
}
