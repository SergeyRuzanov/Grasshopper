using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovik
{
    class Grasshopper
    {
        public event MessageDelegate ErrorMessage;
        public int CoordinateX { get; set; }
        public int PrevCoordinateX { get; set; }
        public void JumpLeft(int sizeJump)
        {
            PrevCoordinateX = CoordinateX;
            CoordinateX -= sizeJump;
            // TODO realization
        }
        public void JumpRight(int sizeJump)
        {
            PrevCoordinateX = CoordinateX;
            CoordinateX += sizeJump;
            // TODO realization
        }
    }
}
