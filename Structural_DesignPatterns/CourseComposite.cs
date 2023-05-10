using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Structural_DesignPatterns
{
    class CourseComposite : CourseComponent
    {
        private List<CourseComponent> _children = new List<CourseComponent>();
        public CourseComposite(string name) : base(name)
        {
        }

        public void Add(CourseComponent component)
        {
            _children.Add(component);
        }

        public void Remove(CourseComponent component)
        {
            _children.Remove(component);
        }

        public override void Display()
        {
            Console.WriteLine(_name);
            foreach (CourseComponent component in _children)
            {
                component.Display();
            }
        }
    }

}
