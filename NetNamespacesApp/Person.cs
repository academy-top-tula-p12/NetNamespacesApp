using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    namespace MyPerson
    {
        file class Account // only in file
        {

        }

        class Person
        {
            int h;

            private int x; // only class
            private protected int y; // only class and for derived class in assembly
            protected int z; // only class and for derivedes classes
            
            internal int w; // for all (public) in assembly
            
            protected internal int c; // for all in assembly and for derivedes in other assembly

            public int a; // for all
        }
    }
}
