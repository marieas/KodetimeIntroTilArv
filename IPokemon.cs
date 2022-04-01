using System;
using System.Collections.Generic;
using System.Text;

namespace IntroTilARv
{
    public interface IPokemon
    {
        public int Health { get; set; }
        public void LooseHealth(int damage);
        public void Attack(IPokemon pokemonToHit);
    }
}
