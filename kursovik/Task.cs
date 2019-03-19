using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovik
{
    class Task
    {
        public int StartPosition { get; set; }
        public int? MaxPosition { get; set; }
        public int? MinPosition { get; set; }
        public int SizeLeftJump { get; set; }
        public int SizeRightJump { get; set; }
        public int FinishPosition { get; set; }
        public List<int> PointsPaint { get; set; }
    }
}
