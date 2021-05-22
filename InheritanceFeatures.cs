using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /*
     * About to show how inheritence works, and its features:
     */
    public class Shape
    {
        public string GetName() { return "Shape"; }
    }
    
    public class Ball : Shape
    {
        public new string GetName() { return "Ball"; }
    }

    public class Pet
    {
        public virtual string GetName() { return "Pet"; }
    }

    public class Cat : Pet
    {
        public override string GetName()
        {
            return "Cat";
        }
    }
}
