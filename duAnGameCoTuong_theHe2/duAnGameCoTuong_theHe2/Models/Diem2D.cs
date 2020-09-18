using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duAnGameCoTuong_theHe2.Models
{
    public class Diem2D
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Diem2D() 
        {
            x = y = 0;
        }

        public Diem2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Diem2D(Diem2D D)
        {
            x = D.x;
            y = D.y;
        }

        public override string ToString()
        {
            return "[ "+x+" , "+y+" ]";
        }
    }
}
