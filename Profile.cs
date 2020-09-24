using DatingProfile;
using System;

namespace TOOYA
{
    class Program
    {
        static void Main(string[] args)
        {
            DatingProfile.Profile sam = new Profile("Tim Smith", 20);
            sam.SetHobbies(new string[] { "Playing lots of video games", "Finding gamers alike to hang out with", "Listing to music", "Meeting new people" });


            Console.WriteLine(sam.ViewProfile());

        }
    }
}
