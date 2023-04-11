using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class ShapeContainer
    {
        int CurrentKey = 1;
        public Dictionary<int, Shape> Shapes;
        public ShapeContainer()
        {
            Shapes = new Dictionary<int, Shape>();
        }
        public void Add(Shape _Shape)
        {
            Shapes.Add(CurrentKey, _Shape);
            CurrentKey++;
        }
        public void Remove(int key)
        {
            if (Shapes.ContainsKey(key))
            {
                Shapes.Remove(key);
            }
            else
            {
                Console.WriteLine($"\nkey {key} could not be found");
            }
        }
        public Shape? Get(int key)
        {
            if (Shapes.ContainsKey(key))
            {
                return Shapes[key];
            }
            else
            {
                Console.WriteLine($"\nkey {key} could not be found");
                return null;
            }
        }
        public void PrintAll()
        {
            if (Shapes.Count() == 0)
            {
                Console.WriteLine("\nno shapes in container");
                return;
            }
            foreach ((int key, Shape shape) in Shapes)
            {
                Console.WriteLine(key + ": " + shape.ToString());
            }
        }
    }
}
