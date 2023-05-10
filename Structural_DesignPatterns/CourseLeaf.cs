using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Structural_DesignPatterns
{
    class CourseLeaf : CourseComponent
    {
        public CourseLeaf(string name) : base(name)
        {
        }
        public override void Display()
        {
            Console.WriteLine(_name);
        }
    }
}
