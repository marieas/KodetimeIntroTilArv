using System;
using System.Collections.Generic;
using System.Text;

namespace IntroTilARv
{
    public class BigPersonList<T> : List<T>
    {
        public void AddThreePeople(T person1, T person2, T person3)
        {
            Add(person1);
            Add(person2);
            Add(person3);
        }
    }
}
