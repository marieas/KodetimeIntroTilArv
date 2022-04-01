using System;
using System.Collections.Generic;
using System.Text;

namespace IntroTilARv
{
    public class Eevee : IPokemon
    {
        public int Health { get; set; }

        public void Tackle(IPokemon enemy)
        {
            enemy.LooseHealth(30);
        }
        public void LooseHealth(int damage)
        {
            this.Health -= damage;
        }

        public void Attack(IPokemon pokemonToHit)
        {
            Tackle(pokemonToHit);
        }
    }
}
