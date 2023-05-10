using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_DesignPatterns
{
    abstract class CourseComponent
    {
        protected string _name;

        public CourseComponent(string name)
        {
            _name = name;
        }

        public abstract void Display();
    }
}
