using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovik
{
    public class Grasshopper
    {
        public event MessageDelegate ErrorMessage;
        public Grasshopper() : this(0)
        {

        }
        public Grasshopper(int coordinate)
        {
            CoordinateX = coordinate;
            PrevCoordinateX = coordinate;
        }
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
