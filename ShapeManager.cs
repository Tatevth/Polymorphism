using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class ShapeManager
    {
        public void ExecuteDraw(List<Shape> shapes)
        {
            
            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Draw();
            }
            
        }
    }
}
