using System;
using System.Collections.Generic;
using System.Text;

namespace IntroTilARv
{
    class Nidoking : IPokemon
    {
        public int Health { get; set; }

        public void Attack(IPokemon pokemonToHit)
        {
            HornDrill(pokemonToHit);
        }

        public void HornDrill(IPokemon enemy)
        {
            enemy.LooseHealth(70);
        }
        public void LooseHealth(int damage)
        {
            this.Health -= damage;
        }
    }
}
