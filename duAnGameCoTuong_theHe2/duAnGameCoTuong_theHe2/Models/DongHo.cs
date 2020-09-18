using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace duAnGameCoTuong_theHe2.Models
{
    public class DongHo
    {
        public int gio { get; set; }
        public int phut { get; set; }
        public int giay { get; set; }

        public DongHo()
        {
            gio = phut = giay = 0;
        }

        public override string ToString()
        {
            return gio + " : "+phut+" : "+giay+" s";
        }

        public void tangMotGiay()
        {
            giay++;
            if (giay == 61)
            {
                giay = 0;
                phut++;
            }
            if (phut == 61)
            {
                phut = 0;
                gio++;
            }
        }

        public void tangMotGiay(Label lbl)
        {
            tangMotGiay();
            lbl.Text = this.ToString();
        }
    }
}
