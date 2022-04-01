using System;
using System.Collections.Generic;
using System.Text;

namespace IntroTilARv
{
    public class Weedle : IPokemon
    {
        public int Health { get; set; }

        public void Attack(IPokemon pokemonToHit)
        {
            BugBite(pokemonToHit);
        }

        public void BugBite(IPokemon enemy)
        {
            enemy.LooseHealth(70);
        }
        public void LooseHealth(int damage)
        {
            this.Health -= damage;
        }
    }
}
