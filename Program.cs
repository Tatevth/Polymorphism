
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeManager shapeManager = new ShapeManager();
            List<Shape> shapes = new List<Shape>();
            
            shapes.Add(new Triangle());
            shapes.Add(new Recktangle());
            shapes.Add(new Square());
            shapeManager.ExecuteDraw(shapes);
        }
    }
}
