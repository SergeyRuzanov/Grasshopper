using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovik
{
    public class Task
    {
        public Task() : this(0, 2, 3, null, null, null, null) { }
        public Task(int startPosition, int sizeLeftJump, int sizeRightJump) : this(startPosition, sizeLeftJump, sizeRightJump, null, null, null, null) { }
        public Task(int startPosition, int sizeLeftJump, int sizeRightJump, int minBorder, int maxBorder) : this(startPosition, sizeLeftJump, sizeRightJump, null, minBorder, maxBorder, null) { }

        public Task(int startPosition, int sizeLeftJump, int sizeRightJump, int? finishPosition, int? maxBorder, int? minBorder, List<int> paintPoints)
        {
            StartPosition = startPosition;
            SizeLeftJump = sizeLeftJump;
            SizeRightJump = sizeRightJump;
            MinBorder = minBorder;
            MaxBorder = maxBorder;
            FinishPosition = finishPosition;
            PointsPaints = paintPoints;
        }
        public int StartPosition { get; set; }
        public int? MaxBorder { get; set; }
        public int? MinBorder { get; set; }
        public int SizeLeftJump { get; set; }
        public int SizeRightJump { get; set; }
        public int? FinishPosition { get; set; }
        public List<int> PointsPaints { get; set; }
    }
}
