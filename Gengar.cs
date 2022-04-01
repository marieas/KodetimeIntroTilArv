using System;
using System.Collections.Generic;
using System.Text;

namespace IntroTilARv
{
    public class Gengar : IPokemon
    {
        public int Health { get; set; }

        public void Attack(IPokemon pokemonToHit)
        {
            FadeToBlack(pokemonToHit);
        }

        public void FadeToBlack(IPokemon enemy)
        {
            enemy.LooseHealth(70);
        }

        public void LooseHealth(int damage)
        {
            this.Health -= damage;
        }
    }
}
