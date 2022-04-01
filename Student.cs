using System;
using System.Collections.Generic;
using System.Text;

namespace IntroTilARv
{
    public class Hybel
    {

    }
    public class Student : IPerson
    {
        public Hybel Hybel { get; set; }
        public int StudentID { get; set; }
        public int StudentLoan { get; set; }
        public Face Face { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public Student(string name)
        {
            Name = name;
        }   
        public void PepsimaxDiet()
        {
            
        }
        public void BegForMoney()
        {

        }
        public void Oversleep()
        {

        }
        public void Study()
        {

        }

        public void Eat()
        {
            Console.WriteLine($"Hei, jeg spiser nudler {Name}");
        }

        public void Game()
        {
           
        }

        public void Sleep()
        {
          
        }

        public void GoForAWalk()
        {
           
        }
    }
}
