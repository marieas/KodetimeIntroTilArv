using System;
using System.Collections.Generic;

namespace IntroTilARv
{
    class Program
    {
        static List<IPokemon> wildPokemon = new List<IPokemon> { new Eevee(), new Gengar(), new Nidoking(), new Weedle() };
        static Random random = new Random();

        public static  IPokemon GetWildPokemon()
        {           
            var index = random.Next(0, wildPokemon.Count);
            return wildPokemon[index];
        }
        static void Main(string[] args)
        {
            var magicarp = new Magikarp();
            while(magicarp.Health > 0)
            {
                var pokemonToAttackMagicarp = GetWildPokemon();
                pokemonToAttackMagicarp.Attack(magicarp);
            }

            //var people = new BigPersonList<IPerson>();

            //people.AddThreePeople(new Teacher("Bjørnar"),new Student("Kristian"),new Student("Geir A"));
            //people.AddThreePeople(new Student("Lillie"),new Student("Marius"),new Student("Linn"));
            //people.AddThreePeople(new Teacher("Marie"),new Teacher("Anders Kvålo"),new Teacher("Terje"));

            //foreach(var person in people)
            //{
            //    person.Eat();
            //}
            
        }
    }
}
