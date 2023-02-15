using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// interface of shape
    /// </summary>
    internal interface Shape
    {
        /// <summary>
        /// draw using # a certain shape
        /// </summary>
        void Draw();

        void SetIsFilled(bool isFilled);

        bool GetIsFilled();
    }
}
