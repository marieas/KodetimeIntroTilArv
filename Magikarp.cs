using System;
using System.Collections.Generic;
using System.Text;

namespace IntroTilARv
{
    public class Magikarp : IPokemon
    {
        public bool IsUseless { get; set; }
        public int Health { get; set; }

        public Magikarp()
        {
            Health = 100;
        }
        public void Attack(IPokemon pokemonToHit)
        {
            Splash();
        }

        public void LooseHealth(int damage)
        {
            this.Health -= damage;
        }

        public void Splash()
        {

        }
    }
}
