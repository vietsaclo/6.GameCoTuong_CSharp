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
    public class QuanTot : QuanCo
    {
        public QuanTot()
            : base()
        {
            setICON();
        }

        public QuanTot(Diem2D toaDo, NguoiChoi soHuu)
            : base(toaDo, soHuu)
        {
            setICON();
        }

        private void setICON()
        {
            setKhongBiChieu();
            Cursor = Cursors.Hand;
            tenCo = TenQuanCo.QUAN_TOT;
        }

        public override void setKhongBiChieu()
        {
            if (soHuu is NguoiChoiA)
                Image = Image.FromFile(_Modules.IMG_QUAN_TOT_DO);
            if (soHuu is NguoiChoiB)
                Image = Image.FromFile(_Modules.IMG_QUAN_TOT_DEN);
            Tag = "";
        }

        public override void setBiChieu()
        {
            if (soHuu is NguoiChoiA)
                Image = Image.FromFile(_Modules.IMG_QUAN_TOT_DO_BI_CHIEU);
            if (soHuu is NguoiChoiB)
                Image = Image.FromFile(_Modules.IMG_QUAN_TOT_DEN_BI_CHIEU);
            Tag = "BI_CHIEU";
        }

        public override bool nhinXem(QuanCo[,] banCo, bool resetIMG)
        {
            bool truoc = false, sau = false, trai = false, phai = false;
            if (soHuu is NguoiChoiA)
                truoc = nhinTruoc(banCo, resetIMG);
            else
                sau = nhinSau(banCo, resetIMG);
            trai = nhinTrai(banCo, resetIMG);
            phai = nhinPhai(banCo, resetIMG);
            return truoc || sau || trai || phai;
        }

        private bool nhinTruoc(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            i--; if (i == -1) return false;
            if (banCo[i, j].TenCo == TenQuanCo.CHUA_XAC_DINH)
            {
                Image img; String tg;
                if (resetIMG) { img = null; tg = ""; } else { img = Image.FromFile(_Modules.IMG_DUONG_DI); tg = "DUONG_DI"; }
                banCo[i, j].Image = img;
                banCo[i, j].Tag = tg;
                return false;
            }

            return setQuanCoBiChieu(banCo[i,j],resetIMG);
        }

        private bool nhinSau(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            i++; if (i == banCo.GetLength(0)) return false;
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
            if (soHuu is NguoiChoiA && i > 4) return false;
            if (soHuu is NguoiChoiB && i < 5) return false;
            j--; if (j == -1) return false;
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
            if (soHuu is NguoiChoiA && i > 4) return false;
            if (soHuu is NguoiChoiB && i < 5) return false;
            j++; if (j == banCo.GetLength(1)) return false;
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
