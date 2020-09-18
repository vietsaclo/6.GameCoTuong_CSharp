using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using duAnGameCoTuong_theHe2.Models.NguoiCho_DETAIL;
using System.Drawing;
using System.Windows.Forms;

namespace duAnGameCoTuong_theHe2.Models.QuanCo_DETAIL
{
    public class QuanTuong : QuanCo
    {
        public QuanTuong()
            : base()
        {
            setICON();
        }

        public QuanTuong(Diem2D toaDo, NguoiChoi soHuu)
            : base(toaDo, soHuu)
        {
            setICON();
        }

        private void setICON()
        {
            setKhongBiChieu();
            Cursor = Cursors.Hand;
            tenCo = TenQuanCo.QUAN_TUONG;
        }

        public override void setKhongBiChieu()
        {
            if (soHuu is NguoiChoiA)
                Image = Image.FromFile(_Modules.IMG_QUAN_TUONG_DO);
            if (soHuu is NguoiChoiB)
                Image = Image.FromFile(_Modules.IMG_QUAN_TUONG_DEN);
            Tag = "";
        }

        public override void setBiChieu()
        {
            if (soHuu is NguoiChoiA)
                Image = Image.FromFile(_Modules.IMG_QUAN_TUONG_DO_BI_CHIEU);
            if (soHuu is NguoiChoiB)
                Image = Image.FromFile(_Modules.IMG_QUAN_TUONG_DEN_BI_CHIEU);
            Tag = "BI_CHIEU";
        }

        public override bool nhinXem(QuanCo[,] banCo, bool resetIMG)
        {
            nhinTruoc(banCo, resetIMG);
            nhinSau(banCo, resetIMG);
            nhinTrai(banCo, resetIMG);
            nhinPhai(banCo, resetIMG);
            return false;
        }

        private bool nhinTruoc(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            i--; if (i == -1 || i == 6) return false;
            if (banCo[i, j].TenCo == TenQuanCo.CHUA_XAC_DINH)
            {
                Image img; String tg;
                if (resetIMG) { img = null; tg = ""; } else { img = Image.FromFile(_Modules.IMG_DUONG_DI); tg = "DUONG_DI"; }
                banCo[i, j].Image = img;
                banCo[i, j].Tag = tg;
                return false;
            }

            return setQuanCoBiChieu(banCo[i, j], resetIMG);
        }

        private bool nhinSau(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            i++; if (i == banCo.GetLength(0) || i == 3) return false;
            if (banCo[i, j].TenCo == TenQuanCo.CHUA_XAC_DINH)
            {
                Image img; String tg;
                if (resetIMG) { img = null; tg = ""; } else { img = Image.FromFile(_Modules.IMG_DUONG_DI); tg = "DUONG_DI"; }
                banCo[i, j].Image = img;
                banCo[i, j].Tag = tg;
                return false;
            }

            return setQuanCoBiChieu(banCo[i, j], resetIMG);
        }

        private bool nhinTrai(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            j--; if (j==2) return false;
            if (banCo[i, j].TenCo == TenQuanCo.CHUA_XAC_DINH)
            {
                Image img; String tg;
                if (resetIMG) { img = null; tg = ""; } else { img = Image.FromFile(_Modules.IMG_DUONG_DI); tg = "DUONG_DI"; }
                banCo[i, j].Image = img;
                banCo[i, j].Tag = tg;
                return false;
            }

            return setQuanCoBiChieu(banCo[i, j], resetIMG);
        }

        private bool nhinPhai(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            j++; if (j == 6) return false;
            if (banCo[i, j].TenCo == TenQuanCo.CHUA_XAC_DINH)
            {
                Image img; String tg;
                if (resetIMG) { img = null; tg = ""; } else { img = Image.FromFile(_Modules.IMG_DUONG_DI); tg = "DUONG_DI"; }
                banCo[i, j].Image = img;
                banCo[i, j].Tag = tg;
                return false;
            }

            return setQuanCoBiChieu(banCo[i, j], resetIMG);
        }
    }
}
