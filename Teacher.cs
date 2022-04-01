using System;
using System.Collections.Generic;
using System.Text;

namespace IntroTilARv
{
    //Hierarki
    public class Teacher : IPerson
    {
        public Teacher(string name) 
        {
            Name = name;
        }

        public Face Face { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public void CorrectAssignments()
        {

        }

        public void Eat()
        {
            Console.WriteLine($"Hei, jeg gafler i meg pizza {Name}");
        }

        public void Game()
        {
            
        }

        public void GoForAWalk()
        {
            
        }

        public void Help()
        {

        }
        public void Lecture()
        {

        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }

        public void ThreatenStudents()
        {

        }
    }
}
