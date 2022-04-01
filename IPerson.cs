using System;
using System.Collections.Generic;
using System.Text;

namespace IntroTilARv
{
    public class Face
    {

    }
    public interface IPerson
    {
        public Face Face { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public void Eat();
        public void Game();
        public void Sleep();
        public void GoForAWalk();
    }
}
