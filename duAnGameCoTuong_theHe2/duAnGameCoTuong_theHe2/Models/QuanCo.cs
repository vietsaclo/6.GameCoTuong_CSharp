using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace duAnGameCoTuong_theHe2.Models
{
    public class QuanCo:Label
    {
        protected TenQuanCo tenCo;
        protected Diem2D toaDo;
        protected NguoiChoi soHuu;

        public TenQuanCo TenCo
        {
            get { return tenCo; }
            set { tenCo = value; }
        }

        public Diem2D ToaDo
        {
            get { return toaDo; }
            set { toaDo = value; }
        }

        public NguoiChoi SoHuu
        {
            get { return soHuu; }
            set { soHuu = value; }
        }

        public QuanCo()
        {
            _reset();
        }

        public QuanCo(Diem2D toaDo, NguoiChoi soHuu)
        {
            _reset();
            this.toaDo = toaDo;
            this.soHuu = soHuu;
        }

        private void _reset()
        {
            Text = "";
            Tag = "";
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.None;
            Width = Height = 55;
            Cursor = Cursors.Cross;
            tenCo = TenQuanCo.CHUA_XAC_DINH;
            toaDo = new Diem2D(0, 0);
            soHuu = null;
        }

        public override string ToString()
        {
            return tenCo.ToString() + " | "+soHuu.ToString()+" | "+toaDo.ToString();
        }

        public virtual bool nhinXem(QuanCo[,] banCo,bool resetIMG)
        {

            return false;
        }

        public virtual void setKhongBiChieu()
        {

        }

        public virtual void setBiChieu()
        {

        }

        protected bool setQuanCoBiChieu(QuanCo qc, bool resetIMG)
        {
            if (qc.SoHuu == soHuu)
                return false;
            if (resetIMG)
                qc.setKhongBiChieu();
            else
                qc.setBiChieu();

            return qc.TenCo == TenQuanCo.QUAN_TUONG;
        }

        public QuanCo _copy()
        {
            return MemberwiseClone() as QuanCo;
        }
    }
}