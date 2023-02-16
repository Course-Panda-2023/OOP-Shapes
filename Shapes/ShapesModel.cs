using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// class represents a shape model contains all the shape and essential related methods
    /// </summary>
    internal class ShapesModel
    {
        List<Shape> shapes = new List<Shape>();

        public int GetLength()
        {
            return shapes.Count();
        }

        /// <summary>
        /// Add many shapes
        /// </summary>
        /// <param name="shapes">array of shapes</param>
        public void Add(params Shape[] shapes)
        {
            Span<Shape> shapesAsSpan = shapes.AsSpan();
            foreach(var shape in shapesAsSpan)
            {
                this.shapes.Add(shape);
            }
        }

        /// <summary>
        /// Delete shape
        /// </summary>
        /// <param name="shape">a shape</param>
        public void Delete(Shape shape)
        {
            if (shape is null) return;
            if (shapes.Count == 0)
            {
                Console.WriteLine("Three is no shape exists");
                return;
            }
            ShapeFactory shapeFactory1 = new ShapeFactory();
            Shape newShape = shape;
            if (newShape == null) return;
            Shape deletedShape = null;
            foreach(var shapeAsVar in shapes)
            {
                if (shapeAsVar.GetType() == newShape.GetType())
                {
                    deletedShape = shapeAsVar;
                }   
            }
            if (deletedShape!= null)
            {
                shapes.Remove(deletedShape);
            }
        }

        /// <summary>
        /// Draw all the shapes in the model
        /// </summary>
        public void DrawAll()
        {
            if (shapes.Count == 0) return;
            foreach (var shape in CollectionsMarshal.AsSpan(shapes))
            {
                shape.Draw();
            }
        }

        public void Update(int index)
        {
            Shape shape = shapes[index];
            bool isFilled = shape.GetIsFilled();
            Console.WriteLine($"from {isFilled} to {!isFilled}");
            shapes[index].SetIsFilled(!isFilled);
        }
    }
}
