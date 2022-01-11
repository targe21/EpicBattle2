using System;

namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Harry Potter", "Superman", "Mario", "Lara Croft" };
            string[] villains = { "Voldemort", "Joker", "Venom", "Darth Vader", "Cruella" };
                       
            string randomHero = GetRandomCharacter(heroes);
            string randomVillain = GetRandomCharacter(villains);
            string heroWeapon = GetWeapon();
            string villainWeapon = GetWeapon();
            Console.WriteLine($"{randomHero} with {heroWeapon} will fight {randomVillain} with {villainWeapon}");

        }

        public static string GetRandomCharacter(string[] someArray)
        {
            return someArray[GetRandomIndexForArray(someArray)];
        }

        public static string GetWeapon()
        {
            string[] weapon = { "plastic fork", "flip-flop", "light saber", "magic wand", "banana" };
            return weapon[GetRandomIndexForArray(weapon)];
        }

        public static int GetRandomIndexForArray(string[] someArray)
        {
            Random rnd = new Random();
            return rnd.Next(0, someArray.Length);
        }

    }
}
