using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using duAnGameCoTuong_theHe2.Models.NguoiCho_DETAIL;

namespace duAnGameCoTuong_theHe2.Models.QuanCo_DETAIL
{
    public class QuanXe : QuanCo
    {
        public QuanXe()
            : base()
        {
            setICON();
        }

        public QuanXe(Diem2D toaDo, NguoiChoi soHuu)
            : base(toaDo, soHuu)
        {
            setICON();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        private void setICON()
        {
            setKhongBiChieu();
            Cursor = Cursors.Hand;
            tenCo = TenQuanCo.QUAN_XE;
        }

        public override void setKhongBiChieu()
        {
            if (soHuu is NguoiChoiA)
                Image = Image.FromFile(_Modules.IMG_QUAN_XE_DO);
            if (soHuu is NguoiChoiB)
                Image = Image.FromFile(_Modules.IMG_QUAN_XE_DEN);
            Tag = "";
        }

        public override void setBiChieu()
        {
            if (soHuu is NguoiChoiA)
                Image = Image.FromFile(_Modules.IMG_QUAN_XE_DO_BI_CHIEU);
            if (soHuu is NguoiChoiB)
                Image = Image.FromFile(_Modules.IMG_QUAN_XE_DEN_BI_CHIEU);
            Tag = "BI_CHIEU";
        }

        public override bool nhinXem(QuanCo[,] banCo, bool resetIMG)
        {
            bool truoc = nhinTruoc(banCo,resetIMG),
                sau = nhinSau(banCo,resetIMG),
                trai = nhinTrai(banCo,resetIMG),
                phai = nhinPhai(banCo,resetIMG);
            return truoc || sau || trai || phai;
        }

        private bool nhinTruoc(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            i--; if (i == -1) return false;
            Image img; String tg;
            if (resetIMG)
            {
                img = null;
                tg = "";
            }
            else
            {
                img = Image.FromFile(_Modules.IMG_DUONG_DI);
                tg = "DUONG_DI";
            }
            while (banCo[i, j].TenCo == TenQuanCo.CHUA_XAC_DINH)
            {
                banCo[i, j].Tag = tg;
                banCo[i--, j].Image = img;
                if (i == -1)
                    return false;
            }

            return setQuanCoBiChieu(banCo[i, j],resetIMG);
        }

        private bool nhinSau(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            i++; if (i == banCo.GetLength(0)) return false;
            Image img; String tg;
            if (resetIMG)
            {
                img = null;
                tg = "";
            }
            else
            {
                img = Image.FromFile(_Modules.IMG_DUONG_DI);
                tg = "DUONG_DI";
            }
            while (banCo[i, j].TenCo == TenQuanCo.CHUA_XAC_DINH)
            {
                banCo[i, j].Tag = tg;
                banCo[i++, j].Image = img;
                if (i == banCo.GetLength(0)) 
                    return false;
            }

            return setQuanCoBiChieu(banCo[i,j], resetIMG);
        }

        private bool nhinTrai(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            j--; if (j == -1) return false;
            Image img; String tg;
            if (resetIMG)
            {
                img = null;
                tg = "";
            }
            else
            {
                img = Image.FromFile(_Modules.IMG_DUONG_DI);
                tg = "DUONG_DI";
            }
            while (banCo[i, j].TenCo == TenQuanCo.CHUA_XAC_DINH)
            {
                banCo[i, j].Tag = tg;
                banCo[i, j--].Image = img;
                if (j == -1)
                    return false;
            }

            return setQuanCoBiChieu(banCo[i, j], resetIMG);
        }

        private bool nhinPhai(QuanCo[,] banCo, bool resetIMG)
        {
            int i = toaDo.X,
                j = toaDo.Y;
            j++; if (j == banCo.GetLength(1)) return false;
            Image img; String tg;
            if (resetIMG)
            {
                img = null;
                tg = "";
            }
            else
            {
                img = Image.FromFile(_Modules.IMG_DUONG_DI);
                tg = "DUONG_DI";
            }
            while (banCo[i, j].TenCo == TenQuanCo.CHUA_XAC_DINH)
            {
                banCo[i, j].Tag = tg;
                banCo[i, j++].Image = img;
                if (j == banCo.GetLength(1))
                    return false;
            }

            return setQuanCoBiChieu(banCo[i, j], resetIMG);
        }
    }
}