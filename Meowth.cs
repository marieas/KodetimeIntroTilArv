using System;
using System.Collections.Generic;
using System.Text;

namespace IntroTilARv
{
    public class Meowth : IPokemon
    {
        public int Health { get; set; }

        public void PayDay(IPokemon enemy)
        {
            enemy.LooseHealth(50);
        }

        public void LooseHealth(int damage)
        {
            this.Health -= damage;
        }

        public void Attack(IPokemon pokemonToHit)
        {
            PayDay(pokemonToHit);
        }
    }
}
